using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nguoi_dung
    {
        protected string Ma_nhan_vien;
        protected string Ho;
        protected string Ten;
        protected string Gioi_tinh;
        protected DateTime Ngay_sinh;
        protected string Que_quan;
        protected string CCCD;
        protected string Maluong;

        public string GetMaNhanVien()
        {
            return Ma_nhan_vien;
        }

        public void SetMaNhanVien(string value)
        {
            Ma_nhan_vien = value;
        }

        public string GetHo()
        {
            return Ho;
        }

        public void SetHo(string value)
        {
            Ho = value;
        }

        public string GetTen()
        {
            return Ten;
        }

        public void SetTen(string value)
        {
            Ten = value;
        }

        public string GetGioiTinh()
        {
            return Gioi_tinh;
        }

        public void SetGioiTinh(string value)
        {
            Gioi_tinh = value;
        }

        public DateTime GetNgaySinh()
        {
            return Ngay_sinh;
        }

        public void SetNgaySinh(DateTime value)
        {
            Ngay_sinh = value;
        }

        public string GetQueQuan()
        {
            return Que_quan;
        }

        public void SetQueQuan(string value)
        {
            Que_quan = value;
        }

        public string GetCCCD()
        {
            return CCCD;
        }

        public void SetCCCD(string value)
        {
            CCCD = value;
        }

        public string GetMaLuong()
        {
            return Maluong;
        }

        public void SetMaLuong(string value)
        {
            Maluong = value;
        }
    }
}
