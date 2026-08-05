using DVLD_Business_Layer;
using DVLD_Full_Proj.PeopleControls;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj.Users
{
    public partial class UC_ShowUserInfo : UserControl
    {
        clsUsers_BusinessLayer _User;
        public UC_ShowUserInfo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
           
        }
        public void Load_Data(int UserID )
        {
            if (UserID > 0)
            {
                _User = clsUsers_BusinessLayer.Find(UserID);
            }
            if (_User == null) return;

            Initialize_Data();
        
        }
        private void Initialize_Data()
        {
            if (_User == null)
            {
                MessageBox.Show("This Person Is Not User In System", "User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uC_SmalPersonInfo1.Load_Person(_User.PersonID);
            label_UserID.Text = _User.UserID.ToString();
            label_UserName.Text = _User.UserName;
            label_IsActive.Text = _User.IsActive ? "Yes" : "No";
        }
        private void UC_ShowUserInfo_Load(object sender, EventArgs e)
        {
           

        }

        private void uC_SmalPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void uC_SmalPersonInfo1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
