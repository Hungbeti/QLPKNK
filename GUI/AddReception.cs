﻿using System;
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
    public partial class AddReception : Form
    {
        public AddReception()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Xóa hết dữ liệu trong các ô nhập liệu
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cbGender.SelectedIndex = -1;
            txtHometown.Text = "";
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            txtIDCard.Text = "";
            txtEmail.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
