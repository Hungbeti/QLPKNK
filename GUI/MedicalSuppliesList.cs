using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MedicalSuppliesList : Form
    {
        public MedicalSuppliesList()
        {
            InitializeComponent();
            openChildForm(new MedicineList());
        }

        

        // Thuốc
        private void btnMedicine_Click(object sender, EventArgs e)
        {
            btnMedicine.BackColor = Color.FromArgb(68, 197, 229);
            btnService.BackColor = Color.White;
            btnTool.BackColor = Color.White;

            openChildForm(new MedicineList());
        }

        // Dụng cụ
        private void btnTool_Click(object sender, EventArgs e)
        {
            btnMedicine.BackColor = Color.White;
            btnService.BackColor = Color.White;
            btnTool.BackColor = Color.FromArgb(68, 197, 229);

            openChildForm(new ToolList());
        }

        // Dịch vụ
        private void btnService_Click(object sender, EventArgs e)
        {
            btnMedicine.BackColor = Color.White;
            btnService.BackColor = Color.FromArgb(68, 197, 229);
            btnTool.BackColor = Color.White;

            openChildForm(new ServiceList());
        }

        // child form
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
    }
}
