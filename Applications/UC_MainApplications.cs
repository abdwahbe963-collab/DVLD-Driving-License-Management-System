using DVLD_Full_Proj.TestTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Full_Proj.Applications.Licenses;
using DVLD_Full_Proj.Applications.ManageApplications;
using DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense;
using DVLD_Full_Proj.Applications.ManageApplications.InternationalLicense.Controls;
using DVLD_Full_Proj.Applications.Licenses.RenewLicense;
using DVLD_Full_Proj.Applications.Licenses.Replace_License;
using DVLD_Full_Proj.Applications.ManageApplications.Detain_License;
namespace DVLD_Full_Proj.Applications
{
    public partial class UC_MainApplications : UserControl
    {
        public UC_MainApplications()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void Btn_Applications_Click(object sender, EventArgs e)
        {
            MainForm frm = FindForm() as MainForm;
            if (frm == null) return;
            frm.Show_Control(new UC_ApplicationTypes());
        }

        private void Btn_TestTypes_Click(object sender, EventArgs e)
        {
            MainForm frm = FindForm() as MainForm;
            if (frm == null) return;
            frm.Show_Control(new UC_TestTypes());
        }

        private void Btn_Licenses_Click(object sender, EventArgs e)
        {
            Cms_LicensesMenu.Show(Btn_Licenses, new Point(210, Btn_Licenses.Height + 10));

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_AddNewLocalDrivingLicense());
        }

        private void UC_MainApplications_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Cms_ManageApplications.Show(Btn_ManageApplications, new Point(210, Btn_ManageApplications.Height + 10));
        }

        private void LocalDrivingLicenseApplicationstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_ShowLocalDrivingLicenseApplications());
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_AddNewInternationalDrivingLicense());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control( new UC_ShowInternationalDrivingLicenseApplications());
        }

        private void RenewLicensetoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_RenewLocalDrivingLicense());
        }

        private void ReplaceLicensetoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_ReplaceLicenseForLostOrDamaged());
        }

        private void Btn_DetainLicense_Click(object sender, EventArgs e)
        {
            Cms_DetainLicense.Show(Btn_DetainLicense, new Point(210, Btn_DetainLicense.Height + 10));


        }

        private void DetaintoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_DetainLicense());
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_ReleaseLicense());
        }

        private void ManageDetainLicensetoolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_ManageDetainLicense());
        }
    }
}
