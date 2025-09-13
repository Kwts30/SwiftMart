using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftMart_Final
{
    public partial class EditUsers : UserControl
    {
        public EditUsers()
        {
            InitializeComponent();
            LoadData();
        }

        //SQL Connection
        private SqlConnection conn = new SqlConnection(@"Data Source=Kawatskie\SQLEXPRESS04;Initial Catalog=POS;User ID=sa;Password=07302005");
        // Load table
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
        // Loading the user data
        public void LoadUserData(string userID, string role,string firstName,string middleName, string lastName, string fullName, string genderValue, DateTime birthDate, string usernameValue, string passwordValue, string emailValue, string phoneNumValue, string addressValue)
        {
            UserId.Text = userID;
            fullNameValue.Text = fullName;
            this.firstNameVal.Texts = firstName;
            this.middleNameVal.Texts = middleName;
            this.lastNameVal.Texts = lastName;
            this.userName.Texts = usernameValue;
            this.passWord.Texts = passwordValue;
            this.eMail.Texts = emailValue;
            this.phoneNum.Texts = phoneNumValue;
            this.address.Texts = addressValue;
            DateTime birthDateDTP = birthDate;
            cmbGender.SelectedItem = genderValue;

            if (role == "Admin")
            {
                AdminBtn.Checked = true;
            }
            else if (role == "User")
            {
                UserBtn.Checked = true;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Retrieve data from the input fields
            string userId = UserId.Text;
            string firstName = firstNameVal.Texts;
            string middleName = middleNameVal.Texts;
            string lastName = lastNameVal.Texts;
            string username = this.userName.Texts;
            string password = this.passWord.Texts;
            string email = this.eMail.Texts;
            string phoneNum = this.phoneNum.Texts;
            string address = this.address.Texts;
            string gender = cmbGender.SelectedItem.ToString();
            DateTime birthdate = birthDateDTP.Value;
            string birthDate = birthDateDTP.Value.ToString();
            string role = AdminBtn.Checked ? "Admin" : "User";
            
            // Input validation
            if (AdminBtn.Checked)
            {
                role = "Admin";
            }
            else if (UserBtn.Checked)
            {
                role = "User";
            }
            else
            {
                MessageBox.Show("Please select the role of the account.", "Error adding user.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            // Validate all required fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(birthDate) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNum) ||
                string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all required fields.", "Adding User Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Valid name
            if (!IsNameValid(firstName) || !IsNameValid(lastName))
            {
                MessageBox.Show("Name must be more than 1 character and contain only valid characters.");
                return;
            }
            // Valid username
            if (!IsValidUsername(username))
            {
                MessageBox.Show("Username must be more than 4 characters and valid symbols.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Valid email
            if (!IsEmailValid(email))
            {
                MessageBox.Show("Invalid email. Please try again.", "Inavlid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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




            // Update the data in db
            try
            {
                conn.Open();
                string query = "UPDATE users SET username = @username, password = @password, first_name = @first_name, last_name = @last_name, middle_name = @middle_name, gender = @gender, birth_date = @birth_date, phone_number = @phone_number, email_address = @email_address, address = @address, role = @role WHERE user_ID = @user_ID";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem);
                    cmd.Parameters.AddWithValue("@first_name", firstName);
                    cmd.Parameters.AddWithValue("@last_name", lastName);
                    cmd.Parameters.AddWithValue("@middle_name", middleName);
                    cmd.Parameters.AddWithValue("@username", userName.Texts);
                    cmd.Parameters.AddWithValue("@password", passWord.Texts);
                    cmd.Parameters.AddWithValue("@email_address", email);
                    cmd.Parameters.AddWithValue("@phone_number", phoneNum);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@birth_date", birthDate);
                    cmd.Parameters.AddWithValue("@user_ID", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully.");

                        // Navigate back to UsersInfo control
                        UsersInfo usersInfo = new UsersInfo();
                        if (this.ParentForm is AdminMenu menu)
                        {
                            menu.LoadUsersInfo(usersInfo);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No changes were made or user not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating user information: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadData();
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
        // Show password
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
               passWord.PasswordChar = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UsersInfo usersInfo = new UsersInfo();

            if (this.ParentForm is AdminMenu menu)
            {
                menu.LoadUsersInfo(usersInfo);
            }
        }
    }
    }

