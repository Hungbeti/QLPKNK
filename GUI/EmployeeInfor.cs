using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GUI
{
    public partial class EmployeeInfor : Form
    {
        public EmployeeInfor()
        {
            InitializeComponent();
            openChildForm(new ReceptionInfor());
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
            pnContent.Controls.Add(childForm);
            pnContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Lễ tân
        private void btnReception_Click(object sender, EventArgs e)
        {
            openChildForm(new ReceptionInfor());
            btnDoctor.BackColor = Color.White;
            btnReception.BackColor = Color.FromArgb(68, 197, 229);
        }

        // Bác sĩ
        private void btnDoctor_Click(object sender, EventArgs e)
        {
            openChildForm(new DoctorInfor());
            btnReception.BackColor = Color.White;
            btnDoctor.BackColor = Color.FromArgb(68, 197, 229);
        }
    }
}
