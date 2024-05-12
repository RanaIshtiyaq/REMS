using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;


namespace Real_Estate_Management_System
{
    public partial class Buyer_Report : Form
    {
        public Buyer_Report()
        {
            InitializeComponent();
        }
        private DataSet1 GetDataonload()
        {

            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM buyers ", queryClass.con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTable1");
            return ds;

        }
        


        private void Buyer_Report_Load(object sender, EventArgs e)
        {
            try
            {
                queryClass.fr = this;
                queryClass.repoTheme(pnTopDb,reportViewer1);
                DataSet1 ds = GetDataonload(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }
        private DataSet1 GetData()
        {
            queryClass.con.Close();
            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM buyers where bId=@i", queryClass.con);

            cmd.Parameters.AddWithValue("@i", tbSearch.Text);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTable1");
            return ds;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1 ds = GetData(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }
    }
}
