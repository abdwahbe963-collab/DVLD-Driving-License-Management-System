using DVLD_Business_Layer;
using DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense.Forms;
using DVLD_Full_Proj.Applications.ManageApplications.Driving_License;
using DVLD_Full_Proj.Applications.ManageApplications.Driving_License.DrivingLicenseControls;
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

namespace DVLD_Full_Proj.Applications.Licenses.Replace_License
{
    public partial class UC_ReplaceLicenseForLostOrDamaged : UserControl
    {
        enum _EnStatus { New = 1, Cancelled = 2, Completed = 3 }
        UC_ShowLocalDrivingLicenseinfo UC_ShowLocalLicenseinfo = new UC_ShowLocalDrivingLicenseinfo();
        clsLicenses_BusinessLayer _License = null;
        clsDrivers_BusinessLayer _Driver = null;
        int _ApplicationId = -1;
        int _Licenseid = -1;
        public UC_ReplaceLicenseForLostOrDamaged()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void RefrishPanel()
        {
            UC_ShowLocalLicenseinfo = new UC_ShowLocalDrivingLicenseinfo(_ApplicationId);
            UC_ShowLocalLicenseinfo.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_ShowLocalLicenseinfo);
        }
        private void Initilaize_Data()
        {
            UC_ShowLocalLicenseinfo = new UC_ShowLocalDrivingLicenseinfo(_ApplicationId);
            UC_ShowLocalLicenseinfo.Dock = DockStyle.Fill;

            Txt_FillterBy.KeyPress += Txt_FillterBy_KeyPress;
            
            //Load Data On Panel
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_ShowLocalLicenseinfo);
            // initilize App Info

            label_AppDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            label_IssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (Rd_Lost.Checked)
            {
                label_AppFees.Text = Cls_ApplicationTypes_BusinessLayer.Find(3).ApplicationFees.ToString();
            }
            else
            {
                label_AppFees.Text = Cls_ApplicationTypes_BusinessLayer.Find(4).ApplicationFees.ToString();
            }
            label_EX_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Label_Old_Licenseid.Text = _Licenseid.ToString();
            label_CreatedBy.Text = CurrentUser.User.UserName;
            label_Re_Licenseid.Text = "??";
            label_Re_Appid.Text = "??";
            
        }
        private void Txt_FillterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool iSDetaindLicense()
        {
            return clsLicenses_BusinessLayer.IsLicenseDetained(_Licenseid);
        }
        bool IsLicenseExpired()
        {

            int Comaper = DateTime.Compare(_License.IssueDate, _License.ExpirationDate);
            return Comaper != -1;

        }
        private void UC_ReplaceLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            //initialize Radio
            Rd_Lost.Checked = true;
            Btn_Save.Enabled = false;
            Btn_ShowLicenseInfo.Enabled = false;
            Btn_ShowLicenseHistory.Enabled = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_ShowLocalLicenseinfo);
        }
        private void Btn_FindLicense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_FillterBy.Text))
            {
                errorProvider1.SetError(Txt_FillterBy, "Please Enter License id");

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
                if (_License == null) return;
                _Driver = clsDrivers_BusinessLayer.Find(_License.DriverID);
                if (_Driver == null) return;
                if (_License.IsActive)
                {
                    if (!iSDetaindLicense() && !IsLicenseExpired())
                    {
                        Btn_Save.Enabled = true;
                        Btn_ShowLicenseHistory.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sorry You Can't Replace Detaind or Expired  License",
                            "Find License", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Sorry You Can't Replace (Not Active)  License",
                        "Find License", MessageBoxButtons.OK
                , MessageBoxIcon.Error);
                    Btn_Save.Enabled = false;
                    Btn_ShowLicenseInfo.Enabled = false;
                    Btn_ShowLicenseHistory.Enabled = false;
                }

                _ApplicationId = _License.ApplicationID;
                Initilaize_Data();
            }
        }
        private void Btn_ShowLicenseHistory_Click(object sender, EventArgs e)
        {
            Frm_ShowLicenseHistory Frm_LicenseHistory = new Frm_ShowLicenseHistory(_License.DriverID);
            Frm_LicenseHistory.ShowDialog();
        }

        private void Btn_ShowLicenseInfo_Click(object sender, EventArgs e)
        {
            Frm_ShowDrivingLicenseInfo Frm_int_Licenseinfo = new Frm_ShowDrivingLicenseInfo(_License.ApplicationID);
            Frm_int_Licenseinfo.ShowDialog();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            //Add Replace License Application
            Cls_Applications_BusinessLayer Application = new Cls_Applications_BusinessLayer();
            Application.ApplicantPersonID = _Driver.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationStatus = (byte)_EnStatus.Completed;
            if(Rd_Lost.Checked)
            {
                Application.ApplicationTypeID = Cls_ApplicationTypes_BusinessLayer.Find(3).ApllicationId;

            }
            else
            {
                Application.ApplicationTypeID = Cls_ApplicationTypes_BusinessLayer.Find(4).ApllicationId;
            }
            Application.PaidFees = 0;

            Application.LastStatusDate = DateTime.Now;
            Application.CreatedByUserID = CurrentUser.User.UserID;
            if (!Application.Save()) return;

            //Add Replace License App
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocalLicenseApp =
                new Cls_LocalDrivingLicenseApplication_BusinessLayer();
            LocalLicenseApp.ApplicationID = Application.ApplicationID;
            LocalLicenseApp.LicenseClassID = _License.LicenseClass;
            if (!LocalLicenseApp.Save()) return;
            //Add to Licenses
            clsLicenses_BusinessLayer NewLicense = new clsLicenses_BusinessLayer();
            NewLicense.ApplicationID = Application.ApplicationID;
            NewLicense.DriverID = _License.DriverID;
            NewLicense.LicenseClass = _License.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate =_License.ExpirationDate;
              
            if (!String.IsNullOrEmpty(Txt_Notes.Text))
            {
                NewLicense.Notes = Txt_Notes.Text;
            }
            else
            {
                NewLicense.Notes = null;
            }
            NewLicense.PaidFees = Cls_LicenseClasses_BusinessLayer.Find(_License.LicenseClass).ClassFees;
            NewLicense.IsActive = true;
            if (Rd_Lost.Checked)
            {
                NewLicense.IssueReason = 3;//Lost

            }
            else
            {
                NewLicense.IssueReason = 4;//Damaged

            }
           
            NewLicense.CreatedByUserID = CurrentUser.User.UserID;
            // DeActivate Old License
            _License.IsActive = false;
            if (!_License.Save()) return;
            if (NewLicense.Save())
            {
                label_Re_Appid.Text = Application.ApplicationID.ToString();
                Btn_ShowLicenseInfo.Enabled = true;
                MessageBox.Show("New License Added Successfully With id= " + NewLicense.LicenseID,
                    "Replase License", MessageBoxButtons.OK
                  , MessageBoxIcon.Information);
                RefrishPanel();
                _License=NewLicense;
                Btn_Save.Enabled = false;
                panel3.Enabled= false;
                Btn_FindLicense.Enabled = false;
                Txt_FillterBy.Enabled = false;  
            }
            else
            {

                MessageBox.Show("Error Can't Replase License", "System Error", MessageBoxButtons.OK
                   , MessageBoxIcon.Error);
            }
        }

        private void Btn_Closel_Click(object sender, EventArgs e)
        {
            var FrmMain = FindForm() as MainForm;
            if (FrmMain == null) return;

            FrmMain.Show_Control(new UC_MainApplications());


        }

        private void Rd_Lost_CheckedChanged(object sender, EventArgs e)
        {
            if (Rd_Lost.Checked)
            {
                label_AppFees.Text = Cls_ApplicationTypes_BusinessLayer.Find(3).ApplicationFees.ToString();


            }
            else
            {
                label_AppFees.Text = Cls_ApplicationTypes_BusinessLayer.Find(4).ApplicationFees.ToString();
            }
        }
    }
}
