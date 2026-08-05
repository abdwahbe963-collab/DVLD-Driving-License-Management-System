using DVLD_Business_Layer;
using DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense;
using DVLD_Full_Proj.Applications.Licenses.IternationalDrivingLicense.Forms;
using DVLD_Full_Proj.Applications.ManageApplications.Driving_License;
using DVLD_Full_Proj.Applications.ManageApplications.Forms;
using DVLD_Full_Proj.PeopleControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj.Applications.ManageApplications.Detain_License
{
    public partial class UC_ManageDetainLicense : UserControl
    {
        DataTable _dtDetaindLicenses = null;
        public UC_ManageDetainLicense()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void _Refresh_DataGridVeiw()
        {

            dg_DetainedicenseApplications.DataSource = null;
            _dtDetaindLicenses = null;
            _dtDetaindLicenses = clsDetainedLicenses_BusinessLayer.GetAllDetainedLicenses_Info();
            dg_DetainedicenseApplications.DataSource = _dtDetaindLicenses;
            lbl_Records.Text = dg_DetainedicenseApplications.Rows.Count.ToString();

            if (dg_DetainedicenseApplications.Rows.Count > 0)
            {
                dg_DetainedicenseApplications.Columns[0].DataPropertyName = "DetainID";
                dg_DetainedicenseApplications.Columns[0].HeaderText = "D.ID";
                dg_DetainedicenseApplications.Columns[0].Width = 90;

                dg_DetainedicenseApplications.Columns[1].DataPropertyName = "LicenseID";
                dg_DetainedicenseApplications.Columns[1].HeaderText = "L.ID";
                dg_DetainedicenseApplications.Columns[1].Width = 90;

                dg_DetainedicenseApplications.Columns[2].DataPropertyName = "DetainDate";
                dg_DetainedicenseApplications.Columns[2].HeaderText = "D.Date";
                dg_DetainedicenseApplications.Columns[2].Width = 170;

                dg_DetainedicenseApplications.Columns[3].DataPropertyName = "IsReleased";
                dg_DetainedicenseApplications.Columns[3].HeaderText = "IsReleased";
                dg_DetainedicenseApplications.Columns[3].Width = 90;

                dg_DetainedicenseApplications.Columns[4].DataPropertyName = "ReleaseDate";
                dg_DetainedicenseApplications.Columns[4].HeaderText = "R.Date";
                dg_DetainedicenseApplications.Columns[4].Width = 170;

                dg_DetainedicenseApplications.Columns[5].DataPropertyName = "ReleaseApplicationID";
                dg_DetainedicenseApplications.Columns[5].HeaderText = " R.AppID";
                dg_DetainedicenseApplications.Columns[5].Width = 90;

                dg_DetainedicenseApplications.Columns[6].DataPropertyName = "FullName";
                dg_DetainedicenseApplications.Columns[6].HeaderText = "FullName";
                dg_DetainedicenseApplications.Columns[6].Width = 270;
                dg_DetainedicenseApplications.Columns[7].DataPropertyName = "NationalNo";
                dg_DetainedicenseApplications.Columns[7].HeaderText = "N.No";
                dg_DetainedicenseApplications.Columns[7].Width = 90;

            }
        }

        private void Initialize_Data()
        {

            _Refresh_DataGridVeiw();
            lbl_Records.Text = dg_DetainedicenseApplications.RowCount.ToString() + " Records";
            Cb_FilterBy.SelectedItem = "None";

        }
        private void Btn_DetainDrivingLicenseApp_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            UC_DetainLicense Uc_DetainLicense = new UC_DetainLicense();
            Uc_DetainLicense.BackMode = UC_DetainLicense.EnBackMode.BackToManageDetainedLicense;
            Frm.Show_Control(Uc_DetainLicense);
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

            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "DetainID")
            {
                Txt_FillterBy.Visible = true;
                Txt_FillterBy.KeyPress += Txt_FillterBy_KeyPress;

            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "LicenseID")
            {
                Txt_FillterBy.Visible = true;
                Txt_FillterBy.KeyPress += Txt_FillterBy_KeyPress;

            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "NationalNo")
            {
                Txt_FillterBy.Visible = true;
                Txt_FillterBy.KeyPress -= Txt_FillterBy_KeyPress;

            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "FullName")
            {
                Txt_FillterBy.Visible = true;

                Txt_FillterBy.KeyPress -= Txt_FillterBy_KeyPress;
            }
           

        }

        private void Txt_FillterBy_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dg_DetainedicenseApplications.DataSource;
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

                case "DetainID":
                    if (int.TryParse(value, out int IntLicnsseID))
                        RowFillter = $"DetainID = {IntLicnsseID}";
                    else
                        RowFillter = "1=0";
                    break;
                case "LicenseID":
                    if (int.TryParse(value, out int LocalLicnsseID))
                        RowFillter = $"LicenseID = {LocalLicnsseID}";
                    else
                        RowFillter = "1=0";
                    break;
                case "NationalNo":
                    RowFillter = $"NationalNo like '%{value}%'";
                    break;
                case "FullName":
                        RowFillter = $"FullName like '%{value}%'";
                    break;



            }
            dt.DefaultView.RowFilter = RowFillter;
            lbl_Records.Text = dg_DetainedicenseApplications.RowCount.ToString() + " Records";
        }


        private void UC_ManageDetainLicense_Load(object sender, EventArgs e)
        {
            Initialize_Data();
        }
       

        private void ShowPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Licenseid = (int)dg_DetainedicenseApplications.CurrentRow.Cells["LicenseID"].Value;
            clsLicenses_BusinessLayer License = clsLicenses_BusinessLayer.Find(Licenseid);
            if (License == null) return;
            clsDrivers_BusinessLayer Driver = clsDrivers_BusinessLayer.Find(License.DriverID);
            if (Driver == null) return;
            Frm_ShowSmallPersonInfo Frm_Personinfo = new Frm_ShowSmallPersonInfo(Driver.PersonID);
            Frm_Personinfo.ShowDialog();
        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Licenseid = (int)dg_DetainedicenseApplications.CurrentRow.Cells["LicenseID"].Value;
            Frm_ShowDrivingLicenseInfo Frm_internationalLic
                = new Frm_ShowDrivingLicenseInfo(-1, Licenseid);
            Frm_internationalLic.ShowDialog();
        }

        private void LicenseHistorytoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int Licenseid = (int)dg_DetainedicenseApplications.CurrentRow.Cells["LicenseID"].Value;
            clsLicenses_BusinessLayer License = clsLicenses_BusinessLayer.Find(Licenseid);
            if (License == null) return;
            clsDrivers_BusinessLayer Driver = clsDrivers_BusinessLayer.Find(License.DriverID);
            if (Driver == null) return;
            Frm_ShowLicenseHistory Frm_licHistory = new Frm_ShowLicenseHistory(License.DriverID);
            Frm_licHistory.ShowDialog();
        }

        private void Btn_ReleaseLicense_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            UC_ReleaseLicense UC_Release = new UC_ReleaseLicense();
            UC_Release.BackMode = UC_ReleaseLicense.EnBackMode.BackToManageDetainedLicense;
            Frm.Show_Control(UC_Release);
        }
    }
}
