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
    public partial class ReceptionInfor : Form
    {
        private DataSet _dataset;
        public ReceptionInfor()
        {
            InitializeComponent();
            _dataset = new DataSet();
        }

        // Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddReception addReception = new AddReception();
            if (addReception.ShowDialog() == DialogResult.OK)
            {
                LoadReceptionData(); // Tải lại dữ liệu sau khi thêm thành công
            }
        }

        // Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditReception editReception = new EditReception();
            if (editReception.ShowDialog() == DialogResult.OK)
            {
                LoadReceptionData(); // Tải lại dữ liệu sau khi sửa thành công
            }
        }

        private void ReceptionInfor_Load(object sender, EventArgs e)
        {
            LoadReceptionData();
        }

        public void LoadReceptionData()
        {
            // Lấy danh sách thuốc từ BLL và hiển thị lên DataGridView
            _dataset = BLL.InforManagement.DanhSachLeTan();
            dataGridViewReception.DataSource = _dataset.Tables[0];

            // Thiết lập tên tiêu đề cột
            dataGridViewReception.Columns["Ma_nhan_vien"].HeaderText = "Mã NV";
            dataGridViewReception.Columns["Ho"].HeaderText = "Họ";
            dataGridViewReception.Columns["Ten"].HeaderText = "Tên";
            dataGridViewReception.Columns["Gioi_tinh"].HeaderText = "Giới tính";
            dataGridViewReception.Columns["Hoatdong"].HeaderText = "Tình trạng hoạt động";
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (dataGridViewReception.SelectedRows.Count > 0)
            {
                string maNhanVien = dataGridViewReception.SelectedRows[0].Cells["Ma_nhan_vien"].Value.ToString();
                string result = BLL.AddUser.DisableUser(maNhanVien);
                MessageBox.Show(result);
                LoadReceptionData(); // Refresh dữ liệu sau khi vô hiệu hóa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lễ tân để vô hiệu hóa.");
            }
        }
    }
}
