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
    public partial class EditTool : Form
    {
        private string name;
        public EditTool()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Xóa hết dữ liệu trong các ô nhập liệu
            txtName.Text = "";
            txtDVT.Text = "";
            txtColor.Text = "";
            txtTrigia.Text = "";
            txtQuantity.Text = "";
            txtNote.Text = "";
            txtType.Text = "";
            txtSize.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
