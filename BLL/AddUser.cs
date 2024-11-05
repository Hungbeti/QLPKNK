using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AddUser
    {
        public static string Add(DTO.Nguoi_dung user)
        {
            DAL.AddUser.Add(user);
            return "Thêm nhân viên thành công";
        }
        public static void EditUser(DTO.Nguoi_dung user)
        {
            DAL.AddUser.EditUser(user);
        }
        public static string DisableUser(string maNhanVien)
        {
            DAL.AddUser.DisableUser(maNhanVien);
            return "Nhân viên đã bị vô hiệu hóa";
        }
    }
}
