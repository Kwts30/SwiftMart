namespace SwiftMart_Final
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.SwiftMartIcon = new System.Windows.Forms.PictureBox();
            this.SwiftMartTitle = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PersonalInfoLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.OptionalMLabel = new System.Windows.Forms.Label();
            this.EmailAddLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.HomeAddLabel = new System.Windows.Forms.Label();
            this.chkTerms = new System.Windows.Forms.CheckBox();
            this.StartDateTime = new System.Windows.Forms.Timer(this.components);
            this.LoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NewAccLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtUsername = new SwiftMart.roundedControls.RoundTxtBox();
            this.btnRegister = new SwiftMart.RoundedControls.RoundedBtn();
            this.txtAddress = new SwiftMart.roundedControls.RoundTxtBox();
            this.dtpBirthDate = new SwiftMart_Final.RoundedControls.RoundedDateTimePicker();
            this.txtMiddleName = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtPhone = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtEmail = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtLastName = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtFirstName = new SwiftMart.roundedControls.RoundTxtBox();
            this.WelcomePanel = new SwiftMart.RoundedPanel();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.cmbGender = new SwiftMart_Final.RoundedControls.RoundedComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new SwiftMart.roundedControls.RoundTxtBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwiftMartIcon)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.WelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.TitlePanel.Controls.Add(this.SwiftMartIcon);
            this.TitlePanel.Controls.Add(this.SwiftMartTitle);
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1322, 68);
            this.TitlePanel.TabIndex = 2;
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
            this.LoginLabel.Location = new System.Drawing.Point(553, 151);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(247, 33);
            this.LoginLabel.TabIndex = 7;
            this.LoginLabel.Text = "SwiftMart Signup";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonalInfoLabel
            // 
            this.PersonalInfoLabel.AutoSize = true;
            this.PersonalInfoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.PersonalInfoLabel.Location = new System.Drawing.Point(566, 201);
            this.PersonalInfoLabel.Name = "PersonalInfoLabel";
            this.PersonalInfoLabel.Size = new System.Drawing.Size(191, 23);
            this.PersonalInfoLabel.TabIndex = 8;
            this.PersonalInfoLabel.Text = "Personal Information";
            this.PersonalInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(247, 259);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 16);
            this.FirstNameLabel.TabIndex = 16;
            this.FirstNameLabel.Text = "First Name*";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(547, 259);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(79, 16);
            this.LastNameLabel.TabIndex = 17;
            this.LastNameLabel.Text = "Last Name*";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameLabel.Location = new System.Drawing.Point(847, 259);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(91, 16);
            this.MiddleNameLabel.TabIndex = 18;
            this.MiddleNameLabel.Text = "Middle Name";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(247, 354);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(59, 16);
            this.GenderLabel.TabIndex = 19;
            this.GenderLabel.Text = "Gender*";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBLabel.Location = new System.Drawing.Point(547, 354);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(91, 16);
            this.DOBLabel.TabIndex = 22;
            this.DOBLabel.Text = "Date of Birth*";
            // 
            // OptionalMLabel
            // 
            this.OptionalMLabel.AutoSize = true;
            this.OptionalMLabel.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionalMLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.OptionalMLabel.Location = new System.Drawing.Point(944, 259);
            this.OptionalMLabel.Name = "OptionalMLabel";
            this.OptionalMLabel.Size = new System.Drawing.Size(68, 16);
            this.OptionalMLabel.TabIndex = 23;
            this.OptionalMLabel.Text = "(Optional)";
            // 
            // EmailAddLabel
            // 
            this.EmailAddLabel.AutoSize = true;
            this.EmailAddLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddLabel.Location = new System.Drawing.Point(247, 457);
            this.EmailAddLabel.Name = "EmailAddLabel";
            this.EmailAddLabel.Size = new System.Drawing.Size(102, 16);
            this.EmailAddLabel.TabIndex = 24;
            this.EmailAddLabel.Text = "Email Address*";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(847, 354);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(107, 16);
            this.PhoneNumberLabel.TabIndex = 25;
            this.PhoneNumberLabel.Text = "Phone Number*";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.BottomPanel.Controls.Add(this.ExitBtn);
            this.BottomPanel.Controls.Add(this.DateTimeLabel);
            this.BottomPanel.Location = new System.Drawing.Point(0, 795);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1322, 68);
            this.BottomPanel.TabIndex = 26;
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
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DateTimeLabel.Location = new System.Drawing.Point(1210, 15);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(113, 38);
            this.DateTimeLabel.TabIndex = 0;
            this.DateTimeLabel.Text = "0:00 AM\r\nMM/DD/YYYY";
            // 
            // HomeAddLabel
            // 
            this.HomeAddLabel.AutoSize = true;
            this.HomeAddLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAddLabel.Location = new System.Drawing.Point(547, 551);
            this.HomeAddLabel.Name = "HomeAddLabel";
            this.HomeAddLabel.Size = new System.Drawing.Size(85, 16);
            this.HomeAddLabel.TabIndex = 35;
            this.HomeAddLabel.Text = "Full Address";
            // 
            // chkTerms
            // 
            this.chkTerms.AutoSize = true;
            this.chkTerms.Location = new System.Drawing.Point(249, 632);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.Size = new System.Drawing.Size(360, 20);
            this.chkTerms.TabIndex = 36;
            this.chkTerms.Text = "I agree to the Terms and Conditions  and Privacy Policy.";
            this.chkTerms.UseVisualStyleBackColor = true;
            // 
            // StartDateTime
            // 
            this.StartDateTime.Tick += new System.EventHandler(this.StartDateTime_Tick);
            // 
            // LoginLinkLabel
            // 
            this.LoginLinkLabel.AutoSize = true;
            this.LoginLinkLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.LoginLinkLabel.Location = new System.Drawing.Point(698, 753);
            this.LoginLinkLabel.Name = "LoginLinkLabel";
            this.LoginLinkLabel.Size = new System.Drawing.Size(145, 19);
            this.LoginLinkLabel.TabIndex = 39;
            this.LoginLinkLabel.TabStop = true;
            this.LoginLinkLabel.Text = "Click here to login!";
            this.LoginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkLabel_LinkClicked);
            // 
            // NewAccLabel
            // 
            this.NewAccLabel.AutoSize = true;
            this.NewAccLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccLabel.Location = new System.Drawing.Point(526, 753);
            this.NewAccLabel.Name = "NewAccLabel";
            this.NewAccLabel.Size = new System.Drawing.Size(125, 19);
            this.NewAccLabel.TabIndex = 38;
            this.NewAccLabel.Text = "Already a user?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Username*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(847, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Password*";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(850, 476);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(250, 37);
            this.txtPassword.TabIndex = 42;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(550, 476);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(250, 37);
            this.txtUsername.TabIndex = 40;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.btnRegister.BorderRadius = 15;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(511, 692);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(332, 51);
            this.btnRegister.TabIndex = 37;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(550, 570);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(549, 56);
            this.txtAddress.TabIndex = 34;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Back_Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dtpBirthDate.Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dtpBirthDate.Border_Radius = 5;
            this.dtpBirthDate.Border_Size = 2;
            this.dtpBirthDate.CustomFormat = "";
            this.dtpBirthDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(550, 372);
            this.dtpBirthDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(250, 35);
            this.dtpBirthDate.TabIndex = 21;
            this.dtpBirthDate.TextColor = System.Drawing.Color.Black;
            this.dtpBirthDate.Value = new System.DateTime(2024, 10, 3, 0, 0, 0, 0);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtMiddleName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtMiddleName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMiddleName.BorderRadius = 10;
            this.txtMiddleName.BorderSize = 2;
            this.txtMiddleName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(850, 278);
            this.txtMiddleName.Multiline = false;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Padding = new System.Windows.Forms.Padding(7);
            this.txtMiddleName.PasswordChar = false;
            this.txtMiddleName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMiddleName.PlaceholderText = "";
            this.txtMiddleName.Size = new System.Drawing.Size(250, 37);
            this.txtMiddleName.TabIndex = 11;
            this.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMiddleName.Texts = "";
            this.txtMiddleName.UnderlinedStyle = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.BorderSize = 2;
            this.txtPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(850, 372);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.Size = new System.Drawing.Size(250, 37);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(250, 476);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 37);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLastName.BorderRadius = 10;
            this.txtLastName.BorderSize = 2;
            this.txtLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(550, 278);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(7);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.Size = new System.Drawing.Size(250, 37);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.Texts = "";
            this.txtLastName.UnderlinedStyle = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtFirstName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFirstName.BorderRadius = 10;
            this.txtFirstName.BorderSize = 2;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(250, 278);
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(7);
            this.txtFirstName.PasswordChar = false;
            this.txtFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.Size = new System.Drawing.Size(250, 37);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.Texts = "";
            this.txtFirstName.UnderlinedStyle = false;
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
            this.WelcomePanel.TabIndex = 3;
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.WelcomeMessage.Location = new System.Drawing.Point(392, 61);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(535, 26);
            this.WelcomeMessage.TabIndex = 5;
            this.WelcomeMessage.Text = "You\'re almost there! Just a few details to get started.";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.cmbGender.Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.cmbGender.Border_Radius = 20;
            this.cmbGender.Border_Size = 15;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.ForeColor = System.Drawing.Color.Black;
            this.cmbGender.Icon_Color = System.Drawing.Color.MidnightBlue;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Rather not say"});
            this.cmbGender.List_BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbGender.List_TextColor = System.Drawing.Color.Black;
            this.cmbGender.Location = new System.Drawing.Point(241, 364);
            this.cmbGender.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Padding = new System.Windows.Forms.Padding(10);
            this.cmbGender.Size = new System.Drawing.Size(268, 51);
            this.cmbGender.TabIndex = 20;
            this.cmbGender.Texts = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Confirm Password*";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtPasswordConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtPasswordConfirm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPasswordConfirm.BorderRadius = 10;
            this.txtPasswordConfirm.BorderSize = 2;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.Location = new System.Drawing.Point(250, 570);
            this.txtPasswordConfirm.Multiline = false;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Padding = new System.Windows.Forms.Padding(7);
            this.txtPasswordConfirm.PasswordChar = true;
            this.txtPasswordConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPasswordConfirm.PlaceholderText = "";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(250, 37);
            this.txtPasswordConfirm.TabIndex = 44;
            this.txtPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordConfirm.Texts = "";
            this.txtPasswordConfirm.UnderlinedStyle = false;
            // 
            // showPass
            // 
            this.showPass.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(850, 519);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(139, 24);
            this.showPass.TabIndex = 73;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 863);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.LoginLinkLabel);
            this.Controls.Add(this.NewAccLabel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkTerms);
            this.Controls.Add(this.HomeAddLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailAddLabel);
            this.Controls.Add(this.OptionalMLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PersonalInfoLabel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.cmbGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwiftMartIcon)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.PictureBox SwiftMartIcon;
        private System.Windows.Forms.Label SwiftMartTitle;
        private SwiftMart.RoundedPanel WelcomePanel;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PersonalInfoLabel;
        private SwiftMart.roundedControls.RoundTxtBox txtFirstName;
        private SwiftMart.roundedControls.RoundTxtBox txtLastName;
        private SwiftMart.roundedControls.RoundTxtBox txtEmail;
        private SwiftMart.roundedControls.RoundTxtBox txtPhone;
        private SwiftMart.roundedControls.RoundTxtBox txtMiddleName;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private RoundedControls.RoundedComboBox cmbGender;
        private RoundedControls.RoundedDateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label OptionalMLabel;
        private System.Windows.Forms.Label EmailAddLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.Label DateTimeLabel;
        private SwiftMart.roundedControls.RoundTxtBox txtAddress;
        private System.Windows.Forms.Label HomeAddLabel;
        private System.Windows.Forms.CheckBox chkTerms;
        private SwiftMart.RoundedControls.RoundedBtn btnRegister;
        private System.Windows.Forms.Timer StartDateTime;
        private System.Windows.Forms.LinkLabel LoginLinkLabel;
        private System.Windows.Forms.Label NewAccLabel;
        private System.Windows.Forms.Label label1;
        private SwiftMart.roundedControls.RoundTxtBox txtUsername;
        private System.Windows.Forms.Label label2;
        private SwiftMart.roundedControls.RoundTxtBox txtPassword;
        private System.Windows.Forms.Label label3;
        private SwiftMart.roundedControls.RoundTxtBox txtPasswordConfirm;
        private System.Windows.Forms.CheckBox showPass;
    }
}