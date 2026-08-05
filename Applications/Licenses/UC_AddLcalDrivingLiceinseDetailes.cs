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

namespace DVLD_Full_Proj.Applications.Licenses
{
    public partial class UC_AddLcalDrivingLiceinseDetailes : UserControl
    {
        Cls_Applications_BusinessLayer _Application = new Cls_Applications_BusinessLayer();
        Cls_LocalDrivingLicenseApplication_BusinessLayer _LocalLicense;
        enum _EnMode { AddNew = 1, Update = 2 };
        _EnMode mode = _EnMode.AddNew;

       
        public int LicenseClass
        {
           
            get { return Convert.ToInt32(Cmb_ApplicationTypes.SelectedValue); }
        }

        public UC_AddLcalDrivingLiceinseDetailes(int ApplicationId=-1)
        {
           
            InitializeComponent();
            if (ApplicationId != -1)
            {
                mode = _EnMode.Update;
                _Application = Cls_Applications_BusinessLayer.Find(ApplicationId);
                if (_Application == null) return;
                this.DoubleBuffered = true;
            }
            
        }
        private void Load_Application()
        {

            _LocalLicense=Cls_LocalDrivingLicenseApplication_BusinessLayer.FindByApplicationID(_Application.ApplicationID);
            if (_LocalLicense == null) return;
            label_Id.Text = _Application.ApplicationID.ToString();
            label_Fees.Text=_Application.PaidFees.ToString();
            Label_Date.Text=_Application.ApplicationDate.ToString("dd/MM/yyyy");
            label_CreatedBy.Text =clsUsers_BusinessLayer.Find(_Application.CreatedByUserID).UserName;
            Cmb_ApplicationTypes.SelectedValue =_LocalLicense.LicenseClassID;

        }
        

        private void _Intialize_Data()
        {
            
           
            Cmb_ApplicationTypes.DisplayMember = "ClassName";
            Cmb_ApplicationTypes.ValueMember = "LicenseClassID";
            Cmb_ApplicationTypes.DataSource = Cls_LicenseClasses_BusinessLayer.GetLicenseClassess();
            Cmb_ApplicationTypes.SelectedIndex = 2;
        }

        private void UC_AddLcalDrivingLicinseDetailes_Load(object sender, EventArgs e)
        {
            _Intialize_Data();
            if (mode == _EnMode.Update)
            {
                Load_Application();
            }
        }
    }
}
