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

namespace DVLD_Full_Proj.Applications.ManageApplications
{
    public partial class UC_ShowApplicationInfo : UserControl
    {
        Cls_Applications_BusinessLayer _Application = null;
        DataTable DtApplicationInfo = null;
        int _Applicationid = -1;
        public UC_ShowApplicationInfo(int ApplicationID=-1)
        {
            InitializeComponent();
            this.Load += UC_ShowApplicationInfo_Load;
            this.DoubleBuffered = true;
            if (ApplicationID==-1)return;
            _Applicationid = ApplicationID;
        }
       
        private void Initialize_Data()
        {
            if (_Applicationid == -1) return;
            DtApplicationInfo = Cls_Applications_BusinessLayer.GetApplicationFromVeiw(_Applicationid);
            _Application = Cls_Applications_BusinessLayer.Find(_Applicationid);
            if (_Application == null|| DtApplicationInfo == null || DtApplicationInfo.Rows.Count==0) return;
            //ApllicationInfo
            label_AppId.Text = DtApplicationInfo.Rows[0]["ApplicationID"].ToString();
            label_Status.Text = DtApplicationInfo.Rows[0]["Status"].ToString();
            label_Fees.Text = DtApplicationInfo.Rows[0]["PaidFees"].ToString();
            label_Type.Text = Cls_ApplicationTypes_BusinessLayer.Find((int)DtApplicationInfo.Rows[0]["ApplicationTypeID"]).ApplicationTitle;
            label_Applicant.Text = DtApplicationInfo.Rows[0]["FullName"].ToString();
            DateTime appDate = Convert.ToDateTime(DtApplicationInfo.Rows[0]["ApplicationDate"]);
            label_Date.Text = appDate.ToString("dd/MM/yyyy");
            DateTime LastappDate = (DateTime)DtApplicationInfo.Rows[0]["LastStatusDate"];
            label_StatusDate.Text = LastappDate.ToString("dd/MM/yyyy");
            label_CreatedBy.Text = clsUsers_BusinessLayer.Find((int)DtApplicationInfo.Rows[0]["CreatedByUserID"]).UserName;


        }
        private void UC_ShowApplicationInfo_Load(object sender, EventArgs e)
        {
            Initialize_Data();
        }
    }
}
