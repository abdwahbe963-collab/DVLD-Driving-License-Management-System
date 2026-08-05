using DVLD_Business_Layer;
using DVLD_Full_Proj.Applications;
using DVLD_Full_Proj.TestTypes.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj.TestTypes
{
    public partial class UC_TestTypes : UserControl
    {
        public UC_TestTypes()
        {
            InitializeComponent();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeId=(int) dg_TestTypes.CurrentRow.Cells[0].Value;
            Frm_EditTestsType frm = new Frm_EditTestsType(TestTypeId);
            frm.ShowDialog();
            _Referesh_Dg_TestTypes();
        }
        private void _Referesh_Dg_TestTypes()
        {
            dg_TestTypes.DataSource = Cls_TestTypes_BusinessLayer.GetTestTypes();
        }
        private void UC_TestTypes_Load(object sender, EventArgs e)
        {
            _Referesh_Dg_TestTypes();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            MainForm Frm = FindForm() as MainForm;
            if (Frm == null) return;
            Frm.Show_Control(new UC_MainApplications());
        }
    }
}
