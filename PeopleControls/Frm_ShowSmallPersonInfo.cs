using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj.PeopleControls
{
    public partial class Frm_ShowSmallPersonInfo : Form
    {
        public Frm_ShowSmallPersonInfo(int PersonId=-1)
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
            if (PersonId !=-1)
            {
                uC_SmalPersonInfo1.Load_Person(PersonId);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
