using DVLD_Business_Layer;
using DVLD_Full_Proj.Applications.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Full_Proj.Applications.ManageApplications.Forms;
using DVLD_Full_Proj.Applications.ManageApplications.Forms.WrittrnTestForms;
using DVLD_Full_Proj.Applications.ManageApplications.Forms.StreetTest;
using DVLD_Full_Proj.Applications.ManageApplications.Driving_License;
namespace DVLD_Full_Proj.Applications.ManageApplications
{
    public partial class UC_ShowLocalDrivingLicenseApplications : UserControl
    {

        public UC_ShowLocalDrivingLicenseApplications()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
        }
        private void _Refresh_DataGridVeiw()
        {
            dg_LocalDrivingLicenseApplications.DataSource = Cls_Applications_BusinessLayer.GetLocalLicenseApplications();

        }
        private void Initialize_Data()
        {
            _Refresh_DataGridVeiw();
            lbl_Records.Text = dg_LocalDrivingLicenseApplications.RowCount.ToString() + " Records";
            Cb_FilterBy.SelectedItem = "None";
            Cmb_Status.SelectedItem = "All";

        }
        private void Btn_AddLocalDrivingLicenseApp_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            UC_AddNewLocalDrivingLicense Uc_AddLocalLicense = new UC_AddNewLocalDrivingLicense();
            Uc_AddLocalLicense.BackMode = UC_AddNewLocalDrivingLicense.EnBackMod.BackToLocalDrivingLicenseApplications;
            Frm.Show_Control(Uc_AddLocalLicense);
        }

        private void UC_ShowLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            Initialize_Data();
        }
        private void Txt_FillterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_FilterBy.SelectedItem.ToString() == "None")
            {
                Txt_FillterBy.Visible = false;
                Cmb_Status.Visible = false;

            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "L.D.L.AppID")
            {
                Txt_FillterBy.Visible = true;
                Cmb_Status.Visible = false;
                Txt_FillterBy.KeyPress += Txt_FillterBy_KeyPress;

            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "FullName")
            {
                Txt_FillterBy.Visible = true;
                Cmb_Status.Visible = false;

                Txt_FillterBy.KeyPress -= Txt_FillterBy_KeyPress;
            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "Status")
            {
                Txt_FillterBy.Visible = false;
                Cmb_Status.Visible = true;
                Txt_FillterBy.KeyPress -= Txt_FillterBy_KeyPress;

            }

        }

        private void Txt_FillterBy_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dg_LocalDrivingLicenseApplications.DataSource;
            if (dt == null) return;

            string value = Txt_FillterBy.Text.Trim();

            if (value == "")
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            value = value.Replace("'", "''");
            string RowFillter = "";
            switch (Cb_FilterBy.SelectedItem.ToString())
            {
                case "None":
                    dt.DefaultView.RowFilter = "";
                    break;
                case "L.D.L.AppID":
                    if (int.TryParse(value, out int LocalLicnsseID))
                        RowFillter = $"LocalDrivingLicenseApplicationID = {LocalLicnsseID}";
                    else
                        RowFillter = "1=0";
                    break;
                case "FullName":
                    RowFillter = $"FullName LIKE '%{value}%'";
                    break;

                case "Status":
                    break;

            }
            dt.DefaultView.RowFilter = RowFillter;
            lbl_Records.Text = dg_LocalDrivingLicenseApplications.RowCount.ToString() + " Records";
        }

        private void Cmb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dg_LocalDrivingLicenseApplications.DataSource;
            if (dt == null) return;

            string value = Cmb_Status.Text.Trim();

            if (value == "")
            {
                dt.DefaultView.RowFilter = "";
                return;
            }
            switch (Cmb_Status.SelectedItem)
            {
                case "All":
                    {
                        dt.DefaultView.RowFilter = "";
                    }
                    break;

                case "New":
                    {
                        dt.DefaultView.RowFilter = "Status ='New'";
                    }
                    break;
                case "Cancelled":
                    {
                        dt.DefaultView.RowFilter = "Status ='Cancelled'";

                    }
                    break;
                case "Completed":
                    {
                        dt.DefaultView.RowFilter = "Status ='Completed'";

                    }
                    break;
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            MainForm Frm=FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_MainApplications());
        }

        private void DeleteApplicationtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
           int Applicationid= LocatDrivngLicense.ApplicationID;
           if( Cls_LocalDrivingLicenseApplication_BusinessLayer.Delete(LocalLicenseAppId))
            {
                if (Cls_Applications_BusinessLayer.Delete(Applicationid))
                {
                    MessageBox.Show("Application Deleted Successfully ", "Delete Application",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can't Delete This Application There Is Data Connected To It!", "Delete Application",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can't Delete This Application There Is Data Connected To It!","Delete Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           _Refresh_DataGridVeiw();
        }

        private void CancelApplicationToolStripMenultem_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find (LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
            Cls_Applications_BusinessLayer _Application = Cls_Applications_BusinessLayer.Find(LocatDrivngLicense.ApplicationID);
            if (_Application == null) return;
            if (_Application.ApplicationStatus == 1)
            {
                _Application.ApplicationStatus = 2;
                _Application.Save();
                _Refresh_DataGridVeiw();
            }
            else
            {
                MessageBox.Show("You Can't Cancel a completed or cancelled Application","Not cancelled"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           

        }

        private void VisionTesttoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
            Frm_VisionTestAppointment FrmVision =new Frm_VisionTestAppointment(LocatDrivngLicense.ApplicationID);
            FrmVision.ShowDialog();
            _Refresh_DataGridVeiw() ;
        }

       

        private void Cms_LocalDrivingLicense_Opening(object sender, CancelEventArgs e)
        {


            int PassedTests = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells["PassedTestCount"].Value;
            string Status =dg_LocalDrivingLicenseApplications.CurrentRow.Cells["Status"].Value.ToString();
            if (Status == "New"&& PassedTests==3)
            {
                IssueLicenseToolStripMenuItem.Enabled = true;
            }
            else
            {
                IssueLicenseToolStripMenuItem.Enabled = false;

            }
            switch (PassedTests)
            {
                case 0:
                    {
                        if(Status == "Completed")
                        {
                            SechduleTesttoolStripMenuItem1.Enabled = false;
                        }
                        else
                        {
                            SechduleTesttoolStripMenuItem1.Enabled = true;
                            VisionTesttoolStripMenuItem1.Enabled = true;
                            WrittenTesttoolStripMenuItem1.Enabled = false;
                            StreetTesttoolStripMenuItem1.Enabled = false;

                        }
                        break;
                    }
                case 1:
                    {
                        SechduleTesttoolStripMenuItem1.Enabled = true;
                        VisionTesttoolStripMenuItem1.Enabled = false;
                        WrittenTesttoolStripMenuItem1.Enabled = true;
                        StreetTesttoolStripMenuItem1.Enabled = false;
                        break;
                    }

                case 2:
                    {
                        SechduleTesttoolStripMenuItem1.Enabled = true;
                        VisionTesttoolStripMenuItem1.Enabled = false;
                        WrittenTesttoolStripMenuItem1.Enabled = false;
                        StreetTesttoolStripMenuItem1.Enabled = true;
                        break;
                    }
                case 3:
                    {
                        SechduleTesttoolStripMenuItem1.Enabled = true;
                        VisionTesttoolStripMenuItem1.Enabled = false; 
                        WrittenTesttoolStripMenuItem1.Enabled = false;
                        StreetTesttoolStripMenuItem1.Enabled = false;

                        break;
                    }
                    default:
                    {
                        SechduleTesttoolStripMenuItem1.Enabled = true;
                        VisionTesttoolStripMenuItem1.Enabled = true;
                        WrittenTesttoolStripMenuItem1.Enabled = false;
                        StreetTesttoolStripMenuItem1.Enabled = false;
                      
                        break;
                    }

            }

            if (Status == "Completed" )
            {
                ShowLicenseToolStripMenuItem.Enabled = true;
            }
            else
            {
                ShowLicenseToolStripMenuItem.Enabled = false;

            }
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
            Cls_Applications_BusinessLayer _Application = Cls_Applications_BusinessLayer.Find(LocatDrivngLicense.ApplicationID);
            if (_Application == null) return;


            if (!clsDrivers_BusinessLayer.IsDriverExistByPersonid(_Application.ApplicantPersonID))
            {
                LicenseHistorytoolStripMenuItem1.Enabled = false;
            }
            else
            {
                LicenseHistorytoolStripMenuItem1.Enabled = true;

            }
        }

        private void AddApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            UC_AddNewLocalDrivingLicense Uc_AddLocalLicense = new UC_AddNewLocalDrivingLicense();
            Uc_AddLocalLicense.BackMode = UC_AddNewLocalDrivingLicense.EnBackMod.BackToLocalDrivingLicenseApplications;
            Frm.Show_Control(Uc_AddLocalLicense);
        }

        private void EditApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            UC_AddNewLocalDrivingLicense Uc_AddLocalLicense = new UC_AddNewLocalDrivingLicense(LocatDrivngLicense.ApplicationID);
            Uc_AddLocalLicense.BackMode = UC_AddNewLocalDrivingLicense.EnBackMod.BackToLocalDrivingLicenseApplications;
            Frm.Show_Control(Uc_AddLocalLicense);
        }

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
            Frm_ShowLocalDrivingLicenseAppInfo Frm_ShowDetails = new Frm_ShowLocalDrivingLicenseAppInfo(LocatDrivngLicense.ApplicationID);
            Frm_ShowDetails.Show();
        }

        private void WrittenTesttoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
            Frm_WriitenTestAppointment FrmVision = new Frm_WriitenTestAppointment(LocatDrivngLicense.ApplicationID);
            FrmVision.ShowDialog();
            _Refresh_DataGridVeiw();
        }

        private void StreetTesttoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
            Frm_StreetTestAppointment FrmVision = new Frm_StreetTestAppointment(LocatDrivngLicense.ApplicationID);
            FrmVision.ShowDialog();
            _Refresh_DataGridVeiw();
        }

        private void IssueLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            Frm_IssueDrivingLicense_FirstTime FrmIssueLicense =
                new Frm_IssueDrivingLicense_FirstTime(LocalLicenseAppId);
            FrmIssueLicense.ShowDialog();
            _Refresh_DataGridVeiw();
        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
            Frm_ShowDrivingLicenseInfo Frm_LicenseInfo = new Frm_ShowDrivingLicenseInfo(LocatDrivngLicense.ApplicationID);
            Frm_LicenseInfo.ShowDialog();
        }

        private void LicenseHistorytoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int LocalLicenseAppId = (int)dg_LocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            Cls_LocalDrivingLicenseApplication_BusinessLayer LocatDrivngLicense = Cls_LocalDrivingLicenseApplication_BusinessLayer.Find(LocalLicenseAppId);
            if (LocatDrivngLicense == null) return;
            Cls_Applications_BusinessLayer _Application = Cls_Applications_BusinessLayer.Find(LocatDrivngLicense.ApplicationID);
            if (_Application == null) return;
           int Driverid= clsDrivers_BusinessLayer.FindByPersonid(_Application.ApplicantPersonID).DriverID;
            if (Driverid <= 0) return;
            Frm_ShowLicenseHistory Frm_LicenseHistory = new Frm_ShowLicenseHistory(Driverid);
            Frm_LicenseHistory.ShowDialog();
        }
    }
}
