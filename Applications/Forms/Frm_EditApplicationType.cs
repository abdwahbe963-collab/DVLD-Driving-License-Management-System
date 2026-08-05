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

namespace DVLD_Full_Proj.Applications.Forms
{
    public partial class Frm_EditApplicationType : Form
    {
        Cls_ApplicationTypes_BusinessLayer _Application =null;
        int _ApplicationID = -1;
        public Frm_EditApplicationType(int ApplicationID)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _ApplicationID=ApplicationID;
            if (ApplicationID < 0) return;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_ApplicationFees.Text)
                && !string.IsNullOrEmpty(Txt_ApplicationTitle.Text))
            {
                MessageBox.Show("Data Saved Successfuly","Data Saved"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Application.ApplicationTitle = Txt_ApplicationTitle.Text;
                _Application.ApplicationFees = Convert.ToDecimal(Txt_ApplicationFees.Text);
                _Application.UpdateApplicationTypes();
                return;

            }
            MessageBox.Show("Data not saved please fill all faildes", "Can't save data"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Initialize_Data()
        {
            label_Id.Text = _Application.ApllicationId.ToString();
            Txt_ApplicationTitle.Text = _Application.ApplicationTitle;
            Txt_ApplicationFees.Text = _Application.ApplicationFees.ToString();
        }

        private void Frm_EditApplicationType_Load(object sender, EventArgs e)
        {
            _Application = Cls_ApplicationTypes_BusinessLayer.Find(_ApplicationID);
            if (_Application!=null)
            Initialize_Data();
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
