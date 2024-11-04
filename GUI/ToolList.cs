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
    public partial class ToolList : Form
    {
        private DataSet _dataset;
        public ToolList()
        {
            InitializeComponent();
            _dataset = new DataSet();
        }

        // Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTool addTool = new AddTool();
            if (addTool.ShowDialog() == DialogResult.OK)
            {
                LoadToolData(); // Tải lại dữ liệu sau khi thêm thành công
            }
        }

        // Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTool editTool = new EditTool();
            if (editTool.ShowDialog() == DialogResult.OK)
            {
                LoadToolData(); // Tải lại dữ liệu sau khi thêm thành công
            }
        }

        // Xóa
        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void ToolList_Load(object sender, EventArgs e)
        {
            LoadToolData();
        }

        public void LoadToolData()
        {
            // Lấy danh sách thuốc từ BLL và hiển thị lên DataGridView
            _dataset = BLL.MedicalSuppliesList.DanhSachDungCu();
            dataGridViewTool.DataSource = _dataset.Tables[0];

            // Thiết lập tên tiêu đề cột
            dataGridViewTool.Columns["Ten_dung_cu"].HeaderText = "Tên dụng cụ";
            dataGridViewTool.Columns["Mau_sac"].HeaderText = "Màu sắc";
            dataGridViewTool.Columns["Kich_co"].HeaderText = "Kích cỡ";
            dataGridViewTool.Columns["DVT"].HeaderText = "Đơn vị tính";
            dataGridViewTool.Columns["Tri_gia"].HeaderText = "Trị giá";
            dataGridViewTool.Columns["So_luong"].HeaderText = "Số lượng";
            dataGridViewTool.Columns["Ghi_chu"].HeaderText = "Ghi chú";
            dataGridViewTool.Columns["Loai"].HeaderText = "Loại";
        }
    }
}
