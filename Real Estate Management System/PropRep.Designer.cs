namespace Real_Estate_Management_System
{
    partial class PropRep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropRep));
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Real_Estate_Management_System.DataSet2();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnTopDb = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new Real_Estate_Management_System.CirPicBox();
            this.tbSearch = new Real_Estate_Management_System.roundText();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.pnTopDb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Real_Estate_Management_System.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(82, 110);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(961, 568);
            this.reportViewer2.TabIndex = 0;
            // 
            // pnTopDb
            // 
            this.pnTopDb.BackColor = System.Drawing.Color.Transparent;
            this.pnTopDb.BackgroundImage = global::Real_Estate_Management_System.Properties.Resources.bgTop;
            this.pnTopDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTopDb.Controls.Add(this.label24);
            this.pnTopDb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopDb.Location = new System.Drawing.Point(0, 0);
            this.pnTopDb.Name = "pnTopDb";
            this.pnTopDb.Size = new System.Drawing.Size(1121, 35);
            this.pnTopDb.TabIndex = 277;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(504, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(181, 20);
            this.label24.TabIndex = 6;
            this.label24.Text = "PROPERTY REPORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(387, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 280;
            this.label1.Text = "ID";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(708, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 282;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.Location = new System.Drawing.Point(425, 71);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(314, 32);
            this.tbSearch.TabIndex = 281;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PropRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1121, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pnTopDb);
            this.Controls.Add(this.reportViewer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PropRep";
            this.Text = "PropRep";
            this.Load += new System.EventHandler(this.PropRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.pnTopDb.ResumeLayout(false);
            this.pnTopDb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet2 DataSet2;
        private System.Windows.Forms.Panel pnTopDb;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private CirPicBox btnSearch;
        private roundText tbSearch;
    }
}