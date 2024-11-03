using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dich_vu
    {
        private String Ten_dich_vu;
        private String Don_vi_tinh;
        private float Don_gia;
        private String Ghi_chu;
        private String Ten_danh_muc;

        public Dich_vu() { }

        public Dich_vu(string ten_dich_vu, string don_vi_tinh, float don_gia, string ghi_chu, string ten_danh_muc)
        {
            Ten_dich_vu = ten_dich_vu;
            Don_vi_tinh = don_vi_tinh;
            Don_gia = don_gia;
            Ghi_chu = ghi_chu;
            Ten_danh_muc = ten_danh_muc;
        }

        public String getTen_dich_vu()
        {
            return Ten_dich_vu;
        }

        public String getDon_vi_tinh()
        {
            return Don_vi_tinh;
        }

        public float getDon_gia()
        {
            return Don_gia;
        }

        public String getGhi_chu()
        {
            return Ghi_chu;
        }

        public String getTen_danh_muc()
        {
            return Ten_danh_muc;
        }

        public void setTen_dich_vu(String ten_dich_vu) 
        {
            this.Ten_dich_vu = ten_dich_vu;
        }

        public void setDon_gia(float don_gia)
        {
            this.Don_gia = don_gia;
        }

        public void setDon_vi_tinh(String don_vi_tinh)
        {
            this.Don_vi_tinh = don_vi_tinh;
        }

        public void setGhi_chu(String ghi_chu)
        {
            this.Ghi_chu = ghi_chu;
        }

        public void setTen_danh_muc(String ten_danh_muc)
        {
            this.Ten_danh_muc = ten_danh_muc;
        }
    }
}
