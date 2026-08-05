using DVLD_Business_Layer;
using DVLD_Full_Proj.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj
{  
   
    public partial class Uc_ShowPersonInfo : UserControl
    {
        private enum _Gender { Male=0,Female=1}

        private clsPeople_BusinessLayer _Person = null;
        public Uc_ShowPersonInfo(int Personid)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _Person = clsPeople_BusinessLayer.Find(Personid);

        }

        private void Btn_EditPerson_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            if (mainForm == null) return;
            UC_Add_UpdatePerson uC_Add_UpdatePerson = new UC_Add_UpdatePerson(_Person.ID);
            uC_Add_UpdatePerson.BackMode=UC_Add_UpdatePerson.EnBackMode.BackToShowPersonInfo;
            mainForm.Show_Control(uC_Add_UpdatePerson);
        }

        private void Btn_DoubleBack_Click(object sender, EventArgs e)
        {
            var MainForm = this.FindForm() as MainForm;
            if (MainForm == null) return;

            this.Dispose();

            MainForm.Initialize_MainForm();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            if (mainForm == null) return;

            mainForm.Show_Control(new UC_ShowPeopleInfo());
        }

        private void Uc_ShowPersonInfo_Load(object sender, EventArgs e)
        {
            label_Id.Text = _Person.ID.ToString();
            label_Name.Text = _Person.FirstName;
            label_NationalNo.Text = _Person.NationalNo;
            label_Phone.Text = _Person.Phone;
            label_Address.Text = _Person.Address;
            label_Email.Text = _Person.Email;
            label_Country.Text = _Person.CountryInfo.CountryName;
            label_DateOfBirth.Text=_Person.DateOfBirth.ToString("dd/MM/yyyy");
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

       
    }


}

