using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string qry = string.Format("select * from admin where adName='" + usernameText.Text + "' AND adPasword='" + paswordText.Text + "' ");
            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand(qry, queryClass.con);
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Dashbord db = new Dashbord();
                db.Show();
                this.Hide();
            }
            else
            {
                queryClass.showMess("Error in username or pasword", Color.Green);
            }

            queryClass.con.Close();            
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm You Want to Close Login Form", "Close Login Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            this.Close();
        }

        private void usernameText_Leave(object sender, EventArgs e)
        {
            lbName.Visible = false;
            pnName.BackColor = Color.White;
            pbName.Image = Properties.Resources.nameW;
        }

        private void paswordText_Leave(object sender, EventArgs e)
        {
            lbPas.Visible = false;
            pnPas.BackColor = Color.White;
            pbPass.Image = Properties.Resources.passwordWhit;
        }

        private void usernameText_MouseEnter(object sender, EventArgs e)
        {
            this.ActiveControl = usernameText;
            lbName.Visible = true;
            pnName.BackColor = Color.Red;
            pbName.Image = Properties.Resources.name11;
        }

        private void paswordText_MouseEnter(object sender, EventArgs e)
        {
            this.ActiveControl = paswordText;
            lbPas.Visible = true;
            pnPas.BackColor = Color.Red;
            pbPass.Image = Properties.Resources.password11;
        }

        private void cbKeepMe_CheckedChanged(object sender, EventArgs e)
        {
            if (paswordText.Text == "" || usernameText.Text =="" ) 
            {
                cbKeepMe.Checked = false;
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Default")
            {
                this.BackColor = Color.DodgerBlue;
                usernameText.BackColor = Color.DodgerBlue;
                paswordText.BackColor = Color.DodgerBlue;
            }
            if (Properties.Settings.Default.Theme == "Pink")
            {
                this.BackColor = Color.Orchid;
                usernameText.BackColor = Color.Orchid;
                paswordText.BackColor = Color.Orchid;
            }
            if (Properties.Settings.Default.Theme == "Green")
            {
                this.BackColor = Color.MediumSeaGreen;
                usernameText.BackColor = Color.MediumSeaGreen;
                paswordText.BackColor = Color.MediumSeaGreen;
            }
        }

    }
}
