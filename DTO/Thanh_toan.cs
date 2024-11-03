using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thanh_toan
    {
        private string ID;
        private string STT;
        private DateTime Gio;
        private float Tongtien;
        private string Hinhthuc;
        private string Tinhtrang;

        public Thanh_toan() { }

        public Thanh_toan(string ID, string STT, DateTime Gio, float Tongtien, string Hinhthuc, string Tinhtrang)
        {
            this.ID = ID;
            this.STT = STT;
            this.Gio = Gio;
            this.Tongtien = Tongtien;
            this.Hinhthuc = Hinhthuc;
            this.Tinhtrang = Tinhtrang;
        }

        public string getID() 
        { 
            return ID;
        }
        public string getSTT()
        { 
            return STT;
        }
        public DateTime getGio() 
        {
            return Gio; 
        }
        public float getTongtien() 
        { 
            return Tongtien; 
        }
        public string getHinhthuc() 
        {
            return Hinhthuc; 
        }
        public string getTinhtrang() 
        { 
            return Tinhtrang; 
        }

        public void setID(string ID) 
        { 
            this.ID = ID; 
        }
        public void setSTT(string STT) 
        { 
            this.STT = STT; 
        }
        public void setGio(DateTime Gio) 
        { 
            this.Gio = Gio;
        }
        public void setTongtien(float Tongtien)
        { 
            this.Tongtien = Tongtien; 
        }
        public void setHinhthuc(string Hinhthuc) 
        { 
            this.Hinhthuc = Hinhthuc; 
        }
        public void setTinhtrang(string Tinhtrang)
        { 
            this.Tinhtrang = Tinhtrang;
        }
    }
}
