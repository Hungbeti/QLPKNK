using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Login
    {
        public static string Log(DTO.TaiKhoan account)
        {
            if (account.getTaiKhoan().Length == 0 || account.getTaiKhoan().Equals("Tên tài khoản/ Email"))
            {
                return "Vui lòng nhập tài khoản";
            }
            if (account.getMatKhau().Length == 0 || account.getMatKhau().Equals("Mật khẩu"))
            {
                return "Vui lòng nhập mật khẩu";
            }
            return DAL.Login.Log(account);
        }
    }
}
