using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nguoi_Kham
    {
        private string STT;
        private DateTime Ngay;
        private int Ca;
        private string Ma_benh_nhan;
        private string Ma_le_tan;
        private string Ma_bac_si;
        private string Trang_thai;
        private string Ghi_chu;

        public Nguoi_Kham() { }

        public Nguoi_Kham(string STT, DateTime Ngay, int Ca, string Ma_benh_nhan, string Ma_le_tan, string Ma_bac_si, string Trang_thai, string Ghi_chu)
        {
            this.STT = STT;
            this.Ngay = Ngay;
            this.Ca = Ca;
            this.Ma_benh_nhan = Ma_benh_nhan;
            this.Ma_le_tan = Ma_le_tan;
            this.Ma_bac_si = Ma_bac_si;
            this.Trang_thai = Trang_thai;
            this.Ghi_chu = Ghi_chu;
        }

        public string getSTT() 
        {
            return STT; 
        }
        public DateTime getNgay() 
        {
            return Ngay; 
        }
        public int getCa()
        { 
            return Ca;
        }
        public string getMa_benh_nhan() 
        { 
            return Ma_benh_nhan;
        }
        public string getMa_le_tan() 
        { 
            return Ma_le_tan; 
        }
        public string getMa_bac_si() 
        { 
            return Ma_bac_si; 
        }
        public string getTrang_thai() 
        { 
            return Trang_thai; 
        }
        public string getGhi_chu() 
        {
            return Ghi_chu; 
        }

        public void setSTT(string STT) 
        { 
            this.STT = STT; 
        }
        public void setNgay(DateTime Ngay) 
        { 
            this.Ngay = Ngay; 
        }
        public void setCa(int Ca) 
        { 
            this.Ca = Ca; 
        }
        public void setMa_benh_nhan(string Ma_benh_nhan) 
        { 
            this.Ma_benh_nhan = Ma_benh_nhan; 
        }
        public void setMa_le_tan(string Ma_le_tan) 
        { 
            this.Ma_le_tan = Ma_le_tan; 
        }
        public void setMa_bac_si(string Ma_bac_si) 
        { 
            this.Ma_bac_si = Ma_bac_si; 
        }
        public void setTrang_thai(string Trang_thai) 
        { 
            this.Trang_thai = Trang_thai; 
        }
        public void setGhi_chu(string Ghi_chu) 
        { 
            this.Ghi_chu = Ghi_chu; 
        }
    }
}
