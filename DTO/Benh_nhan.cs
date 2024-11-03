using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Benh_nhan
    {
        protected string CCCD;
        protected string Ho;
        protected string Ten;
        protected string Gioi_tinh;
        protected DateTime Tuoi;

        public Benh_nhan() { }
        public Benh_nhan(string cccd, string ho, string ten, string gioiTinh, DateTime tuoi)
        {
            CCCD = cccd;
            Ho = ho;
            Ten = ten;
            Gioi_tinh = gioiTinh;
            Tuoi = tuoi;
        }

        public string GetCCCD()
        {
            return CCCD;
        }

        public void SetCCCD(string cccd)
        {
            CCCD = cccd;
        }

        public string GetHo()
        {
            return Ho;
        }

        public void SetHo(string ho)
        {
            Ho = ho;
        }

        public string GetTen()
        {
            return Ten;
        }

        public void SetTen(string ten)
        {
            Ten = ten;
        }

        public string GetGioiTinh()
        {
            return Gioi_tinh;
        }

        public void SetGioiTinh(string gioiTinh)
        {
            Gioi_tinh = gioiTinh;
        }

        public DateTime GetTuoi()
        {
            return Tuoi;
        }

        public void SetTuoi(DateTime tuoi)
        {
            Tuoi = tuoi;
        }
    }
}
