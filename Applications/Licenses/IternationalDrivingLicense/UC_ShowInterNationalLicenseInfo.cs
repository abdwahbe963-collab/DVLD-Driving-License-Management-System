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

namespace DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense
{
   
    public partial class UC_ShowInterNationalLicenseInfo : UserControl
    {
        int _Applicationid = -1;
        Cls_Applications_BusinessLayer Application;
        clsInternationalLicense_BusenessLayer _InterNationalLicense;
        clsPeople_BusinessLayer Person;
        public UC_ShowInterNationalLicenseInfo(int Applicatiionid = -1)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (Applicatiionid == -1) return;
            _Applicationid = Applicatiionid;

        }
        private void Initilaize_Data()
        {
            if (_Applicationid == -1) return;
            Application = Cls_Applications_BusinessLayer.Find(_Applicationid);
            if (Application == null) return;
            _InterNationalLicense = clsInternationalLicense_BusenessLayer.FindByApplicationID(_Applicationid);
            if (_InterNationalLicense == null) return;
            Person = clsPeople_BusinessLayer.Find(Application.ApplicantPersonID);
            if (Person == null) return;
        }
      
        private void UC_ShowInterNationalLicenseInfo_Load(object sender, EventArgs e)
        {
            if (_Applicationid == -1) return;
            
            Initilaize_Data();
            if (_InterNationalLicense == null) return;
            label_Appid.Text= _Applicationid.ToString();
            label_Name.Text = Person.FullName;
            label_internationalLicenseid.Text = _InterNationalLicense.InternationalLicenseID.ToString();
            label_LocalLicsenseid.Text = _InterNationalLicense.IssuedUsingLocalLicenseID.ToString();
            label_NationalNo.Text = Person.NationalNo;
            if (Person.Gender == 0)
            {
                label_Gender.Text = "Male";

            }
            else
            {
                label_Gender.Text = "Female";
            }
            label_issueDate.Text = _InterNationalLicense.IssueDate.ToString("dd/MM/yyyy");
            if (_InterNationalLicense.IsActive == true)
            {
                label_IsActive.Text = "Yes";

            }
            else
            {
                label_IsActive.Text = "No";

            }
            label_DateOfBirth.Text = Person.DateOfBirth.ToString("dd/MM/yyyy");
            label_Driverid.Text = _InterNationalLicense.DriverID.ToString();
            label_ExpirationDate.Text = _InterNationalLicense.ExpirationDate.ToString("dd/MM/yyyy");

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
