using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User
    {
        public static DTO.Nguoi_dung GetUser(string taikhoan)
        {
            return DAL.USER.GetUSER(taikhoan);
        }
    }
}
