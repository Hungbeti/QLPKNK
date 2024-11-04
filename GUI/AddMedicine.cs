using DTO;
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
using System.Xml.Linq;

namespace GUI
{
    public partial class AddMedicine : Form
    {
        private string name;
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Xóa hết dữ liệu trong các ô nhập liệu
            txtName.Text = "";
            txtDVT.Text = "";
            txtPrice.Text = "";
            txtHamLuong.Text = "";
            txtQuantity.Text = "";
            txtNote.Text = "";
            txtType.Text = "";
        }

        public AddMedicine(string name)
        {
            InitializeComponent();
            this.name = name;
            DTO.Thuoc thuoc = BLL.MedicalSuppliesList.GetThuoc(name);
            txtName.Text = name;
            txtName.Enabled = false;
            txtDVT.Text = thuoc.getDVT();
            txtQuantity.Text = thuoc.getSo_luong().ToString();
            txtPrice.Text = thuoc.getGia_ban().ToString("#");
            txtHamLuong.Text = thuoc.getHam_luong();
            txtNote.Text = thuoc.getGhi_chu();
            txtType.Text = thuoc.getTen_loai();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string text = BLL.MedicalSuppliesList.AddThuoc(txtName.Text, txtDVT.Text, txtQuantity.Text, txtPrice.Text, txtHamLuong.Text, txtNote.Text, txtType.Text);
            MessageBox.Show(text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
