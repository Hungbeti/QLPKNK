using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Le_Tan
    {
        private string Ma_le_tan;

        public Le_Tan() { }

        public Le_Tan(string Ma_le_tan) 
        {
            this.Ma_le_tan = Ma_le_tan;
        }

        public string getMa_le_tan()
        { 
            return Ma_le_tan;
        }
        public void setMa_le_tan(string Ma_le_tan) 
        { 
            this.Ma_le_tan = Ma_le_tan;
        }
    }
}
