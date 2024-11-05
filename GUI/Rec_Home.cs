using Guna.UI2.WinForms;
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
    public partial class Rec_Home : Form
    {
        public Rec_Home()
        {
            InitializeComponent();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            Point menuPosition = btnLanguage.PointToScreen(new Point(0, btnLanguage.Height));
            guna2ContextMenuStrip1.Show(menuPosition);
        }

        // Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
