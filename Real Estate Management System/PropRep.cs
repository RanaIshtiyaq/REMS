using Microsoft.Reporting.WinForms;
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
    public partial class PropRep : Form
    {
        public PropRep()
        {
            InitializeComponent();
        }
        private DataSet2 GetDataonlload()
        {

            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM properties ", queryClass.con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet2 ds = new DataSet2();
            da.Fill(ds, "DataTable1");
            return ds;
        }
        private DataSet2 GetData()
        {
            queryClass.con.Close();
            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM properties where prId=@i", queryClass.con);

            cmd.Parameters.AddWithValue("@i", tbSearch.Text);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet2 ds = new DataSet2();
            da.Fill(ds, "DataTable1");
            return ds;
        }

        private void PropRep_Load(object sender, EventArgs e)
        {
            try
            {
                queryClass.fr = this;
                queryClass.repoTheme(pnTopDb,reportViewer2);
                DataSet2 ds = GetDataonlload(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer2.LocalReport.DataSources.Clear();
                this.reportViewer2.LocalReport.DataSources.Add(datasource);
                this.reportViewer2.RefreshReport();
            }
            catch (Exception x) {
                MessageBox.Show(x.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet2 ds = GetData(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer2.LocalReport.DataSources.Clear();
                this.reportViewer2.LocalReport.DataSources.Add(datasource);
                this.reportViewer2.RefreshReport();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }    
        }
    }
}
