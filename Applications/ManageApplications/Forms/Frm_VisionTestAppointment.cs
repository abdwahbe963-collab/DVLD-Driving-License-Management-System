using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;
using DVLD_Full_Proj.Applications.ManageApplications;
using static System.Net.Mime.MediaTypeNames;
namespace DVLD_Full_Proj.Applications.ManageApplications.Forms
{

    public partial class Frm_VisionTestAppointment : Form
    {
        enum EnTestType { Vision = 1, Written = 2, Street = 3 }

        UC_ShowApplicationInfo_DrivingLicenseInfo Uc_ShowAppDetails = null;
        Cls_LocalDrivingLicenseApplication_BusinessLayer _LocalLicense=null;
        int _ApplicationId = -1;
        public Frm_VisionTestAppointment(int Applicationid)
        {

            InitializeComponent();
            this.DoubleBuffered = true;
        
            _ApplicationId = Applicationid;
            if (_ApplicationId == -1) return;



        }
        private void _Refrish_Dg_TestAppointment()
        {
           
           Dg_TestAppointment.DataSource =
             clsTestAppointments_BusinessLayer.GetAllTestAppointments_For_LocalLicenseApplication(
                 _LocalLicense.LocalDrivingLicenseApplicationID,(int)EnTestType.Vision);
           
        }
        private void Frm_VisionTest_Load(object sender, EventArgs e)
        {
            _LocalLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.FindByApplicationID(_ApplicationId);
           
            Uc_ShowAppDetails = new UC_ShowApplicationInfo_DrivingLicenseInfo(_ApplicationId);
            panel1.Controls.Clear();
            panel1.Controls.Add(Uc_ShowAppDetails);
            _Refrish_Dg_TestAppointment();

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_AddSchudleVisionTest_Click(object sender, EventArgs e)
        {
            clsTestAppointments_BusinessLayer _TestAppointment=
            clsTestAppointments_BusinessLayer.FindTop1TestAppointmentByLocalDrivingLicenseAppId_ForVisionTest(_LocalLicense.LocalDrivingLicenseApplicationID, _LocalLicense.LicenseClassID);
           
            if (_TestAppointment == null)
            {
                Frm_SchudleVisionTest frm =
                new Frm_SchudleVisionTest(-1, _LocalLicense.LocalDrivingLicenseApplicationID);

                frm.ShowDialog();
                
            }
           else if (_TestAppointment.IsLocked==false)
            {
                MessageBox.Show("This person did not complete his last request.",
                    "Not Completed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var test = clsTests_BusinessLayer.FindByAppointmentTestid(_TestAppointment.TestAppointmentID);
              
                if (test == null)return;

                if (test.TestResult == false)
                {
                    Frm_SchudleVisionTest frm =
                        new Frm_SchudleVisionTest(-1, _LocalLicense.LocalDrivingLicenseApplicationID, true);

                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("This person passed the test on the request ["+ _TestAppointment.TestAppointmentID+" ]",
                        "Already Pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _Refrish_Dg_TestAppointment();

        }
       
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Dg_TestAppointment.CurrentRow.Cells["IsLocked"].Value.ToString());
           

                int Appointmentid = Convert.ToInt32(Dg_TestAppointment.CurrentRow.Cells[0].Value);
                clsTestAppointments_BusinessLayer _Apointment = clsTestAppointments_BusinessLayer.Find(Appointmentid);
                if (_Apointment == null) return;
                Frm_SchudleVisionTest frm;
                if((_Apointment.RetakeTestApplicationID!=null|| _Apointment.RetakeTestApplicationID>0))
                {
                    frm = new Frm_SchudleVisionTest(Appointmentid, _Apointment.LocalDrivingLicenseApplicationID, true);

                }
                else
                {
                    frm = new Frm_SchudleVisionTest(Appointmentid, _Apointment.LocalDrivingLicenseApplicationID);

                }
                frm.ShowDialog();

            _Refrish_Dg_TestAppointment();
        }

        private void TakeTesttoolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int Appointmentid = Convert.ToInt32(Dg_TestAppointment.CurrentRow.Cells[0].Value);
            clsTestAppointments_BusinessLayer _Apointment = clsTestAppointments_BusinessLayer.Find(Appointmentid);
            if (_Apointment == null) return;
            if(_Apointment.IsLocked)
            {
                MessageBox.Show("This Person Already Taked This Test", "Take Test", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                return;
            }

            Frm_TakeVisionTest frm_TakeVisionTest = new Frm_TakeVisionTest(Appointmentid, _Apointment.LocalDrivingLicenseApplicationID);
            frm_TakeVisionTest.ShowDialog();

            _Refrish_Dg_TestAppointment();


        }
    }
}
