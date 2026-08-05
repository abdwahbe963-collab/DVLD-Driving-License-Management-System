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
    public partial class Frm_ShowLocalDrivingLicenseAppInfo : Form
    {
        UC_ShowApplicationInfo_DrivingLicenseInfo _appInfo;
        int _Applicationid=-1;
        public Frm_ShowLocalDrivingLicenseAppInfo(int ApplicationInid)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (ApplicationInid == -1) return;
            _Applicationid=ApplicationInid;
        }

        private void Frm_ShowLocalDrivingLicenseAppInfo_Load(object sender, EventArgs e)
        {

            
            _appInfo=new UC_ShowApplicationInfo_DrivingLicenseInfo(_Applicationid);
             if(_appInfo==null)return;
            _appInfo.Dock = DockStyle.Fill;
            panel1.Controls.Add(_appInfo);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
