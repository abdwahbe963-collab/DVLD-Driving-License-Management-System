using DVLD_Business_Layer;
using DVLD_Full_Proj.Properties;
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

namespace DVLD_Full_Proj.PeopleControls
{
    public partial class UC_SmalPersonInfo : UserControl
    {
        private clsPeople_BusinessLayer _Person = null;
        public enum EnBackMode { BackToShowUser=1,BackToAddUser=2}
        EnBackMode _BackMode = EnBackMode.BackToShowUser;
        private enum _Gender { Male = 0, Female = 1 }

        public EnBackMode BackMode
        {
            set { _BackMode = value; }
        }
        public int PersonID
        {
            get { return _Person.ID; }
        }
        public string NationalNo
        {
            get { return _Person.NationalNo; }
        }
       
        public UC_SmalPersonInfo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
        public bool Load_Person(int Personid)
        {
            
            _Person = clsPeople_BusinessLayer.Find(Personid);
            if (_Person == null)
            {
                return false;
            }
            Fill_Components();
            return true;    
        }

        private void Fill_Components()
        {
            label_Id.Text = _Person.ID.ToString();
            label_Name.Text = _Person.FirstName;
            label_NationalNo.Text = _Person.NationalNo;
            label_Phone.Text = _Person.Phone;
            label_Address.Text = _Person.Address;
            label_Email.Text = _Person.Email;
            label_Country.Text = _Person.CountryInfo.CountryName;
            label_DateOfBirth.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            switch (_Person.Gender)
            {
                case (byte)_Gender.Male:
                    {
                        label_Gender.Text = "Male";
                        break;
                    }

                case (byte)_Gender.Female:
                    {
                        label_Gender.Text = "Femail";
                        break;
                    }


            }
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {

                using (var fs = new FileStream(_Person.ImagePath.ToString(), FileMode.Open, FileAccess.Read))
                {
                    PicBox_Person.Image = Image.FromStream(fs);
                }
            }
            else
            {
                switch (_Person.Gender)
                {
                    case (byte)_Gender.Male:
                        {
                            PicBox_Person.Image = Resources.icons8_man_100;
                            break;
                        }

                    case (byte)_Gender.Female:
                        {
                            PicBox_Person.Image = Resources.icons8_woman_100;
                            break;
                        }


                }
            }
        }

        private void UC_SmalPersonInfo_Load(object sender, EventArgs e)
        {




        }

        private void Btn_Edit_Person_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            if (mainForm == null) return;
            if(_Person==null)
            {
                MessageBox.Show("No Person Selected","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (_BackMode == EnBackMode.BackToAddUser)
            {
                UC_Add_UpdatePerson UC_AddUpdatePerson1 = new UC_Add_UpdatePerson(_Person.ID);

                UC_AddUpdatePerson1.BackMode = UC_Add_UpdatePerson.EnBackMode.BackToAddUser;
                mainForm.Show_Control(UC_AddUpdatePerson1);
            }
            else
            {
                UC_Add_UpdatePerson UC_AddUpdatePerson1 = new UC_Add_UpdatePerson(_Person.ID);

                UC_AddUpdatePerson1.BackMode = UC_Add_UpdatePerson.EnBackMode.BackToShowUser;
                mainForm.Show_Control(UC_AddUpdatePerson1);
            }
           
        }
    }
}
