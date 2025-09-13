using System.Drawing;
using System.Windows.Forms;

namespace SwiftMart_Final
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.centerpanel_MainMenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(185)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(185)))), ((int)(((byte)(90)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 690);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 690);
            this.panel2.TabIndex = 1;
            // 
            // guna2Button3
            // 
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button3.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(185)))), ((int)(((byte)(90)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button3.ImageSize = new System.Drawing.Size(75, 75);
            this.guna2Button3.Location = new System.Drawing.Point(0, 618);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(158, 73);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "LOG OUT";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 26);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(127, 147);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button5
            // 
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.guna2Button5.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(185)))), ((int)(((byte)(90)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.guna2Button5.ImageSize = new System.Drawing.Size(75, 75);
            this.guna2Button5.Location = new System.Drawing.Point(0, 870);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(217, 73);
            this.guna2Button5.TabIndex = 5;
            this.guna2Button5.Text = "LOG OUT";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnhome.Checked = true;
            this.btnhome.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.btnhome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(139)))));
            this.btnhome.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnhome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(185)))), ((int)(((byte)(90)))));
            this.btnhome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.btnhome.ImageSize = new System.Drawing.Size(75, 75);
            this.btnhome.Location = new System.Drawing.Point(0, 355);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(158, 73);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "HOME";
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // centerpanel_MainMenu
            // 
            this.centerpanel_MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerpanel_MainMenu.Location = new System.Drawing.Point(158, 0);
            this.centerpanel_MainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.centerpanel_MainMenu.Name = "centerpanel_MainMenu";
            this.centerpanel_MainMenu.Size = new System.Drawing.Size(1161, 690);
            this.centerpanel_MainMenu.TabIndex = 1;
            this.centerpanel_MainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.centerpanel_MainMenu_Paint_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 690);
            this.Controls.Add(this.centerpanel_MainMenu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Kawatskie_RoundedPanel roundedPanel2;
        private Kawatskie_RoundedPanel roundedPanel3;
        private Kawatskie_RoundedPanel roundedPanel4;
        private Kawatskie_RoundedPanel roundedPanel5;
        private Kawatskie_RoundedPanel roundedPanel6;
        private Kawatskie_RoundedPanel roundedPanel7;
        private Kawatskie_RoundedPanel roundedPanel8;
        private Kawatskie_RoundedPanel roundedPanel9;
        private Kawatskie_RoundedPanel roundedPanel10;
        private Kawatskie_RoundedPanel roundedPanel11;
        private Kawatskie_RoundedPanel roundedPanel12;
        private Kawatskie_RoundedPanel roundedPanel13;
        private Kawatskie_RoundedPanel roundedPanel14;
        private Kawatskie_RoundedPanel roundedPanel15;
        private Kawatskie_RoundedPanel roundedPanel16;
        private Kawatskie_RoundedPanel roundedPanel17;
        private Kawatskie_RoundedPanel roundedPanel18;
        private Kawatskie_RoundedPanel roundedPanel19;
        private Kawatskie_RoundedPanel roundedPanel20;
        private Kawatskie_RoundedPanel roundedPanel21;
        private Kawatskie_RoundedPanel roundedPanel22;
        private Kawatskie_RoundedPanel roundedPanel23;
        private Kawatskie_RoundedPanel roundedPanel24;
        private Kawatskie_RoundedPanel roundedPanel25;
        private Kawatskie_RoundedPanel roundedPanel26;
        private Kawatskie_RoundedPanel roundedPanel27;
        private Kawatskie_RoundedPanel roundedPanel28;
        private Kawatskie_RoundedPanel roundedPanel29;
        private Kawatskie_RoundedPanel roundedPanel30;
        private Panel panel2;
        private Panel centerpanel_MainMenu;
    }
}
