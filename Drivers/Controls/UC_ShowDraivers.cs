using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj.Drivers.Controls
{
    public partial class UC_ShowDraivers : UserControl
    {
        DataTable _dtDrivers;
        public UC_ShowDraivers()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void UC_ShowDraivers_Load(object sender, EventArgs e)
        {
            Cb_FilterBy.SelectedIndex = 0;
            load_Drivers();
        }
        private void load_Drivers()
        {

            dg_Drivers.DataSource = null;
            _dtDrivers = null;
            _dtDrivers = clsDrivers_BusinessLayer.GetAllDriversWithDetails();

         
            dg_Drivers.DataSource = _dtDrivers;
            lbl_Records.Text = dg_Drivers.Rows.Count.ToString();

            if (dg_Drivers.Rows.Count > 0)
            {
                dg_Drivers.Columns[0].DataPropertyName = "DriverID";
                dg_Drivers.Columns[0].HeaderText = "Driver ID";
                dg_Drivers.Columns[0].Width = 110;

                dg_Drivers.Columns[1].DataPropertyName = "PersonID";
                dg_Drivers.Columns[1].HeaderText = "Person ID";
                dg_Drivers.Columns[1].Width = 110;

                dg_Drivers.Columns[2].DataPropertyName = "CreatedDate";
                dg_Drivers.Columns[2].HeaderText = "Created Date";
                dg_Drivers.Columns[2].Width = 270;

                dg_Drivers.Columns[3].DataPropertyName = "NationalNo";
                dg_Drivers.Columns[3].HeaderText = "National No";
                dg_Drivers.Columns[3].Width = 170;

                dg_Drivers.Columns[4].DataPropertyName = "FullName";
                dg_Drivers.Columns[4].HeaderText = "FullName";
                dg_Drivers.Columns[4].Width = 110;

                dg_Drivers.Columns[5].DataPropertyName = "LicenseCount";
                dg_Drivers.Columns[5].HeaderText = "License No";
                dg_Drivers.Columns[5].Width = 110;

            }

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
            else if (Cb_FilterBy.SelectedItem.ToString() == "Personid"
                || Cb_FilterBy.SelectedItem.ToString() == "Driverid")
            {
                Txt_FillterBy.Visible = true;
                Txt_FillterBy.KeyPress += Txt_FillterBy_KeyPress;

            }
            else
            {
                Txt_FillterBy.Visible = true;
                Txt_FillterBy.KeyPress -= Txt_FillterBy_KeyPress;

            }
        }

        private void Txt_FillterBy_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = (DataTable)dg_Drivers.DataSource;
            if (dt == null) return;

            string value = Txt_FillterBy.Text.Trim();

            if (value == "")
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            value = value.Replace("'", "''"); // Protection
            string RowFillter = "";
            switch (Cb_FilterBy.SelectedItem.ToString())
            {
                case "None":
                    dt.DefaultView.RowFilter = "";
                    break;

                case "Personid":
                    if (int.TryParse(value, out int id))
                        RowFillter = $"PersonID = {id}";
                    else
                        RowFillter = "1=0";
                    break;

                case "Driverid":
                    if (int.TryParse(value, out int DriverID))
                        RowFillter = $"DriverID = {DriverID}";
                    else
                        RowFillter = "1=0";
                    break;

                case "National No":
                    RowFillter = $"NationalNo LIKE '%{value}%'";
                    break;

                case "FullName":
                    RowFillter = $"FullName LIKE '%{value}%'";
                    break;

            }
            dt.DefaultView.RowFilter = RowFillter;
            lbl_Records.Text = dg_Drivers.RowCount.ToString() + " Records";
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var Frm_Main= FindForm() as MainForm;
            if (Frm_Main == null) return; 
            Frm_Main.Initialize_MainForm();
        }
    }
}
