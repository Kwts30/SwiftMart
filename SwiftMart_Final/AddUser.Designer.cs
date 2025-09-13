namespace SwiftMart_Final
{
    partial class AddUser
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
            this.WelcomePanel = new SwiftMart.RoundedPanel();
            this.AddUserHdr = new System.Windows.Forms.Label();
            this.txtFirstName = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtLastName = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtMiddleName = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtPhone = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtPassword = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtUsername = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtEmail = new SwiftMart.roundedControls.RoundTxtBox();
            this.txtAddress = new SwiftMart.roundedControls.RoundTxtBox();
            this.cmbGender = new SwiftMart_Final.RoundedControls.RoundedComboBox();
            this.dtpBirthDate = new SwiftMart_Final.RoundedControls.RoundedDateTimePicker();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.OptionalMLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailAddLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.HomeAddLabel = new System.Windows.Forms.Label();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.AdminBtn = new System.Windows.Forms.RadioButton();
            this.UserBtn = new System.Windows.Forms.RadioButton();
            this.AddBtn = new SwiftMart.RoundedControls.RoundedBtn();
            this.CancelBtn = new SwiftMart.RoundedControls.RoundedBtn();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.WelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.Color.DarkBlue;
            this.WelcomePanel.BorderColor = System.Drawing.SystemColors.Control;
            this.WelcomePanel.BorderSize = 0;
            this.WelcomePanel.Controls.Add(this.AddUserHdr);
            this.WelcomePanel.ForeColor = System.Drawing.Color.White;
            this.WelcomePanel.Location = new System.Drawing.Point(-12, -30);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(760, 102);
            this.WelcomePanel.TabIndex = 4;
            // 
            // AddUserHdr
            // 
            this.AddUserHdr.AutoSize = true;
            this.AddUserHdr.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserHdr.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUserHdr.Location = new System.Drawing.Point(310, 52);
            this.AddUserHdr.Name = "AddUserHdr";
            this.AddUserHdr.Size = new System.Drawing.Size(115, 27);
            this.AddUserHdr.TabIndex = 5;
            this.AddUserHdr.Text = "Add User";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtFirstName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFirstName.BorderRadius = 10;
            this.txtFirstName.BorderSize = 2;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(12, 142);
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(7);
            this.txtFirstName.PasswordChar = false;
            this.txtFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.Size = new System.Drawing.Size(221, 37);
            this.txtFirstName.TabIndex = 10;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.Texts = "";
            this.txtFirstName.UnderlinedStyle = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLastName.BorderRadius = 10;
            this.txtLastName.BorderSize = 2;
            this.txtLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(258, 142);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(7);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.Size = new System.Drawing.Size(221, 37);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.Texts = "";
            this.txtLastName.UnderlinedStyle = false;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtMiddleName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtMiddleName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMiddleName.BorderRadius = 10;
            this.txtMiddleName.BorderSize = 2;
            this.txtMiddleName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(506, 142);
            this.txtMiddleName.Multiline = false;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Padding = new System.Windows.Forms.Padding(7);
            this.txtMiddleName.PasswordChar = false;
            this.txtMiddleName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMiddleName.PlaceholderText = "";
            this.txtMiddleName.Size = new System.Drawing.Size(221, 37);
            this.txtMiddleName.TabIndex = 14;
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
            this.txtPhone.Location = new System.Drawing.Point(506, 215);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.Size = new System.Drawing.Size(221, 37);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(506, 288);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(221, 37);
            this.txtPassword.TabIndex = 20;
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
            this.txtUsername.Location = new System.Drawing.Point(258, 288);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(221, 37);
            this.txtUsername.TabIndex = 19;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 288);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(221, 37);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(15, 361);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(712, 81);
            this.txtAddress.TabIndex = 35;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
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
            this.cmbGender.List_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbGender.List_TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.cmbGender.Location = new System.Drawing.Point(4, 206);
            this.cmbGender.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Padding = new System.Windows.Forms.Padding(10);
            this.cmbGender.Size = new System.Drawing.Size(229, 51);
            this.cmbGender.TabIndex = 36;
            this.cmbGender.Texts = "";
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
            this.dtpBirthDate.Location = new System.Drawing.Point(258, 215);
            this.dtpBirthDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(221, 35);
            this.dtpBirthDate.TabIndex = 37;
            this.dtpBirthDate.TextColor = System.Drawing.Color.Black;
            this.dtpBirthDate.Value = new System.DateTime(2024, 11, 3, 0, 0, 0, 0);
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameLabel.Location = new System.Drawing.Point(503, 123);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(91, 16);
            this.MiddleNameLabel.TabIndex = 40;
            this.MiddleNameLabel.Text = "Middle Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(255, 123);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(79, 16);
            this.LastNameLabel.TabIndex = 39;
            this.LastNameLabel.Text = "Last Name*";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 123);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 16);
            this.FirstNameLabel.TabIndex = 38;
            this.FirstNameLabel.Text = "First Name*";
            // 
            // OptionalMLabel
            // 
            this.OptionalMLabel.AutoSize = true;
            this.OptionalMLabel.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionalMLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.OptionalMLabel.Location = new System.Drawing.Point(600, 123);
            this.OptionalMLabel.Name = "OptionalMLabel";
            this.OptionalMLabel.Size = new System.Drawing.Size(68, 16);
            this.OptionalMLabel.TabIndex = 41;
            this.OptionalMLabel.Text = "(Optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Password*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Username*";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(503, 196);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(107, 16);
            this.PhoneNumberLabel.TabIndex = 47;
            this.PhoneNumberLabel.Text = "Phone Number*";
            // 
            // EmailAddLabel
            // 
            this.EmailAddLabel.AutoSize = true;
            this.EmailAddLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddLabel.Location = new System.Drawing.Point(12, 269);
            this.EmailAddLabel.Name = "EmailAddLabel";
            this.EmailAddLabel.Size = new System.Drawing.Size(102, 16);
            this.EmailAddLabel.TabIndex = 46;
            this.EmailAddLabel.Text = "Email Address*";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBLabel.Location = new System.Drawing.Point(255, 196);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(91, 16);
            this.DOBLabel.TabIndex = 45;
            this.DOBLabel.Text = "Date of Birth*";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(12, 196);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(59, 16);
            this.GenderLabel.TabIndex = 44;
            this.GenderLabel.Text = "Gender*";
            // 
            // HomeAddLabel
            // 
            this.HomeAddLabel.AutoSize = true;
            this.HomeAddLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAddLabel.Location = new System.Drawing.Point(12, 342);
            this.HomeAddLabel.Name = "HomeAddLabel";
            this.HomeAddLabel.Size = new System.Drawing.Size(90, 16);
            this.HomeAddLabel.TabIndex = 50;
            this.HomeAddLabel.Text = "Full Address*";
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.Location = new System.Drawing.Point(550, 453);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(69, 16);
            this.userTypeLabel.TabIndex = 51;
            this.userTypeLabel.Text = "User Type";
            // 
            // AdminBtn
            // 
            this.AdminBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBtn.Location = new System.Drawing.Point(553, 472);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(104, 24);
            this.AdminBtn.TabIndex = 52;
            this.AdminBtn.TabStop = true;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = true;
            // 
            // UserBtn
            // 
            this.UserBtn.AutoSize = true;
            this.UserBtn.Font = new System.Drawing.Font("Arial", 10.2F);
            this.UserBtn.Location = new System.Drawing.Point(663, 472);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(64, 23);
            this.UserBtn.TabIndex = 53;
            this.UserBtn.TabStop = true;
            this.UserBtn.Text = "User";
            this.UserBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.AddBtn.BorderRadius = 15;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(606, 513);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 51);
            this.AddBtn.TabIndex = 54;
            this.AddBtn.Text = "Create";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelBtn.BorderRadius = 15;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(479, 513);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(121, 51);
            this.CancelBtn.TabIndex = 55;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // showPass
            // 
            this.showPass.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(506, 331);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(139, 24);
            this.showPass.TabIndex = 73;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(739, 576);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.HomeAddLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailAddLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.OptionalMLabel);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.WelcomePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwiftMart.RoundedPanel WelcomePanel;
        private System.Windows.Forms.Label AddUserHdr;
        private SwiftMart.roundedControls.RoundTxtBox txtFirstName;
        private SwiftMart.roundedControls.RoundTxtBox txtLastName;
        private SwiftMart.roundedControls.RoundTxtBox txtMiddleName;
        private SwiftMart.roundedControls.RoundTxtBox txtPhone;
        private SwiftMart.roundedControls.RoundTxtBox txtPassword;
        private SwiftMart.roundedControls.RoundTxtBox txtUsername;
        private SwiftMart.roundedControls.RoundTxtBox txtEmail;
        private SwiftMart.roundedControls.RoundTxtBox txtAddress;
        private RoundedControls.RoundedComboBox cmbGender;
        private RoundedControls.RoundedDateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label OptionalMLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailAddLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label HomeAddLabel;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.RadioButton AdminBtn;
        private System.Windows.Forms.RadioButton UserBtn;
        private SwiftMart.RoundedControls.RoundedBtn AddBtn;
        private SwiftMart.RoundedControls.RoundedBtn CancelBtn;
        private System.Windows.Forms.CheckBox showPass;
    }
}