using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chu
    {
        private string Ma_chu;

        public Chu() { }

        public Chu(string Ma_chu) { this.Ma_chu = Ma_chu; }

        public string getMa_chu() { return Ma_chu; }
        public void setMa_chu(string Ma_chu) { this.Ma_chu = Ma_chu; }
    }
}
