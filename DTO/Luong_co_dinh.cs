using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Luong_co_dinh
    {
        private String Ma;
        private float So_tien;

        public Luong_co_dinh() {}

        public Luong_co_dinh(String Ma, float So_tien) {
            this.Ma = Ma;
            this.So_tien = So_tien;
        }

        public String getMa()
        {
            return Ma;
        }
        public float getSo_tien()
        {
            return So_tien;
        }

        public void setMa(String Ma)
        {
            this.Ma = Ma;
        }

        public void setSo_tien(float So_tien)
        {
            this.So_tien = So_tien;
        }
    }
}
