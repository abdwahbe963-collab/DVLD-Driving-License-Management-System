using DVLD_Business_Layer;
using DVLD_Full_Proj.Applications.Licenses;
using DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense;
using DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense.Forms;
using DVLD_Full_Proj.Applications.ManageApplications.Driving_License;
using DVLD_Full_Proj.PeopleControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Full_Proj.Applications.ManageApplications.InternationalLicense.Controls
{
    public partial class UC_ShowInternationalDrivingLicenseApplications : UserControl
    {
        DataTable _dtnternationalicenses = null;
        public UC_ShowInternationalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void _Refresh_DataGridVeiw()
        {

            dg_InternationalDrivingLicenseApplications.DataSource = null;
            _dtnternationalicenses = null;
            _dtnternationalicenses = clsInternationalLicense_BusenessLayer.GetAllInternationalLicenses();

            dg_InternationalDrivingLicenseApplications.DataSource = _dtnternationalicenses;
            lbl_Records.Text = dg_InternationalDrivingLicenseApplications.Rows.Count.ToString();

            if (dg_InternationalDrivingLicenseApplications.Rows.Count > 0)
            {
                dg_InternationalDrivingLicenseApplications.Columns[0].DataPropertyName = "InternationalLicenseID";
                dg_InternationalDrivingLicenseApplications.Columns[0].HeaderText = "int.License.ID";
                dg_InternationalDrivingLicenseApplications.Columns[0].Width = 110;

                dg_InternationalDrivingLicenseApplications.Columns[1].DataPropertyName = "ApplicationID";
                dg_InternationalDrivingLicenseApplications.Columns[1].HeaderText = "App.ID";
                dg_InternationalDrivingLicenseApplications.Columns[1].Width = 110;

                dg_InternationalDrivingLicenseApplications.Columns[2].DataPropertyName = "DriverID";
                dg_InternationalDrivingLicenseApplications.Columns[2].HeaderText = "Driver ID";
                dg_InternationalDrivingLicenseApplications.Columns[2].Width = 270;

                dg_InternationalDrivingLicenseApplications.Columns[3].DataPropertyName = "IssuedUsingLocalLicenseID";
                dg_InternationalDrivingLicenseApplications.Columns[3].HeaderText = "Local.Lic.ID";
                dg_InternationalDrivingLicenseApplications.Columns[3].Width = 170;

                dg_InternationalDrivingLicenseApplications.Columns[4].DataPropertyName = "IssueDate";
                dg_InternationalDrivingLicenseApplications.Columns[4].HeaderText = "Issue Date";
                dg_InternationalDrivingLicenseApplications.Columns[4].Width = 170;

                dg_InternationalDrivingLicenseApplications.Columns[5].DataPropertyName = "ExpirationDate";
                dg_InternationalDrivingLicenseApplications.Columns[5].HeaderText = "Expiration Date";
                dg_InternationalDrivingLicenseApplications.Columns[5].Width = 170;

                dg_InternationalDrivingLicenseApplications.Columns[6].DataPropertyName = "IsActive";
                dg_InternationalDrivingLicenseApplications.Columns[6].HeaderText = "Is Active";
                dg_InternationalDrivingLicenseApplications.Columns[6].Width = 110;

            }
        }

        private void Initialize_Data()
        {
            
            _Refresh_DataGridVeiw();
            lbl_Records.Text = dg_InternationalDrivingLicenseApplications.RowCount.ToString() + " Records";
            Cb_FilterBy.SelectedItem = "None";

        }
        private void Btn_AddinternationalDrivingLicenseApp_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            UC_AddNewInternationalDrivingLicense Uc_AddinternationalLocalLicense = new UC_AddNewInternationalDrivingLicense();
            Uc_AddinternationalLocalLicense.BackMode = UC_AddNewInternationalDrivingLicense.EnBackMode.BackToInternationalLicenseApp;
            Frm.Show_Control(Uc_AddinternationalLocalLicense);
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {

            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_MainApplications());
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
            else if (Cb_FilterBy.SelectedItem.ToString() == "I.D.License")
            {
                Txt_FillterBy.Visible = true;
                Cmb_Status.Visible = false;
                Txt_FillterBy.KeyPress += Txt_FillterBy_KeyPress;

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
            else if (Cb_FilterBy.SelectedItem.ToString() == "IsActive")
            {
                Txt_FillterBy.Visible = false;
                Cmb_Status.Visible = true;
                Txt_FillterBy.KeyPress -= Txt_FillterBy_KeyPress;

            }

        }

        private void Txt_FillterBy_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dg_InternationalDrivingLicenseApplications.DataSource;
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

                case "I.D.License":
                    if (int.TryParse(value, out int IntLicnsseID))
                        RowFillter = $"InternationalLicenseID = {IntLicnsseID}";
                    else
                        RowFillter = "1=0";
                    break;
                case "L.D.L.AppID":
                    if (int.TryParse(value, out int LocalLicnsseID))
                        RowFillter = $"IssuedUsingLocalLicenseID = {LocalLicnsseID}";
                    else
                        RowFillter = "1=0";
                    break;

                case "IsActive":
                    break;

            }
            dt.DefaultView.RowFilter = RowFillter;
            lbl_Records.Text = dg_InternationalDrivingLicenseApplications.RowCount.ToString() + " Records";
        }

        

        private void UC_ShowInternationalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            Initialize_Data();
        }

       

        private void Cmb_Status_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dg_InternationalDrivingLicenseApplications.DataSource;
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

                case "Active":
                    {
                        dt.DefaultView.RowFilter = "IsActive =1";
                    }
                    break;
                case "NotActive":
                    {
                        dt.DefaultView.RowFilter = "IsActive =0";

                    }
                    break;

            }
        }

        private void ShowPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Driverid = (int)dg_InternationalDrivingLicenseApplications.CurrentRow.Cells["DriverID"].Value;
            clsDrivers_BusinessLayer Driver= clsDrivers_BusinessLayer.Find(Driverid);
            if(Driver== null)return;
            Frm_ShowSmallPersonInfo Frm_Personinfo = new Frm_ShowSmallPersonInfo(Driver.PersonID);
            Frm_Personinfo.ShowDialog();
        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Appid = (int)dg_InternationalDrivingLicenseApplications.CurrentRow.Cells["ApplicationID"].Value;
            Frm_ShowInternationalDrivingLicenseInfo Frm_internationalLic 
                = new Frm_ShowInternationalDrivingLicenseInfo(Appid);
            Frm_internationalLic.ShowDialog();
        }

        private void LicenseHistorytoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int Driverid = (int)dg_InternationalDrivingLicenseApplications.CurrentRow.Cells["DriverID"].Value;
            Frm_ShowLicenseHistory Frm_licHistory = new Frm_ShowLicenseHistory(Driverid);
            Frm_licHistory.ShowDialog();
        }
    }
}
