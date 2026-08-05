using DVLD_Full_Proj.Applications.ManageApplications.Driving_License.DrivingLicenseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj.Applications.ManageApplications.Driving_License
{
    public partial class Frm_ShowDrivingLicenseInfo : Form
    {
        UC_ShowLocalDrivingLicenseinfo licenseinfo;
        int _Applicationid;
        int _Licenseid;
        public Frm_ShowDrivingLicenseInfo(int applicationid=-1,int Licenseid = -1)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _Applicationid = applicationid;
            _Licenseid= Licenseid;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ShowDrivingLicenseInfo_Load(object sender, EventArgs e)
        {
            licenseinfo= new UC_ShowLocalDrivingLicenseinfo(_Applicationid, _Licenseid);
            licenseinfo.Dock = DockStyle.Fill;
            panel1.Controls.Clear();    
            panel1.Controls.Add(licenseinfo);
        }
    }
}
