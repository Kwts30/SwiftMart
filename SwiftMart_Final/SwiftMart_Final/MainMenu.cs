using System;
using System.Runtime.InteropServices;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace SwiftMart_Final
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadFormInPanel(new Home());
        }

        private void LoadFormInPanel(Form form)
        {
            centerpanel_MainMenu.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            centerpanel_MainMenu.Controls.Add(form);
            form.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Home());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void HOME_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void centerpanel_MainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Home());
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
