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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Full_Proj.TestTypes.Forms
{
    public partial class Frm_EditTestsType : Form
    {
        Cls_TestTypes_BusinessLayer _TestType = null;
        int _TestTypeID = -1;
        public Frm_EditTestsType(int TestTypeID)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (TestTypeID < 0) return;
            
            _TestTypeID = TestTypeID;

           
        }
        private void Initialize_Data()
        {
            label_Id.Text = _TestType.TestTypeID.ToString();
            Txt_ApplicationTitle.Text = _TestType.TestTypeTitle;
            Txt_Description.Text = _TestType.TestTypeDescription;
            Txt_ApplicationFees.Text = _TestType.TestTypeFees.ToString();
        }
        private void Frm_EditTestsType_Load(object sender, EventArgs e)
        {
            _TestType = Cls_TestTypes_BusinessLayer.Find(_TestTypeID);
            if (_TestType != null)
               

            Initialize_Data();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Txt_ApplicationFees.Text)
                && !string.IsNullOrEmpty(Txt_ApplicationTitle.Text))
            {
                MessageBox.Show("Data Saved Successfuly", "Data Saved"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                _TestType.TestTypeTitle = Txt_ApplicationTitle.Text;
                _TestType.TestTypeFees = Convert.ToDecimal(Txt_ApplicationFees.Text);
                _TestType.TestTypeDescription= Txt_Description.Text;
                _TestType.UpdateTestTypes();
                return;

            }
            MessageBox.Show("Data not saved please fill all faildes", "Can't save data"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close", "Close"
                  , MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
