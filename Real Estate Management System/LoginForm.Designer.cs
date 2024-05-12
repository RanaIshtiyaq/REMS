namespace Real_Estate_Management_System
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.cbKeepMe = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnName = new System.Windows.Forms.Panel();
            this.pnPas = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPas = new System.Windows.Forms.Label();
            this.pbLogingImg = new System.Windows.Forms.PictureBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancleBtn = new Real_Estate_Management_System.golButton();
            this.loginButton = new Real_Estate_Management_System.golButton();
            this.paswordText = new Real_Estate_Management_System.roundText();
            this.usernameText = new Real_Estate_Management_System.roundText();
            this.logingolButton2 = new Real_Estate_Management_System.golButton();
            this.golButton1 = new Real_Estate_Management_System.golButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogingImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKeepMe
            // 
            this.cbKeepMe.AutoSize = true;
            this.cbKeepMe.BackColor = System.Drawing.Color.Transparent;
            this.cbKeepMe.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbKeepMe.Location = new System.Drawing.Point(465, 225);
            this.cbKeepMe.Name = "cbKeepMe";
            this.cbKeepMe.Size = new System.Drawing.Size(98, 17);
            this.cbKeepMe.TabIndex = 3;
            this.cbKeepMe.Text = "Keep Me Login";
            this.cbKeepMe.UseVisualStyleBackColor = false;
            this.cbKeepMe.CheckedChanged += new System.EventHandler(this.cbKeepMe_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(495, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Get Started Form Login Below";
            // 
            // pnName
            // 
            this.pnName.BackColor = System.Drawing.Color.White;
            this.pnName.Location = new System.Drawing.Point(470, 172);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(176, 1);
            this.pnName.TabIndex = 27;
            // 
            // pnPas
            // 
            this.pnPas.BackColor = System.Drawing.Color.White;
            this.pnPas.Location = new System.Drawing.Point(471, 218);
            this.pnPas.Name = "pnPas";
            this.pnPas.Size = new System.Drawing.Size(176, 1);
            this.pnPas.TabIndex = 28;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbName.Location = new System.Drawing.Point(655, 151);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(94, 20);
            this.lbName.TabIndex = 29;
            this.lbName.Text = "User Name";
            this.lbName.Visible = false;
            // 
            // lbPas
            // 
            this.lbPas.AutoSize = true;
            this.lbPas.BackColor = System.Drawing.Color.Transparent;
            this.lbPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPas.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbPas.Location = new System.Drawing.Point(655, 197);
            this.lbPas.Name = "lbPas";
            this.lbPas.Size = new System.Drawing.Size(74, 20);
            this.lbPas.TabIndex = 29;
            this.lbPas.Text = "Pasword";
            this.lbPas.Visible = false;
            // 
            // pbLogingImg
            // 
            this.pbLogingImg.Image = ((System.Drawing.Image)(resources.GetObject("pbLogingImg.Image")));
            this.pbLogingImg.Location = new System.Drawing.Point(0, -1);
            this.pbLogingImg.Name = "pbLogingImg";
            this.pbLogingImg.Size = new System.Drawing.Size(399, 352);
            this.pbLogingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogingImg.TabIndex = 33;
            this.pbLogingImg.TabStop = false;
            // 
            // pbPass
            // 
            this.pbPass.BackColor = System.Drawing.Color.Transparent;
            this.pbPass.Image = global::Real_Estate_Management_System.Properties.Resources.passwordWhit;
            this.pbPass.Location = new System.Drawing.Point(430, 189);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(30, 30);
            this.pbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPass.TabIndex = 22;
            this.pbPass.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.BackColor = System.Drawing.Color.Transparent;
            this.pbName.Image = global::Real_Estate_Management_System.Properties.Resources.nameW;
            this.pbName.Location = new System.Drawing.Point(430, 143);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(30, 30);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbName.TabIndex = 21;
            this.pbName.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(405, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // CancleBtn
            // 
            this.CancleBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CancleBtn.BackgroundImage = global::Real_Estate_Management_System.Properties.Resources.btncancel;
            this.CancleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancleBtn.ForeColor = System.Drawing.Color.White;
            this.CancleBtn.Location = new System.Drawing.Point(564, 257);
            this.CancleBtn.Name = "CancleBtn";
            this.CancleBtn.Size = new System.Drawing.Size(70, 70);
            this.CancleBtn.TabIndex = 5;
            this.CancleBtn.UseVisualStyleBackColor = false;
            this.CancleBtn.Click += new System.EventHandler(this.CancleBtn_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loginButton.BackgroundImage = global::Real_Estate_Management_System.Properties.Resources.btnlogin;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(488, 257);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(70, 70);
            this.loginButton.TabIndex = 4;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // paswordText
            // 
            this.paswordText.BackColor = System.Drawing.Color.DodgerBlue;
            this.paswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paswordText.ForeColor = System.Drawing.Color.White;
            this.paswordText.Location = new System.Drawing.Point(459, 193);
            this.paswordText.Name = "paswordText";
            this.paswordText.PasswordChar = '*';
            this.paswordText.Size = new System.Drawing.Size(198, 27);
            this.paswordText.TabIndex = 2;
            this.paswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paswordText.Enter += new System.EventHandler(this.paswordText_MouseEnter);
            this.paswordText.Leave += new System.EventHandler(this.paswordText_Leave);
            this.paswordText.MouseEnter += new System.EventHandler(this.paswordText_MouseEnter);
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.Color.DodgerBlue;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ForeColor = System.Drawing.Color.White;
            this.usernameText.Location = new System.Drawing.Point(459, 147);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(198, 27);
            this.usernameText.TabIndex = 1;
            this.usernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameText.Enter += new System.EventHandler(this.usernameText_MouseEnter);
            this.usernameText.Leave += new System.EventHandler(this.usernameText_Leave);
            this.usernameText.MouseEnter += new System.EventHandler(this.usernameText_MouseEnter);
            // 
            // logingolButton2
            // 
            this.logingolButton2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.logingolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logingolButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logingolButton2.ForeColor = System.Drawing.Color.GhostWhite;
            this.logingolButton2.Location = new System.Drawing.Point(676, 255);
            this.logingolButton2.Name = "logingolButton2";
            this.logingolButton2.Size = new System.Drawing.Size(64, 45);
            this.logingolButton2.TabIndex = 24;
            this.logingolButton2.Text = "Login";
            this.logingolButton2.UseVisualStyleBackColor = false;
            // 
            // golButton1
            // 
            this.golButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.golButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.golButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golButton1.ForeColor = System.Drawing.Color.GhostWhite;
            this.golButton1.Location = new System.Drawing.Point(742, 254);
            this.golButton1.Name = "golButton1";
            this.golButton1.Size = new System.Drawing.Size(64, 45);
            this.golButton1.TabIndex = 23;
            this.golButton1.Text = "Cancle";
            this.golButton1.UseVisualStyleBackColor = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(805, 351);
            this.Controls.Add(this.pbLogingImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancleBtn);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.lbPas);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pnPas);
            this.Controls.Add(this.pnName);
            this.Controls.Add(this.paswordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbKeepMe);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogingImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbKeepMe;
        private System.Windows.Forms.Label label1;
        private golButton golButton1;
        private golButton logingolButton2;
        private roundText usernameText;
        private roundText paswordText;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.Panel pnPas;
        private golButton loginButton;
        private golButton CancleBtn;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPas;
        private System.Windows.Forms.PictureBox pbLogingImg;
    }
}

