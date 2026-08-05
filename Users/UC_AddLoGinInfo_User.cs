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

namespace DVLD_Full_Proj.Users
{
    public partial class UC_AddLoGinInfo_User : UserControl
    {
        enum _EnMode { AddNew, Update }
        _EnMode _Mode = _EnMode.AddNew;
        clsUsers_BusinessLayer _User = null;

       
        public string UserName
        {
            get { return Txt_UserName.Text; }
        }
        public string Password
        {
            get { return Txt_Password.Text; }
        }
        public bool IsActive
        {
            get { return Chk_IsActive.Checked; }
        }
        public UC_AddLoGinInfo_User()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }
        public void LoadData(int UserID=-1)
        {
            if (UserID != -1)
            {
                _Mode = _EnMode.Update;
                _User = clsUsers_BusinessLayer.Find(UserID);
                if (_User == null) return;
            }
            _Initialize_Components();
        }
        private void _Initialize_Components()
        {
            if (_Mode == _EnMode.Update)
            {
                label_Id.Text =_User.UserID.ToString();
                Txt_UserName.Text = _User.UserName;
                Txt_Password.Text = _User.Password;
                Txt_ConfirmPassword.Text = _User.Password;
                Chk_IsActive.Checked= _User.IsActive;
            }
           else
            {

                Txt_UserName.Text = "";
                Txt_Password.Text = "";
                Txt_ConfirmPassword.Text ="";
                Chk_IsActive.Checked = false;
            }

        }
      
        private void UC_AddLoGinInfo_User_Load(object sender, EventArgs e)
        {

        }
        public bool Validate_textBox()
        {
            if (Txt_Password.Text !=Txt_ConfirmPassword.Text)
            {
                errorProvider1.SetError(Txt_Password, "The password must be the same in both fields.");
                errorProvider1.SetError(Txt_ConfirmPassword, "The password must be the same in both fields.");
                return false;
            }
            else
            {
                errorProvider1.SetError(Txt_Password, "");
                errorProvider1.SetError(Txt_ConfirmPassword, "");
                return true;
            }
        }

    }
}
