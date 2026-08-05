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

namespace DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense.Forms
{
    public partial class Frm_ShowInternationalDrivingLicenseInfo : Form
    {
        UC_ShowInterNationalLicenseInfo int_licenseinfo;
        int _Applicationid;
        public Frm_ShowInternationalDrivingLicenseInfo(int applicationid)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _Applicationid = applicationid;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ShowInternationalDrivingLicenseInfo_Load(object sender, EventArgs e)
        {
            int_licenseinfo = new UC_ShowInterNationalLicenseInfo(_Applicationid);
            int_licenseinfo.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(int_licenseinfo);
        }
    }
}
