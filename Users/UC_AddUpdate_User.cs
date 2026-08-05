using DVLD_Business_Layer;
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

namespace DVLD_Full_Proj.Users
{
    public partial class UC_AddUpdate_User : UserControl
    {

        enum  _EnMode { AddNew,Update}
        _EnMode _Mode = _EnMode.AddNew;
        int _personId = -1;
        clsUsers_BusinessLayer _User=null;
        UC_AddLoGinInfo_User UC_AddLoginINFO = new UC_AddLoGinInfo_User();
        UC_FindPerson UC_FindPerson1=new UC_FindPerson();
        public UC_AddUpdate_User(int PersonID=-1)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if(PersonID!=-1)
            {
               _Mode = _EnMode.Update;
                lbl_Title.Text = "Update User";
                _personId = PersonID;

            }
            else 
            {
                lbl_Title.Text = "Add New User";
            }
        }

        public void Load_Data_On_UCFindPerson(int PersonID)
        {
          
            UC_FindPerson1.LoadData(PersonID);

        }
        private void Initialize_Data ()
        {
           
            Btn_Next.Visible = true;
            Btn_Back.Visible = false;

            if (_Mode == _EnMode.AddNew)
            {
                _User= new clsUsers_BusinessLayer();
                return;
            }
           
            _User = clsUsers_BusinessLayer.FindUserByPersonID(_personId);
            if (_User == null)return;
            UC_FindPerson1.LoadData(_User.PersonID);


        }
        private void UC_AddUpdate_User_Load(object sender, EventArgs e)
        {
            
            UC_FindPerson1.BacKMode = UC_FindPerson.ENBacKMode.BackToAddUser;
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_FindPerson1);
            Initialize_Data();
           

        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if(UC_FindPerson1.PersonId ==-1)
            {
                MessageBox.Show("Please Select Person First","Not Selected"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (_Mode ==_EnMode.Update)
            {

                UC_AddLoginINFO.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(UC_AddLoginINFO);
                UC_AddLoginINFO.LoadData(_User.UserID);
            }
            else
            {
                if (UC_FindPerson1.IsUser)
                {
                    MessageBox.Show("Person {" + UC_FindPerson1.PersonId + "} is already User ", "Is User"
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                UC_AddLoginINFO.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(UC_AddLoginINFO);
            }
           
            Btn_Next.Visible = false;
            Btn_Back.Visible = true;
        }
       
        private void Btn_Back_Click(object sender, EventArgs e)
        {

            UC_FindPerson1.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(UC_FindPerson1);
            Btn_Next.Visible = true;
            Btn_Back.Visible = false;
            
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            
           string UserName= UC_AddLoginINFO.UserName;
           string Password= UC_AddLoginINFO.Password;
           if(!UC_AddLoginINFO.Validate_textBox())
            {
                return;
            }

            if (UC_FindPerson1.PersonId == -1)
            {
                MessageBox.Show("Please Select Person First", "Not Selected"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password)
                || UC_FindPerson1.PersonId ==-1)
            {
                MessageBox.Show("Please Fill Login Info For Current Person", "Invalid Input"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _User.UserName = UserName;
            _User.Password = Password;
            _User.PersonID = UC_FindPerson1.PersonId;
            _User.IsActive = UC_AddLoginINFO.IsActive;
            
            if (!_User.Save())
            {
                MessageBox.Show("Invalid input Data Is not Saved","invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Data Saved Successfuly","Data Saved"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            _User = clsUsers_BusinessLayer.FindUserByPersonID(_User.PersonID);
            _Mode =_EnMode.Update;
            lbl_Title.Text = "Update User";
            UC_FindPerson1.LoadData(_User.PersonID);
            UC_AddLoginINFO.LoadData(_User.UserID);
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
