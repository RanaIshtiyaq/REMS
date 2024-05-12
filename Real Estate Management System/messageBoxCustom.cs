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
    public partial class messageBoxCustom : Form
    {
        public messageBoxCustom(string message,Color bgcolor)
        {
            InitializeComponent();
            BackColor = bgcolor;
            lbMessage.Text = message;
        }

        private void messageBoxCustom_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
