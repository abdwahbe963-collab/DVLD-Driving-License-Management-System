using DVLD_Business_Layer;
using DVLD_Full_Proj.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj
{
    public partial class Login_Form : Form
    {
        private clsUsers_BusinessLayer _User = null;
        private enum _UserSatus { Active, NoTActive, NotExist }
        _UserSatus _EnStatus = _UserSatus.NotExist;
      
        string[] _ArrUserLoginInfo = new string[2];

        public Login_Form()
        {
            InitializeComponent();
        }


        
        private void Btn_Login_Click(object sender, EventArgs e)
        {

            switch (_User_Login())
            {
                case true:
                    {
                        if (_EnStatus == _UserSatus.Active)
                        {

                            if (Chk_Remenber.Checked && !string.IsNullOrEmpty(Txt_UserName.Text) && !string.IsNullOrEmpty(Txt_Pass.Text))
                            {
                                CurrentUser.User = _User;
                                CurrentUser. Write_To_File(Txt_UserName.Text, Txt_Pass.Text);

                            }
                            else
                            {
                                CurrentUser.ClearFile();
                            }

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                    }
                    break;
                case false:
                    {
                        if (_EnStatus == _UserSatus.NoTActive)
                        {
                            MessageBox.Show("This User Is Not Active Please Contact Support", "NotActive", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else if (_EnStatus == _UserSatus.NotExist)
                        {
                            MessageBox.Show("Invalid username or password ", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
            }


        }
        private bool _User_Login()
        {

            _User = clsUsers_BusinessLayer.Login(Txt_UserName.Text, Txt_Pass.Text);
            if (_User != null)
            {
                if (_User.IsActive)
                {
                    _EnStatus = _UserSatus.Active;
                    
                    return true;
                }
                _EnStatus = _UserSatus.NoTActive;
                return false;
            }
            _EnStatus = _UserSatus.NotExist;

            return false;
        }
        private void Login_Form_Load(object sender, EventArgs e)
        {
            _ArrUserLoginInfo = CurrentUser.Read_From_File();

            if (_ArrUserLoginInfo != null)
            {
                Chk_Remenber.Checked = true;
                Txt_UserName.Text = _ArrUserLoginInfo[0];
                Txt_Pass.Text = _ArrUserLoginInfo[1];
            }

            if (string.IsNullOrEmpty(Txt_UserName.Text) || string.IsNullOrEmpty(Txt_Pass.Text))
            {
                Chk_Remenber.Enabled = false;
            }
           
        }



        private void Txt_UserName_TextChanged(object sender, EventArgs e)
        {
            if (Txt_UserName.Text.Length > 3 && Txt_Pass.Text.Length > 3)
                Chk_Remenber.Enabled = true;

        }

        private void Txt_Pass_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Pass.Text.Length >= 3 && Txt_UserName.Text.Length >= 3)
                Chk_Remenber.Enabled = true;
        }

       

    }
}
