using SwiftMart_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftMart_Final
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAdminHome();
        }

        private void LoadAdminHome() 
        { 
            panelContainer.Controls.Clear();

            AdminHome adminHome = new AdminHome();
            {
                Dock = DockStyle.Fill;
            }
            panelContainer.Controls.Add(adminHome);
        }

       

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();

            AdminHome adminHome = new AdminHome();
            {
                Dock = DockStyle.Fill;
            }
            panelContainer.Controls.Add(adminHome);
        }
        private void ItemBtn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();

            items items = new items();
            {
                Dock = DockStyle.Fill;
            }
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(items);
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {

        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();

            UsersInfo customerInfo = new UsersInfo
            {
                Dock = DockStyle.Fill
            };
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(customerInfo);
        }
        // Load another panel within the Customer Page

        public void LoadEditUsers(EditUsers editUserControl)
        {
            panelContainer.Controls.Clear(); // Clear existing controls
            editUserControl.Dock = DockStyle.Fill; // Make it fill the panel
            panelContainer.Controls.Add(editUserControl); // Add the new control
        }
        public void LoadItemData(items ItemData)
        {
            panelContainer.Controls.Clear(); // Clear existing controls
            ItemData.Dock = DockStyle.Fill; // Make it fill the panel
            panelContainer.Controls.Add(ItemData); // Add the new control
        }

        // Load the panel back from the Edit User page
        public void LoadUsersInfo(UsersInfo customerInfo)
        {
            panelContainer.Controls.Clear(); // Clear existing controls
            customerInfo.Dock = DockStyle.Fill; // Make it fill the panel
            panelContainer.Controls.Add(customerInfo); // Add the new control
        }
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
