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
            accRole.Visible = false;
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
                string role = selectedRow.Cells["role"].Value.ToString();
                string birthDate = selectedRow.Cells["birth_date"].Value.ToString();
                string genderValue = selectedRow.Cells["gender"].Value.ToString(); 
                string usernameValue = selectedRow.Cells["username"].Value.ToString(); 
                string passwordValue = selectedRow.Cells["password"].Value.ToString(); 
                string emailValue = selectedRow.Cells["email_address"].Value.ToString(); 
                string phoneNumValue = selectedRow.Cells["phone_number"].Value.ToString(); 
                string addressValue = selectedRow.Cells["address"].Value.ToString();

                // Combine the names into a full name
                string FullName = $"{firstName} {middleName} {lastName}".Trim();

                UserId.Text = selectedRow.Cells["user_ID"].Value.ToString();
                fullName.Text = FullName;
                accRole.Text = role;
                birthdate.Text = birthDate;
                gender.Text = genderValue;
                username.Text = usernameValue;
                password.Text = passwordValue;
                email.Text = emailValue;
                phonenum.Text = phoneNumValue;
                address.Text = addressValue;

                UserId.Visible = true;
                fullName.Visible = true;
                accRole.Visible = true;
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
            AddUser addUser = new AddUser();
            addUser.Show();

        }

        // Edit a user
        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Check if user is selected to access the control
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Get data from the row
                DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
                string userID = selectedRow.Cells["user_ID"].Value.ToString();
                string firstName = selectedRow.Cells["first_name"].Value.ToString();
                string middleName = selectedRow.Cells["middle_name"].Value.ToString();
                string lastName = selectedRow.Cells["last_name"].Value.ToString();
                string role = selectedRow.Cells["role"].Value.ToString();
                DateTime birthDate = DateTime.Parse(selectedRow.Cells["birth_date"].Value.ToString());
                string genderValue = selectedRow.Cells["gender"].Value.ToString();
                string usernameValue = selectedRow.Cells["username"].Value.ToString();
                string passwordValue = selectedRow.Cells["password"].Value.ToString();
                string emailValue = selectedRow.Cells["email_address"].Value.ToString();
                string phoneNumValue = selectedRow.Cells["phone_number"].Value.ToString();
                string addressValue = selectedRow.Cells["address"].Value.ToString();

                string fullName = $"{firstName} {middleName} {lastName}".Trim();

                // Open the control
                EditUsers editUserControl = new EditUsers();

                // Pass the data to the control
                editUserControl.LoadUserData(userID, role, firstName, middleName, lastName, fullName, genderValue, birthDate, usernameValue, passwordValue, emailValue, phoneNumValue, addressValue);
 
                    // Ensure `Parent` is the main form or can access `LoadUserControl`
                    if (this.ParentForm is AdminMenu mainForm) // Replace `MainForm` with your main form's class name
                    {
                    mainForm.LoadEditUsers(editUserControl);
                    }
            }
            else
            {
                // If row is not selected;
                MessageBox.Show("Please select a user to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void UserId_Click(object sender, EventArgs e)
        {

        }

        private void accRole_Click(object sender, EventArgs e)
        {

        }

        private void FullNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void fullName_Click(object sender, EventArgs e)
        {

        }

        private void GenderLbl_Click(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void DOBLbl_Click(object sender, EventArgs e)
        {

        }

        private void birthdate_Click(object sender, EventArgs e)
        {

        }

        private void usernameLbl_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void passwordLbl_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void emailAddLbl_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void phonenumLbl_Click(object sender, EventArgs e)
        {

        }

        private void phonenum_Click(object sender, EventArgs e)
        {

        }

        private void addLbl_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

    


