using DVLD_Business_Layer;
using DVLD_Full_Proj.Applications.ManageApplications;
using DVLD_Full_Proj.General;
using DVLD_Full_Proj.PeopleControls;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Full_Proj.Applications.Licenses
{
    
    public partial class UC_AddNewLocalDrivingLicense : UserControl
    {  
        enum EnMode { Addnew=1,update=2}
        EnMode _mode=EnMode.Addnew;
        public enum EnBackMod { BackToMainApplications=1, BackToLocalDrivingLicenseApplications=2}
        private EnBackMod _BackMode=EnBackMod.BackToMainApplications;
        public EnBackMod BackMode
        { 
           set { _BackMode = value; }
        }
        enum _EnApplicationStatus { New=1, Cancelled =2, Completed =3}
        UC_AddLcalDrivingLiceinseDetailes UC_AddLicenseDetailes;
        int _ApplicationID = -1;
        Cls_Applications_BusinessLayer _Application;
        Cls_LocalDrivingLicenseApplication_BusinessLayer _LocalLicense;
          
       
        public UC_AddNewLocalDrivingLicense(int Applicationid=-1)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if ( Applicationid!=-1  )
            {
                _mode = EnMode.update;
                _ApplicationID = Applicationid;
            }
            
            UC_FindPerson1.BacKMode = UC_FindPerson.ENBacKMode.BackToLicense;
            Btn_Save.Enabled = false;
        }
         
        private void Initialize_Data()
        {
            if(_mode==EnMode.update)
            {
                _Application = Cls_Applications_BusinessLayer.Find(_ApplicationID);
                if (_Application == null) return;
                _LocalLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.FindByApplicationID(_ApplicationID);
                if (_LocalLicense == null) return;
               
                UC_FindPerson1.LoadData(_Application.ApplicantPersonID);
                UC_FindPerson1.EnableFillter = false;
                lbl_Title.Text = "Update Local Driving License";
            }
            else
            {
                _Application = new Cls_Applications_BusinessLayer();
                _LocalLicense = new Cls_LocalDrivingLicenseApplication_BusinessLayer();
            }
        }
        private void UC_AddNewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            Initialize_Data();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (UC_FindPerson1.PersonId == -1)
            {
                MessageBox.Show("Please Select Person First", "Not Selected"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Btn_Save.Enabled =true;
           UC_AddLicenseDetailes =
              new UC_AddLcalDrivingLiceinseDetailes(_Application.ApplicationID);

            UC_AddLicenseDetailes.Dock=DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_AddLicenseDetailes);
            Btn_Next.Visible = false;
            Btn_Back.Visible = true;
         
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            UC_FindPerson1.Dock=DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_FindPerson1);
            Btn_Next.Visible = true;
            Btn_Back.Visible = false;
        }
        private DataTable _GetPersonApplications()
        {
           return Cls_Applications_BusinessLayer.GetPersonApplications(UC_FindPerson1.PersonId);
        }
        private bool Is_PersonApplicationEqualNewApplication()
        {
            int PersonLicenseClass = 0;
            DataTable Dt_CurrentPersonApplications = _GetPersonApplications();
            if (Dt_CurrentPersonApplications == null)return false;
            foreach(DataRow dr in Dt_CurrentPersonApplications.Rows)
            {
                if (_mode == EnMode.update && (int)dr["ApplicationID"]==_ApplicationID)
                {
                    continue;
                }

                    int Person_Appid = (int)dr["ApplicationID"];
                Cls_LocalDrivingLicenseApplication_BusinessLayer LocalLicenseClass = Cls_LocalDrivingLicenseApplication_BusinessLayer.FindByApplicationID(Person_Appid);
                if (LocalLicenseClass != null )
                {
                   
                     PersonLicenseClass = (int)LocalLicenseClass.LicenseClassID;

                }
               
                    if (Cls_Applications_BusinessLayer.Find(Person_Appid).ApplicationStatus
                        == (int)_EnApplicationStatus.New &&
                         PersonLicenseClass == UC_AddLicenseDetailes.LicenseClass) return false;

                    if (Cls_Applications_BusinessLayer.Find(Person_Appid).ApplicationStatus
                      == (int)_EnApplicationStatus.Completed &&
                       PersonLicenseClass == UC_AddLicenseDetailes.LicenseClass) return false;
               
                
            }
            return true;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (UC_FindPerson1.PersonId == -1)
            {
                MessageBox.Show("Please Select Person First", "Not Selected"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Is_PersonApplicationEqualNewApplication())
            {
                MessageBox.Show("Person Has (New) or (Completed) Application For this LicenseClass", "Same License Class"
                   , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _Application.ApplicationDate =DateTime.Now;
            _Application.LastStatusDate = DateTime.Now;
            _Application.CreatedByUserID= CurrentUser.User.UserID;
            _Application.ApplicantPersonID= UC_FindPerson1.PersonId;
            _Application.PaidFees = Cls_ApplicationTypes_BusinessLayer.Find(1).ApplicationFees;
            _Application.ApplicationStatus = Convert.ToByte( _EnApplicationStatus.New);
            _Application.ApplicationTypeID = 1;
            if (_Application.Save())
            {
                
                _LocalLicense.LicenseClassID = UC_AddLicenseDetailes.LicenseClass;
                _LocalLicense.ApplicationID = _Application.ApplicationID;
               if( _LocalLicense.Save())
                {
                    if (_mode == EnMode.Addnew)
                    {
                        MessageBox.Show("Application Added Successfully", "Data Saved"
                      , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Application Updated Successfully", "Data Saved"
                     , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    UC_AddLicenseDetailes =
                   new UC_AddLcalDrivingLiceinseDetailes(_Application.ApplicationID);
                    UC_AddLicenseDetailes.Dock = DockStyle.Fill;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(UC_AddLicenseDetailes);
                    lbl_Title.Text = "Update Local Driving License";
                    _mode=EnMode.update;
                }
               else
                {
                    MessageBox.Show("System Wrong", "Data Not Saved"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Application Not Added Successfully", "Data Not Saved"
             , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
          
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }    
                MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            if (_BackMode == EnBackMod.BackToMainApplications)
            {
                Frm.Show_Control(new UC_MainApplications());
            }
            else
            {
                Frm.Show_Control(new UC_ShowLocalDrivingLicenseApplications());
            }

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
