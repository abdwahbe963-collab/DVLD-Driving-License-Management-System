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
    public partial class UC_ShowUsersInfo : UserControl
    {
        public UC_ShowUsersInfo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void UC_ShowUsersInfo_Load(object sender, EventArgs e)
        {
            Cmb_IsActive.Visible = false;
            Cmb_IsActive.SelectedItem = "All";
            Cb_FilterBy.SelectedItem = "None";
            dg_Users.AutoGenerateColumns = false;
            Referesh_dg_Users();
            lbl_Records.Text = dg_Users.RowCount.ToString() + " Records";
        }
        private void Referesh_dg_Users()
        {
            dg_Users.DataSource = clsUsers_BusinessLayer.GetUsers();
            lbl_Records.Text = dg_Users.RowCount.ToString() + " Records";

        }
      



        private void Btn_AddUser_Click(object sender, EventArgs e)
        {

            var mainform = this.FindForm() as MainForm;
            if (mainform == null)
                return;

            
            mainform.Show_Control(new UC_AddUpdate_User());

        }
        private void Txt_FillterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cmb_FillterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cb_FilterBy.SelectedItem.ToString() == "None")
            {
                Txt_FillterBy.Visible = false;
                Cmb_IsActive.Visible = false;

            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "PersonID")
            {
                Txt_FillterBy.Visible = true;
                Cmb_IsActive.Visible = false;

                Txt_FillterBy.KeyPress += Txt_FillterBy_KeyPress;

            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "IsActive")
            {
                Txt_FillterBy.Visible = false;
                Cmb_IsActive.Visible = true;

            }
            else
            {
                Txt_FillterBy.Visible = true;
                Cmb_IsActive.Visible = false;
                Txt_FillterBy.KeyPress -= Txt_FillterBy_KeyPress;

            }



        }



        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }





        private void Txt_FillterBy_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = (DataTable)dg_Users.DataSource;
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

                case "PersonID":
                    if (int.TryParse(value, out int PersonID))
                        RowFillter = $"PersonID = {PersonID}";
                    else
                        RowFillter = "1=0";
                    break;
                case "UserID":
                    if (int.TryParse(value, out int Userid))
                        RowFillter = $"UserID = {Userid}";
                    else
                        RowFillter = "1=0";
                    break;

                case "UserName":
                    RowFillter = $"UserName LIKE '%{value}%'";
                    break;

                case "IsActive":
                    break;




            }
            dt.DefaultView.RowFilter = RowFillter;
            lbl_Records.Text = dg_Users.RowCount.ToString() + " Records";



        }



        private void Btn_Back_Click_1(object sender, EventArgs e)
        {
            var MainForm = this.FindForm() as MainForm;
            if (MainForm == null) return;

            this.Dispose();

            MainForm.Initialize_MainForm();
        }

        private void Cmb_IsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dg_Users.DataSource;
            if (dt == null) return;

            string value = Cmb_IsActive.Text.Trim();

            if (value == "")
            {
                dt.DefaultView.RowFilter = "";
                return;
            }
            switch (Cmb_IsActive.SelectedItem)
            {
                case "All":
                    {
                        dt.DefaultView.RowFilter = "";
                    }
                    break;

                case "Is Active":
                    {
                        dt.DefaultView.RowFilter = "IsActive =1";
                    }
                    break;
                case "Not Active":
                    {
                        dt.DefaultView.RowFilter = "IsActive =0";

                    }
                    break;


            }
        }

        private void EditUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            if (mainform == null)
                return;
            int PersonId = (int)dg_Users.CurrentRow.Cells[1].Value;
            mainform.Show_Control(new UC_AddUpdate_User(PersonId));

        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            if (mainform == null)
                return;
            mainform.Show_Control(new UC_AddUpdate_User());
            Referesh_dg_Users();
        }

        private void DeleteUsertoolStripMenuItem_Click(object sender, EventArgs e)
        {

            int Userid = (int)dg_Users.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("are you sure to delete this User " + Userid.ToString(), "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsUsers_BusinessLayer.DeleteUser(Userid))
                {
              
                    MessageBox.Show("User was not deleted because it has data linked to it", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
          
                else
                {
               
                    MessageBox.Show("User Deleted Successduly", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Referesh_dg_Users();

                
                }

            }
        }

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MainFrm= FindForm() as MainForm;
            if(MainFrm == null) return;
            int Userid = (int)dg_Users.CurrentRow?.Cells[0].Value;
            UC_ShowUserInfo UC_ShowUser1 = new UC_ShowUserInfo();
            UC_ShowUser1.Load_Data(Userid);
            MainFrm.Show_Control(UC_ShowUser1);
        }

        private void ChangePasswordToolStripMenultem_Click(object sender, EventArgs e)
        {
            var MainFrm = FindForm() as MainForm;
            if (MainFrm == null) return;
            int Userid = (int)dg_Users.CurrentRow?.Cells[0].Value;
            MainFrm.Show_Control(new UC_ChangeUserPassword (Userid));
        }
    }
}
