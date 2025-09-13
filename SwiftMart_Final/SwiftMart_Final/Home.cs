using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;


namespace SwiftMart_Final
{
    public partial class Home : Form
    {
        private readonly string connectionString = "Data Source=Kawatskie\\SQLEXPRESS04;Initial Catalog=POS;User ID=sa;Password=07302005";
        private Dictionary<string, int> itemStocks = new Dictionary<string, int>();
        public Home()
        {
            InitializeComponent();

            btnallitem1.Tag = "Dole 100% Pineapple Juice \r\nDrink Unsweetened 240ml";
            btnallitem1.Click += ItemButton_Click;

            btnallitem2.Tag = "Young's Town Sardines \r\nIn Tomato Sauce 155g";
            btnallitem2.Click += ItemButton_Click;

            btnallitem3.Tag = "Young's Town Sardines In \r\nTomato Sauce With \r\nHot Chili 155g";
            btnallitem3.Click += ItemButton_Click;

            btnallitem4.Tag = " Argentina Corned Beef 150g";
            btnallitem4.Click += ItemButton_Click;

            btnallitem5.Tag = "Mega Sardines In Tomato \r\nSauce 155g";
            btnallitem5.Click += ItemButton_Click;

            btnallitem6.Tag = "Virginia Premium Hotdog \r\nRegular 1kg";
            btnallitem6.Click += ItemButton_Click;

            btnallitem7.Tag = "Purefoods Chicken Breast\r\nNuggets 200g";
            btnallitem7.Click += ItemButton_Click;

            btnallitem8.Tag = "Sarangani Bay Boneless \r\nMilkfish Unseasoned Medium 320g";
            btnallitem8.Click += ItemButton_Click;

            btnallitem9.Tag = "Purefoods Chicken Breast \r\nNuggets 1kg";
            btnallitem9.Click += ItemButton_Click;

            btnallitem10.Tag = "Purefoods Beef Tapa 220g";
            btnallitem10.Click += ItemButton_Click;

            btnallitem11.Tag = "Coke Regular 1L";
            btnallitem11.Click += ItemButton_Click;

            btnallitem12.Tag = "Kopiko Blanca Creamy \r\nCoffee Twin Pack\r\n 58g";
            btnallitem12.Click += ItemButton_Click;

            btnallitem13.Tag = "Kopiko Brown Coffee Twin \r\nPack 53g";
            btnallitem13.Click += ItemButton_Click;

            btnallitem14.Tag = "Nature's Spring Distilled \r\nWater 10L";
            btnallitem14.Click += ItemButton_Click;

            btnallitem15.Tag = "Sprite Regular 1L";
            btnallitem15.Click += ItemButton_Click;


            // Repeat for each item button you have
            // Example:
            // btnItem5.Tag = "Item Name Here";
            // btnItem5.Click += ItemButton_Click;
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            if (!(sender is Guna.UI2.WinForms.Guna2Button clickedButton))
            {
                MessageBox.Show("Error: Sender is not a button.");
                return;
            }

            if (clickedButton.Tag == null)
            {
                MessageBox.Show($"Error: Button '{clickedButton.Name}' does not have a Tag set.");
                return;
            }

            string itemName = clickedButton.Tag.ToString();
            decimal price = GetPriceFromDatabase(itemName);
            bool itemExists = false;

            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (row.Cells["columnItemName"].Value?.ToString() == itemName)
                {
                    // Update quantity and total price for the item
                    int currentQuantity = Convert.ToInt32(row.Cells["columnItemQuantity"].Value);
                    row.Cells["columnItemQuantity"].Value = currentQuantity + 1;
                    row.Cells["columnItemPrice"].Value = price * (currentQuantity + 1);
                    itemExists = true;
                    break;
                }
            }

            if (!itemExists)
            {
                // Add new row with quantity 1
                dataGridViewItems.Rows.Add(itemName, price, 1);
            }

            // Update total price label after adding or updating an item
            UpdateTotalPrice();
        }

        private decimal GetPriceFromDatabase(string itemName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT item_price FROM Items WHERE item_name = @ItemName", connection))
                    {
                        command.Parameters.AddWithValue("@ItemName", itemName);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching item price: " + ex.Message);
            }

            // Default price if item not found in database
            return 0.00m;
        }

        private void FetchAndDisplayItemDetails(string itemName)
        {
            const int defaultStock = 100;
            decimal price = GetPriceFromDatabase(itemName); // Fetch or assign default price per item

            // Check if item already exists in the DataGridView
            bool itemExists = false;
            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (row.Cells["columnItemName"].Value?.ToString() == itemName)
                {
                    // Increment the quantity if item already exists
                    int currentQuantity = Convert.ToInt32(row.Cells["columnItemQuantity"].Value);
                    row.Cells["columnItemQuantity"].Value = currentQuantity + 1;

                    // Update the total price for that item
                    row.Cells["columnItemPrice"].Value = price * (currentQuantity + 1);
                    itemExists = true;
                    break;
                }
            }

            // If item doesn't exist, add it with quantity 1
            if (!itemExists)
            {
                dataGridViewItems.Rows.Add(itemName, price, 1);
            }

            // Recalculate total price after any change
            UpdateTotalPrice();
        }

        // Method to calculate total price and update lbltotal
        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (row.Cells["columnItemPrice"].Value != null)
                {
                    totalPrice += Convert.ToDecimal(row.Cells["columnItemPrice"].Value);
                }
            }

            totalLabel.Text = $"Total: {totalPrice:C}"; // Format as currency
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 0;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void HomeCenterpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 1;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 2;
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 3;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {

        }

        private void btnallitem2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewItems.Rows.Clear();

            totalLabel.Text = "Total: ₱0.00";
        }

        private void cmbPaymentMethod_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (paymentComboBox.SelectedItem == null) return;

            string selectedPayment = paymentComboBox.SelectedItem.ToString();

            if (selectedPayment == "Cash")
            {
                lblPaymentMethod.Text = "Cash: ";
            }
            else if (selectedPayment == "Card" || selectedPayment == "Gcash/Maya")
            {
                lblPaymentMethod.Text = "Reference No: ";
            }
        }

        private void GenerateReceipt(decimal totalAmount, decimal paymentAmount, string deliveryMethod, string paymentMethod, decimal change)
        {
            Document document = new Document();
            Section section = document.AddSection();

            // Company Information
            section.AddParagraph("SwiftMart Inc.").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 12);
            section.AddParagraph("Trinidad Rd, maa").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
            section.AddParagraph("Davao City, 8000").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
            section.AddParagraph("Tel: 09917354106").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
            section.AddParagraph("Date: " + DateTime.Now.ToString("MM/dd/yyyy")).Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
            section.AddParagraph("----------------------------------------");

            // Receipt Title
            Paragraph title = section.AddParagraph("Receipt");
            title.Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 14);
            title.Format.Font.Bold = true;
            title.Format.SpaceAfter = "0.5cm";

            // Line separator
            section.AddParagraph("----------------------------------------");

            // List items
            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (row.Cells["columnItemName"].Value != null &&
                    row.Cells["columnItemQuantity"].Value != null &&
                    row.Cells["columnItemPrice"].Value != null)
                {
                    string itemName = row.Cells["columnItemName"].Value.ToString();
                    string quantity = row.Cells["columnItemQuantity"].Value.ToString();
                    string price = Convert.ToDecimal(row.Cells["columnItemPrice"].Value).ToString("C");

                    // Format each item as a single line
                    section.AddParagraph($"{itemName.PadRight(20)} x{quantity.PadLeft(3)} {price.PadLeft(10)}").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
                }
            }

            // Line separator
            section.AddParagraph("----------------------------------------");

            // Payment summary
            section.AddParagraph($"Total Payment:         {totalAmount:C}").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
            section.AddParagraph($"Delivery Method:       {deliveryMethod}").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
            section.AddParagraph($"Payment Method:        {paymentMethod}").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
            section.AddParagraph($"Payment Amount:        {paymentAmount:C}").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
            section.AddParagraph($"Change:                {change:C}").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);

            // Line separator and thank you message
            section.AddParagraph("----------------------------------------");
            section.AddParagraph("Thank you for shopping with SwiftMart!").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);
            section.AddParagraph("Visit us again soon!").Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 10);

            // Render the document to PDF
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();
            string filename = "Receipt.pdf";
            pdfRenderer.PdfDocument.Save(filename);

            MessageBox.Show("Receipt generated successfully!");

            // Open the generated PDF using the default PDF viewer
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = filename,
                UseShellExecute = true // Opens the file with the default associated application
            };
            Process.Start(psi);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            // Parse total amount from totalLabel.Text after removing non-numeric text
            decimal totalAmount;
            try
            {
                totalAmount = decimal.Parse(totalLabel.Text.Replace("Total: ₱", "").Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid total amount format.");
                return;
            }

            // Retrieve user-entered payment amount
            decimal paymentAmount;
            if (!decimal.TryParse(paymentTextBox.Text, out paymentAmount))
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

            // Check for insufficient payment
            if (paymentAmount < totalAmount)
            {
                MessageBox.Show("Insufficient payment. Cannot generate receipt.");
                return;
            }

            // Determine the payment method and delivery method
            string paymentMethod = paymentComboBox.SelectedItem?.ToString();
            string deliveryMethod = deliveryComboBox.SelectedItem?.ToString();

            // Calculate change
            decimal change = paymentAmount - totalAmount;

            // Display confirmation or proceed with receipt generation
            MessageBox.Show("Payment accepted. Generating receipt...");

            // Corrected method call with parameters in the right order
            GenerateReceipt(totalAmount, paymentAmount, deliveryMethod, paymentMethod, change);

            // Optionally, clear fields after successful payment
            ClearFields();
        }

        private void ClearFields()
        {
            paymentTextBox.Text = "";
            paymentComboBox.SelectedIndex = -1;
            deliveryComboBox.SelectedIndex = -1;
            totalLabel.Text = "0.00"; // Reset total label if needed
        }
    }
}
