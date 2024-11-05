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
    public partial class PatientInfor : Form
    {
        private DataSet _dataset;
        public PatientInfor()
        {
            InitializeComponent();
            _dataset = new DataSet();
        }

        // Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();
        }

        // Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDoctor patient = new EditDoctor();
            patient.ShowDialog();
        }

        //Xóa
        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void PatientInfor_Load(object sender, EventArgs e)
        {
            LoadPatientInfor();
        }

        public void LoadPatientInfor()
        {
            _dataset = BLL.InforManagement.DanhSachBenhNhan();
            dataGridViewPatient.DataSource = _dataset.Tables[0];

            // Thiết lập tên tiêu đề cột
            dataGridViewPatient.Columns["STT"].HeaderText = "STT";
            dataGridViewPatient.Columns["Ten_benh_nhan"].HeaderText = "Tên bệnh nhân";
            dataGridViewPatient.Columns["Gioi_tinh"].HeaderText = "Giới tính";
            dataGridViewPatient.Columns["Ngay_sinh"].HeaderText = "Ngày sinh";
            dataGridViewPatient.Columns["Ngay_kham"].HeaderText = "Ngày khám";

        }
    }
}
