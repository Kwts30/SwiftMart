using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace SwiftMart_Final
{
    public partial class items : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=Kawatskie\SQLEXPRESS04;Initial Catalog=POS;User ID=sa;Password=07302005");
        public items()
        {
            InitializeComponent();
            LoadData();

            // Hide labels before selecting an item
            itemId.Visible = false;
            itemName.Visible = false;
            itemCategory.Visible = false;
            itemPrice.Visible = false;
            itemStocks.Visible = false;
            itemSold.Visible = false;

            // Set up event for item selection
            dgvItems.CellClick += dgvItems_CellContentClick_1;

        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM items";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvItems.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void items_Load(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerInfoLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvItems.Rows[e.RowIndex];

                itemId.Text = selectedRow.Cells["item_ID"].Value.ToString();
                itemName.Text = selectedRow.Cells["item_name"].Value.ToString();
                itemCategory.Text = selectedRow.Cells["item_category"].Value.ToString();
                itemPrice.Text = selectedRow.Cells["item_price"].Value.ToString();
                itemStocks.Text = selectedRow.Cells["item_stocks"].Value.ToString();
                itemSold.Text = selectedRow.Cells["item_sold"].Value.ToString();

                itemId.Visible = true;
                itemName.Visible = true;
                itemPrice.Visible = true;
                itemStocks.Visible = true;
                itemCategory.Visible = true;
                itemSold.Visible = true;
            }
        }

        private void lblitemStocks_Click(object sender, EventArgs e)
        {

        }

        private void itemStocks_Click(object sender, EventArgs e)
        {

        }

        private void lblitemSold_Click(object sender, EventArgs e)
        {

        }

        private void itemSold_Click(object sender, EventArgs e)
        {

        }
    }
}
