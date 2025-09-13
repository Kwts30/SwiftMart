namespace SwiftMart_Final
{
    partial class AdminMenu
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menuPanel = new SwiftMart.RoundedPanel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SwiftMartIcon = new System.Windows.Forms.PictureBox();
            this.CustomersBtn = new System.Windows.Forms.Button();
            this.ItemBtn = new System.Windows.Forms.Button();
            this.AdminIcon = new System.Windows.Forms.PictureBox();
            this.titlePanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwiftMartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.titlePanel.Controls.Add(this.TitleLabel);
            this.titlePanel.Controls.Add(this.SwiftMartIcon);
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(246, 68);
            this.titlePanel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(78, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(106, 26);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "SwiftMart";
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(232, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1092, 872);
            this.panelContainer.TabIndex = 2;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.menuPanel.BorderColor = System.Drawing.SystemColors.Control;
            this.menuPanel.BorderSize = 0;
            this.menuPanel.Controls.Add(this.LogOutBtn);
            this.menuPanel.Controls.Add(this.CustomersBtn);
            this.menuPanel.Controls.Add(this.ItemBtn);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.AdminIcon);
            this.menuPanel.ForeColor = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(-18, 30);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(264, 845);
            this.menuPanel.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LogOutBtn.Image = global::SwiftMart_Final.Properties.Resources.LogoutIcon;
            this.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.Location = new System.Drawing.Point(35, 738);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(209, 83);
            this.LogOutBtn.TabIndex = 21;
            this.LogOutBtn.Text = "     Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome, \r\nAdmin!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SwiftMartIcon
            // 
            this.SwiftMartIcon.Image = global::SwiftMart_Final.Properties.Resources.SwiftMart_Icon;
            this.SwiftMartIcon.InitialImage = null;
            this.SwiftMartIcon.Location = new System.Drawing.Point(12, 7);
            this.SwiftMartIcon.Name = "SwiftMartIcon";
            this.SwiftMartIcon.Size = new System.Drawing.Size(56, 62);
            this.SwiftMartIcon.TabIndex = 2;
            this.SwiftMartIcon.TabStop = false;
            // 
            // CustomersBtn
            // 
            this.CustomersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.CustomersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomersBtn.FlatAppearance.BorderSize = 0;
            this.CustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomersBtn.Image = global::SwiftMart_Final.Properties.Resources.CustomersIcon;
            this.CustomersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersBtn.Location = new System.Drawing.Point(30, 410);
            this.CustomersBtn.Name = "CustomersBtn";
            this.CustomersBtn.Size = new System.Drawing.Size(209, 83);
            this.CustomersBtn.TabIndex = 19;
            this.CustomersBtn.Text = "        Customers";
            this.CustomersBtn.UseVisualStyleBackColor = false;
            this.CustomersBtn.Click += new System.EventHandler(this.CustomersBtn_Click);
            // 
            // ItemBtn
            // 
            this.ItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.ItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemBtn.FlatAppearance.BorderSize = 0;
            this.ItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ItemBtn.Image = global::SwiftMart_Final.Properties.Resources.icons8_box_64;
            this.ItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemBtn.Location = new System.Drawing.Point(35, 309);
            this.ItemBtn.Name = "ItemBtn";
            this.ItemBtn.Size = new System.Drawing.Size(209, 83);
            this.ItemBtn.TabIndex = 17;
            this.ItemBtn.Text = "   Items";
            this.ItemBtn.UseVisualStyleBackColor = false;
            this.ItemBtn.Click += new System.EventHandler(this.ItemBtn_Click);
            // 
            // AdminIcon
            // 
            this.AdminIcon.Image = global::SwiftMart_Final.Properties.Resources.AdminIcon;
            this.AdminIcon.Location = new System.Drawing.Point(35, 57);
            this.AdminIcon.Name = "AdminIcon";
            this.AdminIcon.Size = new System.Drawing.Size(80, 82);
            this.AdminIcon.TabIndex = 2;
            this.AdminIcon.TabStop = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 863);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwiftMartIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SwiftMart.RoundedPanel menuPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox SwiftMartIcon;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox AdminIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CustomersBtn;
        private System.Windows.Forms.Button ItemBtn;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button LogOutBtn;
    }
}

