using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bac_si : Nguoi_dung
    {
        private String Ma_bac_si;
        private String Chuyen_khoa;
        public Bac_si() { }

        public Bac_si(string ma_bac_si, string chuyen_khoa)
        {
            Ma_bac_si = ma_bac_si;
            Chuyen_khoa = chuyen_khoa;
        }

        public String getMa_bac_si()
        {
            return Ma_bac_si;
        }
        public String getChuyen_khoa()
        {
            return Chuyen_khoa;
        }

        public void setChuyen_khoa(String chuyen_khoa)
        {
            this.Chuyen_khoa = chuyen_khoa;
        }
        public void setMaBS(string mabs)
        {
            this.Ma_bac_si = mabs;
        }
    }
}
