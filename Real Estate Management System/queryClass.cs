using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.Text.RegularExpressions;

namespace Real_Estate_Management_System
{
    class queryClass
    {
        public static Form fr;
        public static int id;
        public static Panel pnn;
        public static Color colors, headColor;
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\REMSdb.accdb");
        
        //Show custom message box function
        public static void showMess(string message, Color bgcolor)
        {
            messageBoxCustom messbox = new messageBoxCustom(message, bgcolor);
            messbox.Show();
        }
        //Validations
        //For Latter
        public static void valLatr(KeyPressEventArgs kp)
        {
            char ch = kp.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != Convert.ToChar(" "))
            {
                kp.Handled = true;
            }
        }
        //For Number
        public static void valNum(KeyPressEventArgs kp)
        {
            char ch = kp.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                kp.Handled = true;
            }
        }
        //For Decimal Number
        public static void valNumDec(KeyPressEventArgs kp)
        {
            char ch = kp.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != Convert.ToChar("."))
            {
                kp.Handled = true;
            }
        }
        //For Reg and Vehicle no
        public static void valLaterNum(KeyPressEventArgs kp)
        {
            char ch = kp.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != Convert.ToChar(" ") && !char.IsLetter(ch))
            {
                kp.Handled = true;
            }
        }
        //For address
        public static void valadr(KeyPressEventArgs kp)
        {
            char ch = kp.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && !char.IsLetter(ch) && ch != Convert.ToChar(" ") && ch != Convert.ToChar(","))
            {
                kp.Handled = true;
            }
        }
        //For CNIC hyphon
        public static void valaCNICh(TextBox t)
        {
            if (t.Text.Length == 5 || t.Text.Length == 13)
            {
                t.Text = t.Text + "-";
                t.SelectionStart = t.Text.Length;
            }
        }
        //For Cell no hyphon
        public static void valaCellh(TextBox t)
        {
            if (t.Text.Length == 4 )
            {
                t.Text = t.Text + "-";
                t.SelectionStart = t.Text.Length;
            }
        }
        //Image Save & reload
        public static byte[] stra(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            pb.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }

        public static Image loadImg( byte[] p) 
        {
                MemoryStream ms = new MemoryStream(p);
                return Image.FromStream(ms);
             
        }
        
        //Clear Controls 
        public static void clrearC(Panel p)
        {
            try
            {
                foreach (Control c in p.Controls)
                {
                    if (c is roundText) { c.Text = ""; }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        //Open Dialog Box
        public static void od(PictureBox pb,string title)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = title;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pb.BorderStyle = BorderStyle.None;
                    pb.Image = Image.FromFile(ofd.FileName);
                    pb.Enabled = false;
                }
                else
                {
                    pb.BackgroundImage = Properties.Resources.noImage;
                    pb.Enabled = true;
                    pb.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        //Minimize & Maximize Functions
        public static void controlMini(DataGridView dg,Panel pnH,PictureBox pbU,PictureBox pbD)
        {
            try
            {
                dg.Location = new System.Drawing.Point(5, 328);
                dg.Size = new System.Drawing.Size(1110, 355);
                pnH.Location = new System.Drawing.Point(5, 272);
                pbU.Visible = true;
                pbD.Visible = false;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public static void controlMaxi(DataGridView dg, Panel pnH, PictureBox pbU, PictureBox pbD)
        {try{
            dg.Location = new System.Drawing.Point(5, 170);
            dg.Size = new System.Drawing.Size(1110, 512);
            pnH.Location = new System.Drawing.Point(5, 113);
            pbU.Visible = false;
            pbD.Visible = true;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        
        //themess
        public static void dgvra( DataGridView dgf)
        {
            try
            {
                for (int i = 0; i < dgf.RowCount; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (Properties.Settings.Default.Theme == "Default")
                        {
                            dgf.Rows[i].DefaultCellStyle.BackColor = Color.DodgerBlue;
                        }
                        if (Properties.Settings.Default.Theme == "Pink")
                        {
                            dgf.Rows[i].DefaultCellStyle.BackColor = Color.Orchid;
                           
                        }
                        if (Properties.Settings.Default.Theme == "Green")
                        {
                            dgf.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                        }

                    }
                    else
                    {
                        dgf.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                        dgf.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        //Change Form Controls color
        public static void changecolor(Panel padnew, Panel pT, Panel pH, DataGridView dgf, DataGridView dgof,roundText tbsrch)
        {
            try
            {
                pH.BackColor = pT.BackColor = headColor; pT.BackgroundImage = null;
                dgof.BackgroundColor =  dgf.BackgroundColor = colors;
                foreach (Control c in padnew.Controls)
                {
                    if (c is roundText) { tbsrch.BackColor=c.BackColor = queryClass.colors; }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        //For form change color

        public static void thm(Panel padnew, Panel pT, Panel pH, DataGridView dgf, DataGridView dgof, roundText tbsrch)
        {
            try
            {
                        if (Properties.Settings.Default.Theme == "Default")
                        {
                            queryClass.headColor = Color.DarkBlue;
                            fr.BackColor = queryClass.colors = Color.DodgerBlue;
                            queryClass.changecolor(padnew, pT, pH, dgf, dgof,tbsrch);
                            pT.BackgroundImage = Properties.Resources.bgTop;

                        }
                        if (Properties.Settings.Default.Theme == "Pink")
                        {
                            queryClass.headColor = Color.Fuchsia;
                            fr.BackColor = queryClass.colors = Color.Orchid;
                            queryClass.changecolor(padnew, pT, pH, dgf, dgof,tbsrch);
                        }
                        if (Properties.Settings.Default.Theme == "Green")
                        {
                            queryClass.headColor = Color.SeaGreen;
                            fr.BackColor = queryClass.colors = Color.MediumSeaGreen;
                            queryClass.changecolor(padnew, pT, pH, dgf, dgof,tbsrch);
                        }
                }
            
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        //RepTheme
        public static void repoTheme(Panel pntp , ReportViewer rv)
        {
            try
            {
                        if (Properties.Settings.Default.Theme == "Default")
                        {
                            queryClass.headColor = Color.DarkBlue;
             
                           fr.BackColor=rv.BackColor= Color.DodgerBlue;
                            pntp.BackgroundImage = Properties.Resources.bgTop;
                        }
                        if (Properties.Settings.Default.Theme == "Pink")
                        {
                            queryClass.headColor = Color.Fuchsia;
                            fr.BackColor = rv.BackColor = Color.Orchid; 
                            pntp.BackColor = headColor; pntp.BackgroundImage = null;
                        }
                        if (Properties.Settings.Default.Theme == "Green")
                        {
                            queryClass.headColor = Color.SeaGreen;
                            fr.BackColor = rv.BackColor = Color.MediumSeaGreen;
                            pntp.BackColor = headColor; pntp.BackgroundImage = null;
                        }

            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        //All Query
        public static void insert(string qry)
        { 
            try
            {                
                OleDbCommand cmd = new OleDbCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        
        public static void Delete(string qry)
        {
            try
            {
                
                OleDbCommand cmd = new OleDbCommand(qry, con);
                cmd.Parameters.AddWithValue("@i",id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public static void update(string qry)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(qry, con);
                cmd.Parameters.AddWithValue("@i", id);                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static DataSet ds;
        public static DataSet selectds(string qry)
        { 
            try
            {
                DataSet dss = new DataSet();
                con.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(qry, con);                
                adp.Fill(dss);
                ds = dss;
                con.Close();
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        //Enter & Leave Events
        public static void enter(roundText rt,Panel p,Label l) 
        { try{
            rt.Focus();
            p.BackColor = Color.OrangeRed;
            l.Visible=true;
            }
                
            catch (Exception e)
            {
                
                MessageBox.Show(e.Message);
            }
        }
        public static void leave(Panel p, Label l)
        {try{
            p.BackColor = Color.White;
            l.Visible = false;
        }

        catch (Exception e)
        {

            MessageBox.Show(e.Message);
        }
        }

        
    }
}
