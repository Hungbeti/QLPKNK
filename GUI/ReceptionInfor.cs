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
        public ReceptionInfor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddReception addReception = new AddReception();
            addReception.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditReception editReception = new EditReception();
            editReception.ShowDialog();
        }
    }
}
