namespace SwiftMart_Final
{
    partial class EditUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlePanel = new System.Windows.Forms.Panel();
            this.kawatskie_RoundedPanel1 = new SwiftMart_Final.Kawatskie_RoundedPanel();
            this.customerInfoLbl = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.middleNameVal = new SwiftMart.roundedControls.RoundTxtBox();
            this.address = new SwiftMart.roundedControls.RoundTxtBox();
            this.lastNameVal = new SwiftMart.roundedControls.RoundTxtBox();
            this.CancelBtn = new SwiftMart.RoundedControls.RoundedBtn();
            this.SaveBtn = new SwiftMart.RoundedControls.RoundedBtn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passWord = new SwiftMart.roundedControls.RoundTxtBox();
            this.userName = new SwiftMart.roundedControls.RoundTxtBox();
            this.eMail = new SwiftMart.roundedControls.RoundTxtBox();
            this.phoneNum = new SwiftMart.roundedControls.RoundTxtBox();
            this.cmbGender = new SwiftMart_Final.RoundedControls.RoundedComboBox();
            this.birthDateDTP = new SwiftMart_Final.RoundedControls.RoundedDateTimePicker();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.firstNameVal = new SwiftMart.roundedControls.RoundTxtBox();
            this.UserId = new System.Windows.Forms.Label();
            this.AdminBtn = new System.Windows.Forms.RadioButton();
            this.UserBtn = new System.Windows.Forms.RadioButton();
            this.fullNameValue = new System.Windows.Forms.Label();
            this.DOBLbl = new System.Windows.Forms.Label();
            this.addLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.phonenumLbl = new System.Windows.Forms.Label();
            this.emailAddLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.kawatskie_RoundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.titlePanel.Controls.Add(this.kawatskie_RoundedPanel1);
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1092, 68);
            this.titlePanel.TabIndex = 36;
            // 
            // kawatskie_RoundedPanel1
            // 
            this.kawatskie_RoundedPanel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.kawatskie_RoundedPanel1.BorderRadius = 20;
            this.kawatskie_RoundedPanel1.Controls.Add(this.customerInfoLbl);
            this.kawatskie_RoundedPanel1.Controls.Add(this.pictureBox1);
            this.kawatskie_RoundedPanel1.Location = new System.Drawing.Point(14, 15);
            this.kawatskie_RoundedPanel1.Name = "kawatskie_RoundedPanel1";
            this.kawatskie_RoundedPanel1.Size = new System.Drawing.Size(318, 66);
            this.kawatskie_RoundedPanel1.TabIndex = 56;
            // 
            // customerInfoLbl
            // 
            this.customerInfoLbl.AutoSize = true;
            this.customerInfoLbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.customerInfoLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoLbl.ForeColor = System.Drawing.Color.Black;
            this.customerInfoLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerInfoLbl.ImageKey = "(none)";
            this.customerInfoLbl.Location = new System.Drawing.Point(77, 19);
            this.customerInfoLbl.Name = "customerInfoLbl";
            this.customerInfoLbl.Size = new System.Drawing.Size(218, 27);
            this.customerInfoLbl.TabIndex = 4;
            this.customerInfoLbl.Text = "Edit Customer Info";
            this.customerInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(470, 74);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(609, 644);
            this.dgvUsers.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.showPass);
            this.panel1.Controls.Add(this.middleNameVal);
            this.panel1.Controls.Add(this.fullNameValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.firstNameVal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UserBtn);
            this.panel1.Controls.Add(this.birthDateDTP);
            this.panel1.Controls.Add(this.AdminBtn);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.UserId);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.phoneNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.eMail);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.lastNameVal);
            this.panel1.Controls.Add(this.passWord);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.FullNameLbl);
            this.panel1.Controls.Add(this.usernameLbl);
            this.panel1.Controls.Add(this.passwordLbl);
            this.panel1.Controls.Add(this.emailAddLbl);
            this.panel1.Controls.Add(this.phonenumLbl);
            this.panel1.Controls.Add(this.GenderLbl);
            this.panel1.Controls.Add(this.addLbl);
            this.panel1.Controls.Add(this.DOBLbl);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 825);
            this.panel1.TabIndex = 37;
            // 
            // middleNameVal
            // 
            this.middleNameVal.BackColor = System.Drawing.Color.White;
            this.middleNameVal.BorderColor = System.Drawing.Color.White;
            this.middleNameVal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.middleNameVal.BorderRadius = 10;
            this.middleNameVal.BorderSize = 2;
            this.middleNameVal.Font = new System.Drawing.Font("Arial", 12F);
            this.middleNameVal.Location = new System.Drawing.Point(171, 245);
            this.middleNameVal.Multiline = false;
            this.middleNameVal.Name = "middleNameVal";
            this.middleNameVal.Padding = new System.Windows.Forms.Padding(7);
            this.middleNameVal.PasswordChar = false;
            this.middleNameVal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.middleNameVal.PlaceholderText = "";
            this.middleNameVal.Size = new System.Drawing.Size(250, 37);
            this.middleNameVal.TabIndex = 67;
            this.middleNameVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.middleNameVal.Texts = "";
            this.middleNameVal.UnderlinedStyle = false;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.White;
            this.address.BorderColor = System.Drawing.Color.White;
            this.address.BorderFocusColor = System.Drawing.Color.HotPink;
            this.address.BorderRadius = 10;
            this.address.BorderSize = 2;
            this.address.Font = new System.Drawing.Font("Arial", 12F);
            this.address.Location = new System.Drawing.Point(171, 665);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Padding = new System.Windows.Forms.Padding(7);
            this.address.PasswordChar = false;
            this.address.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.address.PlaceholderText = "";
            this.address.Size = new System.Drawing.Size(250, 89);
            this.address.TabIndex = 63;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.address.Texts = "";
            this.address.UnderlinedStyle = false;
            // 
            // lastNameVal
            // 
            this.lastNameVal.BackColor = System.Drawing.Color.White;
            this.lastNameVal.BorderColor = System.Drawing.Color.White;
            this.lastNameVal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lastNameVal.BorderRadius = 10;
            this.lastNameVal.BorderSize = 2;
            this.lastNameVal.Font = new System.Drawing.Font("Arial", 12F);
            this.lastNameVal.Location = new System.Drawing.Point(171, 295);
            this.lastNameVal.Multiline = false;
            this.lastNameVal.Name = "lastNameVal";
            this.lastNameVal.Padding = new System.Windows.Forms.Padding(7);
            this.lastNameVal.PasswordChar = false;
            this.lastNameVal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lastNameVal.PlaceholderText = "";
            this.lastNameVal.Size = new System.Drawing.Size(250, 37);
            this.lastNameVal.TabIndex = 57;
            this.lastNameVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastNameVal.Texts = "";
            this.lastNameVal.UnderlinedStyle = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.BorderRadius = 15;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(817, 775);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(121, 51);
            this.CancelBtn.TabIndex = 38;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Coral;
            this.SaveBtn.BorderRadius = 15;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(944, 775);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 51);
            this.SaveBtn.TabIndex = 34;
            this.SaveBtn.Text = "Save Info";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.pictureBox1.Image = global::SwiftMart_Final.Properties.Resources.CustomersIcon;
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // passWord
            // 
            this.passWord.BackColor = System.Drawing.Color.White;
            this.passWord.BorderColor = System.Drawing.Color.White;
            this.passWord.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passWord.BorderRadius = 10;
            this.passWord.BorderSize = 2;
            this.passWord.Font = new System.Drawing.Font("Arial", 12F);
            this.passWord.Location = new System.Drawing.Point(171, 495);
            this.passWord.Multiline = false;
            this.passWord.Name = "passWord";
            this.passWord.Padding = new System.Windows.Forms.Padding(7);
            this.passWord.PasswordChar = true;
            this.passWord.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passWord.PlaceholderText = "";
            this.passWord.Size = new System.Drawing.Size(250, 37);
            this.passWord.TabIndex = 59;
            this.passWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passWord.Texts = "";
            this.passWord.UnderlinedStyle = false;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.BorderColor = System.Drawing.Color.White;
            this.userName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userName.BorderRadius = 10;
            this.userName.BorderSize = 2;
            this.userName.Font = new System.Drawing.Font("Arial", 12F);
            this.userName.Location = new System.Drawing.Point(171, 445);
            this.userName.Multiline = false;
            this.userName.Name = "userName";
            this.userName.Padding = new System.Windows.Forms.Padding(7);
            this.userName.PasswordChar = false;
            this.userName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userName.PlaceholderText = "";
            this.userName.Size = new System.Drawing.Size(250, 37);
            this.userName.TabIndex = 58;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userName.Texts = "";
            this.userName.UnderlinedStyle = false;
            // 
            // eMail
            // 
            this.eMail.BackColor = System.Drawing.Color.White;
            this.eMail.BorderColor = System.Drawing.Color.White;
            this.eMail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.eMail.BorderRadius = 10;
            this.eMail.BorderSize = 2;
            this.eMail.Font = new System.Drawing.Font("Arial", 12F);
            this.eMail.Location = new System.Drawing.Point(184, 565);
            this.eMail.Multiline = false;
            this.eMail.Name = "eMail";
            this.eMail.Padding = new System.Windows.Forms.Padding(7);
            this.eMail.PasswordChar = false;
            this.eMail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.eMail.PlaceholderText = "";
            this.eMail.Size = new System.Drawing.Size(237, 37);
            this.eMail.TabIndex = 60;
            this.eMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eMail.Texts = "";
            this.eMail.UnderlinedStyle = false;
            // 
            // phoneNum
            // 
            this.phoneNum.BackColor = System.Drawing.Color.White;
            this.phoneNum.BorderColor = System.Drawing.Color.White;
            this.phoneNum.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNum.BorderRadius = 10;
            this.phoneNum.BorderSize = 2;
            this.phoneNum.Font = new System.Drawing.Font("Arial", 12F);
            this.phoneNum.Location = new System.Drawing.Point(186, 615);
            this.phoneNum.Multiline = false;
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Padding = new System.Windows.Forms.Padding(7);
            this.phoneNum.PasswordChar = false;
            this.phoneNum.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneNum.PlaceholderText = "";
            this.phoneNum.Size = new System.Drawing.Size(235, 37);
            this.phoneNum.TabIndex = 62;
            this.phoneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneNum.Texts = "";
            this.phoneNum.UnderlinedStyle = false;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.White;
            this.cmbGender.Border_Color = System.Drawing.Color.White;
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
            this.cmbGender.Location = new System.Drawing.Point(167, 338);
            this.cmbGender.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Padding = new System.Windows.Forms.Padding(10);
            this.cmbGender.Size = new System.Drawing.Size(254, 51);
            this.cmbGender.TabIndex = 64;
            this.cmbGender.Texts = "";
            // 
            // birthDateDTP
            // 
            this.birthDateDTP.Back_Color = System.Drawing.Color.White;
            this.birthDateDTP.BackColor = System.Drawing.Color.White;
            this.birthDateDTP.Border_Color = System.Drawing.Color.White;
            this.birthDateDTP.Border_Radius = 8;
            this.birthDateDTP.Border_Size = 2;
            this.birthDateDTP.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateDTP.CalendarTitleBackColor = System.Drawing.Color.White;
            this.birthDateDTP.CustomFormat = "MM/dd/yyyy";
            this.birthDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.birthDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDTP.Location = new System.Drawing.Point(171, 395);
            this.birthDateDTP.MinimumSize = new System.Drawing.Size(4, 35);
            this.birthDateDTP.Name = "birthDateDTP";
            this.birthDateDTP.Size = new System.Drawing.Size(250, 35);
            this.birthDateDTP.TabIndex = 65;
            this.birthDateDTP.TextColor = System.Drawing.Color.Black;
            // 
            // showPass
            // 
            this.showPass.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(184, 538);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(139, 24);
            this.showPass.TabIndex = 72;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // firstNameVal
            // 
            this.firstNameVal.BackColor = System.Drawing.Color.White;
            this.firstNameVal.BorderColor = System.Drawing.Color.White;
            this.firstNameVal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.firstNameVal.BorderRadius = 10;
            this.firstNameVal.BorderSize = 2;
            this.firstNameVal.Font = new System.Drawing.Font("Arial", 12F);
            this.firstNameVal.Location = new System.Drawing.Point(171, 195);
            this.firstNameVal.Multiline = false;
            this.firstNameVal.Name = "firstNameVal";
            this.firstNameVal.Padding = new System.Windows.Forms.Padding(7);
            this.firstNameVal.PasswordChar = false;
            this.firstNameVal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.firstNameVal.PlaceholderText = "";
            this.firstNameVal.Size = new System.Drawing.Size(250, 37);
            this.firstNameVal.TabIndex = 69;
            this.firstNameVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstNameVal.Texts = "";
            this.firstNameVal.UnderlinedStyle = false;
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.BackColor = System.Drawing.Color.DarkSalmon;
            this.UserId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId.ForeColor = System.Drawing.Color.Black;
            this.UserId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserId.ImageKey = "(none)";
            this.UserId.Location = new System.Drawing.Point(190, 50);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(63, 23);
            this.UserId.TabIndex = 38;
            this.UserId.Text = "userid";
            this.UserId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminBtn
            // 
            this.AdminBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBtn.Location = new System.Drawing.Point(149, 100);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(104, 24);
            this.AdminBtn.TabIndex = 54;
            this.AdminBtn.TabStop = true;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = true;
            // 
            // UserBtn
            // 
            this.UserBtn.AutoSize = true;
            this.UserBtn.Font = new System.Drawing.Font("Arial", 10.2F);
            this.UserBtn.Location = new System.Drawing.Point(259, 100);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(64, 23);
            this.UserBtn.TabIndex = 55;
            this.UserBtn.TabStop = true;
            this.UserBtn.Text = "User";
            this.UserBtn.UseVisualStyleBackColor = true;
            // 
            // fullNameValue
            // 
            this.fullNameValue.AutoSize = true;
            this.fullNameValue.BackColor = System.Drawing.Color.DarkSalmon;
            this.fullNameValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameValue.ForeColor = System.Drawing.Color.Black;
            this.fullNameValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fullNameValue.ImageKey = "(none)";
            this.fullNameValue.Location = new System.Drawing.Point(190, 150);
            this.fullNameValue.Name = "fullNameValue";
            this.fullNameValue.Size = new System.Drawing.Size(133, 23);
            this.fullNameValue.TabIndex = 71;
            this.fullNameValue.Text = "fullNameValue";
            this.fullNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DOBLbl
            // 
            this.DOBLbl.AutoSize = true;
            this.DOBLbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.DOBLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBLbl.ForeColor = System.Drawing.Color.Black;
            this.DOBLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DOBLbl.ImageKey = "(none)";
            this.DOBLbl.Location = new System.Drawing.Point(27, 400);
            this.DOBLbl.Name = "DOBLbl";
            this.DOBLbl.Size = new System.Drawing.Size(104, 24);
            this.DOBLbl.TabIndex = 46;
            this.DOBLbl.Text = "Birthdate:";
            this.DOBLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addLbl
            // 
            this.addLbl.AutoSize = true;
            this.addLbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.addLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLbl.ForeColor = System.Drawing.Color.Black;
            this.addLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLbl.ImageKey = "(none)";
            this.addLbl.Location = new System.Drawing.Point(27, 670);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(95, 24);
            this.addLbl.TabIndex = 47;
            this.addLbl.Text = "Address:";
            this.addLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.GenderLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.ForeColor = System.Drawing.Color.Black;
            this.GenderLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenderLbl.ImageKey = "(none)";
            this.GenderLbl.Location = new System.Drawing.Point(27, 350);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(87, 24);
            this.GenderLbl.TabIndex = 45;
            this.GenderLbl.Text = "Gender:";
            this.GenderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phonenumLbl
            // 
            this.phonenumLbl.AutoSize = true;
            this.phonenumLbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.phonenumLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumLbl.ForeColor = System.Drawing.Color.Black;
            this.phonenumLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phonenumLbl.ImageKey = "(none)";
            this.phonenumLbl.Location = new System.Drawing.Point(27, 620);
            this.phonenumLbl.Name = "phonenumLbl";
            this.phonenumLbl.Size = new System.Drawing.Size(157, 24);
            this.phonenumLbl.TabIndex = 44;
            this.phonenumLbl.Text = "Phone Number:";
            this.phonenumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailAddLbl
            // 
            this.emailAddLbl.AutoSize = true;
            this.emailAddLbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.emailAddLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddLbl.ForeColor = System.Drawing.Color.Black;
            this.emailAddLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailAddLbl.ImageKey = "(none)";
            this.emailAddLbl.Location = new System.Drawing.Point(27, 570);
            this.emailAddLbl.Name = "emailAddLbl";
            this.emailAddLbl.Size = new System.Drawing.Size(151, 24);
            this.emailAddLbl.TabIndex = 43;
            this.emailAddLbl.Text = "Email Address:";
            this.emailAddLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.passwordLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.Black;
            this.passwordLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLbl.ImageKey = "(none)";
            this.passwordLbl.Location = new System.Drawing.Point(27, 500);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(110, 24);
            this.passwordLbl.TabIndex = 42;
            this.passwordLbl.Text = "Password:";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.usernameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.Black;
            this.usernameLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLbl.ImageKey = "(none)";
            this.usernameLbl.Location = new System.Drawing.Point(27, 450);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(112, 24);
            this.usernameLbl.TabIndex = 41;
            this.usernameLbl.Text = "Username:";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.FullNameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLbl.ForeColor = System.Drawing.Color.Black;
            this.FullNameLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FullNameLbl.ImageKey = "(none)";
            this.FullNameLbl.Location = new System.Drawing.Point(27, 150);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(110, 24);
            this.FullNameLbl.TabIndex = 40;
            this.FullNameLbl.Text = "Full Name:";
            this.FullNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblUserID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserID.ImageKey = "(none)";
            this.lblUserID.Location = new System.Drawing.Point(27, 50);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(86, 24);
            this.lblUserID.TabIndex = 39;
            this.lblUserID.Text = "User ID:";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(27, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "Role:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(27, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImageKey = "(none)";
            this.label3.Location = new System.Drawing.Point(27, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "Middle Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImageKey = "(none)";
            this.label4.Location = new System.Drawing.Point(27, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "First Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panel1);
            this.Name = "EditUsers";
            this.Size = new System.Drawing.Size(1092, 872);
            this.titlePanel.ResumeLayout(false);
            this.kawatskie_RoundedPanel1.ResumeLayout(false);
            this.kawatskie_RoundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel1;
        private Kawatskie_RoundedPanel kawatskie_RoundedPanel1;
        private System.Windows.Forms.Label customerInfoLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SwiftMart.roundedControls.RoundTxtBox lastNameVal;
        private SwiftMart.roundedControls.RoundTxtBox address;
        private SwiftMart.RoundedControls.RoundedBtn SaveBtn;
        private SwiftMart.RoundedControls.RoundedBtn CancelBtn;
        private SwiftMart.roundedControls.RoundTxtBox middleNameVal;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Label fullNameValue;
        private System.Windows.Forms.Label label4;
        private SwiftMart.roundedControls.RoundTxtBox firstNameVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton UserBtn;
        private RoundedControls.RoundedDateTimePicker birthDateDTP;
        private System.Windows.Forms.RadioButton AdminBtn;
        private RoundedControls.RoundedComboBox cmbGender;
        private System.Windows.Forms.Label UserId;
        private SwiftMart.roundedControls.RoundTxtBox phoneNum;
        private System.Windows.Forms.Label label1;
        private SwiftMart.roundedControls.RoundTxtBox eMail;
        private SwiftMart.roundedControls.RoundTxtBox userName;
        private SwiftMart.roundedControls.RoundTxtBox passWord;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label emailAddLbl;
        private System.Windows.Forms.Label phonenumLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label addLbl;
        private System.Windows.Forms.Label DOBLbl;
    }
}
