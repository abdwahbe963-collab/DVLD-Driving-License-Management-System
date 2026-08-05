using DVLD_Business_Layer;
using DVLD_Full_Proj.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj.Applications.ManageApplications.Driving_License.DrivingLicenseControls
{
    public partial class UC_ShowLocalDrivingLicenseinfo : UserControl
    {
        int _Applicationid=-1;
        int _Licenseid = -1;
        Cls_Applications_BusinessLayer Application;
        Cls_LocalDrivingLicenseApplication_BusinessLayer LocalLicenseApp;
        clsLicenses_BusinessLayer License;
        clsPeople_BusinessLayer Person;
        public UC_ShowLocalDrivingLicenseinfo(int Applicatiionid=-1, int Licenseid=-1)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (Applicatiionid == -1 && Licenseid==-1) return;
            if (Applicatiionid != -1 && Licenseid == -1)
            {
                _Applicationid = Applicatiionid;
            }
            else
            {
                _Licenseid = Licenseid;
            }
          

        }
        private void Initilaize_Data()
        {
            if (_Licenseid != -1)
            {
                License = clsLicenses_BusinessLayer.Find(_Licenseid);
                if (License == null) return;
                Application = Cls_Applications_BusinessLayer.Find(License.ApplicationID);
                if (Application == null) return;
                LocalLicenseApp = Cls_LocalDrivingLicenseApplication_BusinessLayer.FindByApplicationID(License.ApplicationID);
                if (LocalLicenseApp == null) return;
                Person = clsPeople_BusinessLayer.Find(Application.ApplicantPersonID);
                if (Person == null) return;
            }
            else
            {
                if (_Applicationid == -1) return;
                Application = Cls_Applications_BusinessLayer.Find(_Applicationid);
                if (Application == null) return;
                LocalLicenseApp = Cls_LocalDrivingLicenseApplication_BusinessLayer.FindByApplicationID(_Applicationid);
                if (LocalLicenseApp == null) return;
                License = clsLicenses_BusinessLayer.FindByApplicationId(_Applicationid);
                if (License == null) return;
                Person = clsPeople_BusinessLayer.Find(Application.ApplicantPersonID);
                if (Person == null) return;
            }
            
        }
        private void UC_ShowLocalDrivingLicenseinfo_Load(object sender, EventArgs e)
        {
            if (_Applicationid == -1&& _Licenseid==-1) return;

            Initilaize_Data();
            if (License == null) return;
            int LicenseClass = LocalLicenseApp.LicenseClassID;
            label_LicenseClass.Text = Cls_LicenseClasses_BusinessLayer.Find(LicenseClass).ClassName;
            label_Name.Text = Person.FullName;
            label_Licenseid.Text= License.LicenseID.ToString();
            label_NationalNo.Text = Person.NationalNo;
            if (Person.Gender == 0)
            {
                label_Gender.Text = "Male";

            }
            else
            {
                label_Gender.Text = "Female";
            }
            label_issueDate.Text = License.IssueDate.ToString("dd/MM/yyyy");
            Label_issueReason.Text = License.IssueReason.ToString();
            label_Notes.Text = License.Notes==null? "No Notes" : License.Notes;
            if (License.IsActive == true)
            {
                label_IsActive.Text = "Yes";
                
            }
            else
            {
                label_IsActive.Text = "No";

            }
            label_DateOfBirth.Text=Person.DateOfBirth.ToString("dd/MM/yyyy");
            label_Driverid.Text = License.DriverID.ToString();
            label_ExpirationDate.Text = License.ExpirationDate.ToString("dd/MM/yyyy");
            bool ISDetaind = clsLicenses_BusinessLayer.IsLicenseDetained(License.LicenseID);
            if (ISDetaind)
            {
                label_IsDetaind.Text = "Yes";

            }
            else
            {
                label_IsDetaind.Text = "No";
            }
            if (Person.ImagePath != null)
            {
                using (var fs = new FileStream(Person.ImagePath.ToString(), FileMode.Open, FileAccess.Read))
                {
                    PicBox_Person.Image = Image.FromStream(fs);
                }
            }
            else
            {

                PicBox_Person.Image = Resources.icons8_person_64;
            }

        }
    }
}
