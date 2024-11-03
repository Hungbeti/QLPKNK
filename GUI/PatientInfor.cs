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
        public PatientInfor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDoctor patient = new EditDoctor();
            patient.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
