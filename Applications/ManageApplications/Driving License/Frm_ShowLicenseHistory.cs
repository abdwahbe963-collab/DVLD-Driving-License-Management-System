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
using DVLD_Full_Proj.PeopleControls;
using DVLD_Full_Proj.Applications.ManageApplications.Driving_License.DrivingLicenseControls;
namespace DVLD_Full_Proj.Applications.ManageApplications.Driving_License
{
    public partial class Frm_ShowLicenseHistory : Form
    {
        clsDrivers_BusinessLayer Driver;
        clsPeople_BusinessLayer Person;
        UC_SmalPersonInfo Uc_personInfo;
        UC_ShowLocalAndInternationalDrivingLicenseHistory UC_showLocal_International_LicenseInfo;
        int _DriverID = -1;
        public Frm_ShowLicenseHistory(int DriverId)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _DriverID = DriverId;   
        }

        private void Initialize_Data()
        {
            Driver = clsDrivers_BusinessLayer.Find(_DriverID);
            if (Driver == null ) return;
            Person=clsPeople_BusinessLayer.Find(Driver.PersonID);
            if (Person == null) return; 
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ShowLicenseHistory_Load(object sender, EventArgs e)
        {
            Initialize_Data();

            Uc_personInfo = new UC_SmalPersonInfo();
            Uc_personInfo.Dock = DockStyle.Fill;
            Uc_personInfo.Load_Person(Person.ID);
            panel1.Controls.Clear();
            panel1.Controls.Add(Uc_personInfo);

            UC_showLocal_International_LicenseInfo
                = new UC_ShowLocalAndInternationalDrivingLicenseHistory(_DriverID);
            UC_showLocal_International_LicenseInfo.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(UC_showLocal_International_LicenseInfo);
        }
    }
}
