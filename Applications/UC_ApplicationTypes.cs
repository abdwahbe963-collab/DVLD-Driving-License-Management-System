using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;
using DVLD_Full_Proj.Applications.Forms;
namespace DVLD_Full_Proj.Applications
{
    public partial class UC_ApplicationTypes : UserControl
    {
        
        public UC_ApplicationTypes()
        {
            InitializeComponent();
        }
        private void _Referesh_Dg_ApllicationTypes()
        {
            dg_ApplicationTypes.DataSource = Cls_ApplicationTypes_BusinessLayer.GetApplicationTypes();
        }
        private void UC_ApplicationMain_Load(object sender, EventArgs e)
        {
          
            _Referesh_Dg_ApllicationTypes();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID=(int) dg_ApplicationTypes.CurrentRow.Cells[0].Value;
            Frm_EditApplicationType FrmEdit= new Frm_EditApplicationType(ApplicationTypeID);
            FrmEdit.ShowDialog();
           _Referesh_Dg_ApllicationTypes();


        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            MainForm Frm =FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control( new UC_MainApplications());

        }
    }
}
