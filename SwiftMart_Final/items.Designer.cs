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
            this.kawatskie_RoundedPanel1 = new SwiftMart_Final.Kawatskie_RoundedPanel();
            this.customerInfoLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.itemId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblitemSold = new System.Windows.Forms.Label();
            this.itemSold = new System.Windows.Forms.Label();
            this.lblitemStocks = new System.Windows.Forms.Label();
            this.itemStocks = new System.Windows.Forms.Label();
            this.lblitemPrice = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.lblitemCategory = new System.Windows.Forms.Label();
            this.itemCategory = new System.Windows.Forms.Label();
            this.lblitemName = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.kawatskie_RoundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kawatskie_RoundedPanel1
            // 
            this.kawatskie_RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.kawatskie_RoundedPanel1.BorderRadius = 20;
            this.kawatskie_RoundedPanel1.Controls.Add(this.customerInfoLbl);
            this.kawatskie_RoundedPanel1.Controls.Add(this.pictureBox1);
            this.kawatskie_RoundedPanel1.Location = new System.Drawing.Point(13, 17);
            this.kawatskie_RoundedPanel1.Name = "kawatskie_RoundedPanel1";
            this.kawatskie_RoundedPanel1.Size = new System.Drawing.Size(282, 75);
            this.kawatskie_RoundedPanel1.TabIndex = 32;
            // 
            // customerInfoLbl
            // 
            this.customerInfoLbl.AutoSize = true;
            this.customerInfoLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.customerInfoLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoLbl.ForeColor = System.Drawing.Color.Black;
            this.customerInfoLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerInfoLbl.ImageKey = "(none)";
            this.customerInfoLbl.Location = new System.Drawing.Point(95, 19);
            this.customerInfoLbl.Name = "customerInfoLbl";
            this.customerInfoLbl.Size = new System.Drawing.Size(163, 27);
            this.customerInfoLbl.TabIndex = 4;
            this.customerInfoLbl.Text = "Inventory Info";
            this.customerInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerInfoLbl.Click += new System.EventHandler(this.customerInfoLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::SwiftMart_Final.Properties.Resources.icons8_box_64;
            this.pictureBox1.Location = new System.Drawing.Point(19, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.lblItemID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.ForeColor = System.Drawing.Color.Black;
            this.lblItemID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItemID.ImageKey = "(none)";
            this.lblItemID.Location = new System.Drawing.Point(28, 50);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(82, 24);
            this.lblItemID.TabIndex = 9;
            this.lblItemID.Text = "Item ID:";
            this.lblItemID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemId
            // 
            this.itemId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.itemId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemId.ForeColor = System.Drawing.Color.Black;
            this.itemId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemId.ImageKey = "(none)";
            this.itemId.Location = new System.Drawing.Point(191, 50);
            this.itemId.Name = "itemId";
            this.itemId.Size = new System.Drawing.Size(224, 23);
            this.itemId.TabIndex = 8;
            this.itemId.Text = "item ID";
            this.itemId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblitemSold);
            this.panel1.Controls.Add(this.itemSold);
            this.panel1.Controls.Add(this.lblitemStocks);
            this.panel1.Controls.Add(this.itemStocks);
            this.panel1.Controls.Add(this.lblitemPrice);
            this.panel1.Controls.Add(this.itemPrice);
            this.panel1.Controls.Add(this.lblitemCategory);
            this.panel1.Controls.Add(this.itemCategory);
            this.panel1.Controls.Add(this.lblitemName);
            this.panel1.Controls.Add(this.itemName);
            this.panel1.Controls.Add(this.lblItemID);
            this.panel1.Controls.Add(this.itemId);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 823);
            this.panel1.TabIndex = 37;
            // 
            // lblitemSold
            // 
            this.lblitemSold.AutoSize = true;
            this.lblitemSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.lblitemSold.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemSold.ForeColor = System.Drawing.Color.Black;
            this.lblitemSold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblitemSold.ImageKey = "(none)";
            this.lblitemSold.Location = new System.Drawing.Point(28, 353);
            this.lblitemSold.Name = "lblitemSold";
            this.lblitemSold.Size = new System.Drawing.Size(105, 24);
            this.lblitemSold.TabIndex = 43;
            this.lblitemSold.Text = "Item Sold:";
            this.lblitemSold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblitemSold.Click += new System.EventHandler(this.lblitemSold_Click);
            // 
            // itemSold
            // 
            this.itemSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.itemSold.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSold.ForeColor = System.Drawing.Color.Black;
            this.itemSold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemSold.ImageKey = "(none)";
            this.itemSold.Location = new System.Drawing.Point(191, 353);
            this.itemSold.Name = "itemSold";
            this.itemSold.Size = new System.Drawing.Size(224, 23);
            this.itemSold.TabIndex = 42;
            this.itemSold.Text = "item Sold";
            this.itemSold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemSold.Click += new System.EventHandler(this.itemSold_Click);
            // 
            // lblitemStocks
            // 
            this.lblitemStocks.AutoSize = true;
            this.lblitemStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.lblitemStocks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemStocks.ForeColor = System.Drawing.Color.Black;
            this.lblitemStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblitemStocks.ImageKey = "(none)";
            this.lblitemStocks.Location = new System.Drawing.Point(28, 300);
            this.lblitemStocks.Name = "lblitemStocks";
            this.lblitemStocks.Size = new System.Drawing.Size(128, 24);
            this.lblitemStocks.TabIndex = 41;
            this.lblitemStocks.Text = "Item Stocks:";
            this.lblitemStocks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblitemStocks.Click += new System.EventHandler(this.lblitemStocks_Click);
            // 
            // itemStocks
            // 
            this.itemStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.itemStocks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStocks.ForeColor = System.Drawing.Color.Black;
            this.itemStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemStocks.ImageKey = "(none)";
            this.itemStocks.Location = new System.Drawing.Point(191, 300);
            this.itemStocks.Name = "itemStocks";
            this.itemStocks.Size = new System.Drawing.Size(224, 23);
            this.itemStocks.TabIndex = 40;
            this.itemStocks.Text = "item Stocks";
            this.itemStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemStocks.Click += new System.EventHandler(this.itemStocks_Click);
            // 
            // lblitemPrice
            // 
            this.lblitemPrice.AutoSize = true;
            this.lblitemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.lblitemPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemPrice.ForeColor = System.Drawing.Color.Black;
            this.lblitemPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblitemPrice.ImageKey = "(none)";
            this.lblitemPrice.Location = new System.Drawing.Point(28, 246);
            this.lblitemPrice.Name = "lblitemPrice";
            this.lblitemPrice.Size = new System.Drawing.Size(111, 24);
            this.lblitemPrice.TabIndex = 39;
            this.lblitemPrice.Text = "Item Price:";
            this.lblitemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemPrice
            // 
            this.itemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.itemPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.ForeColor = System.Drawing.Color.Black;
            this.itemPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemPrice.ImageKey = "(none)";
            this.itemPrice.Location = new System.Drawing.Point(191, 246);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(224, 23);
            this.itemPrice.TabIndex = 38;
            this.itemPrice.Text = "item Price";
            this.itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblitemCategory
            // 
            this.lblitemCategory.AutoSize = true;
            this.lblitemCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.lblitemCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemCategory.ForeColor = System.Drawing.Color.Black;
            this.lblitemCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblitemCategory.ImageKey = "(none)";
            this.lblitemCategory.Location = new System.Drawing.Point(28, 199);
            this.lblitemCategory.Name = "lblitemCategory";
            this.lblitemCategory.Size = new System.Drawing.Size(149, 24);
            this.lblitemCategory.TabIndex = 37;
            this.lblitemCategory.Text = "Item Category:";
            this.lblitemCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblitemCategory.Click += new System.EventHandler(this.label2_Click);
            // 
            // itemCategory
            // 
            this.itemCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.itemCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCategory.ForeColor = System.Drawing.Color.Black;
            this.itemCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemCategory.ImageKey = "(none)";
            this.itemCategory.Location = new System.Drawing.Point(191, 199);
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.Size = new System.Drawing.Size(224, 23);
            this.itemCategory.TabIndex = 36;
            this.itemCategory.Text = "item Category";
            this.itemCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemCategory.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblitemName
            // 
            this.lblitemName.AutoSize = true;
            this.lblitemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.lblitemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemName.ForeColor = System.Drawing.Color.Black;
            this.lblitemName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblitemName.ImageKey = "(none)";
            this.lblitemName.Location = new System.Drawing.Point(28, 96);
            this.lblitemName.Name = "lblitemName";
            this.lblitemName.Size = new System.Drawing.Size(116, 24);
            this.lblitemName.TabIndex = 35;
            this.lblitemName.Text = "Item Name:";
            this.lblitemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemName
            // 
            this.itemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.itemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.ForeColor = System.Drawing.Color.Black;
            this.itemName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemName.ImageKey = "(none)";
            this.itemName.Location = new System.Drawing.Point(191, 96);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(248, 90);
            this.itemName.TabIndex = 34;
            this.itemName.Text = "item Name";
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(470, 66);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(609, 784);
            this.dgvItems.TabIndex = 35;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick_1);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.titlePanel.Controls.Add(this.kawatskie_RoundedPanel1);
            this.titlePanel.Location = new System.Drawing.Point(0, -8);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1092, 68);
            this.titlePanel.TabIndex = 36;
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.titlePanel);
            this.Name = "items";
            this.Size = new System.Drawing.Size(1092, 872);
            this.Load += new System.EventHandler(this.items_Load);
            this.kawatskie_RoundedPanel1.ResumeLayout(false);
            this.kawatskie_RoundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Kawatskie_RoundedPanel kawatskie_RoundedPanel1;
        private System.Windows.Forms.Label customerInfoLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label itemId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblitemCategory;
        private System.Windows.Forms.Label itemCategory;
        private System.Windows.Forms.Label lblitemName;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label lblitemSold;
        private System.Windows.Forms.Label itemSold;
        private System.Windows.Forms.Label lblitemStocks;
        private System.Windows.Forms.Label itemStocks;
        private System.Windows.Forms.Label lblitemPrice;
        private System.Windows.Forms.Label itemPrice;
    }
}
