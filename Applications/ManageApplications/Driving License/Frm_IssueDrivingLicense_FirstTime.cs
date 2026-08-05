using DVLD_Business_Layer;
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

namespace DVLD_Full_Proj.Applications.ManageApplications.Driving_License
{
    public partial class Frm_IssueDrivingLicense_FirstTime : Form
    {
        enum EnApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }

        UC_ShowApplicationInfo_DrivingLicenseInfo UC_LicenseAndAppInfo;
        Cls_LocalDrivingLicenseApplication_BusinessLayer LocalLicense;
        clsDrivers_BusinessLayer Driver;
        clsLicenses_BusinessLayer License;
        Cls_Applications_BusinessLayer Application;
        int _LocalLicenseAppid = -1;
        public Frm_IssueDrivingLicense_FirstTime(int LocalLicenseAppid=-1)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (LocalLicenseAppid == -1) return;
            _LocalLicenseAppid=LocalLicenseAppid;
        }
        private void initialize_Data()
        {
            LocalLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(_LocalLicenseAppid);
            Application= Cls_Applications_BusinessLayer.Find(LocalLicense.ApplicationID);
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            License = new clsLicenses_BusinessLayer();

            if (!clsDrivers_BusinessLayer.IsDriverExistByPersonid(Application.ApplicantPersonID))
            {
                Driver = new clsDrivers_BusinessLayer();
                Driver.PersonID = Application.ApplicantPersonID;
                Driver.CreatedDate = DateTime.Now;
                Driver.CreatedByUserID = CurrentUser.User.UserID;
                if (!Driver.Save())
                {
                    MessageBox.Show("Sorry Driver Not Added",
                        "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Driver = clsDrivers_BusinessLayer.FindByPersonid(Application.ApplicantPersonID);
            if(Driver==null)return;
            License.ApplicationID=LocalLicense.ApplicationID;
            License.DriverID=Driver.DriverID;
            License.LicenseClass=LocalLicense.LicenseClassID;
            License.IssueDate = DateTime.Now;
            int ValidityYears =(int) Cls_LicenseClasses_BusinessLayer.Find(LocalLicense.LicenseClassID).DefaultValidityLength;
            License.ExpirationDate =DateTime.Now.AddYears(ValidityYears);
            License.Notes = Txt_Notes.Text;
            License.PaidFees = Cls_LicenseClasses_BusinessLayer.Find(LocalLicense.LicenseClassID).ClassFees;
            License.IssueReason = 1;
            License.CreatedByUserID = CurrentUser.User.UserID;  
            License.IsActive = true;
            if (License.Save())
            {
                MessageBox.Show("License Added Succsessfully Whit id= "+License.LicenseID + '.'
                    ,"Add License" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.ApplicationStatus =(int) EnApplicationStatus.Completed;
                if (!Application.Save())
                {
                    return; 
                }
            }
            else
            {
                MessageBox.Show("License Not Added Succsessfully", "Add License"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);

                clsDrivers_BusinessLayer.DeleteDriver(Driver.DriverID);
            }


        }

        private void Frm_IssueDrivingLicense_FirstTime_Load(object sender, EventArgs e)
        {
            initialize_Data();
            if (LocalLicense == null|| Application==null) return;
            UC_LicenseAndAppInfo= new UC_ShowApplicationInfo_DrivingLicenseInfo(LocalLicense.ApplicationID);
            UC_LicenseAndAppInfo.Dock = DockStyle.Fill; 
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_LicenseAndAppInfo);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
