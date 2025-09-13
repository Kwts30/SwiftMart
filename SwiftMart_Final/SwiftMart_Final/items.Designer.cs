namespace SwiftMart_Final
{
    partial class items
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.customerInfoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(24, 89);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(1032, 711);
            this.dgvItems.TabIndex = 7;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // customerInfoLbl
            // 
            this.customerInfoLbl.AutoSize = true;
            this.customerInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.customerInfoLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoLbl.ForeColor = System.Drawing.Color.Black;
            this.customerInfoLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerInfoLbl.ImageKey = "(none)";
            this.customerInfoLbl.Location = new System.Drawing.Point(433, 32);
            this.customerInfoLbl.Name = "customerInfoLbl";
            this.customerInfoLbl.Size = new System.Drawing.Size(227, 27);
            this.customerInfoLbl.TabIndex = 8;
            this.customerInfoLbl.Text = "SwiftMart Inventory";
            this.customerInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerInfoLbl);
            this.Controls.Add(this.dgvItems);
            this.Name = "items";
            this.Size = new System.Drawing.Size(1092, 872);
            this.Load += new System.EventHandler(this.items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label customerInfoLbl;
    }
}
