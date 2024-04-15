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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string usernameQuanLy = "admin";
            string passwordQuanLy = "admin123";

            string usernameNhanVien = "staff";
            string passwordNhanVien = "staff123";
            string username = User.Text;
            string password = Pass.Text;

            if (username == usernameQuanLy && password == passwordQuanLy)
            {
                // Đăng nhập thành công với vai trò quản lý
                MainForm f = new MainForm();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (username == usernameNhanVien && password == passwordNhanVien)
            {
                // Đăng nhập thành công với vai trò nhân viên
                MessageBox.Show("Đăng nhập thành công với vai trò nhân viên");
                // Thực hiện các hành động nhân viên tại đây
            }
            else
            {
                MessageBox.Show("Sai tên người dùng hoặc mật khẩu");
                
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
