namespace Real_Estate_Management_System
{
    partial class ReportFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFrm));
            this.btnBuyrRep = new Real_Estate_Management_System.golButton();
            this.btnSellerRep = new Real_Estate_Management_System.golButton();
            this.btnPropRep = new Real_Estate_Management_System.golButton();
            this.pnTopDb = new System.Windows.Forms.Panel();
            this.lbClose = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pnTopDb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuyrRep
            // 
            this.btnBuyrRep.BackColor = System.Drawing.Color.Green;
            this.btnBuyrRep.Image = global::Real_Estate_Management_System.Properties.Resources.buyrRep;
            this.btnBuyrRep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuyrRep.Location = new System.Drawing.Point(318, 367);
            this.btnBuyrRep.Name = "btnBuyrRep";
            this.btnBuyrRep.Size = new System.Drawing.Size(116, 116);
            this.btnBuyrRep.TabIndex = 277;
            this.btnBuyrRep.Text = "Buyer Report";
            this.btnBuyrRep.UseVisualStyleBackColor = false;
            // 
            // btnSellerRep
            // 
            this.btnSellerRep.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSellerRep.Image = global::Real_Estate_Management_System.Properties.Resources.SellerRep;
            this.btnSellerRep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSellerRep.Location = new System.Drawing.Point(409, 305);
            this.btnSellerRep.Name = "btnSellerRep";
            this.btnSellerRep.Size = new System.Drawing.Size(116, 116);
            this.btnSellerRep.TabIndex = 277;
            this.btnSellerRep.Text = "Seller Report";
            this.btnSellerRep.UseVisualStyleBackColor = false;
            // 
            // btnPropRep
            // 
            this.btnPropRep.BackColor = System.Drawing.Color.DeepPink;
            this.btnPropRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropRep.Image = ((System.Drawing.Image)(resources.GetObject("btnPropRep.Image")));
            this.btnPropRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPropRep.Location = new System.Drawing.Point(174, 105);
            this.btnPropRep.Name = "btnPropRep";
            this.btnPropRep.Size = new System.Drawing.Size(291, 291);
            this.btnPropRep.TabIndex = 277;
            this.btnPropRep.Text = "Propert Report";
            this.btnPropRep.UseVisualStyleBackColor = false;
            this.btnPropRep.Click += new System.EventHandler(this.btnPropRep_Click);
            // 
            // pnTopDb
            // 
            this.pnTopDb.BackColor = System.Drawing.Color.Transparent;
            this.pnTopDb.BackgroundImage = global::Real_Estate_Management_System.Properties.Resources.bgTop;
            this.pnTopDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTopDb.Controls.Add(this.lbClose);
            this.pnTopDb.Controls.Add(this.label24);
            this.pnTopDb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopDb.Location = new System.Drawing.Point(0, 0);
            this.pnTopDb.Name = "pnTopDb";
            this.pnTopDb.Size = new System.Drawing.Size(1121, 35);
            this.pnTopDb.TabIndex = 276;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.White;
            this.lbClose.Location = new System.Drawing.Point(1090, 3);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(28, 27);
            this.lbClose.TabIndex = 226;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(518, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 20);
            this.label24.TabIndex = 6;
            this.label24.Text = "Reports";
            // 
            // ReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1121, 690);
            this.Controls.Add(this.btnBuyrRep);
            this.Controls.Add(this.btnPropRep);
            this.Controls.Add(this.pnTopDb);
            this.Controls.Add(this.btnSellerRep);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportFrm";
            this.Text = "ReportFrm";
            this.pnTopDb.ResumeLayout(false);
            this.pnTopDb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopDb;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbClose;
        private golButton btnPropRep;
        private golButton btnBuyrRep;
        private golButton btnSellerRep;
    }
}