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
    public partial class ServiceList : Form
    {
        private DataSet _dataset;
        public ServiceList()
        {
            InitializeComponent();
            _dataset = new DataSet();
        }

        // Thêm dịch vụ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            if (addService.ShowDialog() == DialogResult.OK)
            {
                LoadServiceData(); // Tải lại dữ liệu sau khi thêm thành công
            }
        }

        // Sửa dịch vụ
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditService editService = new EditService();
            if (editService.ShowDialog() == DialogResult.OK)
            {
                LoadServiceData(); // Tải lại dữ liệu sau khi thêm thành công
            }
        }

        // Xóa dịch vụ
        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void ServiceList_Load(object sender, EventArgs e)
        {
            LoadServiceData();
        }

        public void LoadServiceData()
        {
            // Lấy danh sách thuốc từ BLL và hiển thị lên DataGridView
            _dataset = BLL.MedicalSuppliesList.DanhSachDichVu();
            dataGridViewService.DataSource = _dataset.Tables[0];

            // Thiết lập tên tiêu đề cột
            dataGridViewService.Columns["Ten_dich_vu"].HeaderText = "Tên dịch vụ";
            dataGridViewService.Columns["Don_vi_tinh"].HeaderText = "Đơn vị tính";
            dataGridViewService.Columns["Don_gia"].HeaderText = "Đơn giá";
            dataGridViewService.Columns["Ghi_chu"].HeaderText = "Ghi chú";
            dataGridViewService.Columns["Ten_danh_muc"].HeaderText = "Tên danh mục";
        }
    }
}
