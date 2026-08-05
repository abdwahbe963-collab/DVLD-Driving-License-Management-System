using DVLD_Business_Layer;
using DVLD_Full_Proj.General;
using DVLD_Full_Proj.PeopleControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Full_Proj.Users
{
    public partial class UC_ChangeUserPassword : UserControl
    {
        clsUsers_BusinessLayer _User;
        public UC_ChangeUserPassword(int UserID)
        {
            InitializeComponent();
            if (UserID > 0)
            {
                _User=clsUsers_BusinessLayer.Find(UserID);
            }
        }

        private void Initialize_Data()
        {
            uC_ShowUserInfo1.Load_Data(_User.UserID);
        }
        private bool Validate_textBox()
        {
            if (Txt_NewPassword.Text != Txt_ConfirmPassword.Text)
            {
                errorProvider1.SetError(Txt_NewPassword, "The password must be the same in both fields.");
                errorProvider1.SetError(Txt_ConfirmPassword, "The password must be the same in both fields.");
                return false;
            }
            else
            {
                errorProvider1.SetError(Txt_NewPassword, "");
                errorProvider1.SetError(Txt_ConfirmPassword, "");
                return true;
            }

        }
        
        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (txt == null) return;
            if (string.IsNullOrEmpty(txt.Text) )
            {
                errorProvider1.SetError(txt, txt.Tag + " Can't be Empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt, "");
              
            }
        }
            private bool Validate_CurrentPass()
        {
            if (_User.Password != Txt_CurrentPassword.Text.Trim())
            {
                errorProvider1.SetError(Txt_CurrentPassword, "Current Password is not Currect!");

                return false;
            }
            else
            {
                errorProvider1.SetError(Txt_CurrentPassword, "");
                return true;

            }
        }

        private void UC_ChangeUserPassword_Load(object sender, EventArgs e)
        {
            if (_User == null) return;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            Initialize_Data();

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            { return; }
            else
            {
                if (!Validate_CurrentPass())
                { return; }
                if (!Validate_textBox())
                { return; }
            }



            _User.Password = Txt_NewPassword.Text;
            if (_User.Save())
            {
                MessageBox.Show("Password Is Changed Successfuly","Change Password",MessageBoxButtons.OK,MessageBoxIcon.Information);
                _User = clsUsers_BusinessLayer.Find(_User.UserID); 
                CurrentUser.User= _User;
                CurrentUser.ClearFile();    
                CurrentUser.Write_To_File(_User.UserName, _User.Password);
                return;
            }
            MessageBox.Show("Sorry You Can't Change Password", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var MainForm = this.FindForm() as MainForm;
                if (MainForm == null) return;
                MainForm.Show_Control(new UC_ShowUsersInfo());
            }
        }

       
    }
}
