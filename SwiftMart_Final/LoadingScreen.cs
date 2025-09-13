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
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
            this.Load += LoadingScreen_Load;
        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            LoadingTimer.Start();
        }
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            LoadingTimer.Stop();

            var LoginForm = new Login();
            LoginForm.Show();

            this.Hide();
        }
    }
}
