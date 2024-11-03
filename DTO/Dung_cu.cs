using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dung_cu
    {
        private String Ten_dung_cu;
        private String Mau_sac;
        private float Kich_co;
        private String DVT;
        private float Tri_gia;
        private int So_luong;
        private String Ghi_chu;
        private String Loai;

        public Dung_cu() { }

        public Dung_cu(string ten_dung_cu, string mau_sac, float kich_co, string dVT, float tri_gia, int so_luong, string ghi_chu, string loai)
        {
            Ten_dung_cu = ten_dung_cu;
            Mau_sac = mau_sac;
            Kich_co = kich_co;
            DVT = dVT;
            Tri_gia = tri_gia;
            So_luong = so_luong;
            Ghi_chu = ghi_chu;
            Loai = loai;
        }

        public String getTen_dung_cu()
        {
            return Ten_dung_cu;
        }

        public String mau_sac()
        { 
            return Mau_sac;
        }

        public float getKich_co() 
        { 
            return Kich_co; 
        }

        public String getDVT()
        {
            return DVT;
        }

        public float getTri_gia() 
        {  
            return Tri_gia; 
        }
        public int getSo_luong() 
        { 
            return So_luong; 
        }
        public String getGhi_chu() 
        {
            return Ghi_chu;
        }
        public String getLoai() 
        {
            return Loai;
        }

        public void setTen_dung_cu(String ten_dung_cu)
        {
            this.Ten_dung_cu = ten_dung_cu;
        }

        public void setMau_sac(string Mau_sac) 
        { 
            this.Mau_sac = Mau_sac; 
        }
        public void setKich_co(float Kich_co) 
        { 
            this.Kich_co = Kich_co; 
        }
        public void setDVT(string DVT) 
        { 
            this.DVT = DVT; 
        }
        public void setTri_gia(float Tri_gia) 
        { 
            this.Tri_gia = Tri_gia; 
        }
        public void setSo_luong(int So_luong) 
        { 
            this.So_luong = So_luong; 
        }
        public void setGhi_chu(string Ghi_chu) 
        {
            this.Ghi_chu = Ghi_chu; 
        }
        public void setLoai(string Loai) 
        {
            this.Loai = Loai;
        }
    }
}
