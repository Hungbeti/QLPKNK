using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Login
    {
        public static string Log(DTO.Tai_khoan account)
        {
            string message = "";

            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_check_login", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@taikhoan", account.getTaiKhoan());
            cmd.Parameters.AddWithValue("@matkhau", account.getMatKhau());

            SqlParameter outputParameter = new SqlParameter
            {
                ParameterName = "@message",
                SqlDbType = SqlDbType.NVarChar,
                Size = 1000,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputParameter);

            cmd.ExecuteNonQuery();
            message = outputParameter.Value.ToString();
            conn.Close();
            return message;
        }

    }
}
