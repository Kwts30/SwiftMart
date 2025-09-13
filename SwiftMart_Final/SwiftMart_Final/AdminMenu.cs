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

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
