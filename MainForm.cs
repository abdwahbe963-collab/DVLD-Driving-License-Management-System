using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer ;
using DVLD_Full_Proj.Applications;
using DVLD_Full_Proj.Drivers.Controls;
using DVLD_Full_Proj.General;
using DVLD_Full_Proj.Properties;
using DVLD_Full_Proj.Users;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.Logging;

namespace DVLD_Full_Proj
{
    public partial class MainForm : Form
    {

        

        public MainForm()
        {
            InitializeComponent();
        }
        public void Show_Control(UserControl UC)
        
        {

            if (UC == null) return;
           
            Pnl_Right_MainForm.Controls.Clear();
            UC.Dock = DockStyle.Fill;
            Pnl_Right_MainForm.Controls.Add(UC);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        

        private void CtrlMinimize_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }

        private void CtrlClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pnl_Right_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_Left_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_People_Click_1(object sender, EventArgs e)
        {
            UC_ShowPeopleInfo uC_ShowPeopleInfo = new UC_ShowPeopleInfo();
            Pnl_Right_MainForm.Controls.Clear();
            uC_ShowPeopleInfo.Dock = DockStyle.Fill;
            Pnl_Right_MainForm.Controls.Add(uC_ShowPeopleInfo);
        }

        private Guna2CirclePictureBox _logo;

        public void Initialize_MainForm()
        {
            Pnl_Right_MainForm.Controls.Clear();
            _logo = null;
            _logo = new Guna2CirclePictureBox();
            _logo.Image = Resources.Logo;
            _logo.SizeMode = PictureBoxSizeMode.Zoom;
            _logo.Dock = DockStyle.Fill;
            _logo.BackColor = Color.Transparent;
            Pnl_Right_MainForm.Controls.Add(_logo);
           

        }
        

        private void PicBox_MainForm_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CurrentUser_Click(object sender, EventArgs e)
        {
            Cms_UserMenu.Show(Btn_CurrentUser, new Point(35, Btn_CurrentUser.Height + 10));

        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            UC_ShowUsersInfo ShowUsersInfo = new UC_ShowUsersInfo();
            Pnl_Right_MainForm.Controls.Clear();
            ShowUsersInfo.Dock = DockStyle.Fill;
            Pnl_Right_MainForm.Controls.Add(ShowUsersInfo);

        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_ShowUserInfo ShowUserInfo = new UC_ShowUserInfo();
            ShowUserInfo.Load_Data(CurrentUser.User.UserID);
            this.Show_Control(ShowUserInfo);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_ChangeUserPassword UC_ChangeUserPass= new UC_ChangeUserPassword(CurrentUser.User.UserID);
            this.Show_Control(UC_ChangeUserPass);

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initialize_MainForm();
            this.Hide();
            using (Login_Form login_Form = new Login_Form())
            {

                if (login_Form.ShowDialog() == DialogResult.OK)
                {
                  
                    this.Show();

                }
                else
                {
                    this.Close();
                }
            }
        }

        private void BtnMainApplications_Click(object sender, EventArgs e)

        {
            UC_MainApplications UC_MainApps = new UC_MainApplications();
            this.Show_Control(UC_MainApps);
        }

        private void Btn_Drivers_Click(object sender, EventArgs e)
        {
            UC_ShowDraivers UC_Drivers= new UC_ShowDraivers();
            this.Show_Control(UC_Drivers);  
        }
    }
}
