using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTieuDungCu
    {
        private string ID;
        private string Ten_dung_cu;
        private int So_luong;
        private float Thanh_tien;
        private string STT;

        public ChiTieuDungCu() { }

        public ChiTieuDungCu(string ID, string Ten_dung_cu, int So_luong, float Thanh_tien, string STT)
        {
            this.ID = ID;
            this.Ten_dung_cu = Ten_dung_cu;
            this.So_luong = So_luong;
            this.Thanh_tien = Thanh_tien;
            this.STT = STT;
        }

        public string getID() 
        { 
            return ID; 
        }
        public string getTen_dung_cu() 
        { 
            return Ten_dung_cu; 
        }
        public int getSo_luong() 
        { 
            return So_luong; 
        }
        public float getThanh_tien() 
        { 
            return Thanh_tien; 
        }
        public string getSTT()
        { 
            return STT;
        }

        public void setID(string ID) 
        { 
            this.ID = ID; 
        }
        public void setTen_dung_cu(string Ten_dung_cu) 
        { 
            this.Ten_dung_cu = Ten_dung_cu; 
        }
        public void setSo_luong(int So_luong) 
        { 
            this.So_luong = So_luong; 
        }
        public void setThanh_tien(float Thanh_tien) 
        { 
            this.Thanh_tien = Thanh_tien; 
        }
        public void setSTT(string STT) 
        { 
            this.STT = STT; 
        }
    }
}
