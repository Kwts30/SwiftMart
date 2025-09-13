namespace SwiftMart_Final
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.SwiftMartIcon = new System.Windows.Forms.PictureBox();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.SwiftMartTitle = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NewAccLabel = new System.Windows.Forms.Label();
            this.SignupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StartDateTime = new System.Windows.Forms.Timer(this.components);
            this.VertLine = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.LoginBtn = new SwiftMart.RoundedControls.RoundedBtn();
            this.txtpassword = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtusername = new SwiftMart.roundedControls.RoundTxtBox();
            this.WelcomePanel = new SwiftMart.RoundedPanel();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwiftMartIcon)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.WelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.TitlePanel.Controls.Add(this.SwiftMartIcon);
            this.TitlePanel.Controls.Add(this.DateTimeLabel);
            this.TitlePanel.Controls.Add(this.SwiftMartTitle);
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1322, 68);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitlePanel_Paint);
            // 
            // SwiftMartIcon
            // 
            this.SwiftMartIcon.Image = global::SwiftMart_Final.Properties.Resources.SwiftMart_Icon;
            this.SwiftMartIcon.Location = new System.Drawing.Point(8, 5);
            this.SwiftMartIcon.Name = "SwiftMartIcon";
            this.SwiftMartIcon.Size = new System.Drawing.Size(54, 68);
            this.SwiftMartIcon.TabIndex = 2;
            this.SwiftMartIcon.TabStop = false;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DateTimeLabel.Location = new System.Drawing.Point(1179, 10);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(140, 46);
            this.DateTimeLabel.TabIndex = 0;
            this.DateTimeLabel.Text = "0:00 AM\r\nMM/DD/YYYY";
            this.DateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DateTimeLabel.Click += new System.EventHandler(this.DateTimeLabel_Click);
            // 
            // SwiftMartTitle
            // 
            this.SwiftMartTitle.AutoSize = true;
            this.SwiftMartTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwiftMartTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SwiftMartTitle.Location = new System.Drawing.Point(68, 20);
            this.SwiftMartTitle.Name = "SwiftMartTitle";
            this.SwiftMartTitle.Size = new System.Drawing.Size(106, 26);
            this.SwiftMartTitle.TabIndex = 4;
            this.SwiftMartTitle.Text = "SwiftMart";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.LoginLabel.Location = new System.Drawing.Point(850, 163);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(228, 33);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "SwiftMart Login";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.BottomPanel.Controls.Add(this.ExitBtn);
            this.BottomPanel.Location = new System.Drawing.Point(0, 795);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1322, 68);
            this.BottomPanel.TabIndex = 5;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(12, 8);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(54, 50);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(827, 476);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(71, 16);
            this.UsernameLabel.TabIndex = 10;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(827, 553);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(68, 16);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Password";
            // 
            // NewAccLabel
            // 
            this.NewAccLabel.AutoSize = true;
            this.NewAccLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccLabel.Location = new System.Drawing.Point(826, 734);
            this.NewAccLabel.Name = "NewAccLabel";
            this.NewAccLabel.Size = new System.Drawing.Size(87, 19);
            this.NewAccLabel.TabIndex = 13;
            this.NewAccLabel.Text = "New here?";
            // 
            // SignupLinkLabel
            // 
            this.SignupLinkLabel.AutoSize = true;
            this.SignupLinkLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.SignupLinkLabel.Location = new System.Drawing.Point(919, 734);
            this.SignupLinkLabel.Name = "SignupLinkLabel";
            this.SignupLinkLabel.Size = new System.Drawing.Size(181, 19);
            this.SignupLinkLabel.TabIndex = 14;
            this.SignupLinkLabel.TabStop = true;
            this.SignupLinkLabel.Text = "Sign up for an account!";
            this.SignupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignupLinkLabel_LinkClicked);
            // 
            // StartDateTime
            // 
            this.StartDateTime.Tick += new System.EventHandler(this.StartDateTime_Tick);
            // 
            // VertLine
            // 
            this.VertLine.BackColor = System.Drawing.Color.DarkBlue;
            this.VertLine.Location = new System.Drawing.Point(657, 174);
            this.VertLine.Name = "VertLine";
            this.VertLine.Size = new System.Drawing.Size(5, 575);
            this.VertLine.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(367, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 146);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwiftMart_Final.Properties.Resources.SwiftMart_Person;
            this.pictureBox1.Location = new System.Drawing.Point(73, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 495);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // UserIcon
            // 
            this.UserIcon.Image = global::SwiftMart_Final.Properties.Resources.User_Icon;
            this.UserIcon.Location = new System.Drawing.Point(833, 212);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(245, 244);
            this.UserIcon.TabIndex = 3;
            this.UserIcon.TabStop = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.LoginBtn.BorderRadius = 15;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(845, 638);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(221, 51);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtpassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtpassword.BorderRadius = 10;
            this.txtpassword.BorderSize = 2;
            this.txtpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(830, 572);
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtpassword.PasswordChar = true;
            this.txtpassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.Size = new System.Drawing.Size(250, 37);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.Texts = "";
            this.txtpassword.UnderlinedStyle = false;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtusername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtusername.BorderRadius = 10;
            this.txtusername.BorderSize = 2;
            this.txtusername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(830, 495);
            this.txtusername.Multiline = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.Padding = new System.Windows.Forms.Padding(7);
            this.txtusername.PasswordChar = false;
            this.txtusername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtusername.PlaceholderText = "";
            this.txtusername.Size = new System.Drawing.Size(250, 37);
            this.txtusername.TabIndex = 7;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.Texts = "";
            this.txtusername.UnderlinedStyle = false;
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.Color.DarkBlue;
            this.WelcomePanel.BorderColor = System.Drawing.SystemColors.Control;
            this.WelcomePanel.BorderSize = 0;
            this.WelcomePanel.Controls.Add(this.WelcomeMessage);
            this.WelcomePanel.ForeColor = System.Drawing.Color.White;
            this.WelcomePanel.Location = new System.Drawing.Point(-5, 20);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(1327, 102);
            this.WelcomePanel.TabIndex = 1;
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.WelcomeMessage.Location = new System.Drawing.Point(460, 61);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(400, 26);
            this.WelcomeMessage.TabIndex = 5;
            this.WelcomeMessage.Text = "Your gateway to SwiftMart starts here! ";
            // 
            // showPass
            // 
            this.showPass.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(833, 615);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(139, 24);
            this.showPass.TabIndex = 73;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 863);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VertLine);
            this.Controls.Add(this.SignupLinkLabel);
            this.Controls.Add(this.NewAccLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.WelcomePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwiftMartIcon)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private SwiftMart.RoundedPanel WelcomePanel;
        private System.Windows.Forms.PictureBox SwiftMartIcon;
        private System.Windows.Forms.PictureBox UserIcon;
        private System.Windows.Forms.Label SwiftMartTitle;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private SwiftMart.roundedControls.RoundTxtBox txtusername;
        private SwiftMart.roundedControls.RoundTxtBox txtpassword;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private SwiftMart.RoundedControls.RoundedBtn LoginBtn;
        private System.Windows.Forms.Label NewAccLabel;
        private System.Windows.Forms.LinkLabel SignupLinkLabel;
        private System.Windows.Forms.Timer StartDateTime;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.Panel VertLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.CheckBox showPass;
    }
}

