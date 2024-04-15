using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManageEnd
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
           
            InitializeComponent();
            OpenChildForm(new Dashboardcs());
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboardcs());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Panel childPanel = new Panel();
            childPanel.Visible = false;
            OpenChildForm(new UserForm());
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer());
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product());
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
           
        }

        private Form activeFrom = null;
        public void OpenChildForm(Form childfrorm)
        {
            if (activeFrom != null)
            {
                activeFrom.Close();


            }
            activeFrom = childfrorm;
            childfrorm.TopLevel = false;
            childfrorm.FormBorderStyle = FormBorderStyle.None;
            childfrorm.Dock = DockStyle.Fill;
            label3.Text = activeFrom.Text;
            childpanel.Controls.Add(childfrorm);
            childpanel.Tag = childfrorm;
            childfrorm.BringToFront();
            childfrorm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void childpanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
