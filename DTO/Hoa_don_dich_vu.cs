using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoa_don_dich_vu
    {
        private string ID;
        private string STT;
        private string Ten_dich_vu;
        private int So_luong;
        private float Thanh_tien;
        private string Ghi_chu;

        public Hoa_don_dich_vu() { }

        public Hoa_don_dich_vu(string ID, string STT, string Ten_dich_vu, int So_luong, float Thanh_tien, string Ghi_chu)
        {
            this.ID = ID;
            this.STT = STT;
            this.Ten_dich_vu = Ten_dich_vu;
            this.So_luong = So_luong;
            this.Thanh_tien = Thanh_tien;
            this.Ghi_chu = Ghi_chu;
        }

        public string getID() 
        { 
            return ID; 
        }
        public string getSTT() 
        { 
            return STT; 
        }
        public string getTen_dich_vu() 
        { 
            return Ten_dich_vu; 
        }
        public int getSo_luong() 
        { 
            return So_luong;
        }
        public float getThanh_tien() 
        { 
            return Thanh_tien; 
        }
        public string getGhi_chu() 
        { 
            return Ghi_chu; 
        }

        public void setID(string ID) 
        { 
            this.ID = ID; 
        }
        public void setSTT(string STT) 
        { 
            this.STT = STT; 
        }
        public void setTen_dich_vu(string Ten_dich_vu) 
        { 
            this.Ten_dich_vu = Ten_dich_vu; 
        }
        public void setSo_luong(int So_luong) 
        { 
            this.So_luong = So_luong; 
        }
        public void setThanh_tien(float Thanh_tien) 
        { 
            this.Thanh_tien = Thanh_tien; 
        }
        public void setGhi_chu(string Ghi_chu) 
        { 
            this.Ghi_chu = Ghi_chu; 
        }
    }
}
