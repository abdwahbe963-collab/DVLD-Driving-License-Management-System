using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj
{
    public partial class UC_ShowPeopleInfo : UserControl
    {
        public UC_ShowPeopleInfo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void Referesh_dg_people()
        {
            dg_People.DataSource = clsPeople_BusinessLayer.GetPeople();
            lbl_Records.Text = dg_People.RowCount.ToString() + " Records";

        }
        private void UC_ShowPeopleInfo_Load(object sender, EventArgs e)
        {
            Cb_FilterBy.SelectedItem = "None";
            dg_People.AutoGenerateColumns = false;
            Referesh_dg_people();
            lbl_Records.Text = dg_People.RowCount.ToString() + " Records";
        }



        private void Btn_AddPeople_Click(object sender, EventArgs e)
        {

            var mainform = this.FindForm() as MainForm;
            if (mainform == null)
                return;

            mainform.Show_Control(new UC_Add_UpdatePerson());

        }
        private void Txt_FillterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cb_FilterBy.SelectedItem.ToString() == "None")
            {
                Txt_FillterBy.Visible = false;

            }
            else if (Cb_FilterBy.SelectedItem.ToString() == "Personid"
                || Cb_FilterBy.SelectedItem.ToString()== "Phone")
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

       

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }



        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersoniD = (int)dg_People.CurrentRow.Cells[0].Value;
            var mainForm = this.FindForm() as MainForm;
            if (mainForm==null) return;
            mainForm.Show_Control(new Uc_ShowPersonInfo(PersoniD));


        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            if (mainform == null)
                return;

            mainform.Show_Control(new UC_Add_UpdatePerson());
            Referesh_dg_people();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            if (mainform == null)
                return;
            int Person_ID = Convert.ToInt32(dg_People.CurrentRow.Cells[0].Value);
            mainform.Show_Control(new UC_Add_UpdatePerson(Person_ID));
            Referesh_dg_people();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Person_ID = Convert.ToInt32(dg_People.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("are you sure to delete this Person " + Person_ID.ToString(), "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsPeople_BusinessLayer.DeletePerson(Person_ID))
                {

                    MessageBox.Show("person was not deleted because it has data linked to it", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               else 
                {
                    MessageBox.Show("Person Deleted Successduly", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Referesh_dg_people();

                }
            }
        }

        private void Txt_FillterBy_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = (DataTable)dg_People.DataSource;
            if (dt == null) return;

            string value = Txt_FillterBy.Text.Trim();

            if (value == "")
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            value = value.Replace("'", "''"); // حماية
            string RowFillter = "";
            switch (Cb_FilterBy.SelectedItem.ToString())
            {
                case "None":
                    dt.DefaultView.RowFilter = "";
                    break;

                case "Personid":
                    if (int.TryParse(value, out int id))
                        RowFillter = $"PersonID = {id}";
                    else
                        RowFillter = "1=0";
                    break;

                case "First Name":
                    RowFillter = $"FirstName LIKE '%{value}%'";
                    break;

                case "Second Name":
                    RowFillter = $"SecondName LIKE '%{value}%'";
                    break;

                case "National No":
                    RowFillter = $"NationalNo LIKE '%{value}%'";
                    break;

                case "Third Name":
                    RowFillter = $"ThirdName LIKE '%{value}%'";
                    break;

                case "Last Name":
                    RowFillter = $"LastName LIKE '%{value}%'";
                    break;

                case "Phone":
                    RowFillter = $"Phone LIKE '%{value}%'";
                    break;

                case "Email":
                    RowFillter = $"Email LIKE '%{value}%'";
                    break;

                case "Nationalty":

                    RowFillter = $"CountryName LIKE '%{value}%'";
                    
                    break;

            }
            dt.DefaultView.RowFilter = RowFillter;
            lbl_Records.Text = dg_People.RowCount.ToString() + " Records";



        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var MainForm = this.FindForm() as MainForm;
            if (MainForm == null) return;

            this.Dispose();

            MainForm.Initialize_MainForm();

        }
    }     
}       
