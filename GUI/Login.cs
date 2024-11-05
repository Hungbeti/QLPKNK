using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //// Lấy thông tin tài khoản và mật khẩu từ TextBox
            //string username = txtEmail.Text;
            //string password = txtMk.Text;

            //// Tạo đối tượng Account và gán thông tin đăng nhập
            //Tai_khoan account = new Tai_khoan();
            //account.setTaiKhoan(username);
            //account.setMatKhau(password);

            //// Kiểm tra đăng nhập qua lớp BLL
            //string resultMessage = BLL.Login.Log(account);

            //if (resultMessage == "Đăng nhập thành công.")
            //{
            //    // Đăng nhập thành công, mở form chính (MainForm)
            //    Home home = new Home();
            //    home.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    // Hiển thị thông báo lỗi
            //    MessageBox.Show(resultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



            DTO.Tai_khoan account = new Tai_khoan();
            account.setTaiKhoan(txtEmail.Text);
            account.setMatKhau(txtMk.Text);
            string kiemtra = BLL.Login.Log(account);
            switch (kiemtra)
            {
                case "Vui lòng nhập tài khoản":
                    MessageBox.Show(kiemtra);
                    txtEmail.Focus();
                    break;
                case "Vui lòng nhập mật khẩu":
                    MessageBox.Show(kiemtra);
                    txtMk.Focus();
                    break;
                case "Không tìm thấy tài khoản":
                    MessageBox.Show(kiemtra);
                    txtEmail.Focus();
                    break;
                case "Sai mật khẩu":
                    MessageBox.Show(kiemtra);
                    txtMk.Focus();
                    break;
                case "Tài khoản không hoạt động":
                    MessageBox.Show(kiemtra);
                    break;
                default:
                    char x = txtEmail.Text[0];
                    DTO.Nguoi_dung user = BLL.User.GetUser(account.getTaiKhoan());
                    //Static.changeUser(user);
                    if (x == 'B' || x == 'b')
                    {
                        BS_Home bsHome = new BS_Home();
                        bsHome.Show();
                        this.Hide();
                    }
                    else if (x == 'L' || x == 'l')
                    {
                        Rec_Home recHome = new Rec_Home();
                        recHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    break;
            }
        }

        // Quên mật khẩu
        private void lbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();

            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
