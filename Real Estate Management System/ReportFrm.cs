using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{
    public partial class ReportFrm : Form
    {
        public ReportFrm()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
                this.Close();
        }

        private void btnPropRep_Click(object sender, EventArgs e)
        {
            
        }
    }
}
