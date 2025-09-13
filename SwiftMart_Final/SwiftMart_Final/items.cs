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
        public items()
        {
            InitializeComponent();
            LoadData();
        }
        private SqlConnection conn = new SqlConnection(@"Data Source=Kawatskie\SQLEXPRESS04;Initial Catalog=POS;User ID=sa;Password=07302005");
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
                MessageBox.Show("An error occurred: " + ex.Message);
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
    }
}
