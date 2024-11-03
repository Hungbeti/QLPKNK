using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loai_thuoc
    {
        private String Ten_loai;
        public Loai_thuoc() { }

        public Loai_thuoc(String Ten_loai)
        {
            this.Ten_loai = Ten_loai;
        }

        public String getTen_loai()
        {
            return Ten_loai;
        }

        public void setTen_loai(String Ten_loai)
        {
            this.Ten_loai= Ten_loai;
        }
    }
}
