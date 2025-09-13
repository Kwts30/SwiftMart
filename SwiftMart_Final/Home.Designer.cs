using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using Label = System.Windows.Forms.Label;
using Panel = System.Windows.Forms.Panel;
using TextBox = System.Windows.Forms.TextBox;
namespace SwiftMart_Final
{
    partial class LoadAdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadAdminHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.payButton = new Guna.UI2.WinForms.Guna2Button();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.deliveryComboBox = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.label92 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.columnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnallitem = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.HomeCenterpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnallitem1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnallitem2 = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnallitem3 = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnallitem4 = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnallitem5 = new Guna.UI2.WinForms.Guna2Button();
            this.label16 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnallitem6 = new Guna.UI2.WinForms.Guna2Button();
            this.label19 = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnallitem7 = new Guna.UI2.WinForms.Guna2Button();
            this.label22 = new System.Windows.Forms.Label();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnallitem8 = new Guna.UI2.WinForms.Guna2Button();
            this.label25 = new System.Windows.Forms.Label();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnallitem9 = new Guna.UI2.WinForms.Guna2Button();
            this.label28 = new System.Windows.Forms.Label();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnallitem10 = new Guna.UI2.WinForms.Guna2Button();
            this.label31 = new System.Windows.Forms.Label();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btnallitem11 = new Guna.UI2.WinForms.Guna2Button();
            this.label34 = new System.Windows.Forms.Label();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.btnallitem12 = new Guna.UI2.WinForms.Guna2Button();
            this.label37 = new System.Windows.Forms.Label();
            this.guna2Panel13 = new Guna.UI2.WinForms.Guna2Panel();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.btnallitem13 = new Guna.UI2.WinForms.Guna2Button();
            this.label40 = new System.Windows.Forms.Label();
            this.guna2Panel14 = new Guna.UI2.WinForms.Guna2Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.btnallitem14 = new Guna.UI2.WinForms.Guna2Button();
            this.label43 = new System.Windows.Forms.Label();
            this.guna2Panel15 = new Guna.UI2.WinForms.Guna2Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.btnallitem15 = new Guna.UI2.WinForms.Guna2Button();
            this.label46 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel16 = new Guna.UI2.WinForms.Guna2Panel();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.btncanned1 = new Guna.UI2.WinForms.Guna2Button();
            this.label47 = new System.Windows.Forms.Label();
            this.guna2Panel17 = new Guna.UI2.WinForms.Guna2Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.btncanned2 = new Guna.UI2.WinForms.Guna2Button();
            this.label50 = new System.Windows.Forms.Label();
            this.guna2Panel18 = new Guna.UI2.WinForms.Guna2Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.btncanned3 = new Guna.UI2.WinForms.Guna2Button();
            this.label55 = new System.Windows.Forms.Label();
            this.guna2Panel19 = new Guna.UI2.WinForms.Guna2Panel();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.btncanned4 = new Guna.UI2.WinForms.Guna2Button();
            this.label56 = new System.Windows.Forms.Label();
            this.guna2Panel20 = new Guna.UI2.WinForms.Guna2Panel();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.btncanned5 = new Guna.UI2.WinForms.Guna2Button();
            this.label59 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel21 = new Guna.UI2.WinForms.Guna2Panel();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.btnfrozen1 = new Guna.UI2.WinForms.Guna2Button();
            this.label64 = new System.Windows.Forms.Label();
            this.guna2Panel22 = new Guna.UI2.WinForms.Guna2Panel();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.btnfrozen2 = new Guna.UI2.WinForms.Guna2Button();
            this.label67 = new System.Windows.Forms.Label();
            this.guna2Panel23 = new Guna.UI2.WinForms.Guna2Panel();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.btnfrozen3 = new Guna.UI2.WinForms.Guna2Button();
            this.label70 = new System.Windows.Forms.Label();
            this.guna2Panel24 = new Guna.UI2.WinForms.Guna2Panel();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.btnfrozen4 = new Guna.UI2.WinForms.Guna2Button();
            this.label73 = new System.Windows.Forms.Label();
            this.guna2Panel25 = new Guna.UI2.WinForms.Guna2Panel();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.btnfrozen5 = new Guna.UI2.WinForms.Guna2Button();
            this.label74 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel26 = new Guna.UI2.WinForms.Guna2Panel();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.btnbeverages1 = new Guna.UI2.WinForms.Guna2Button();
            this.label79 = new System.Windows.Forms.Label();
            this.guna2Panel27 = new Guna.UI2.WinForms.Guna2Panel();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.btnbeverages2 = new Guna.UI2.WinForms.Guna2Button();
            this.label84 = new System.Windows.Forms.Label();
            this.guna2Panel28 = new Guna.UI2.WinForms.Guna2Panel();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.btnbeverages3 = new Guna.UI2.WinForms.Guna2Button();
            this.label87 = new System.Windows.Forms.Label();
            this.guna2Panel29 = new Guna.UI2.WinForms.Guna2Panel();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.btnbeverages4 = new Guna.UI2.WinForms.Guna2Button();
            this.label90 = new System.Windows.Forms.Label();
            this.guna2Panel30 = new Guna.UI2.WinForms.Guna2Panel();
            this.label91 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.btnbeverages5 = new Guna.UI2.WinForms.Guna2Button();
            this.label81 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.HomeCenterpanel.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.guna2Panel10.SuspendLayout();
            this.guna2Panel11.SuspendLayout();
            this.guna2Panel12.SuspendLayout();
            this.guna2Panel13.SuspendLayout();
            this.guna2Panel14.SuspendLayout();
            this.guna2Panel15.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.guna2Panel16.SuspendLayout();
            this.guna2Panel17.SuspendLayout();
            this.guna2Panel18.SuspendLayout();
            this.guna2Panel19.SuspendLayout();
            this.guna2Panel20.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.guna2Panel21.SuspendLayout();
            this.guna2Panel22.SuspendLayout();
            this.guna2Panel23.SuspendLayout();
            this.guna2Panel24.SuspendLayout();
            this.guna2Panel25.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.guna2Panel26.SuspendLayout();
            this.guna2Panel27.SuspendLayout();
            this.guna2Panel28.SuspendLayout();
            this.guna2Panel29.SuspendLayout();
            this.guna2Panel30.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(185)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.payButton);
            this.panel1.Controls.Add(this.paymentTextBox);
            this.panel1.Controls.Add(this.lblPaymentMethod);
            this.panel1.Controls.Add(this.deliveryComboBox);
            this.panel1.Controls.Add(this.label93);
            this.panel1.Controls.Add(this.paymentComboBox);
            this.panel1.Controls.Add(this.label92);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Controls.Add(this.dataGridViewItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(847, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 690);
            this.panel1.TabIndex = 0;
            // 
            // payButton
            // 
            this.payButton.AutoRoundedCorners = true;
            this.payButton.BorderRadius = 21;
            this.payButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.payButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.ForeColor = System.Drawing.Color.White;
            this.payButton.Location = new System.Drawing.Point(41, 622);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(234, 45);
            this.payButton.TabIndex = 10;
            this.payButton.Text = "Pay";
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Location = new System.Drawing.Point(159, 484);
            this.paymentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(143, 22);
            this.paymentTextBox.TabIndex = 9;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.lblPaymentMethod.Location = new System.Drawing.Point(9, 451);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(129, 85);
            this.lblPaymentMethod.TabIndex = 8;
            this.lblPaymentMethod.Text = "Please select the payment method";
            this.lblPaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deliveryComboBox
            // 
            this.deliveryComboBox.FormattingEnabled = true;
            this.deliveryComboBox.Items.AddRange(new object[] {
            "Pick-up",
            "Home Delivery"});
            this.deliveryComboBox.Location = new System.Drawing.Point(187, 378);
            this.deliveryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deliveryComboBox.Name = "deliveryComboBox";
            this.deliveryComboBox.Size = new System.Drawing.Size(115, 24);
            this.deliveryComboBox.TabIndex = 7;
            this.deliveryComboBox.Text = "Select";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.ForeColor = System.Drawing.Color.White;
            this.label93.Location = new System.Drawing.Point(9, 382);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(170, 24);
            this.label93.TabIndex = 6;
            this.label93.Text = "Delivery Method:";
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Gcash/Maya"});
            this.paymentComboBox.Location = new System.Drawing.Point(187, 413);
            this.paymentComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(115, 24);
            this.paymentComboBox.TabIndex = 5;
            this.paymentComboBox.Text = "Select";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.ForeColor = System.Drawing.Color.White;
            this.label92.Location = new System.Drawing.Point(9, 416);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(176, 24);
            this.label92.TabIndex = 4;
            this.label92.Text = "Payment Method:";
            // 
            // btnClear
            // 
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BorderRadius = 21;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(13, 554);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(9, 334);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(154, 38);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total: ₱0";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnItemName,
            this.columnItemPrice,
            this.columnItemQuantity});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.GridColor = System.Drawing.Color.Black;
            this.dataGridViewItems.Location = new System.Drawing.Point(9, 22);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.Size = new System.Drawing.Size(293, 288);
            this.dataGridViewItems.TabIndex = 0;
            // 
            // columnItemName
            // 
            this.columnItemName.DataPropertyName = "item_name";
            this.columnItemName.HeaderText = "Item Name";
            this.columnItemName.MinimumWidth = 6;
            this.columnItemName.Name = "columnItemName";
            this.columnItemName.ReadOnly = true;
            this.columnItemName.Width = 125;
            // 
            // columnItemPrice
            // 
            this.columnItemPrice.DataPropertyName = "item_price";
            this.columnItemPrice.HeaderText = "Price";
            this.columnItemPrice.MinimumWidth = 6;
            this.columnItemPrice.Name = "columnItemPrice";
            this.columnItemPrice.ReadOnly = true;
            this.columnItemPrice.Width = 70;
            // 
            // columnItemQuantity
            // 
            this.columnItemQuantity.DataPropertyName = "item_quantity";
            this.columnItemQuantity.HeaderText = "Quantity";
            this.columnItemQuantity.MinimumWidth = 6;
            this.columnItemQuantity.Name = "columnItemQuantity";
            this.columnItemQuantity.ReadOnly = true;
            this.columnItemQuantity.Width = 80;
            // 
            // btnallitem
            // 
            this.btnallitem.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem.BorderRadius = 15;
            this.btnallitem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnallitem.Checked = true;
            this.btnallitem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.btnallitem.CheckedState.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallitem.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.btnallitem.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.btnallitem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.btnallitem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.btnallitem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.btnallitem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallitem.ForeColor = System.Drawing.Color.White;
            this.btnallitem.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.btnallitem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.btnallitem.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnallitem.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem.Image")));
            this.btnallitem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnallitem.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnallitem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnallitem.Location = new System.Drawing.Point(36, 140);
            this.btnallitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem.Name = "btnallitem";
            this.btnallitem.Size = new System.Drawing.Size(164, 57);
            this.btnallitem.TabIndex = 1;
            this.btnallitem.Text = "All Item";
            this.btnallitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnallitem.TextOffset = new System.Drawing.Point(10, 0);
            this.btnallitem.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(327, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "SwiftMart";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button1.CheckedState.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(231, 140);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(164, 57);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Canned";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_2);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button2.CheckedState.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(427, 140);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(164, 57);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Frozen";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button3.CheckedState.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(619, 140);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(164, 57);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "Beverages";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click_1);
            // 
            // HomeCenterpanel
            // 
            this.HomeCenterpanel.Controls.Add(this.TabControl1);
            this.HomeCenterpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HomeCenterpanel.Location = new System.Drawing.Point(0, 225);
            this.HomeCenterpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeCenterpanel.Name = "HomeCenterpanel";
            this.HomeCenterpanel.Size = new System.Drawing.Size(847, 465);
            this.HomeCenterpanel.TabIndex = 6;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Controls.Add(this.tabPage4);
            this.TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.TabControl1.Location = new System.Drawing.Point(-7, -45);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(861, 519);
            this.TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(853, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel1);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel2);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel3);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel4);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel5);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel6);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel7);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel8);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel9);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel10);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel11);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel12);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel13);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel14);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel15);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(847, 467);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.btnallitem1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel1.Location = new System.Drawing.Point(20, 16);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "/ 240ml";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "₱33.15";
            // 
            // btnallitem1
            // 
            this.btnallitem1.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem1.BorderRadius = 5;
            this.btnallitem1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem1.ForeColor = System.Drawing.Color.White;
            this.btnallitem1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem1.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem1.Image")));
            this.btnallitem1.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem1.Location = new System.Drawing.Point(10, 8);
            this.btnallitem1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem1.Name = "btnallitem1";
            this.btnallitem1.Size = new System.Drawing.Size(230, 114);
            this.btnallitem1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dole 100% Pineapple Juice \r\nDrink Unsweetened";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.btnallitem2);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel2.Location = new System.Drawing.Point(293, 16);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(109, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "/ 155g";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "₱23.90";
            // 
            // btnallitem2
            // 
            this.btnallitem2.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem2.BorderRadius = 5;
            this.btnallitem2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem2.ForeColor = System.Drawing.Color.White;
            this.btnallitem2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem2.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem2.Image")));
            this.btnallitem2.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem2.Location = new System.Drawing.Point(10, 8);
            this.btnallitem2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem2.Name = "btnallitem2";
            this.btnallitem2.Size = new System.Drawing.Size(230, 114);
            this.btnallitem2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 38);
            this.label7.TabIndex = 1;
            this.label7.Text = "Young\'s Town Sardines \r\nIn Tomato Sauce";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.Controls.Add(this.label8);
            this.guna2Panel3.Controls.Add(this.label9);
            this.guna2Panel3.Controls.Add(this.btnallitem3);
            this.guna2Panel3.Controls.Add(this.label10);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel3.Location = new System.Drawing.Point(566, 16);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(109, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "/ 155g";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 33);
            this.label9.TabIndex = 2;
            this.label9.Text = "₱24.70";
            // 
            // btnallitem3
            // 
            this.btnallitem3.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem3.BorderRadius = 5;
            this.btnallitem3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem3.ForeColor = System.Drawing.Color.White;
            this.btnallitem3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem3.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem3.Image")));
            this.btnallitem3.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem3.Location = new System.Drawing.Point(10, 8);
            this.btnallitem3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem3.Name = "btnallitem3";
            this.btnallitem3.Size = new System.Drawing.Size(230, 114);
            this.btnallitem3.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 57);
            this.label10.TabIndex = 1;
            this.label10.Text = "Young\'s Town Sardines In \r\nTomato Sauce With \r\nHot Chili";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.Controls.Add(this.label11);
            this.guna2Panel4.Controls.Add(this.label12);
            this.guna2Panel4.Controls.Add(this.btnallitem4);
            this.guna2Panel4.Controls.Add(this.label13);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel4.Location = new System.Drawing.Point(20, 282);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel4.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(109, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "/ 150g";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 33);
            this.label12.TabIndex = 2;
            this.label12.Text = "₱34.85";
            // 
            // btnallitem4
            // 
            this.btnallitem4.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem4.BorderRadius = 5;
            this.btnallitem4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem4.ForeColor = System.Drawing.Color.White;
            this.btnallitem4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem4.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem4.Image")));
            this.btnallitem4.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem4.Location = new System.Drawing.Point(10, 8);
            this.btnallitem4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem4.Name = "btnallitem4";
            this.btnallitem4.Size = new System.Drawing.Size(230, 114);
            this.btnallitem4.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(10, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "Argentina Corned Beef";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.Controls.Add(this.label14);
            this.guna2Panel5.Controls.Add(this.label15);
            this.guna2Panel5.Controls.Add(this.btnallitem5);
            this.guna2Panel5.Controls.Add(this.label16);
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel5.Location = new System.Drawing.Point(293, 282);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel5.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(109, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 24);
            this.label14.TabIndex = 3;
            this.label14.Text = "/ 155g";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(10, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 33);
            this.label15.TabIndex = 2;
            this.label15.Text = "₱25.50";
            // 
            // btnallitem5
            // 
            this.btnallitem5.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem5.BorderRadius = 5;
            this.btnallitem5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem5.ForeColor = System.Drawing.Color.White;
            this.btnallitem5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem5.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem5.Image")));
            this.btnallitem5.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem5.Location = new System.Drawing.Point(10, 8);
            this.btnallitem5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem5.Name = "btnallitem5";
            this.btnallitem5.Size = new System.Drawing.Size(230, 114);
            this.btnallitem5.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(10, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 38);
            this.label16.TabIndex = 1;
            this.label16.Text = "Mega Sardines In Tomato \r\nSauce";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderRadius = 10;
            this.guna2Panel6.Controls.Add(this.label17);
            this.guna2Panel6.Controls.Add(this.label18);
            this.guna2Panel6.Controls.Add(this.btnallitem6);
            this.guna2Panel6.Controls.Add(this.label19);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel6.Location = new System.Drawing.Point(566, 282);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel6.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(123, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 24);
            this.label17.TabIndex = 3;
            this.label17.Text = "/ 1kg";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(10, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 33);
            this.label18.TabIndex = 2;
            this.label18.Text = "₱229.95";
            // 
            // btnallitem6
            // 
            this.btnallitem6.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem6.BorderRadius = 5;
            this.btnallitem6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem6.ForeColor = System.Drawing.Color.White;
            this.btnallitem6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem6.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem6.Image")));
            this.btnallitem6.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem6.Location = new System.Drawing.Point(10, 8);
            this.btnallitem6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem6.Name = "btnallitem6";
            this.btnallitem6.Size = new System.Drawing.Size(230, 114);
            this.btnallitem6.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(10, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(210, 38);
            this.label19.TabIndex = 1;
            this.label19.Text = "Virginia Premium Hotdog \r\nRegular";
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.BorderRadius = 10;
            this.guna2Panel7.Controls.Add(this.label20);
            this.guna2Panel7.Controls.Add(this.label21);
            this.guna2Panel7.Controls.Add(this.btnallitem7);
            this.guna2Panel7.Controls.Add(this.label22);
            this.guna2Panel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel7.Location = new System.Drawing.Point(20, 548);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel7.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(127, 210);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 24);
            this.label20.TabIndex = 3;
            this.label20.Text = "/ 200g";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(10, 205);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 33);
            this.label21.TabIndex = 2;
            this.label21.Text = "₱126.00";
            // 
            // btnallitem7
            // 
            this.btnallitem7.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem7.BorderRadius = 5;
            this.btnallitem7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem7.ForeColor = System.Drawing.Color.White;
            this.btnallitem7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem7.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem7.Image")));
            this.btnallitem7.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem7.Location = new System.Drawing.Point(10, 8);
            this.btnallitem7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem7.Name = "btnallitem7";
            this.btnallitem7.Size = new System.Drawing.Size(230, 114);
            this.btnallitem7.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(10, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(215, 38);
            this.label22.TabIndex = 1;
            this.label22.Text = "Purefoods Chicken Breast\r\nNuggets";
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel8.BorderRadius = 10;
            this.guna2Panel8.Controls.Add(this.label23);
            this.guna2Panel8.Controls.Add(this.label24);
            this.guna2Panel8.Controls.Add(this.btnallitem8);
            this.guna2Panel8.Controls.Add(this.label25);
            this.guna2Panel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel8.Location = new System.Drawing.Point(293, 548);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel8.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(124, 210);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 24);
            this.label23.TabIndex = 3;
            this.label23.Text = "/ 320g";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(10, 205);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(122, 33);
            this.label24.TabIndex = 2;
            this.label24.Text = "₱169.75";
            // 
            // btnallitem8
            // 
            this.btnallitem8.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem8.BorderRadius = 5;
            this.btnallitem8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem8.ForeColor = System.Drawing.Color.White;
            this.btnallitem8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem8.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem8.Image")));
            this.btnallitem8.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem8.Location = new System.Drawing.Point(10, 8);
            this.btnallitem8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem8.Name = "btnallitem8";
            this.btnallitem8.Size = new System.Drawing.Size(230, 114);
            this.btnallitem8.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(10, 134);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(234, 38);
            this.label25.TabIndex = 1;
            this.label25.Text = "Sarangani Bay Boneless \r\nMilkfish Unseasoned Medium";
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel9.BorderRadius = 10;
            this.guna2Panel9.Controls.Add(this.label26);
            this.guna2Panel9.Controls.Add(this.label27);
            this.guna2Panel9.Controls.Add(this.btnallitem9);
            this.guna2Panel9.Controls.Add(this.label28);
            this.guna2Panel9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel9.Location = new System.Drawing.Point(566, 548);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel9.TabIndex = 8;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(123, 210);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 24);
            this.label26.TabIndex = 3;
            this.label26.Text = "/ 1kg";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(10, 205);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(122, 33);
            this.label27.TabIndex = 2;
            this.label27.Text = "₱531.65";
            // 
            // btnallitem9
            // 
            this.btnallitem9.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem9.BorderRadius = 5;
            this.btnallitem9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem9.ForeColor = System.Drawing.Color.White;
            this.btnallitem9.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem9.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem9.Image")));
            this.btnallitem9.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem9.Location = new System.Drawing.Point(10, 8);
            this.btnallitem9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem9.Name = "btnallitem9";
            this.btnallitem9.Size = new System.Drawing.Size(230, 114);
            this.btnallitem9.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(10, 134);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(220, 38);
            this.label28.TabIndex = 1;
            this.label28.Text = "Purefoods Chicken Breast \r\nNuggets";
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel10.BorderRadius = 10;
            this.guna2Panel10.Controls.Add(this.label29);
            this.guna2Panel10.Controls.Add(this.label30);
            this.guna2Panel10.Controls.Add(this.btnallitem10);
            this.guna2Panel10.Controls.Add(this.label31);
            this.guna2Panel10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel10.Location = new System.Drawing.Point(20, 814);
            this.guna2Panel10.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel10.TabIndex = 9;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(123, 210);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 24);
            this.label29.TabIndex = 3;
            this.label29.Text = "/ 220g";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(10, 205);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(122, 33);
            this.label30.TabIndex = 2;
            this.label30.Text = "₱107.20";
            // 
            // btnallitem10
            // 
            this.btnallitem10.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem10.BorderRadius = 5;
            this.btnallitem10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem10.ForeColor = System.Drawing.Color.White;
            this.btnallitem10.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem10.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem10.Image")));
            this.btnallitem10.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem10.Location = new System.Drawing.Point(10, 8);
            this.btnallitem10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem10.Name = "btnallitem10";
            this.btnallitem10.Size = new System.Drawing.Size(230, 114);
            this.btnallitem10.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(8, 142);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(172, 19);
            this.label31.TabIndex = 1;
            this.label31.Text = "Purefoods Beef Tapa";
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.BorderRadius = 10;
            this.guna2Panel11.Controls.Add(this.label32);
            this.guna2Panel11.Controls.Add(this.label33);
            this.guna2Panel11.Controls.Add(this.btnallitem11);
            this.guna2Panel11.Controls.Add(this.label34);
            this.guna2Panel11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel11.Location = new System.Drawing.Point(293, 814);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel11.TabIndex = 10;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(109, 210);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(62, 24);
            this.label32.TabIndex = 3;
            this.label32.Text = "/ 1.5L";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(10, 205);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(106, 33);
            this.label33.TabIndex = 2;
            this.label33.Text = "₱71.65";
            // 
            // btnallitem11
            // 
            this.btnallitem11.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem11.BorderRadius = 5;
            this.btnallitem11.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem11.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem11.ForeColor = System.Drawing.Color.White;
            this.btnallitem11.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem11.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem11.Image")));
            this.btnallitem11.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem11.Location = new System.Drawing.Point(10, 8);
            this.btnallitem11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem11.Name = "btnallitem11";
            this.btnallitem11.Size = new System.Drawing.Size(230, 114);
            this.btnallitem11.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(10, 142);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(115, 19);
            this.label34.TabIndex = 1;
            this.label34.Text = "Coke Regular";
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel12.BorderRadius = 10;
            this.guna2Panel12.Controls.Add(this.label35);
            this.guna2Panel12.Controls.Add(this.label36);
            this.guna2Panel12.Controls.Add(this.btnallitem12);
            this.guna2Panel12.Controls.Add(this.label37);
            this.guna2Panel12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel12.Location = new System.Drawing.Point(566, 814);
            this.guna2Panel12.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel12.TabIndex = 11;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(109, 210);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(56, 24);
            this.label35.TabIndex = 3;
            this.label35.Text = "/ 58g";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(10, 205);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(106, 33);
            this.label36.TabIndex = 2;
            this.label36.Text = "₱13.00";
            // 
            // btnallitem12
            // 
            this.btnallitem12.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem12.BorderRadius = 5;
            this.btnallitem12.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem12.ForeColor = System.Drawing.Color.White;
            this.btnallitem12.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem12.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem12.Image")));
            this.btnallitem12.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem12.Location = new System.Drawing.Point(10, 8);
            this.btnallitem12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem12.Name = "btnallitem12";
            this.btnallitem12.Size = new System.Drawing.Size(230, 114);
            this.btnallitem12.TabIndex = 1;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(10, 134);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(192, 38);
            this.label37.TabIndex = 1;
            this.label37.Text = "Kopiko Blanca Creamy \r\nCoffee Twin Pack\r\n";
            // 
            // guna2Panel13
            // 
            this.guna2Panel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel13.BorderRadius = 10;
            this.guna2Panel13.Controls.Add(this.label38);
            this.guna2Panel13.Controls.Add(this.label39);
            this.guna2Panel13.Controls.Add(this.btnallitem13);
            this.guna2Panel13.Controls.Add(this.label40);
            this.guna2Panel13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel13.Location = new System.Drawing.Point(20, 1080);
            this.guna2Panel13.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel13.Name = "guna2Panel13";
            this.guna2Panel13.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel13.TabIndex = 12;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(109, 210);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(56, 24);
            this.label38.TabIndex = 3;
            this.label38.Text = "/ 53g";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(10, 205);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(106, 33);
            this.label39.TabIndex = 2;
            this.label39.Text = "₱12.85";
            // 
            // btnallitem13
            // 
            this.btnallitem13.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem13.BorderRadius = 5;
            this.btnallitem13.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem13.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem13.ForeColor = System.Drawing.Color.White;
            this.btnallitem13.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem13.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem13.Image")));
            this.btnallitem13.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem13.Location = new System.Drawing.Point(10, 8);
            this.btnallitem13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem13.Name = "btnallitem13";
            this.btnallitem13.Size = new System.Drawing.Size(230, 114);
            this.btnallitem13.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(10, 134);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(222, 38);
            this.label40.TabIndex = 1;
            this.label40.Text = "Kopiko Brown Coffee Twin \r\nPack";
            // 
            // guna2Panel14
            // 
            this.guna2Panel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel14.BorderRadius = 10;
            this.guna2Panel14.Controls.Add(this.label41);
            this.guna2Panel14.Controls.Add(this.label42);
            this.guna2Panel14.Controls.Add(this.btnallitem14);
            this.guna2Panel14.Controls.Add(this.label43);
            this.guna2Panel14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel14.Location = new System.Drawing.Point(293, 1080);
            this.guna2Panel14.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel14.Name = "guna2Panel14";
            this.guna2Panel14.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel14.TabIndex = 13;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(109, 210);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(56, 24);
            this.label41.TabIndex = 3;
            this.label41.Text = "/ 10L";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(10, 205);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(106, 33);
            this.label42.TabIndex = 2;
            this.label42.Text = "₱98.55";
            // 
            // btnallitem14
            // 
            this.btnallitem14.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem14.BorderRadius = 5;
            this.btnallitem14.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem14.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem14.ForeColor = System.Drawing.Color.White;
            this.btnallitem14.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem14.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem14.Image")));
            this.btnallitem14.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem14.Location = new System.Drawing.Point(10, 8);
            this.btnallitem14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem14.Name = "btnallitem14";
            this.btnallitem14.Size = new System.Drawing.Size(230, 114);
            this.btnallitem14.TabIndex = 1;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(10, 134);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(204, 38);
            this.label43.TabIndex = 1;
            this.label43.Text = "Nature\'s Spring Distilled \r\nWater";
            // 
            // guna2Panel15
            // 
            this.guna2Panel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel15.BorderRadius = 10;
            this.guna2Panel15.Controls.Add(this.label44);
            this.guna2Panel15.Controls.Add(this.label45);
            this.guna2Panel15.Controls.Add(this.btnallitem15);
            this.guna2Panel15.Controls.Add(this.label46);
            this.guna2Panel15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel15.Location = new System.Drawing.Point(566, 1080);
            this.guna2Panel15.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel15.Name = "guna2Panel15";
            this.guna2Panel15.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel15.TabIndex = 14;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(109, 210);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(62, 24);
            this.label44.TabIndex = 3;
            this.label44.Text = "/ 1.5L";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(10, 205);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(106, 33);
            this.label45.TabIndex = 2;
            this.label45.Text = "₱71.65";
            // 
            // btnallitem15
            // 
            this.btnallitem15.BackColor = System.Drawing.Color.Transparent;
            this.btnallitem15.BorderRadius = 5;
            this.btnallitem15.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnallitem15.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnallitem15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnallitem15.ForeColor = System.Drawing.Color.White;
            this.btnallitem15.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnallitem15.Image = ((System.Drawing.Image)(resources.GetObject("btnallitem15.Image")));
            this.btnallitem15.ImageSize = new System.Drawing.Size(230, 142);
            this.btnallitem15.Location = new System.Drawing.Point(10, 8);
            this.btnallitem15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnallitem15.Name = "btnallitem15";
            this.btnallitem15.Size = new System.Drawing.Size(230, 114);
            this.btnallitem15.TabIndex = 1;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(10, 142);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(122, 19);
            this.label46.TabIndex = 1;
            this.label46.Text = "Sprite Regular";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(853, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Canned";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.guna2Panel16);
            this.flowLayoutPanel2.Controls.Add(this.guna2Panel17);
            this.flowLayoutPanel2.Controls.Add(this.guna2Panel18);
            this.flowLayoutPanel2.Controls.Add(this.guna2Panel19);
            this.flowLayoutPanel2.Controls.Add(this.guna2Panel20);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(847, 467);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // guna2Panel16
            // 
            this.guna2Panel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel16.BorderRadius = 10;
            this.guna2Panel16.Controls.Add(this.label48);
            this.guna2Panel16.Controls.Add(this.label49);
            this.guna2Panel16.Controls.Add(this.btncanned1);
            this.guna2Panel16.Controls.Add(this.label47);
            this.guna2Panel16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel16.Location = new System.Drawing.Point(20, 16);
            this.guna2Panel16.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel16.Name = "guna2Panel16";
            this.guna2Panel16.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel16.TabIndex = 3;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(109, 210);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(77, 24);
            this.label48.TabIndex = 3;
            this.label48.Text = "/ 240ml";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(10, 205);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(106, 33);
            this.label49.TabIndex = 2;
            this.label49.Text = "₱33.15";
            // 
            // btncanned1
            // 
            this.btncanned1.BackColor = System.Drawing.Color.Transparent;
            this.btncanned1.BorderRadius = 5;
            this.btncanned1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btncanned1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btncanned1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncanned1.ForeColor = System.Drawing.Color.White;
            this.btncanned1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned1.Image = ((System.Drawing.Image)(resources.GetObject("btncanned1.Image")));
            this.btncanned1.ImageSize = new System.Drawing.Size(230, 142);
            this.btncanned1.Location = new System.Drawing.Point(10, 8);
            this.btncanned1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncanned1.Name = "btncanned1";
            this.btncanned1.Size = new System.Drawing.Size(230, 114);
            this.btncanned1.TabIndex = 1;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(10, 134);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(224, 38);
            this.label47.TabIndex = 1;
            this.label47.Text = "Dole 100% Pineapple Juice \r\nDrink Unsweetened";
            // 
            // guna2Panel17
            // 
            this.guna2Panel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel17.BorderRadius = 10;
            this.guna2Panel17.Controls.Add(this.label51);
            this.guna2Panel17.Controls.Add(this.label52);
            this.guna2Panel17.Controls.Add(this.btncanned2);
            this.guna2Panel17.Controls.Add(this.label50);
            this.guna2Panel17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel17.Location = new System.Drawing.Point(293, 16);
            this.guna2Panel17.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel17.Name = "guna2Panel17";
            this.guna2Panel17.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel17.TabIndex = 4;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(109, 210);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(67, 24);
            this.label51.TabIndex = 3;
            this.label51.Text = "/ 155g";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(10, 205);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(106, 33);
            this.label52.TabIndex = 2;
            this.label52.Text = "₱23.90";
            // 
            // btncanned2
            // 
            this.btncanned2.BackColor = System.Drawing.Color.Transparent;
            this.btncanned2.BorderRadius = 5;
            this.btncanned2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btncanned2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btncanned2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncanned2.ForeColor = System.Drawing.Color.White;
            this.btncanned2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned2.Image = ((System.Drawing.Image)(resources.GetObject("btncanned2.Image")));
            this.btncanned2.ImageSize = new System.Drawing.Size(230, 142);
            this.btncanned2.Location = new System.Drawing.Point(10, 8);
            this.btncanned2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncanned2.Name = "btncanned2";
            this.btncanned2.Size = new System.Drawing.Size(230, 114);
            this.btncanned2.TabIndex = 1;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(10, 134);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(197, 38);
            this.label50.TabIndex = 1;
            this.label50.Text = "Young\'s Town Sardines \r\nIn Tomato Sauce";
            // 
            // guna2Panel18
            // 
            this.guna2Panel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel18.BorderRadius = 10;
            this.guna2Panel18.Controls.Add(this.label53);
            this.guna2Panel18.Controls.Add(this.label54);
            this.guna2Panel18.Controls.Add(this.btncanned3);
            this.guna2Panel18.Controls.Add(this.label55);
            this.guna2Panel18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel18.Location = new System.Drawing.Point(566, 16);
            this.guna2Panel18.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel18.Name = "guna2Panel18";
            this.guna2Panel18.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel18.TabIndex = 5;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(109, 210);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(67, 24);
            this.label53.TabIndex = 3;
            this.label53.Text = "/ 155g";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(10, 205);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(106, 33);
            this.label54.TabIndex = 2;
            this.label54.Text = "₱24.70";
            // 
            // btncanned3
            // 
            this.btncanned3.BackColor = System.Drawing.Color.Transparent;
            this.btncanned3.BorderRadius = 5;
            this.btncanned3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btncanned3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btncanned3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncanned3.ForeColor = System.Drawing.Color.White;
            this.btncanned3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned3.Image = ((System.Drawing.Image)(resources.GetObject("btncanned3.Image")));
            this.btncanned3.ImageSize = new System.Drawing.Size(230, 142);
            this.btncanned3.Location = new System.Drawing.Point(10, 8);
            this.btncanned3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncanned3.Name = "btncanned3";
            this.btncanned3.Size = new System.Drawing.Size(230, 114);
            this.btncanned3.TabIndex = 1;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(10, 134);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(216, 57);
            this.label55.TabIndex = 1;
            this.label55.Text = "Young\'s Town Sardines In \r\nTomato Sauce With \r\nHot Chili";
            // 
            // guna2Panel19
            // 
            this.guna2Panel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel19.BorderRadius = 10;
            this.guna2Panel19.Controls.Add(this.label57);
            this.guna2Panel19.Controls.Add(this.label58);
            this.guna2Panel19.Controls.Add(this.btncanned4);
            this.guna2Panel19.Controls.Add(this.label56);
            this.guna2Panel19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel19.Location = new System.Drawing.Point(155, 282);
            this.guna2Panel19.Margin = new System.Windows.Forms.Padding(155, 16, 3, 2);
            this.guna2Panel19.Name = "guna2Panel19";
            this.guna2Panel19.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel19.TabIndex = 6;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Location = new System.Drawing.Point(109, 210);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(67, 24);
            this.label57.TabIndex = 3;
            this.label57.Text = "/ 150g";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(10, 205);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(106, 33);
            this.label58.TabIndex = 2;
            this.label58.Text = "₱34.85";
            // 
            // btncanned4
            // 
            this.btncanned4.BackColor = System.Drawing.Color.Transparent;
            this.btncanned4.BorderRadius = 5;
            this.btncanned4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btncanned4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btncanned4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncanned4.ForeColor = System.Drawing.Color.White;
            this.btncanned4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned4.Image = ((System.Drawing.Image)(resources.GetObject("btncanned4.Image")));
            this.btncanned4.ImageSize = new System.Drawing.Size(230, 142);
            this.btncanned4.Location = new System.Drawing.Point(10, 8);
            this.btncanned4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncanned4.Name = "btncanned4";
            this.btncanned4.Size = new System.Drawing.Size(230, 114);
            this.btncanned4.TabIndex = 1;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(10, 142);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(188, 19);
            this.label56.TabIndex = 1;
            this.label56.Text = "Argentina Corned Beef";
            // 
            // guna2Panel20
            // 
            this.guna2Panel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel20.BorderRadius = 10;
            this.guna2Panel20.Controls.Add(this.label60);
            this.guna2Panel20.Controls.Add(this.label61);
            this.guna2Panel20.Controls.Add(this.btncanned5);
            this.guna2Panel20.Controls.Add(this.label59);
            this.guna2Panel20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel20.Location = new System.Drawing.Point(428, 282);
            this.guna2Panel20.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel20.Name = "guna2Panel20";
            this.guna2Panel20.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel20.TabIndex = 7;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(109, 210);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(67, 24);
            this.label60.TabIndex = 3;
            this.label60.Text = "/ 155g";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.White;
            this.label61.Location = new System.Drawing.Point(10, 205);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(106, 33);
            this.label61.TabIndex = 2;
            this.label61.Text = "₱25.50";
            // 
            // btncanned5
            // 
            this.btncanned5.BackColor = System.Drawing.Color.Transparent;
            this.btncanned5.BorderRadius = 5;
            this.btncanned5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btncanned5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btncanned5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncanned5.ForeColor = System.Drawing.Color.White;
            this.btncanned5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btncanned5.Image = ((System.Drawing.Image)(resources.GetObject("btncanned5.Image")));
            this.btncanned5.ImageSize = new System.Drawing.Size(230, 142);
            this.btncanned5.Location = new System.Drawing.Point(10, 8);
            this.btncanned5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncanned5.Name = "btncanned5";
            this.btncanned5.Size = new System.Drawing.Size(230, 114);
            this.btncanned5.TabIndex = 1;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(10, 134);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(211, 38);
            this.label59.TabIndex = 1;
            this.label59.Text = "Mega Sardines In Tomato \r\nSauce";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(853, 471);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Meat";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Controls.Add(this.guna2Panel21);
            this.flowLayoutPanel3.Controls.Add(this.guna2Panel22);
            this.flowLayoutPanel3.Controls.Add(this.guna2Panel23);
            this.flowLayoutPanel3.Controls.Add(this.guna2Panel24);
            this.flowLayoutPanel3.Controls.Add(this.guna2Panel25);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(853, 471);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // guna2Panel21
            // 
            this.guna2Panel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel21.BorderRadius = 10;
            this.guna2Panel21.Controls.Add(this.label62);
            this.guna2Panel21.Controls.Add(this.label63);
            this.guna2Panel21.Controls.Add(this.btnfrozen1);
            this.guna2Panel21.Controls.Add(this.label64);
            this.guna2Panel21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel21.Location = new System.Drawing.Point(20, 16);
            this.guna2Panel21.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel21.Name = "guna2Panel21";
            this.guna2Panel21.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel21.TabIndex = 12;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(123, 210);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(56, 24);
            this.label62.TabIndex = 3;
            this.label62.Text = "/ 1kg";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(10, 205);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(122, 33);
            this.label63.TabIndex = 2;
            this.label63.Text = "₱531.65";
            // 
            // btnfrozen1
            // 
            this.btnfrozen1.BackColor = System.Drawing.Color.Transparent;
            this.btnfrozen1.BorderRadius = 5;
            this.btnfrozen1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfrozen1.ForeColor = System.Drawing.Color.White;
            this.btnfrozen1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen1.Image = ((System.Drawing.Image)(resources.GetObject("btnfrozen1.Image")));
            this.btnfrozen1.ImageSize = new System.Drawing.Size(230, 142);
            this.btnfrozen1.Location = new System.Drawing.Point(10, 8);
            this.btnfrozen1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfrozen1.Name = "btnfrozen1";
            this.btnfrozen1.Size = new System.Drawing.Size(230, 114);
            this.btnfrozen1.TabIndex = 1;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(10, 134);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(220, 38);
            this.label64.TabIndex = 1;
            this.label64.Text = "Purefoods Chicken Breast \r\nNuggets";
            // 
            // guna2Panel22
            // 
            this.guna2Panel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel22.BorderRadius = 10;
            this.guna2Panel22.Controls.Add(this.label65);
            this.guna2Panel22.Controls.Add(this.label66);
            this.guna2Panel22.Controls.Add(this.btnfrozen2);
            this.guna2Panel22.Controls.Add(this.label67);
            this.guna2Panel22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel22.Location = new System.Drawing.Point(293, 16);
            this.guna2Panel22.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel22.Name = "guna2Panel22";
            this.guna2Panel22.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel22.TabIndex = 11;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(124, 210);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(67, 24);
            this.label65.TabIndex = 3;
            this.label65.Text = "/ 320g";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(10, 205);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(122, 33);
            this.label66.TabIndex = 2;
            this.label66.Text = "₱169.75";
            // 
            // btnfrozen2
            // 
            this.btnfrozen2.BackColor = System.Drawing.Color.Transparent;
            this.btnfrozen2.BorderRadius = 5;
            this.btnfrozen2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfrozen2.ForeColor = System.Drawing.Color.White;
            this.btnfrozen2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen2.Image = ((System.Drawing.Image)(resources.GetObject("btnfrozen2.Image")));
            this.btnfrozen2.ImageSize = new System.Drawing.Size(230, 142);
            this.btnfrozen2.Location = new System.Drawing.Point(10, 8);
            this.btnfrozen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfrozen2.Name = "btnfrozen2";
            this.btnfrozen2.Size = new System.Drawing.Size(230, 114);
            this.btnfrozen2.TabIndex = 1;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(10, 134);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(234, 38);
            this.label67.TabIndex = 1;
            this.label67.Text = "Sarangani Bay Boneless \r\nMilkfish Unseasoned Medium";
            // 
            // guna2Panel23
            // 
            this.guna2Panel23.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel23.BorderRadius = 10;
            this.guna2Panel23.Controls.Add(this.label68);
            this.guna2Panel23.Controls.Add(this.label69);
            this.guna2Panel23.Controls.Add(this.btnfrozen3);
            this.guna2Panel23.Controls.Add(this.label70);
            this.guna2Panel23.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel23.Location = new System.Drawing.Point(566, 16);
            this.guna2Panel23.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel23.Name = "guna2Panel23";
            this.guna2Panel23.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel23.TabIndex = 10;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(127, 210);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(67, 24);
            this.label68.TabIndex = 3;
            this.label68.Text = "/ 200g";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(10, 205);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(122, 33);
            this.label69.TabIndex = 2;
            this.label69.Text = "₱126.00";
            // 
            // btnfrozen3
            // 
            this.btnfrozen3.BackColor = System.Drawing.Color.Transparent;
            this.btnfrozen3.BorderRadius = 5;
            this.btnfrozen3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfrozen3.ForeColor = System.Drawing.Color.White;
            this.btnfrozen3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen3.Image = ((System.Drawing.Image)(resources.GetObject("btnfrozen3.Image")));
            this.btnfrozen3.ImageSize = new System.Drawing.Size(230, 142);
            this.btnfrozen3.Location = new System.Drawing.Point(10, 8);
            this.btnfrozen3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfrozen3.Name = "btnfrozen3";
            this.btnfrozen3.Size = new System.Drawing.Size(230, 114);
            this.btnfrozen3.TabIndex = 1;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(10, 134);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(215, 38);
            this.label70.TabIndex = 1;
            this.label70.Text = "Purefoods Chicken Breast\r\nNuggets";
            // 
            // guna2Panel24
            // 
            this.guna2Panel24.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel24.BorderRadius = 10;
            this.guna2Panel24.Controls.Add(this.label71);
            this.guna2Panel24.Controls.Add(this.label72);
            this.guna2Panel24.Controls.Add(this.btnfrozen4);
            this.guna2Panel24.Controls.Add(this.label73);
            this.guna2Panel24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel24.Location = new System.Drawing.Point(155, 282);
            this.guna2Panel24.Margin = new System.Windows.Forms.Padding(155, 16, 3, 2);
            this.guna2Panel24.Name = "guna2Panel24";
            this.guna2Panel24.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel24.TabIndex = 9;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.White;
            this.label71.Location = new System.Drawing.Point(123, 210);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(56, 24);
            this.label71.TabIndex = 3;
            this.label71.Text = "/ 1kg";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(10, 205);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(122, 33);
            this.label72.TabIndex = 2;
            this.label72.Text = "₱229.95";
            // 
            // btnfrozen4
            // 
            this.btnfrozen4.BackColor = System.Drawing.Color.Transparent;
            this.btnfrozen4.BorderRadius = 5;
            this.btnfrozen4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfrozen4.ForeColor = System.Drawing.Color.White;
            this.btnfrozen4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen4.Image = ((System.Drawing.Image)(resources.GetObject("btnfrozen4.Image")));
            this.btnfrozen4.ImageSize = new System.Drawing.Size(230, 142);
            this.btnfrozen4.Location = new System.Drawing.Point(10, 8);
            this.btnfrozen4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfrozen4.Name = "btnfrozen4";
            this.btnfrozen4.Size = new System.Drawing.Size(230, 114);
            this.btnfrozen4.TabIndex = 1;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(10, 134);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(210, 38);
            this.label73.TabIndex = 1;
            this.label73.Text = "Virginia Premium Hotdog \r\nRegular";
            // 
            // guna2Panel25
            // 
            this.guna2Panel25.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel25.BorderRadius = 10;
            this.guna2Panel25.Controls.Add(this.label75);
            this.guna2Panel25.Controls.Add(this.label76);
            this.guna2Panel25.Controls.Add(this.btnfrozen5);
            this.guna2Panel25.Controls.Add(this.label74);
            this.guna2Panel25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel25.Location = new System.Drawing.Point(428, 282);
            this.guna2Panel25.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel25.Name = "guna2Panel25";
            this.guna2Panel25.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel25.TabIndex = 13;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.ForeColor = System.Drawing.Color.White;
            this.label75.Location = new System.Drawing.Point(123, 210);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(67, 24);
            this.label75.TabIndex = 3;
            this.label75.Text = "/ 220g";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(10, 205);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(122, 33);
            this.label76.TabIndex = 2;
            this.label76.Text = "₱107.20";
            // 
            // btnfrozen5
            // 
            this.btnfrozen5.BackColor = System.Drawing.Color.Transparent;
            this.btnfrozen5.BorderRadius = 5;
            this.btnfrozen5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnfrozen5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfrozen5.ForeColor = System.Drawing.Color.White;
            this.btnfrozen5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnfrozen5.Image = ((System.Drawing.Image)(resources.GetObject("btnfrozen5.Image")));
            this.btnfrozen5.ImageSize = new System.Drawing.Size(230, 142);
            this.btnfrozen5.Location = new System.Drawing.Point(10, 8);
            this.btnfrozen5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfrozen5.Name = "btnfrozen5";
            this.btnfrozen5.Size = new System.Drawing.Size(230, 114);
            this.btnfrozen5.TabIndex = 1;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(8, 142);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(172, 19);
            this.label74.TabIndex = 1;
            this.label74.Text = "Purefoods Beef Tapa";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.flowLayoutPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(853, 471);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Beverages";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.Controls.Add(this.guna2Panel26);
            this.flowLayoutPanel4.Controls.Add(this.guna2Panel27);
            this.flowLayoutPanel4.Controls.Add(this.guna2Panel28);
            this.flowLayoutPanel4.Controls.Add(this.guna2Panel29);
            this.flowLayoutPanel4.Controls.Add(this.guna2Panel30);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(853, 471);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // guna2Panel26
            // 
            this.guna2Panel26.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel26.BorderRadius = 10;
            this.guna2Panel26.Controls.Add(this.label77);
            this.guna2Panel26.Controls.Add(this.label78);
            this.guna2Panel26.Controls.Add(this.btnbeverages1);
            this.guna2Panel26.Controls.Add(this.label79);
            this.guna2Panel26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel26.Location = new System.Drawing.Point(20, 16);
            this.guna2Panel26.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel26.Name = "guna2Panel26";
            this.guna2Panel26.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel26.TabIndex = 17;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(109, 210);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(56, 24);
            this.label77.TabIndex = 3;
            this.label77.Text = "/ 53g";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.Color.White;
            this.label78.Location = new System.Drawing.Point(10, 205);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(106, 33);
            this.label78.TabIndex = 2;
            this.label78.Text = "₱12.85";
            // 
            // btnbeverages1
            // 
            this.btnbeverages1.BackColor = System.Drawing.Color.Transparent;
            this.btnbeverages1.BorderRadius = 5;
            this.btnbeverages1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbeverages1.ForeColor = System.Drawing.Color.White;
            this.btnbeverages1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages1.Image = ((System.Drawing.Image)(resources.GetObject("btnbeverages1.Image")));
            this.btnbeverages1.ImageSize = new System.Drawing.Size(230, 142);
            this.btnbeverages1.Location = new System.Drawing.Point(10, 8);
            this.btnbeverages1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbeverages1.Name = "btnbeverages1";
            this.btnbeverages1.Size = new System.Drawing.Size(230, 114);
            this.btnbeverages1.TabIndex = 1;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(10, 134);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(222, 38);
            this.label79.TabIndex = 1;
            this.label79.Text = "Kopiko Brown Coffee Twin \r\nPack";
            // 
            // guna2Panel27
            // 
            this.guna2Panel27.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel27.BorderRadius = 10;
            this.guna2Panel27.Controls.Add(this.label82);
            this.guna2Panel27.Controls.Add(this.label83);
            this.guna2Panel27.Controls.Add(this.btnbeverages2);
            this.guna2Panel27.Controls.Add(this.label84);
            this.guna2Panel27.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel27.Location = new System.Drawing.Point(293, 16);
            this.guna2Panel27.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel27.Name = "guna2Panel27";
            this.guna2Panel27.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel27.TabIndex = 15;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.ForeColor = System.Drawing.Color.White;
            this.label82.Location = new System.Drawing.Point(109, 210);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(62, 24);
            this.label82.TabIndex = 3;
            this.label82.Text = "/ 1.5L";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.ForeColor = System.Drawing.Color.White;
            this.label83.Location = new System.Drawing.Point(10, 205);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(106, 33);
            this.label83.TabIndex = 2;
            this.label83.Text = "₱71.65";
            // 
            // btnbeverages2
            // 
            this.btnbeverages2.BackColor = System.Drawing.Color.Transparent;
            this.btnbeverages2.BorderRadius = 5;
            this.btnbeverages2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbeverages2.ForeColor = System.Drawing.Color.White;
            this.btnbeverages2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages2.Image = ((System.Drawing.Image)(resources.GetObject("btnbeverages2.Image")));
            this.btnbeverages2.ImageSize = new System.Drawing.Size(230, 142);
            this.btnbeverages2.Location = new System.Drawing.Point(10, 8);
            this.btnbeverages2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbeverages2.Name = "btnbeverages2";
            this.btnbeverages2.Size = new System.Drawing.Size(230, 114);
            this.btnbeverages2.TabIndex = 1;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.ForeColor = System.Drawing.Color.White;
            this.label84.Location = new System.Drawing.Point(10, 142);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(115, 19);
            this.label84.TabIndex = 1;
            this.label84.Text = "Coke Regular";
            // 
            // guna2Panel28
            // 
            this.guna2Panel28.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel28.BorderRadius = 10;
            this.guna2Panel28.Controls.Add(this.label85);
            this.guna2Panel28.Controls.Add(this.label86);
            this.guna2Panel28.Controls.Add(this.btnbeverages3);
            this.guna2Panel28.Controls.Add(this.label87);
            this.guna2Panel28.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel28.Location = new System.Drawing.Point(566, 16);
            this.guna2Panel28.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel28.Name = "guna2Panel28";
            this.guna2Panel28.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel28.TabIndex = 18;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.ForeColor = System.Drawing.Color.White;
            this.label85.Location = new System.Drawing.Point(109, 210);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(56, 24);
            this.label85.TabIndex = 3;
            this.label85.Text = "/ 10L";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.ForeColor = System.Drawing.Color.White;
            this.label86.Location = new System.Drawing.Point(10, 205);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(106, 33);
            this.label86.TabIndex = 2;
            this.label86.Text = "₱98.55";
            // 
            // btnbeverages3
            // 
            this.btnbeverages3.BackColor = System.Drawing.Color.Transparent;
            this.btnbeverages3.BorderRadius = 5;
            this.btnbeverages3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbeverages3.ForeColor = System.Drawing.Color.White;
            this.btnbeverages3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages3.Image = ((System.Drawing.Image)(resources.GetObject("btnbeverages3.Image")));
            this.btnbeverages3.ImageSize = new System.Drawing.Size(230, 142);
            this.btnbeverages3.Location = new System.Drawing.Point(10, 8);
            this.btnbeverages3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbeverages3.Name = "btnbeverages3";
            this.btnbeverages3.Size = new System.Drawing.Size(230, 114);
            this.btnbeverages3.TabIndex = 1;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.ForeColor = System.Drawing.Color.White;
            this.label87.Location = new System.Drawing.Point(10, 134);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(204, 38);
            this.label87.TabIndex = 1;
            this.label87.Text = "Nature\'s Spring Distilled \r\nWater";
            // 
            // guna2Panel29
            // 
            this.guna2Panel29.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel29.BorderRadius = 10;
            this.guna2Panel29.Controls.Add(this.label88);
            this.guna2Panel29.Controls.Add(this.label89);
            this.guna2Panel29.Controls.Add(this.btnbeverages4);
            this.guna2Panel29.Controls.Add(this.label90);
            this.guna2Panel29.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel29.Location = new System.Drawing.Point(155, 282);
            this.guna2Panel29.Margin = new System.Windows.Forms.Padding(155, 16, 3, 2);
            this.guna2Panel29.Name = "guna2Panel29";
            this.guna2Panel29.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel29.TabIndex = 16;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.ForeColor = System.Drawing.Color.White;
            this.label88.Location = new System.Drawing.Point(109, 210);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(56, 24);
            this.label88.TabIndex = 3;
            this.label88.Text = "/ 58g";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.Color.White;
            this.label89.Location = new System.Drawing.Point(10, 205);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(106, 33);
            this.label89.TabIndex = 2;
            this.label89.Text = "₱13.00";
            // 
            // btnbeverages4
            // 
            this.btnbeverages4.BackColor = System.Drawing.Color.Transparent;
            this.btnbeverages4.BorderRadius = 5;
            this.btnbeverages4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbeverages4.ForeColor = System.Drawing.Color.White;
            this.btnbeverages4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages4.Image = ((System.Drawing.Image)(resources.GetObject("btnbeverages4.Image")));
            this.btnbeverages4.ImageSize = new System.Drawing.Size(230, 142);
            this.btnbeverages4.Location = new System.Drawing.Point(10, 8);
            this.btnbeverages4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbeverages4.Name = "btnbeverages4";
            this.btnbeverages4.Size = new System.Drawing.Size(230, 114);
            this.btnbeverages4.TabIndex = 1;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.ForeColor = System.Drawing.Color.White;
            this.label90.Location = new System.Drawing.Point(10, 134);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(192, 38);
            this.label90.TabIndex = 1;
            this.label90.Text = "Kopiko Blanca Creamy \r\nCoffee Twin Pack\r\n";
            // 
            // guna2Panel30
            // 
            this.guna2Panel30.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel30.BorderRadius = 10;
            this.guna2Panel30.Controls.Add(this.label91);
            this.guna2Panel30.Controls.Add(this.label80);
            this.guna2Panel30.Controls.Add(this.btnbeverages5);
            this.guna2Panel30.Controls.Add(this.label81);
            this.guna2Panel30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Panel30.Location = new System.Drawing.Point(428, 282);
            this.guna2Panel30.Margin = new System.Windows.Forms.Padding(20, 16, 3, 2);
            this.guna2Panel30.Name = "guna2Panel30";
            this.guna2Panel30.Size = new System.Drawing.Size(250, 248);
            this.guna2Panel30.TabIndex = 19;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.ForeColor = System.Drawing.Color.White;
            this.label91.Location = new System.Drawing.Point(109, 210);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(62, 24);
            this.label91.TabIndex = 3;
            this.label91.Text = "/ 1.5L";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(10, 205);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(106, 33);
            this.label80.TabIndex = 2;
            this.label80.Text = "₱71.65";
            // 
            // btnbeverages5
            // 
            this.btnbeverages5.BackColor = System.Drawing.Color.Transparent;
            this.btnbeverages5.BorderRadius = 5;
            this.btnbeverages5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnbeverages5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbeverages5.ForeColor = System.Drawing.Color.White;
            this.btnbeverages5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.btnbeverages5.Image = ((System.Drawing.Image)(resources.GetObject("btnbeverages5.Image")));
            this.btnbeverages5.ImageSize = new System.Drawing.Size(230, 142);
            this.btnbeverages5.Location = new System.Drawing.Point(10, 8);
            this.btnbeverages5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbeverages5.Name = "btnbeverages5";
            this.btnbeverages5.Size = new System.Drawing.Size(230, 114);
            this.btnbeverages5.TabIndex = 1;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.ForeColor = System.Drawing.Color.White;
            this.label81.Location = new System.Drawing.Point(10, 142);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(122, 19);
            this.label81.TabIndex = 1;
            this.label81.Text = "Sprite Regular";
            // 
            // LoadAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 690);
            this.Controls.Add(this.HomeCenterpanel);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnallitem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoadAdminHome";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.HomeCenterpanel.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel9.PerformLayout();
            this.guna2Panel10.ResumeLayout(false);
            this.guna2Panel10.PerformLayout();
            this.guna2Panel11.ResumeLayout(false);
            this.guna2Panel11.PerformLayout();
            this.guna2Panel12.ResumeLayout(false);
            this.guna2Panel12.PerformLayout();
            this.guna2Panel13.ResumeLayout(false);
            this.guna2Panel13.PerformLayout();
            this.guna2Panel14.ResumeLayout(false);
            this.guna2Panel14.PerformLayout();
            this.guna2Panel15.ResumeLayout(false);
            this.guna2Panel15.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.guna2Panel16.ResumeLayout(false);
            this.guna2Panel16.PerformLayout();
            this.guna2Panel17.ResumeLayout(false);
            this.guna2Panel17.PerformLayout();
            this.guna2Panel18.ResumeLayout(false);
            this.guna2Panel18.PerformLayout();
            this.guna2Panel19.ResumeLayout(false);
            this.guna2Panel19.PerformLayout();
            this.guna2Panel20.ResumeLayout(false);
            this.guna2Panel20.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.guna2Panel21.ResumeLayout(false);
            this.guna2Panel21.PerformLayout();
            this.guna2Panel22.ResumeLayout(false);
            this.guna2Panel22.PerformLayout();
            this.guna2Panel23.ResumeLayout(false);
            this.guna2Panel23.PerformLayout();
            this.guna2Panel24.ResumeLayout(false);
            this.guna2Panel24.PerformLayout();
            this.guna2Panel25.ResumeLayout(false);
            this.guna2Panel25.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.guna2Panel26.ResumeLayout(false);
            this.guna2Panel26.PerformLayout();
            this.guna2Panel27.ResumeLayout(false);
            this.guna2Panel27.PerformLayout();
            this.guna2Panel28.ResumeLayout(false);
            this.guna2Panel28.PerformLayout();
            this.guna2Panel29.ResumeLayout(false);
            this.guna2Panel29.PerformLayout();
            this.guna2Panel30.ResumeLayout(false);
            this.guna2Panel30.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnallitem;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Panel HomeCenterpanel;
        private Guna.UI2.WinForms.Guna2TabControl TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Guna.UI2.WinForms.Guna2Button btnallitem1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button btnallitem2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Label label8;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button btnallitem3;
        private Label label10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Label label11;
        private Label label12;
        private Guna.UI2.WinForms.Guna2Button btnallitem4;
        private Label label13;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Label label14;
        private Label label15;
        private Guna.UI2.WinForms.Guna2Button btnallitem5;
        private Label label16;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Label label17;
        private Label label18;
        private Guna.UI2.WinForms.Guna2Button btnallitem6;
        private Label label19;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Label label20;
        private Label label21;
        private Guna.UI2.WinForms.Guna2Button btnallitem7;
        private Label label22;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Label label23;
        private Label label24;
        private Guna.UI2.WinForms.Guna2Button btnallitem8;
        private Label label25;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Label label26;
        private Label label27;
        private Guna.UI2.WinForms.Guna2Button btnallitem9;
        private Label label28;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Label label29;
        private Label label30;
        private Guna.UI2.WinForms.Guna2Button btnallitem10;
        private Label label31;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Label label32;
        private Label label33;
        private Guna.UI2.WinForms.Guna2Button btnallitem11;
        private Label label34;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
        private Label label35;
        private Label label36;
        private Guna.UI2.WinForms.Guna2Button btnallitem12;
        private Label label37;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel13;
        private Label label38;
        private Label label39;
        private Guna.UI2.WinForms.Guna2Button btnallitem13;
        private Label label40;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel14;
        private Label label41;
        private Label label42;
        private Guna.UI2.WinForms.Guna2Button btnallitem14;
        private Label label43;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel15;
        private Label label44;
        private Label label45;
        private Guna.UI2.WinForms.Guna2Button btnallitem15;
        private Label label46;
        private FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel16;
        private Label label48;
        private Label label49;
        private Guna.UI2.WinForms.Guna2Button btncanned1;
        private Label label47;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel17;
        private Label label51;
        private Label label52;
        private Guna.UI2.WinForms.Guna2Button btncanned2;
        private Label label50;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel18;
        private Label label53;
        private Label label54;
        private Guna.UI2.WinForms.Guna2Button btncanned3;
        private Label label55;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel19;
        private Label label57;
        private Label label58;
        private Guna.UI2.WinForms.Guna2Button btncanned4;
        private Label label56;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel20;
        private Label label60;
        private Label label61;
        private Guna.UI2.WinForms.Guna2Button btncanned5;
        private Label label59;
        private FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel21;
        private Label label62;
        private Label label63;
        private Guna.UI2.WinForms.Guna2Button btnfrozen1;
        private Label label64;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel22;
        private Label label65;
        private Label label66;
        private Guna.UI2.WinForms.Guna2Button btnfrozen2;
        private Label label67;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel23;
        private Label label68;
        private Label label69;
        private Guna.UI2.WinForms.Guna2Button btnfrozen3;
        private Label label70;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel24;
        private Label label71;
        private Label label72;
        private Guna.UI2.WinForms.Guna2Button btnfrozen4;
        private Label label73;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel25;
        private Label label75;
        private Label label76;
        private Guna.UI2.WinForms.Guna2Button btnfrozen5;
        private Label label74;
        private FlowLayoutPanel flowLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel26;
        private Label label77;
        private Label label78;
        private Guna.UI2.WinForms.Guna2Button btnbeverages1;
        private Label label79;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel27;
        private Label label82;
        private Label label83;
        private Guna.UI2.WinForms.Guna2Button btnbeverages2;
        private Label label84;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel28;
        private Label label85;
        private Label label86;
        private Guna.UI2.WinForms.Guna2Button btnbeverages3;
        private Label label87;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel29;
        private Label label88;
        private Label label89;
        private Guna.UI2.WinForms.Guna2Button btnbeverages4;
        private Label label90;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel30;
        private Label label91;
        private Label label80;
        private Guna.UI2.WinForms.Guna2Button btnbeverages5;
        private Label label81;
        private DataGridView dataGridViewItems;
        private DataGridViewTextBoxColumn columnItemName;
        private DataGridViewTextBoxColumn columnItemPrice;
        private DataGridViewTextBoxColumn columnItemQuantity;
        private Label totalLabel;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private ComboBox paymentComboBox;
        private Label label92;
        private ComboBox deliveryComboBox;
        private Label label93;
        private TextBox paymentTextBox;
        private Label lblPaymentMethod;
        private Guna.UI2.WinForms.Guna2Button payButton;
    }
}