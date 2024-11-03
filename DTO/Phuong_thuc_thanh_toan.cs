using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phuong_thuc_thanh_toan
    {
        private string Ten;

        public Phuong_thuc_thanh_toan() { }

        public Phuong_thuc_thanh_toan(string Ten) { this.Ten = Ten; }

        public string getTen() 
        { 
            return Ten; 
        }
        public void setTen(string Ten) 
        { 
            this.Ten = Ten; 
        }
    }
}
