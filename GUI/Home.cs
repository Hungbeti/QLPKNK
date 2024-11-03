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

        private void btnQltt_Click(object sender, EventArgs e)
        {
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

        private void btn_ttnv_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeInfor());
        }
    }
}
