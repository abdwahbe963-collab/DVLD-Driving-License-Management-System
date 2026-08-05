using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using DVLD_Full_Proj.PeopleControls;

namespace DVLD_Full_Proj.Applications.ManageApplications
{
    public partial class UC_ShowApplicationInfo_DrivingLicenseInfo : UserControl
    {
        Cls_Applications_BusinessLayer _Application=null;
        DataTable DtApplicationInfo=null;
       
        public UC_ShowApplicationInfo_DrivingLicenseInfo(int ApplicationID)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            DtApplicationInfo = Cls_Applications_BusinessLayer.GetApplicationFromVeiw(ApplicationID); 
            _Application = Cls_Applications_BusinessLayer.Find(ApplicationID);
            if (_Application == null || DtApplicationInfo== null) return;
        }
       
        private void Initialize_Data()
        { 
            //Local Driving License Info
            label_DLAppID.Text = DtApplicationInfo.Rows[0]["LocalDrivingLicenseApplicationID"].ToString();
            label_LicenseClass.Text =  DtApplicationInfo.Rows[0]["ClassName"].ToString();
            label_PassedTests.Text = DtApplicationInfo.Rows[0]["PassedTestCount"].ToString();
            //ApllicationInfo
            label_AppId.Text =  DtApplicationInfo.Rows[0]["ApplicationID"].ToString();
            label_Status.Text = DtApplicationInfo.Rows[0]["Status"].ToString();
            label_Fees.Text= DtApplicationInfo.Rows[0]["PaidFees"].ToString();
            label_Type.Text = Cls_ApplicationTypes_BusinessLayer.Find((int)DtApplicationInfo.Rows[0]["ApplicationTypeID"]).ApplicationTitle;
            label_Applicant.Text = DtApplicationInfo.Rows[0]["FullName"].ToString();
            DateTime appDate = Convert.ToDateTime(DtApplicationInfo.Rows[0]["ApplicationDate"]);
            label_Date.Text = appDate.ToString("dd/MM/yyyy");
            DateTime LastappDate = (DateTime)DtApplicationInfo.Rows[0]["LastStatusDate"];
            label_StatusDate.Text = LastappDate.ToString("dd/MM/yyyy");
            label_CreatedBy.Text=  clsUsers_BusinessLayer.Find((int) DtApplicationInfo.Rows[0]["CreatedByUserID"]).UserName;


        }
        private void UC_ApplicationInfo_DrivingLicenseInfo_Load(object sender, EventArgs e)
        {
            if (_Application == null || DtApplicationInfo == null) return;
            Initialize_Data();
        }

        private void label_CreatedBy_Click(object sender, EventArgs e)
        {

        }

        private void label_Applicant_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ShowPersonInfo_Click(object sender, EventArgs e)
        {
            Form fRM= new Frm_ShowSmallPersonInfo(_Application.ApplicantPersonID);
            fRM.ShowDialog();
        }
    }
}
