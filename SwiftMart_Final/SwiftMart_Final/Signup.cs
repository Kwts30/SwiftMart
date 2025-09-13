using SwiftMart_Final;
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
    public partial class Signup : Form
    {
        public Signup(bool ShowBackButton = false, bool accessedFromAdminMenu = false)
        {
            InitializeComponent();
            BackBtn.Visible = ShowBackButton;
            this.accessedFromAdminMenu = accessedFromAdminMenu;
        }
        private bool accessedFromAdminMenu;
        // Date and Time Display
        SqlConnection conn = new SqlConnection(@"Data Source=DMC\SQLEXPRESS;Initial Catalog=user;User ID=sa;Password=swiftmartadmin");
        private void Signup_Load(object sender, EventArgs e)
        {
           DateTimeLabel.Text = DateTime.Now.ToString("  hh:mm tt\nMM/dd/yyyy", CultureInfo.InvariantCulture);

        }
        // Start date and time display
        private void StartDateTime_Tick(object sender, EventArgs e)
        {
            DateTimeLabel.Text = DateTime.Now.ToString("  hh:mm tt\nMM/dd/yyyy", CultureInfo.InvariantCulture);
            StartDateTime.Start();
        }

        public bool ShowBackButton
        {
            get => BackBtn.Visible;
            set => BackBtn.Visible = value;
        }
        // Sign up new user info
        private void SignupBtn_Click(object sender, EventArgs e)
        {
            
        
        // Collecting form data
        string firstName = txtFirstName.Texts.Trim();
            string lastName = txtLastName.Texts.Trim();
            string middleName = txtMiddleName.Texts.Trim();
            string gender = cmbGender.SelectedItem?.ToString(); // Assuming a ComboBox for gender
            string birthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd"); // Assuming a DateTimePicker for birth date
            string username = txtUsername.Texts.Trim();
            string password = txtPassword.Texts.Trim();
            string emailAddress = txtEmail.Texts.Trim();
            string phoneNumber = txtPhone.Texts.Trim();
            string address = txtAddress.Texts.Trim();
            string role = "User"; // Default role for new users

            // Validate all required fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(birthDate) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all required fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if terms of service checkbox is ticked
            if (!chkTerms.Checked)
            {
                MessageBox.Show("Please accept the terms of service to register.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Open connection
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                // Check if username already exists
                string checkUserQuery = "SELECT COUNT(1) FROM users WHERE username = @username";
                using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int userExists = (int)checkCmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert new user into the database
                string insertUserQuery = @"INSERT INTO users (username, password, first_name, last_name, middle_name, gender, birth_date, 
                                           phone_number, email_address, address, role) 
                                           VALUES (@username, @password, @first_name, @last_name, @middle_name, @gender, @birth_date, 
                                           @phone_number, @email_address, @address, @role)";
                using (SqlCommand insertCmd = new SqlCommand(insertUserQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password); // Consider hashing passwords in production
                    insertCmd.Parameters.AddWithValue("@first_name", firstName);
                    insertCmd.Parameters.AddWithValue("@last_name", lastName);
                    insertCmd.Parameters.AddWithValue("@middle_name", string.IsNullOrEmpty(middleName) ? (object)DBNull.Value : middleName); // Optional field
                    insertCmd.Parameters.AddWithValue("@gender", gender);
                    insertCmd.Parameters.AddWithValue("@birth_date", birthDate);
                    insertCmd.Parameters.AddWithValue("@phone_number", phoneNumber);
                    insertCmd.Parameters.AddWithValue("@email_address", emailAddress);
                    insertCmd.Parameters.AddWithValue("@address", address);
                    insertCmd.Parameters.AddWithValue("@role", role);

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            bool userAddedSuccessfully = true;

            if (userAddedSuccessfully) // If user was added successfully
            {
                MessageBox.Show("User signed up successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Check if accessed from Admin Menu
                if (accessedFromAdminMenu)
                {
                    this.Hide(); // Hide the sign-up form
                    AdminMenu adminMenu = new AdminMenu(); // Create instance of the Admin Menu
                    adminMenu.Show(); // Show the Admin Menu
                }
                else
                {
                    this.Close(); // Close the sign-up form if not accessed from admin menu
                }
            }
            else
            {
                MessageBox.Show("Sign-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Login page
        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }
        // Exit
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.ShowDialog();
        }
    }
}
