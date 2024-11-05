using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class AddTool : Form
    {
        private string name;
        public AddTool()
        {
            InitializeComponent();
        }

        // Xóa
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDVT.Text = "";
            txtColor.Text = "";
            txtTrigia.Text = "";
            txtQuantity.Text = "";
            txtNote.Text = "";
            txtSize.Text = "";
            cbType.SelectedIndex = -1;
        }

        public AddTool(String name)
        {
            InitializeComponent();
            this.name = name;
            DTO.Dung_cu dungCu = BLL.MedicalSuppliesList.GetDungCu(name);
            txtName.Text = name;
            txtName.Enabled = false;
            txtDVT.Text = dungCu.getDVT();
            txtQuantity.Text = dungCu.getSo_luong().ToString();
            txtColor.Text = dungCu.getMau_sac();
            txtNote.Text = dungCu.getGhi_chu();
            txtSize.Text = dungCu.getKich_co().ToString();
            txtTrigia.Text = dungCu.getTri_gia().ToString();
            cbType.Text = dungCu.getLoai();
        }
        // Xác nhận
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string text = BLL.MedicalSuppliesList.AddDungCu(txtName.Text, txtColor.Text, txtSize.Text, txtDVT.Text, txtTrigia.Text, txtQuantity.Text, txtNote.Text, cbType.Text);
            MessageBox.Show(text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Đóng form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
