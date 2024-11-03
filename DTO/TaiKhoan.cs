using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string Taikhoan;
        private string Matkhau;
        private string MaNV;

        public string getTaiKhoan()
        {
            return Taikhoan;
        }

        public string getMatKhau()
        {
            return Matkhau;
        }

        public string getMaNV()
        {
            return MaNV;
        }

        public void setTaiKhoan(string Taikhoan)
        {
            this.Taikhoan = Taikhoan;
        }

        public void setMatKhau(string Matkhau) 
        {
            this.Matkhau = Matkhau;
        }
    }
}
