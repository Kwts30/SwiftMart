using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftMart_Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Kawatskie\SQLEXPRESS04;Initial Catalog=POS;User ID=sa;Password=07302005");
        private void Login_Load(object sender, EventArgs e)
        {
            DateTimeLabel.Text = DateTime.Now.ToString("  hh:mm tt\nMM/dd/yyyy", CultureInfo.InvariantCulture);
        }
        // Start Date and Time Display
        private void StartDateTime_Tick(object sender, EventArgs e)
        {
            DateTimeLabel.Text = DateTime.Now.ToString("  hh:mm tt\nMM/dd/yyyy", CultureInfo.InvariantCulture);
            StartDateTime.Start();
        }
        // Login to the application
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtusername.Texts.Trim();  // User input for username
            string enteredPassword = txtpassword.Texts.Trim();  // User input for password


            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Open the connection explicitly if it's not already open
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                // Query to get the actual username and password from the database
                string query = "SELECT username, password, role FROM users WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", enteredUsername);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the username and password from the database
                            string dbUsername = reader["username"].ToString();
                            string dbPassword = reader["password"].ToString();
                            string userRole = reader["role"].ToString();

                            // Compare the entered password with the password from the database
                            if (dbPassword == enteredPassword)
                            {
                                // Login successful
                                this.Hide();
                                if (userRole == "Admin")
                                {
                                    AdminMenu adminMenu = new AdminMenu();
                                    adminMenu.ShowDialog();
                                }
                                else
                                {
                                    MainMenu mainMenu = new MainMenu();
                                    mainMenu.ShowDialog();
                                }
                            }
                        

                            else
                            {
                                // Password does not match
                                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtpassword.Focus();
                            }
                        }
                        else
                        {
                            // Username does not exist in the database
                            MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtusername.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Show detailed error message for debugging purposes
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed in the finally block
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
            // Show password
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtpassword.PasswordChar = false;
            }
            else
            {
                txtpassword.PasswordChar= true;
            }
         
        }
        // User Registration
        private void SignupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
        }
        // Exit
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DateTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitlePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
