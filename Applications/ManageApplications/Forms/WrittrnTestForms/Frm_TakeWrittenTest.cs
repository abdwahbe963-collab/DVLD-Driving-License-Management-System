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

namespace DVLD_Full_Proj.Applications.ManageApplications.Forms.WrittrnTestForms
{
    public partial class Frm_TakeWrittenTest : Form
    {
        enum EnTestType { Vision = 1, Written = 2, Street = 3 }
        enum EnApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }
        int _TestAppointmentId = -1;
        Cls_LocalDrivingLicenseApplication_BusinessLayer _LocalLicenseApp = null;
        Cls_Applications_BusinessLayer _Application = null;
        int _LocalDrivingLicenseId = 0;
        public Frm_TakeWrittenTest(int Appointmentid = -1, int LocalDrivingLicenseId = -1)
        {
            InitializeComponent();
            if (Appointmentid == -1 || LocalDrivingLicenseId == -1) return;
            this.DoubleBuffered = true;
            _TestAppointmentId = Appointmentid;
            if (LocalDrivingLicenseId != -1)
            {
                _LocalLicenseApp = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalDrivingLicenseId);
                _LocalDrivingLicenseId = LocalDrivingLicenseId;
            }
            if (_LocalLicenseApp == null) return;
            _Application = Cls_Applications_BusinessLayer.Find(_LocalLicenseApp.ApplicationID);
            if (_Application == null) return;
        }
        private void Load_TestInfo()
        {
            Rd_Pass.Checked=true;
            label_DLAppID.Text = _LocalDrivingLicenseId.ToString();
            label_LicenseClass.Text = Cls_LicenseClasses_BusinessLayer.Find(_LocalLicenseApp.LicenseClassID).ClassName;
            label_Name.Text = clsPeople_BusinessLayer.Find(_Application.ApplicantPersonID).FullName;
            label_TestDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label_Fees.Text = Cls_TestTypes_BusinessLayer.Find((int)EnTestType.Written).TestTypeFees.ToString();
            //How Many Trails
            int CountTrails = 0;
            DataTable DtTrails = clsTestAppointments_BusinessLayer.GetAllTestAppointments_For_LocalLicenseApplication(_LocalDrivingLicenseId, (int)EnTestType.Written);
            foreach (DataRow dr in DtTrails.Rows)
            {
                if (dr.Field<bool>("IsLocked") == true)
                {
                    CountTrails++;
                }
            }
            label_Trail.Text = CountTrails.ToString();



        }
       
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure To Save Test Results?", "Save Test Results", MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.No) return;

            clsTests_BusinessLayer _Test = new clsTests_BusinessLayer();
            _Test.TestResult = Rd_Pass.Checked;
            if (String.IsNullOrEmpty(Txt_Notes.Text))
                _Test.Notes = null;
            else
                _Test.Notes = Txt_Notes.Text;
            _Test.TestAppointmentID = _TestAppointmentId;
            _Test.CreatedByUserID = CurrentUser.User.UserID;
            clsTestAppointments_BusinessLayer _TestAppointment = clsTestAppointments_BusinessLayer.Find(_TestAppointmentId);
            if (_TestAppointment == null)
            {
                return;
            }

            if (!_Test.Save())
            {
                MessageBox.Show("Take Test info Not Added Successfully", "Add Take Test", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Take Test info  Added Successfully", "Add Take Test", MessageBoxButtons.OK,
              MessageBoxIcon.Information);
            _TestAppointment.IsLocked = true;
            if (!_TestAppointment.Save())
            {
                clsTests_BusinessLayer.DeleteTest(_Test.TestID);
                MessageBox.Show("Take Test info Not Added Successfully", "Add Take Test", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
            }
            label_TestId.Text = _Test.TestID.ToString();

            Btn_Save.Enabled = false;
        }

        private void Frm_TakeWrittenTest_Load(object sender, EventArgs e)
        {
            Load_TestInfo();
        }

        private void Btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
