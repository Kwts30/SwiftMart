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

namespace SwiftMart_Final
{
    public partial class UsersInfo : UserControl
    {
        public UsersInfo()
        {
            InitializeComponent();
            LoadData();

            // Hide texts before loading data
            UserId.Visible = false;
            fullName.Visible = false;
            birthdate.Visible = false;
            gender.Visible = false;
            username.Visible = false;
            password.Visible = false;
            email.Visible = false;
            phonenum.Visible = false;
            address.Visible = false;

            // Events
            dgvUsers.CellClick += DgvUsers_CellClick;
        }

        private SqlConnection conn = new SqlConnection(@"Data Source=Kawatskie\SQLEXPRESS04;Initial Catalog=POS;User ID=sa;Password=07302005");
        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvUsers.DataSource = dataTable;
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
        // Display user info
        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvUsers.Rows[e.RowIndex];

                // Retrieve the values from the selected row
                string firstName = selectedRow.Cells["first_name"].Value.ToString();
                string middleName = selectedRow.Cells["middle_name"].Value.ToString();
                string lastName = selectedRow.Cells["last_name"].Value.ToString();
                string birthDate = selectedRow.Cells["birth_date"].Value.ToString(); // Replace with your actual column name
                string genderValue = selectedRow.Cells["gender"].Value.ToString(); // Replace with your actual column name
                string usernameValue = selectedRow.Cells["username"].Value.ToString(); // Replace with your actual column name
                string passwordValue = selectedRow.Cells["password"].Value.ToString(); // Replace with your actual column name
                string emailValue = selectedRow.Cells["email_address"].Value.ToString(); // Replace with your actual column name
                string phoneNumValue = selectedRow.Cells["phone_number"].Value.ToString(); // Replace with your actual column name
                string addressValue = selectedRow.Cells["address"].Value.ToString(); // Replace with your actual column name

                // Combine the names into a full name
                string FullName = $"{firstName} {middleName} {lastName}".Trim();

                UserId.Text = selectedRow.Cells["user_ID"].Value.ToString();
                fullName.Text = FullName;
                birthdate.Text = birthDate;
                gender.Text = genderValue;
                username.Text = usernameValue;
                password.Text = passwordValue;
                email.Text = emailValue;
                phonenum.Text = phoneNumValue;
                address.Text = addressValue;

                UserId.Visible = true;
                fullName.Visible = true;
                birthdate.Visible = true;
                gender.Visible = true;
                username.Visible = true;
                password.Visible = true;
                email.Visible = true;
                phonenum.Visible = true;
                address.Visible = true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup Signup = new Signup(true);
            Signup.Show();
        }        
        
        // Delete a user
        private void DelUserBtn_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var selectedRow = dgvUsers.SelectedRows[0];
                string username = selectedRow.Cells["username"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(@"Data Source=Kawatskie\SQLEXPRESS04;Initial Catalog=POS;User ID=sa;Password=07302005"))
                        {
                            conn.Open();
                            string query = "DELETE FROM users WHERE username = @username";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@username", username);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData(); // Reload data to reflect changes
                                }
                                else
                                {
                                    MessageBox.Show("Error deleting user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
    


