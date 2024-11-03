using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Danh_muc_ki_thuat
    {
        private String Ten_danh_muc;
        public Danh_muc_ki_thuat() { }

        public Danh_muc_ki_thuat(string ten_danh_muc)
        {
            this.Ten_danh_muc = ten_danh_muc;
        }

        public String getTen_danh_muc()
        {
            return Ten_danh_muc;
        }

        public void setTen_danh_muc(String ten_danh_muc)
        {
            this.Ten_danh_muc = ten_danh_muc;
        }
    }
}
