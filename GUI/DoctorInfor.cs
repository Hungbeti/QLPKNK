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
    public partial class DoctorInfor : Form
    {
        private DataSet _dataset;
        public DoctorInfor()
        {
            InitializeComponent();
            _dataset = new DataSet();
        }

        // Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor();
            if (addDoctor.ShowDialog() == DialogResult.OK)
            {
                LoadDoctorData(); // Tải lại dữ liệu sau khi thêm thành công
            }
        }

        // Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDoctor editDoctor = new EditDoctor();
            if (editDoctor.ShowDialog() == DialogResult.OK)
            {
                LoadDoctorData(); // Tải lại dữ liệu sau khi sửa thành công
            }
        }

        // Vô hiệu hóa
        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctor.SelectedRows.Count > 0)
            {
                string maNhanVien = dataGridViewDoctor.SelectedRows[0].Cells["Ma_nhan_vien"].Value.ToString();
                string result = BLL.AddUser.DisableUser(maNhanVien);
                MessageBox.Show(result);
                LoadDoctorData(); // Refresh dữ liệu sau khi vô hiệu hóa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bác sĩ để vô hiệu hóa.");
            }
        }

        
        

        public void LoadDoctorData()
        {
            // Lấy danh sách thuốc từ BLL và hiển thị lên DataGridView
            _dataset = BLL.InforManagement.DanhSachBacSi();
            dataGridViewDoctor.DataSource = _dataset.Tables[0];

            // Thiết lập tên tiêu đề cột
            dataGridViewDoctor.Columns["Ma_nhan_vien"].HeaderText = "Mã NV";
            dataGridViewDoctor.Columns["Ho"].HeaderText = "Họ";
            dataGridViewDoctor.Columns["Ten"].HeaderText = "Tên";
            dataGridViewDoctor.Columns["Gioi_tinh"].HeaderText = "Giới tính";
            dataGridViewDoctor.Columns["Chuyen_khoa"].HeaderText = "Công việc";
            dataGridViewDoctor.Columns["Hoatdong"].HeaderText = "Tình trạng hoạt động";
        }

        private void DoctorInfor_Load(object sender, EventArgs e)
        {
            LoadDoctorData();
        }
    }
}
