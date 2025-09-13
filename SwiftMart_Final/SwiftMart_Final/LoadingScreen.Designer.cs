namespace SwiftMart_Final
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.AppLogo = new System.Windows.Forms.PictureBox();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // AppLogo
            // 
            this.AppLogo.Image = ((System.Drawing.Image)(resources.GetObject("AppLogo.Image")));
            this.AppLogo.Location = new System.Drawing.Point(396, 118);
            this.AppLogo.Name = "AppLogo";
            this.AppLogo.Size = new System.Drawing.Size(526, 626);
            this.AppLogo.TabIndex = 0;
            this.AppLogo.TabStop = false;
            this.AppLogo.UseWaitCursor = true;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 3500;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 863);
            this.Controls.Add(this.AppLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AppLogo;
        private System.Windows.Forms.Timer LoadingTimer;
    }
}