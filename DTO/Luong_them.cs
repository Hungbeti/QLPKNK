using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Luong_them
    {
        private int Ma;
        private float Tien;
        private DateTime Gio;
        private string IDHD;

        public Luong_them() { }

        public Luong_them(int Ma, float Tien, DateTime Gio, string IDHD)
        {
            this.Ma = Ma;
            this.Tien = Tien;
            this.Gio = Gio;
            this.IDHD = IDHD;
        }

        public int getMa() 
        { 
            return Ma;
        }
        public float getTien() 
        {
            return Tien; 
        }
        public DateTime getGio() 
        { 
            return Gio;
        }
        public string getIDHD()
        { 
            return IDHD;
        }

        public void setMa(int Ma) 
        { 
            this.Ma = Ma; 
        }
        public void setTien(float Tien)
        { 
            this.Tien = Tien; 
        }
        public void setGio(DateTime Gio)
        {
            this.Gio = Gio; 
        }
        public void setIDHD(string IDHD) 
        { 
            this.IDHD = IDHD; 
        }
    }
}
