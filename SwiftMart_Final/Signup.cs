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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftMart_Final
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
            SqlConnection conn = new SqlConnection(@"Data Source=Kawatskie\SQLEXPRESS04;Initial Catalog=POS;User ID=sa;Password=07302005");
            // Date and Time Display

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
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtPassword.PasswordChar = false;
                txtPasswordConfirm.PasswordChar = false;
            }

        }
        // Sign up new user info
        private void SignupBtn_Click(object sender, EventArgs e)
        {
            
        
        // Collecting form data
            string firstName = txtFirstName.Texts.Trim();
            string lastName = txtLastName.Texts.Trim();
            string middleName = txtMiddleName.Texts.Trim();
            string gender = cmbGender.SelectedItem?.ToString();
            string birthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd"); 
            string username = txtUsername.Texts.Trim();
            string password = txtPassword.Texts.Trim();
            string confirmpass = txtPasswordConfirm.Texts.Trim();
            string emailAddress = txtEmail.Texts.Trim();
            string phoneNumber = txtPhone.Texts.Trim();
            string address = txtAddress.Texts.Trim();
            string role = "User"; // Default role for new users

            // Validate all required fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(birthDate) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmpass) ||
                string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all required fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valid name
            if (!IsNameValid(firstName) || !IsNameValid(lastName))
            {
                MessageBox.Show("Name must be more than 1 character and contain only valid characters");
                return;
            }            
            // Valid username
            if (!IsValidUsername(username))
            {
                MessageBox.Show("Username must be more than 4 characters and valid symbols.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Unique username
            if (!IsUsernameUnique(username))
            {
                MessageBox.Show("Username already exists. Please choose another one.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Valid email
            if (!IsEmailValid(emailAddress))
            {
                MessageBox.Show("Invalid email. Please try again.", "Inavlid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // If password does not match with confirmation
            if (password != confirmpass)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // If username and pass is the same
            if (username == password)
            {
                MessageBox.Show("Username and password cannot match. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // If password does not have at least 1 uppercase letter, number and symbol
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one number, and one symbol.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }
        // Info input requirements

        private bool IsNameValid(string name)
        {
            // letters, spaces, hyphens, apostrophe only
           bool hasValidInput = Regex.IsMatch(name, @"^[a-zA-Z\s'-]+$");

            // length
            if (name.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsValidUsername(string username)
        {
            // only allow letters, nums and underscores.
            bool hasValidChars = Regex.IsMatch(username, @"^[a-zA-Z0-9_]{3,15}$");
            if (username.Length > 1)
            {
                return true;
            }
            else
            {
                 return false;
            }
        }
        private bool IsValidPassword(string password)
        {
            // Check for at least one uppercase letter
            bool hasUppercase = Regex.IsMatch(password, "[A-Z]");
            // Check for at least one digit
            bool hasDigit = Regex.IsMatch(password, "[0-9]");
            // Check for at least one symbol
            bool hasSymbol = Regex.IsMatch(password, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]");

            // Return true if all conditions are met
            return hasUppercase && hasDigit && hasSymbol;
        }
        private bool IsUsernameUnique(string username)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Kawatskie\SQLEXPRESS04;Initial Catalog=POS;User ID=sa;Password=07302005"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count == 0; // If 0, the username is unique

                }
            }
        }
        private bool IsEmailValid(string email)
        { 
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
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
