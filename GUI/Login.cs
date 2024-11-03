using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản và mật khẩu từ TextBox
            string username = txtEmail.Text;
            string password = txtMk.Text;

            // Tạo đối tượng Account và gán thông tin đăng nhập
            TaiKhoan account = new TaiKhoan();
            account.setTaiKhoan(username);
            account.setMatKhau(password);

            // Kiểm tra đăng nhập qua lớp BLL
            string resultMessage = BLL.Login.Log(account);

            if (resultMessage == "Đăng nhập thành công.")
            {
                // Đăng nhập thành công, mở form chính (MainForm)
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show(resultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();

            this.Hide();
        }
    }
}
