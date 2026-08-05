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

namespace DVLD_Full_Proj.Applications.ManageApplications.Driving_License.DrivingLicenseControls
{
    public partial class UC_ShowLocalAndInternationalDrivingLicenseHistory : UserControl
    {
        DataTable _dtDriverLocalL_internationalicensesHistory=null;
        int _DriverID = -1;
        public UC_ShowLocalAndInternationalDrivingLicenseHistory(int Driverid)
        {
            InitializeComponent();
            _DriverID = Driverid;
        }

        private void UC_ShowLocalAndInternationalDrivingLicenseHistory_Load(object sender, EventArgs e)
        {
            _LoadLocalLicenseInfo();
        }
        private void _LoadLocalLicenseInfo()
        {
            dgvLocalLicensesHistory.DataSource = null;
            _dtDriverLocalL_internationalicensesHistory = null;
            _dtDriverLocalL_internationalicensesHistory = clsDrivers_BusinessLayer.GetDriverLicenses(_DriverID);


            dgvLocalLicensesHistory.DataSource = _dtDriverLocalL_internationalicensesHistory;
            lbl_Records.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].DataPropertyName = "LicenseID";
                dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicensesHistory.Columns[0].Width = 110;

                dgvLocalLicensesHistory.Columns[1].DataPropertyName = "ApplicationID";
                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].Width = 110;

                dgvLocalLicensesHistory.Columns[2].DataPropertyName = "ClassName";
                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 270;

                dgvLocalLicensesHistory.Columns[3].DataPropertyName = "IssueDate";
                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 170;

                dgvLocalLicensesHistory.Columns[4].DataPropertyName = "ClassName";
                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 170;

                dgvLocalLicensesHistory.Columns[5].DataPropertyName = "IsActive";
                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 110;

            }
        }

        private void _LoadInternationalLicenseInfo()
        {
            dgvLocalLicensesHistory.DataSource = null;
            _dtDriverLocalL_internationalicensesHistory = null;
            _dtDriverLocalL_internationalicensesHistory = clsDrivers_BusinessLayer.GetDriverInternationalLicenses(_DriverID);
            

            dgvLocalLicensesHistory.DataSource = _dtDriverLocalL_internationalicensesHistory;
            lbl_Records.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].DataPropertyName = "InternationalLicenseID";
                dgvLocalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
                dgvLocalLicensesHistory.Columns[0].Width = 160;

                dgvLocalLicensesHistory.Columns[1].DataPropertyName = "ApplicationID";
                dgvLocalLicensesHistory.Columns[1].HeaderText = "Application ID";
                dgvLocalLicensesHistory.Columns[1].Width = 130;

                dgvLocalLicensesHistory.Columns[2].DataPropertyName = "IssuedUsingLocalLicenseID";
                dgvLocalLicensesHistory.Columns[2].HeaderText = "L.License ID";
                dgvLocalLicensesHistory.Columns[2].Width = 130;

                dgvLocalLicensesHistory.Columns[3].DataPropertyName = "IssueDate";
                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 180;

                dgvLocalLicensesHistory.Columns[4].DataPropertyName = "ExpirationDate";
                dgvLocalLicensesHistory.Columns[4].HeaderText = "ExpirationDate";
                dgvLocalLicensesHistory.Columns[4].Width = 180;

                dgvLocalLicensesHistory.Columns[5].DataPropertyName = "IsActive";
                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 120;
            }
            else
            {

                MessageBox.Show("Person Does Not Have International License","International License",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Btn_LocalLicense_Click(object sender, EventArgs e)
        {
            _LoadLocalLicenseInfo();
        }

        private void Btn_internationalLicense_Click(object sender, EventArgs e)
        {
            _LoadInternationalLicenseInfo();
        }
    }
}
