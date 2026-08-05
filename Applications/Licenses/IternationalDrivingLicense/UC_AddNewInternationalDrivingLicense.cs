using DVLD_Business_Layer;
using DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense.Forms;
using DVLD_Full_Proj.Applications.ManageApplications;
using DVLD_Full_Proj.Applications.ManageApplications.Driving_License;
using DVLD_Full_Proj.Applications.ManageApplications.Driving_License.DrivingLicenseControls;
using DVLD_Full_Proj.Applications.ManageApplications.InternationalLicense.Controls;
using DVLD_Full_Proj.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense
{
    public partial class UC_AddNewInternationalDrivingLicense : UserControl
    {
        public enum EnBackMode {BackToMainApp=1,BackToInternationalLicenseApp=2 }
        EnBackMode _BackMode=EnBackMode.BackToMainApp;
        enum _EnStatus {New=1,Cancelled=2,Completed=3 }
        UC_ShowLocalDrivingLicenseinfo UC_ShowLocalLicenseinfo= new UC_ShowLocalDrivingLicenseinfo();
        clsLicenses_BusinessLayer _License =null;
        clsDrivers_BusinessLayer _Driver =null;
       int _ApplicationId=-1;
        int _Licenseid =-1;
        public EnBackMode BackMode
        {
            set { _BackMode = value; }
        }
        public UC_AddNewInternationalDrivingLicense()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
           
        }
        private void Initilaize_Data()
        {
            UC_ShowLocalLicenseinfo= new UC_ShowLocalDrivingLicenseinfo(_ApplicationId);
            UC_ShowLocalLicenseinfo.Dock= DockStyle.Fill;
            Txt_FillterBy.KeyPress += Txt_FillterBy_KeyPress;
            //Load Data On Panel
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_ShowLocalLicenseinfo);
            // initilize App Info

            label_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label_EX_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label_StatusDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label_Fees.Text= Cls_ApplicationTypes_BusinessLayer.Find(6).ApplicationFees.ToString();
            Label_L_Licenseid.Text=_Licenseid.ToString();
            label_CreatedBy.Text = CurrentUser.User.UserName;
            label_i_Licenseid.Text = "??";
            label_Appid.Text = "??";

        }

        private void UC_AddNewInternationalDrivingLicense_Load(object sender, EventArgs e)
        {
            Btn_Save.Enabled = false;
            Btn_ShowLicenseInfo.Enabled=false;
            Btn_ShowLicenseHistory.Enabled=false;
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_ShowLocalLicenseinfo);
           
        }
        private void Txt_FillterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool DoesHaveLicenseClass3()
        {

            return clsDrivers_BusinessLayer.DoesHaveClass3License(_License.DriverID);
        }
        bool iSDetaindLicense()
        {
            return clsLicenses_BusinessLayer.IsLicenseDetained(_Licenseid);
        }
        private void Btn_FindLicense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_FillterBy.Text))
            {
                errorProvider1.SetError(Txt_FillterBy,"Please Enter License id");
                
               return;
            }
            errorProvider1.SetError(Txt_FillterBy, "");
            _License = 
                clsLicenses_BusinessLayer.Find(Convert.ToInt32(Txt_FillterBy.Text));
            if (_License == null)
            {
                MessageBox.Show("Sorry License Is Not Exist", "Find License", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
                
            }
            else
            {
                _Licenseid = Convert.ToInt32(Txt_FillterBy.Text);
                _License = clsLicenses_BusinessLayer.Find(_Licenseid);
                if (_License == null)return;
                _Driver = clsDrivers_BusinessLayer.Find(_License.DriverID);
                if (_Driver == null)return ;
                if( DoesHaveLicenseClass3())
                {
                    if (_License.IsActive || iSDetaindLicense())
                    {
                        Btn_Save.Enabled = true;
                        Btn_ShowLicenseHistory.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sorry You Can't Issue International License For Detaind Or Not Active License",
                            "Find License", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                    }
                }
               else
                {
                     MessageBox.Show("Driver Does Not Have License Class 3 Can't Isuue International License", "Find License", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                    Btn_Save.Enabled = false;
                    Btn_ShowLicenseInfo.Enabled = false;
                    Btn_ShowLicenseHistory.Enabled = false;
                }
                _ApplicationId = _License.ApplicationID;
                Initilaize_Data();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_ShowLicenseHistory_Click(object sender, EventArgs e)
        {
            Frm_ShowLicenseHistory Frm_LicenseHistory= new Frm_ShowLicenseHistory(_License.DriverID);
            Frm_LicenseHistory.ShowDialog();    
        }

        private void Btn_ShowLicenseInfo_Click(object sender, EventArgs e)
        {
            Frm_ShowInternationalDrivingLicenseInfo Frm_int_Licenseinfo = new Frm_ShowInternationalDrivingLicenseInfo(_License.ApplicationID);
            Frm_int_Licenseinfo.ShowDialog();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (clsInternationalLicense_BusenessLayer.IsExistByLocalLicenseID(_Licenseid))
            {
                MessageBox.Show("Driver Alredy Has An international License System Can't Issue A Second One"
                    , "Issue International License", MessageBoxButtons.OK
                  , MessageBoxIcon.Error);
                Btn_ShowLicenseInfo.Enabled = true;
                return;
            }
            clsInternationalLicense_BusenessLayer InterNational_License =
                new clsInternationalLicense_BusenessLayer();

            //Add international License Application
            Cls_Applications_BusinessLayer Application = new Cls_Applications_BusinessLayer();
            Application.ApplicantPersonID = _Driver.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationStatus = (byte)_EnStatus.Completed;
            Application.ApplicationTypeID = Cls_ApplicationTypes_BusinessLayer.Find(6).ApllicationId;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = Cls_ApplicationTypes_BusinessLayer.Find(6).ApplicationFees;
            Application.CreatedByUserID = CurrentUser.User.UserID;
            if (!Application.Save()) return;

            //Add International License
            InterNational_License.DriverID = _License.DriverID;
            InterNational_License.ApplicationID = _License.ApplicationID;
            InterNational_License.ExpirationDate = DateTime.Now.AddYears(10);
            InterNational_License.IssueDate = DateTime.Now;
            InterNational_License.IssuedUsingLocalLicenseID = _Licenseid;
            InterNational_License.IsActive = true;
            InterNational_License.CreatedByUserID = CurrentUser.User.UserID;

            if (InterNational_License.Save())
            {
                label_i_Licenseid.Text = InterNational_License.InternationalLicenseID.ToString();
                label_Appid.Text = Application.ApplicationID.ToString();
                Btn_ShowLicenseInfo.Enabled = true;
                MessageBox.Show("International License Added Successfully With id= "+ InterNational_License.InternationalLicenseID, 
                    "Issue License", MessageBoxButtons.OK
                  , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Can't Create International License", "System Error", MessageBoxButtons.OK
                   , MessageBoxIcon.Error);
            }

        }

        private void Btn_Closel_Click(object sender, EventArgs e)
        {
            var FrmMain= FindForm() as MainForm;
            if (FrmMain == null) return;
            if (_BackMode==EnBackMode.BackToMainApp)
            {
                FrmMain.Show_Control(new UC_MainApplications());
            }
           else if(_BackMode == EnBackMode.BackToInternationalLicenseApp)
            {
                FrmMain.Show_Control(new UC_ShowInternationalDrivingLicenseApplications());

            }

        }
    }
}
