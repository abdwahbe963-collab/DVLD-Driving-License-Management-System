using DVLD_Business_Layer;
using DVLD_Full_Proj.Properties;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Full_Proj.Users;
using DVLD_Full_Proj.Applications.Licenses;
namespace DVLD_Full_Proj
{
    public partial class UC_Add_UpdatePerson : UserControl
    {


        //delegate
        //public delegate void DataBackEventHandler(object Sender, int Personid);
        //public event DataBackEventHandler DataBack;

        private int _PersonID = 0;
        private string _SelectedImagePath = null;

        private enum _EnGendor { male = 0, Female = 1 }
        private clsPeople_BusinessLayer _Person = null;
        private enum _EnMode { AddNew = 1, Update = 2 }
        private _EnMode _mode = _EnMode.AddNew;
        public enum EnBackMode { BackToUser = 1, BackToPeople = 2,BackToShowPersonInfo=3,BackToShowUser=4,BackToLocalLicines=5 ,BackToAddUser=6}
        private EnBackMode _BackMode=EnBackMode.BackToPeople;

        public EnBackMode BackMode
        {
            set { _BackMode = value; }
        }


        public UC_Add_UpdatePerson(int PersonId=-1)
        {
            this.DoubleBuffered = true;

            InitializeComponent();
            if(PersonId!=-1)
            {
                lbl_Title.Text = "Update Person ";
                _mode= _EnMode.Update;
                _PersonID=PersonId;
            }
            else
            {
             
                lbl_Title.Text = "Add New Person ";
            }

        }
        private void Load_Countries()
        {
            DataTable dT = clsCountries_BusinessLayer.GetCountries();
            foreach (DataRow Dr in dT.Rows)
            {
                Cmb_Country.Items.Add(Dr["CountryName"]);

            }
            if (_mode == _EnMode.AddNew)
            {
                Cmb_Country.SelectedIndex =Cmb_Country.FindString("Syria");
            }



        }
        private void Initialize_DtDateTime()

        {

            Dt_Person.MaxDate = DateTime.Today.AddYears(-18);
            Dt_Person.Value = DateTime.Today.AddYears(-18);
        }
        private void _Load_Person()
        {

            _Person = clsPeople_BusinessLayer.Find(_PersonID);
            Lbl_personID.Text = _Person.ID.ToString();
            Txt_NationalNo.Text = _Person.NationalNo.ToString();
            Txt_FirstName.Text = _Person.FirstName;
            Txt_SecondName.Text = _Person.SecondName;
            if (_Person.ThirdName != null)
                Txt_thirdName.Text = _Person.ThirdName;
            Txt_LastName.Text = _Person.LastName;
            Txt_phone.Text = _Person.Phone;
            if (_Person.Email != null)
                Txt_Email.Text = _Person.Email;
            Txt_Address.Text = _Person.Address;
            Cmb_Country.SelectedItem = _Person.CountryInfo.CountryName;
            Dt_Person.Value = _Person.DateOfBirth;
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                _SelectedImagePath = _Person.ImagePath;
                using (var fs = new FileStream(_Person.ImagePath.ToString(), FileMode.Open, FileAccess.Read))
                {
                    PicBox_Person.Image = Image.FromStream(fs);
                }

                Btn_remove_Pic.Visible = true;

            }
            else
            {

                _SelectedImagePath = null;
                Btn_remove_Pic.Visible = false;
            }

                switch (_Person.Gender)
                {

                    case (byte)_EnGendor.male:
                        {
                            Rd_male.Checked = true;
                            Rd_Female.Checked = false;
                        if(string.IsNullOrEmpty(_Person.ImagePath))
                            PicBox_Person.Image = Resources.icons8_man_100;
                            break;
                        }
                    case (byte)_EnGendor.Female:
                        {
                            Rd_Female.Checked = true;
                            Rd_male.Checked = false;
                        if (string.IsNullOrEmpty(_Person.ImagePath))
                            PicBox_Person.Image = Resources.icons8_woman_100;
                            break;
                        }
                    default:
                        {
                            Rd_male.Checked = false;
                            Rd_Female.Checked = false;
                        if (string.IsNullOrEmpty(_Person.ImagePath))
                            PicBox_Person.Image = Resources.icons8_person_64;
                            break;
                        }
                
            }
        }
        private void Initialize_Components()
        {
            Initialize_DtDateTime();
            Load_Countries();

            if (_mode == _EnMode.AddNew)
            {
                _Person = new clsPeople_BusinessLayer();
                PicBox_Person.Image = Resources.icons8_person_64;
                Btn_remove_Pic.Visible = false;
                return;
            }
            else
            {
                _Load_Person();
            }
        }
        private void HookValidation(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2TextBox txt)
                {
                    if (txt != Txt_thirdName)
                    {
                        txt.Validating += txtBox_Validating;
                        txt.CausesValidation = true;
                    }
                    else
                    {
                        txt.CausesValidation = false;
                    }
                }


                if (c.HasChildren)
                    HookValidation(c); // recursion
            }
        }
        private void UC_Add_UpdateUser_Load(object sender, EventArgs e)
        {
            Rd_male.Checked = true;

            Txt_phone.Tag = "Phone";
            Txt_Email.Tag = "Email";
            Txt_NationalNo.Tag = "NationalNo";
            Btn_Cancel.CausesValidation = false;
            Txt_thirdName.CausesValidation = false;
            Btn_Save.CausesValidation = true;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            Initialize_Components();
            HookValidation(this);
        }
       
        private void Rd_male_CheckedChanged(object sender, EventArgs e)
        {
            if (_SelectedImagePath == null)
            {
                if (Rd_male.Checked)
                {
                    PicBox_Person.Image = Resources.icons8_man_100;
                }
                else
                {
                    PicBox_Person.Image = Resources.icons8_woman_100;
                }
            }
        }

        private bool _SavePerson()
        {
            if (!string.IsNullOrEmpty(Txt_NationalNo.Text))
            {
                _Person.NationalNo = Txt_NationalNo.Text;
            }
            if (!string.IsNullOrEmpty(Txt_FirstName.Text))
            {

                _Person.FirstName = Txt_FirstName.Text;
            }
            if (!string.IsNullOrEmpty(Txt_SecondName.Text))
            {
                _Person.SecondName = Txt_SecondName.Text;
            }
           
           
                _Person.ThirdName = Txt_thirdName.Text;
          
            if (!string.IsNullOrEmpty(Txt_LastName.Text))
            {
                _Person.LastName = Txt_LastName.Text;
            }
            if (Txt_phone.Text != null)
            {
                _Person.Phone = Txt_phone.Text;
            }
            _Person.Email = Txt_Email.Text;

            if (!string.IsNullOrEmpty(Txt_Address.Text))
            _Person.Address = Txt_Address.Text;

            _Person.NationalityCountryID =clsCountries_BusinessLayer.FindCountryByName(Cmb_Country.Text).CountryID;
          
            _Person.DateOfBirth=Dt_Person.Value;
            _Person.ImagePath =_SelectedImagePath;

            if (Rd_male.Checked)
            {
                _Person.Gender = (byte)_EnGendor.male;

            }
            else if (Rd_Female.Checked)
            {
                _Person.Gender = (byte)_EnGendor.Female;
            }
          

            if (_Person.Save())
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void Btn_Edit_Pic_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Select a photo";
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.bmp)|*.jpg;*.jpeg;*.bmp";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (PicBox_Person.Image != null)
                {
                    PicBox_Person.Image.Dispose();
                    PicBox_Person.Image = null;
                }

                _SelectedImagePath = ofd.FileName;

                using (var fs = new FileStream(_SelectedImagePath, FileMode.Open, FileAccess.Read))
                {
                    PicBox_Person.Image = Image.FromStream(fs);
                }

                Btn_remove_Pic.Visible = true;
            }
        }

        private void Btn_remove_Pic_Click(object sender, EventArgs e)
        {
            if (PicBox_Person.Image != null)
            {
                PicBox_Person.Image.Dispose();
                PicBox_Person.Image = null;
            }

            _SelectedImagePath = null;
            Btn_remove_Pic.Visible = false;

            if (Rd_male.Checked)
            {
                PicBox_Person.Image = Resources.icons8_man_100;
            }
            else if (Rd_Female.Checked)
            {
                PicBox_Person.Image = Resources.icons8_man_100;
            }
            else
            {
                PicBox_Person.Image = Resources.icons8_person_64;
            }
          
        }

        private bool UpdatePersonImage()
        {
            string destFolder = @"C:\MyImages";

            if (_SelectedImagePath == null)
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                {
                    try { File.Delete(_Person.ImagePath); } catch { }
                }
                
               
                return true;
            }

            if (_SelectedImagePath != _Person.ImagePath)
            {
                if (!Directory.Exists(destFolder))
                    Directory.CreateDirectory(destFolder);

                string ext = Path.GetExtension(_SelectedImagePath);
                string newFileName = Guid.NewGuid().ToString() + ext;
                string newImagePath = Path.Combine(destFolder, newFileName);

                if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                {
                    try { File.Delete(_Person.ImagePath); } catch { }
                }

                using (FileStream source = new FileStream(_SelectedImagePath, FileMode.Open, FileAccess.Read))
                using (FileStream dest = new FileStream(newImagePath, FileMode.Create, FileAccess.Write))
                {
                    source.CopyTo(dest);
                }

                _SelectedImagePath = newImagePath;
            }

            return true;
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (txt == null) return;
            if (txt.Tag == null) return;

            switch (txt.Tag?.ToString())
            {
                case "Phone":
                    if (string.IsNullOrWhiteSpace(txt.Text) || txt.Text.Length < 10 || !long.TryParse(txt.Text, out _))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txt, "Phone must be number and at least 10 digits!");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(txt, "");
                    }
                    return;

                case "Email":

                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(txt, "");
                        return;
                    }
                    else
                    {
                        if (!txt.Text.Contains("@") || !txt.Text.Contains("."))
                        {
                            e.Cancel = true;
                            errorProvider1.SetError(txt, "Invalid Email!");
                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(txt, "");
                        }
                        return;
                    }
                case "NationalNo":
                    {
                        if (Txt_NationalNo.Text == _Person.NationalNo)
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(txt, "");
                        }
                        else
                        {

                            if (clsPeople_BusinessLayer.IsPersonExist(Txt_NationalNo.Text.ToString()))
                            {
                                e.Cancel = true;
                                errorProvider1.SetError(txt, "National No Is Exist!");

                            }
                            else
                            {
                                e.Cancel = false;
                                errorProvider1.SetError(txt, "");
                            }
                        }
                    }
                    return;
            }

           if (string.IsNullOrWhiteSpace(txt.Text)&& txt.Tag.ToString()!="Email")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt, txt.Tag + " should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }
           if( !UpdatePersonImage())
            {
                return ;
              
            }
            if (!_SavePerson())
            {
                MessageBox.Show("Invalid input Data Is not Saved");
                return;

            }

            MessageBox.Show("Data Saved Successfuly");

            _mode = _EnMode.Update;
            Lbl_personID.Text = _Person.ID.ToString();
            lbl_Title.Text = "Update Person ";
            _Person = clsPeople_BusinessLayer.Find(_Person.ID);

            Btn_remove_Pic.Visible = (_SelectedImagePath!=null);

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var MainForm = this.FindForm() as MainForm;
            if (MainForm == null) return;

            if (_BackMode == EnBackMode.BackToUser)
            {
               
                
                UC_AddUpdate_User UC_AddUpdateUser1 = new UC_AddUpdate_User();
                if (_mode == _EnMode.Update)
                 UC_AddUpdateUser1.Load_Data_On_UCFindPerson(_Person.ID);
                MainForm.Show_Control(UC_AddUpdateUser1);
              
                return;
            }
            if(_BackMode == EnBackMode.BackToShowUser)
            {
                UC_ShowUserInfo Uc_ShowUser = new UC_ShowUserInfo();
              
                    Uc_ShowUser.Load_Data(_Person.UserINfo.UserID);

             
                MainForm.Show_Control(Uc_ShowUser);
                return;
            }
            if (_BackMode == EnBackMode.BackToAddUser)
            {
                UC_AddUpdate_User UC_AddUser=new UC_AddUpdate_User();
                UC_AddUser.Load_Data_On_UCFindPerson(_Person.ID);
                MainForm.Show_Control(UC_AddUser);
                return;
            }
            if (_BackMode == EnBackMode.BackToShowPersonInfo)
            {
                MainForm.Show_Control(new Uc_ShowPersonInfo(_Person.ID));
                return;
            }
            if (_BackMode == EnBackMode.BackToLocalLicines)
            {
                MainForm.Show_Control(new UC_AddNewLocalDrivingLicense());
                return;
            }


            MainForm.Show_Control(new UC_ShowPeopleInfo());
        }

        private void Btn_DoubleBack_Click(object sender, EventArgs e)
        {
           
            var MainForm = this.FindForm() as MainForm;
            if (MainForm == null) return;

            this.Dispose();

            MainForm.Initialize_MainForm();
        }

        private void Btn_Cancel_Click_1(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var MainForm = this.FindForm() as MainForm;
                if (MainForm == null) return;
                MainForm.Show_Control(new UC_ShowPeopleInfo());
            }

        }

    }
}
