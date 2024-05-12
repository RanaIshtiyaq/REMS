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
    public partial class sellerRep : Form
    {
        public sellerRep()
        {
            InitializeComponent();
        }
        private DataSet3 GetDataonlload()
        {

            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM sellers ", queryClass.con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet3 ds = new DataSet3();
            da.Fill(ds, "DataTable1");
            return ds;
        }
        private DataSet3 GetData()
        {
            queryClass.con.Close();
            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM sellers where sId=@i", queryClass.con);
            cmd.Parameters.AddWithValue("@i", tbSearch.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet3 ds = new DataSet3();
            da.Fill(ds, "DataTable1");
            return ds;
        }

        private void sellerRep_Load(object sender, EventArgs e)
        {
            try
            {
                queryClass.fr = this;
                queryClass.repoTheme(pnTopDb, reportViewer1);
                DataSet3 ds = GetDataonlload(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet3 ds = GetData(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
