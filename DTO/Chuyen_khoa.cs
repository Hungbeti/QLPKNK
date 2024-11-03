using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenKhoa
    {
        private string Ten;

        public ChuyenKhoa() { }

        public ChuyenKhoa(string Ten) 
        { 
            this.Ten = Ten; 
        }

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
