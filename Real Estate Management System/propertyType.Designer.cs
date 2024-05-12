namespace Real_Estate_Management_System
{
    partial class propertyType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbFrmHeading = new System.Windows.Forms.Label();
            this.dgvPropType = new System.Windows.Forms.DataGridView();
            this.pnlName = new System.Windows.Forms.Panel();
            this.lbPropertyName = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnlHeadings = new System.Windows.Forms.Panel();
            this.lbHnm = new System.Windows.Forms.Label();
            this.lbHid = new System.Windows.Forms.Label();
            this.pnadnew = new System.Windows.Forms.Panel();
            this.dgpid = new System.Windows.Forms.DataGridView();
            this.pbPtype = new System.Windows.Forms.PictureBox();
            this.tbSearch = new Real_Estate_Management_System.roundText();
            this.tbPropName = new Real_Estate_Management_System.roundText();
            this.btnUpdate = new Real_Estate_Management_System.golButton();
            this.btnDelete = new Real_Estate_Management_System.golButton();
            this.btnInsert = new Real_Estate_Management_System.golButton();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnlHeadings.SuspendLayout();
            this.pnadnew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPtype)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Transparent;
            this.pnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTop.Controls.Add(this.lbClose);
            this.pnTop.Controls.Add(this.lbFrmHeading);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1110, 35);
            this.pnTop.TabIndex = 242;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.White;
            this.lbClose.Location = new System.Drawing.Point(1079, 3);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(28, 27);
            this.lbClose.TabIndex = 225;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // lbFrmHeading
            // 
            this.lbFrmHeading.AutoSize = true;
            this.lbFrmHeading.BackColor = System.Drawing.Color.Transparent;
            this.lbFrmHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrmHeading.ForeColor = System.Drawing.Color.White;
            this.lbFrmHeading.Location = new System.Drawing.Point(503, 4);
            this.lbFrmHeading.Name = "lbFrmHeading";
            this.lbFrmHeading.Size = new System.Drawing.Size(179, 24);
            this.lbFrmHeading.TabIndex = 224;
            this.lbFrmHeading.Text = "PROPERTY TYPE";
            // 
            // dgvPropType
            // 
            this.dgvPropType.AllowUserToAddRows = false;
            this.dgvPropType.AllowUserToDeleteRows = false;
            this.dgvPropType.AllowUserToResizeColumns = false;
            this.dgvPropType.AllowUserToResizeRows = false;
            this.dgvPropType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPropType.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvPropType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPropType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropType.ColumnHeadersVisible = false;
            this.dgvPropType.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPropType.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPropType.GridColor = System.Drawing.Color.White;
            this.dgvPropType.Location = new System.Drawing.Point(690, 47);
            this.dgvPropType.Name = "dgvPropType";
            this.dgvPropType.RowHeadersVisible = false;
            this.dgvPropType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPropType.Size = new System.Drawing.Size(339, 326);
            this.dgvPropType.TabIndex = 262;
            this.dgvPropType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropType_CellClick);
            this.dgvPropType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropType_CellDoubleClick);
            this.dgvPropType.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPropType_RowsAdded);
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.White;
            this.pnlName.Location = new System.Drawing.Point(61, 33);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(180, 1);
            this.pnlName.TabIndex = 264;
            // 
            // lbPropertyName
            // 
            this.lbPropertyName.AutoSize = true;
            this.lbPropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPropertyName.ForeColor = System.Drawing.Color.White;
            this.lbPropertyName.Location = new System.Drawing.Point(251, 13);
            this.lbPropertyName.Name = "lbPropertyName";
            this.lbPropertyName.Size = new System.Drawing.Size(100, 18);
            this.lbPropertyName.TabIndex = 265;
            this.lbPropertyName.Text = "Property Type";
            this.lbPropertyName.Visible = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = global::Real_Estate_Management_System.Properties.Resources.pTypeW;
            this.pbUser.Location = new System.Drawing.Point(20, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(30, 30);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 266;
            this.pbUser.TabStop = false;
            // 
            // pnlHeadings
            // 
            this.pnlHeadings.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeadings.Controls.Add(this.lbHnm);
            this.pnlHeadings.Controls.Add(this.lbHid);
            this.pnlHeadings.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlHeadings.ForeColor = System.Drawing.Color.White;
            this.pnlHeadings.Location = new System.Drawing.Point(690, 46);
            this.pnlHeadings.Name = "pnlHeadings";
            this.pnlHeadings.Size = new System.Drawing.Size(339, 23);
            this.pnlHeadings.TabIndex = 277;
            // 
            // lbHnm
            // 
            this.lbHnm.AutoSize = true;
            this.lbHnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHnm.Location = new System.Drawing.Point(190, 2);
            this.lbHnm.Name = "lbHnm";
            this.lbHnm.Size = new System.Drawing.Size(136, 18);
            this.lbHnm.TabIndex = 261;
            this.lbHnm.Text = "PROPERTY_TYPE";
            // 
            // lbHid
            // 
            this.lbHid.AutoSize = true;
            this.lbHid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHid.Location = new System.Drawing.Point(77, 2);
            this.lbHid.Name = "lbHid";
            this.lbHid.Size = new System.Drawing.Size(22, 18);
            this.lbHid.TabIndex = 261;
            this.lbHid.Text = "ID";
            // 
            // pnadnew
            // 
            this.pnadnew.BackColor = System.Drawing.Color.Transparent;
            this.pnadnew.Controls.Add(this.pbUser);
            this.pnadnew.Controls.Add(this.lbPropertyName);
            this.pnadnew.Controls.Add(this.tbPropName);
            this.pnadnew.Controls.Add(this.pnlName);
            this.pnadnew.Location = new System.Drawing.Point(96, 115);
            this.pnadnew.Name = "pnadnew";
            this.pnadnew.Size = new System.Drawing.Size(365, 46);
            this.pnadnew.TabIndex = 278;
            // 
            // dgpid
            // 
            this.dgpid.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgpid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgpid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpid.Location = new System.Drawing.Point(12, 311);
            this.dgpid.Name = "dgpid";
            this.dgpid.Size = new System.Drawing.Size(10, 10);
            this.dgpid.TabIndex = 0;
            // 
            // pbPtype
            // 
            this.pbPtype.Image = global::Real_Estate_Management_System.Properties.Resources.age1;
            this.pbPtype.Location = new System.Drawing.Point(0, 319);
            this.pbPtype.Name = "pbPtype";
            this.pbPtype.Size = new System.Drawing.Size(10, 10);
            this.pbPtype.TabIndex = 279;
            this.pbPtype.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(0, 335);
            this.tbSearch.MaxLength = 2;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(10, 24);
            this.tbSearch.TabIndex = 280;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.Visible = false;
            // 
            // tbPropName
            // 
            this.tbPropName.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbPropName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPropName.ForeColor = System.Drawing.Color.White;
            this.tbPropName.Location = new System.Drawing.Point(50, 10);
            this.tbPropName.MaxLength = 50;
            this.tbPropName.Name = "tbPropName";
            this.tbPropName.Size = new System.Drawing.Size(202, 24);
            this.tbPropName.TabIndex = 263;
            this.tbPropName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPropName.Enter += new System.EventHandler(this.tbPropName_MouseEnter);
            this.tbPropName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPropName_KeyPress);
            this.tbPropName.Leave += new System.EventHandler(this.tbPropName_Leave);
            this.tbPropName.MouseEnter += new System.EventHandler(this.tbPropName_MouseEnter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::Real_Estate_Management_System.Properties.Resources.btnUpdate;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(528, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 70);
            this.btnUpdate.TabIndex = 241;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Real_Estate_Management_System.Properties.Resources.btndelRed;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(528, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 70);
            this.btnDelete.TabIndex = 240;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImage = global::Real_Estate_Management_System.Properties.Resources.btnInsert;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(528, 103);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(70, 70);
            this.btnInsert.TabIndex = 239;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // propertyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1110, 415);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgpid);
            this.Controls.Add(this.pbPtype);
            this.Controls.Add(this.pnadnew);
            this.Controls.Add(this.pnlHeadings);
            this.Controls.Add(this.dgvPropType);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(5, 326);
            this.Name = "propertyType";
            this.Text = "propertyType";
            this.Load += new System.EventHandler(this.propertyType_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.propertyType_MouseClick);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnlHeadings.ResumeLayout(false);
            this.pnlHeadings.PerformLayout();
            this.pnadnew.ResumeLayout(false);
            this.pnadnew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPtype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbFrmHeading;
        private golButton btnUpdate;
        private golButton btnDelete;
        private golButton btnInsert;
        private System.Windows.Forms.DataGridView dgvPropType;
        private System.Windows.Forms.Panel pnlName;
        private roundText tbPropName;
        private System.Windows.Forms.Label lbPropertyName;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel pnlHeadings;
        private System.Windows.Forms.Label lbHnm;
        private System.Windows.Forms.Label lbHid;
        private System.Windows.Forms.Panel pnadnew;
        private System.Windows.Forms.DataGridView dgpid;
        private System.Windows.Forms.PictureBox pbPtype;
        private roundText tbSearch;
    }
}