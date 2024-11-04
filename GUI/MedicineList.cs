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
    public partial class MedicineList : Form
    {
        private DataSet _dataset;

        public MedicineList()
        {
            InitializeComponent();
            _dataset = new DataSet();
        }

        // Thêm thuốc
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine();
            if (addMedicine.ShowDialog() == DialogResult.OK)
            {
                LoadMedicineData(); // Tải lại dữ liệu sau khi thêm thành công
            }
            //addMedicine.ShowDialog();
        }

        // Sửa thuốc
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMedicine editMedicine = new EditMedicine();
            if(editMedicine.ShowDialog() == DialogResult.OK)
            {
                LoadMedicineData();
            }
        }

        private void MedicineList_Load(object sender, EventArgs e)
        {
            LoadMedicineData();
        }


        private string selectedMedicineName;

        // Xóa thuốc
        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadMedicineData()
        {
            // Lấy danh sách thuốc từ BLL và hiển thị lên DataGridView
            _dataset = BLL.MedicalSuppliesList.DanhSachThuoc();
            dataGridViewMedicine.DataSource = _dataset.Tables[0];

            // Thiết lập tên tiêu đề cột
            dataGridViewMedicine.Columns["Ten_thuoc"].HeaderText = "Tên thuốc";
            dataGridViewMedicine.Columns["DVT"].HeaderText = "Đơn vị tính";
            dataGridViewMedicine.Columns["So_luong"].HeaderText = "Số lượng";
            dataGridViewMedicine.Columns["Gia_ban"].HeaderText = "Giá bán";
            dataGridViewMedicine.Columns["Ham_luong"].HeaderText = "Hàm lượng";
            dataGridViewMedicine.Columns["Ghi_chu"].HeaderText = "Ghi chú";
            dataGridViewMedicine.Columns["Ten_loai"].HeaderText = "Tên loại";
        }
    }
}
