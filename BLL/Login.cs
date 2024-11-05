using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Login
    {
        static char tach = '?';
        private static string Encode(string str)
        {
            try
            {
                string s = "";
                byte[] bit = Encoding.Unicode.GetBytes(str);

                for (int index = 0; index < bit.Length; index++)
                {
                    s += bit[index];
                    if (index < bit.Length - 1) s += tach.ToString();
                }
                return s;
            }
            catch
            {
                return "";
            }

        }

        private static string Decode(string str)
        {
            try
            {
                List<Byte> bytes = new List<byte>();
                string[] temp = str.Split(tach);

                for (int index = 0; index < temp.Length; index++)
                {
                    bytes.Add(new byte());
                    if (temp[index] != "") bytes[index] = byte.Parse(temp[index]);
                }
                return Encoding.Unicode.GetString(bytes.ToArray());
            }
            catch
            {
                return "";
            }
        }

        public static DTO.Tai_khoan Load()
        {

            FileStream fileStream;
            if (!File.Exists("Config.ini"))
            {
                fileStream = new FileStream("Config.ini", FileMode.Create);
                fileStream = new FileStream("Config.ini", FileMode.Append);
                StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
                streamWriter.WriteLine("0");
                streamWriter.Close();
            }
            string[] line = File.ReadAllLines("Config.ini");
            if (line.Length > 0 && line[line.Length - 1] == "1")
            {
                DTO.Tai_khoan account = new Tai_khoan();
                account.setTaiKhoan(Decode(line[line.Length - 2]));
                account.setMatKhau(Decode(line[line.Length - 3]));
                return account;
            }
            return null;
        }
        public static string Log(DTO.Tai_khoan account)
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
