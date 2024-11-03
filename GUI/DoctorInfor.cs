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
        public DoctorInfor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDoctor editDoctor = new EditDoctor();
            editDoctor.ShowDialog();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {

        }
    }
}
