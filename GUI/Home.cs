using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Home : Form
    {
        private Boolean show_pnQltt = false;

        public Home()
        {
            InitializeComponent();

            toogle_pn_qltt();
        }

        // Quản lý thông tin
        private void btnQltt_Click(object sender, EventArgs e)
        {
            lb.Text = btnQltt.Text;
            show_pnQltt = !show_pnQltt;

            toogle_pn_qltt();
        }

        private void toogle_pn_qltt()
        {
            if (show_pnQltt)
            {
                pnQltt.Height = 108;
            }
            else
            {
                pnQltt.Height = 0;
            }
        }

        // Đăng xuất
        private void btn_dx_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }  
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Thông tin nhân viên
        private void btn_ttnv_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeInfor());
        }

        // Thông tin bệnh nhân
        private void btn_thbn_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientInfor());
        }

        // Quản lý vật tư y tế
        private void btn_qlllv_Click(object sender, EventArgs e)
        {
        }

        private void btn_qlvtyt_Click(object sender, EventArgs e)
        {
            lb.Text = btn_qlvtyt.Text;
            openChildForm(new MedicalSuppliesList());
        }
    }
}
