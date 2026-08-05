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

namespace DVLD_Full_Proj.Applications.ManageApplications.Forms
{
    public partial class Frm_SchudleVisionTest : Form
    {
        enum EnTestType { Vision = 1, Written = 2, Street = 3 }
        enum EnApplicationStatus {New=1,Cancelled=2,Completed=3 }
        enum EnMode { AddNew=1,Edit=2}
        EnMode _Mode = EnMode.AddNew;
        Cls_LocalDrivingLicenseApplication_BusinessLayer _LocalLicenseApp=null;
        clsTestAppointments_BusinessLayer _TestAppointment=null;
        Cls_Applications_BusinessLayer _Application=null;
        Cls_Applications_BusinessLayer _RetakeTestApp=null;
        int _LocalDrivingLicenseId = 0;

        public Frm_SchudleVisionTest(int AppointmenId=-1,int LocalDrivingLicenseId=-1,bool EnabelRetakeTest=false)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Gp_RetakeTEst.Enabled = EnabelRetakeTest;
            if (LocalDrivingLicenseId != -1)
            {
                _LocalLicenseApp = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalDrivingLicenseId);
                _LocalDrivingLicenseId = LocalDrivingLicenseId;
            }
            if (_LocalLicenseApp == null) return;
            //AddMode
            if (AppointmenId == -1)
            {
                _TestAppointment = new clsTestAppointments_BusinessLayer();
            }
            else
            {
                //UdateMode
                _Mode = EnMode.Edit;
                _TestAppointment = clsTestAppointments_BusinessLayer.Find(AppointmenId);
                if (_TestAppointment == null) return;

               
            }
            _Application = Cls_Applications_BusinessLayer.Find(_LocalLicenseApp.ApplicationID);
            if (_Application == null) return;

        }

        private void Defult_Initialize()
        {
            Dt_AppDate.MaxDate = DateTime.Now.AddMonths(3);
            Dt_AppDate.MinDate = DateTime.Now.AddYears(-18);
           
        }
        private void Load_Application()
        {
            if (_Mode == EnMode.AddNew)
            {
                label_DLAppID.Text = _LocalDrivingLicenseId.ToString();
              
                label_LicenseClass.Text = Cls_LicenseClasses_BusinessLayer.Find(_LocalLicenseApp.LicenseClassID).ClassName;
                label_Name.Text = clsPeople_BusinessLayer.Find(_Application.ApplicantPersonID).FullName;
                Dt_AppDate.Value = DateTime.Now;
                label_Fees.Text = Cls_TestTypes_BusinessLayer.Find((int)EnTestType.Vision).TestTypeFees.ToString();
                if (Gp_RetakeTEst.Enabled == true)
                {

                    //Retake Test Fees
                    label_RAppFees.Text = Cls_ApplicationTypes_BusinessLayer.Find(7).ApplicationFees.ToString();
                   
                }
            }
            if (_Mode== EnMode.Edit)
            {
                if(_TestAppointment.IsLocked)
                {
                    Btn_Save.Enabled = false;
                    Dt_AppDate.Enabled = false;
                }
                lbl_Title.Text = "Edit Schudeled Test";
                label_DLAppID.Text= _LocalDrivingLicenseId.ToString();
                label_LicenseClass.Text = Cls_LicenseClasses_BusinessLayer.Find(_LocalLicenseApp.LicenseClassID).ClassName;
                label_Name.Text = clsPeople_BusinessLayer.Find(_Application.ApplicantPersonID).FullName;
                Dt_AppDate.Value =Convert.ToDateTime( _TestAppointment.AppointmentDate);
                label_Fees.Text = Cls_TestTypes_BusinessLayer.Find((int)EnTestType.Vision).TestTypeFees.ToString();
                if (Gp_RetakeTEst.Enabled ==true)
                {
                    
                    //Retake Test Fees
                    label_RAppFees.Text = Cls_ApplicationTypes_BusinessLayer.Find(7).ApplicationFees.ToString();
                    label_RTestAppId.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                }
            }
            //How Many Trails
            int CountTrails = 0;
            DataTable DtTrails = clsTestAppointments_BusinessLayer.GetAllTestAppointments_For_LocalLicenseApplication(_LocalDrivingLicenseId, (int)EnTestType.Vision);
            foreach (DataRow dr in DtTrails.Rows)
            {
                if (dr.Field<bool>("IsLocked")==true)
                {
                    CountTrails++;
                }
            }
                label_Trail.Text = CountTrails.ToString();
          
            decimal fees = 0;
            decimal rAppFees = 0;
            decimal.TryParse(label_Fees.Text, out fees);
            decimal.TryParse(label_RAppFees.Text, out rAppFees);
            decimal TotalFees = fees + rAppFees; 
            label_totalFees.Text = Convert.ToString(TotalFees);

        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        

        private void Frm_SchudleVisionTest_Load(object sender, EventArgs e)
        {
            Load_Application();
        }
        private bool _Save_Data()
        {
            return true;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            _TestAppointment.AppointmentDate = Dt_AppDate.Value;
            _TestAppointment.TestTypeID = (int)EnTestType.Vision;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalLicenseApp.LocalDrivingLicenseApplicationID;
            _TestAppointment.PaidFees = Convert.ToDecimal(label_totalFees.Text);
            _TestAppointment.CreatedByUserID = CurrentUser.User.UserID;
            _TestAppointment.IsLocked =false;
          
            if (Gp_RetakeTEst.Enabled == true)
            {
                //Add New Retake Test App
                Cls_Applications_BusinessLayer _RetakeTestAPP= new Cls_Applications_BusinessLayer();
                _RetakeTestAPP.ApplicationTypeID = Cls_ApplicationTypes_BusinessLayer.Find(7).ApllicationId;
                _RetakeTestAPP.PaidFees = Cls_ApplicationTypes_BusinessLayer.Find(7).ApplicationFees;
                _RetakeTestAPP.ApplicationStatus= (int) EnApplicationStatus.Completed;
                _RetakeTestAPP. ApplicationDate = DateTime.Now ;
                _RetakeTestAPP.ApplicantPersonID = clsPeople_BusinessLayer.Find(_Application.ApplicantPersonID).ID;
                _RetakeTestAPP.CreatedByUserID= CurrentUser.User.UserID;
                _RetakeTestAPP.LastStatusDate = DateTime.Now ;
                if (_RetakeTestAPP.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = _RetakeTestAPP.ApplicationID;
                }
                else
                {
                    return;
                }

            }
            
            if (!_TestAppointment.Save())
            {
                MessageBox.Show("Schudle Test Not Added Successfully", "Add Schudle Test", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;

            }
            MessageBox.Show("Schudle Test Added Successfully","Add Schudle Test",MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            lbl_Title.Text = "Edit Schudeled Test";
            _Mode= EnMode.Edit;
            
            if (Gp_RetakeTEst.Enabled == true)
            {
               label_RTestAppId.Text= _TestAppointment.RetakeTestApplicationID.ToString(); 
                

            }


        }

        private void label_totalFees_Click(object sender, EventArgs e)
        {

        }
    }
}
