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
    public partial class AddService : Form
    {
        private String name;
        public AddService()
        {
            InitializeComponent();
        }

        // Đóng form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xóa
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtNote.Text = "";
            cbDVT.SelectedIndex = -1;
            cbDanhMuc.SelectedIndex = -1;
        }

        public AddService(string name)
        {
            InitializeComponent();
            this.name = name;
            DTO.Dich_vu dichVu = BLL.MedicalSuppliesList.GetDichVu(name);
            txtName.Text = name;
            txtName.Enabled = false;
            txtPrice.Text = dichVu.getDon_gia().ToString();
            txtNote.Text = dichVu.getGhi_chu();
            cbDVT.Text = dichVu.getDon_vi_tinh();
            cbDanhMuc.Text = dichVu.getTen_danh_muc();
        }

        // Xác nhận
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string text = BLL.MedicalSuppliesList.AddDichVu(txtName.Text, cbDVT.Text, txtPrice.Text, txtNote.Text,  cbDanhMuc.Text);
            MessageBox.Show(text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
