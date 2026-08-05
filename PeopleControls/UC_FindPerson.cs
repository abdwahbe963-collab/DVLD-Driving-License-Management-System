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
using DVLD_Full_Proj;


namespace DVLD_Full_Proj.PeopleControls
{
    public partial class UC_FindPerson : UserControl
    {
        int _firstPersonId = -1;
        UC_Add_UpdatePerson uC_Add_UpdatePerson = new UC_Add_UpdatePerson();
        enum _EnMode { AddNew, Update }
        _EnMode _Mode = _EnMode.AddNew;
       public enum ENBacKMode {BackToUser=1,BackToLicense=2 ,BackToAddUser=3}
        private ENBacKMode  _BacKMode = ENBacKMode.BackToUser;

        public ENBacKMode BacKMode 
        {
            set {_BacKMode=value;}  
        }
        public UC_FindPerson()

        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Cb_FilterBy.SelectedItem = "Personid";
          

        }
       
        public bool EnableFillter
        {
            set {  Gp_Fillter.Enabled=value; }
        }
        public int PersonId
        {
            get { return _firstPersonId; }
        }
        public bool IsUser
        {
            get { return clsUsers_BusinessLayer.FindUserByPersonID(_firstPersonId) != null; }
        }
        public void LoadData(int PersonID )
        {
            
            _Mode = _EnMode.Update;
            Cb_FilterBy.SelectedItem = "Personid";
            _firstPersonId = PersonID;

            if (uC_SmalPersonInfo1.Load_Person(_firstPersonId))
            {
                Txt_FillterBy.Text = _firstPersonId.ToString();
            }
            else
            {
                return;
            }
        }

      
        
       private bool Validate_textBox()
        {
            if (string.IsNullOrEmpty( Txt_FillterBy.Text))
            {
                errorProvider1.SetError(Txt_FillterBy, "Please Select Person");
                return false;
            }
            else
            {
                errorProvider1.SetError(Txt_FillterBy, "");
                return true;
            }
        }

        private void Btn_FindPerson_Click(object sender, EventArgs e)
        {
            if(!Validate_textBox())
            {
                return;
            }
            if (_firstPersonId != -1)
            {
                uC_SmalPersonInfo1.Load_Person(_firstPersonId);
            }
            else if (_firstPersonId == -1)
            {
                MessageBox.Show("Person not Exist", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Txt_FillterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void Txt_FillterBy_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = clsPeople_BusinessLayer.GetPeople();
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
               

                case "Personid":
                    if (int.TryParse(value, out int id))
                        RowFillter = $"PersonID = {id}";
                    else
                        RowFillter = "1=0";
                    break;

                case "National No":
                    RowFillter = $"NationalNo = '{value}'";
                    break;

               

            }
            dt.DefaultView.RowFilter = RowFillter;

            if (dt.DefaultView.Count > 0)
            {
                _firstPersonId = Convert.ToInt32(dt.DefaultView[0]["PersonID"]);


            }
            
        }
        private void Cb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           if (Cb_FilterBy.SelectedItem.ToString() == "Personid")
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


        private void Btn_AddPerson_Click(object sender, EventArgs e)
        {

            var mainform = this.FindForm() as MainForm;
            if (mainform == null)
                return;
           
            if(_BacKMode==ENBacKMode.BackToUser)
            uC_Add_UpdatePerson.BackMode= UC_Add_UpdatePerson.EnBackMode.BackToUser;
            else if (_BacKMode == ENBacKMode.BackToLicense)
                uC_Add_UpdatePerson.BackMode = UC_Add_UpdatePerson.EnBackMode.BackToLocalLicines;
            
            mainform.Show_Control(uC_Add_UpdatePerson);
        }
       

        private void uC_SmalPersonInfo1_Load(object sender, EventArgs e)
        {
          
        }

        private void UC_FindPerson_Load(object sender, EventArgs e)
        {
            if (_BacKMode == ENBacKMode.BackToAddUser)
            {
                uC_SmalPersonInfo1.BackMode = UC_SmalPersonInfo.EnBackMode.BackToAddUser;
            }
        }

        private void Gp_Fillter_Click(object sender, EventArgs e)
        {

        }
    }
}
