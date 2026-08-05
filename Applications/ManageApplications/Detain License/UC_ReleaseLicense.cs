using DVLD_Business_Layer;
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

namespace DVLD_Full_Proj.Applications.ManageApplications.Detain_License
{
    public partial class UC_ReleaseLicense : UserControl
    {
        public enum EnBackMode { BackToMain = 1, BackToManageDetainedLicense = 2 }
        EnBackMode _BackMode = EnBackMode.BackToMain;
        clsDrivers_BusinessLayer _Driver = null;
        enum _EnStatus { New = 1, Cancelled = 2, Completed = 3 }
        UC_ShowLocalDrivingLicenseinfo UC_ShowLocalLicenseinfo = new UC_ShowLocalDrivingLicenseinfo();
        clsLicenses_BusinessLayer _License = null;
        clsDetainedLicenses_BusinessLayer _Detain_License = null;
        int _ApplicationId = -1;
        int _Licenseid = -1;
        public UC_ReleaseLicense()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public EnBackMode BackMode
        {
            set { _BackMode = value; }
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

            label_DetainDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            label_AppFees.Text = Cls_ApplicationTypes_BusinessLayer.Find(5).ApplicationFees.ToString();
            label_CreatedBy.Text = CurrentUser.User.UserName;
            label_Licenseid.Text = "??";
            label_Detainid.Text = "??";
            label_FineFees.Text = "??";
            // After Find License 
            if (_License != null && _Detain_License != null)
            {
                label_FineFees.Text = Cls_LicenseClasses_BusinessLayer.Find(_License.LicenseClass).ClassFees.ToString();
                label_Licenseid.Text = _License.LicenseID.ToString();
                decimal FineFees = _Detain_License.FineFees;
                label_FineFees.Text = FineFees.ToString();
                decimal TotalFees = FineFees + Convert.ToDecimal(label_AppFees.Text);
                label_totalFees.Text = TotalFees.ToString();
                label_Detainid.Text = _Detain_License.DetainID.ToString();

            }
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
        private void UC_ReleaseLicense_Load(object sender, EventArgs e)
        {
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
            else
            {
                errorProvider1.SetError(Txt_FillterBy, "");

            }
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
                    if (iSDetaindLicense() && !IsLicenseExpired())
                    {
                        _Detain_License = clsDetainedLicenses_BusinessLayer.FindByLicenseID(_License.LicenseID);
                        if (_Detain_License == null) return;
                        Btn_Save.Enabled = true;
                        Btn_ShowLicenseHistory.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sorry You Can't Release Not Detaind or Expired  License",
                            "Find License", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                        Btn_Save.Enabled = false;
                        Btn_ShowLicenseInfo.Enabled = false;
                        Btn_ShowLicenseHistory.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry You Can't Release Not Active License",
                           "Find License", MessageBoxButtons.OK
                       , MessageBoxIcon.Error);
                    Btn_Save.Enabled = false;
                    Btn_ShowLicenseInfo.Enabled = false;
                    Btn_ShowLicenseHistory.Enabled = false;
                }
                RefrishPanel();
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


            // Add Release App
            Cls_Applications_BusinessLayer Application = new Cls_Applications_BusinessLayer();
            Application.ApplicantPersonID = _Driver.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationStatus = (byte)_EnStatus.Completed;
            Application.ApplicationTypeID = Cls_ApplicationTypes_BusinessLayer.Find(5).ApllicationId;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = Cls_ApplicationTypes_BusinessLayer.Find(5).ApplicationFees;
            Application.CreatedByUserID = CurrentUser.User.UserID;
            if (!Application.Save()) return;


            if (_Detain_License.ReleaseLicense(CurrentUser.User.UserID, Application.ApplicationID))
            {
                _Detain_License = clsDetainedLicenses_BusinessLayer.FindByLicenseID(_Licenseid);
                label_Appid.Text = Application.ApplicationID.ToString();
                Btn_ShowLicenseInfo.Enabled = true;
                MessageBox.Show(" License is Released Successfully With App id= " + Application.ApplicationID,
                    "Detain License", MessageBoxButtons.OK
                  , MessageBoxIcon.Information);
                RefrishPanel();
                Btn_Save.Enabled = false;
                Btn_FindLicense.Enabled = false;
                Txt_FillterBy.Enabled = false;

            }
            else
            {

                MessageBox.Show("Error Can't Release License", "System Error", MessageBoxButtons.OK
                   , MessageBoxIcon.Error);
            }
        }

        private void Btn_Closel_Click(object sender, EventArgs e)
        {
            var FrmMain = FindForm() as MainForm;
            if (FrmMain == null) return;
            if (_BackMode == EnBackMode.BackToMain)
            {
                FrmMain.Show_Control(new UC_MainApplications());

            }
            else
            {
                FrmMain.Show_Control(new UC_ManageDetainLicense());


            }
        }
    }
}
