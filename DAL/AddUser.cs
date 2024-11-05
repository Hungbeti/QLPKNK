using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AddUser
    {
        public static void Add(DTO.Nguoi_dung user)
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Them_Nhan_Vien", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ho", user.GetHo());
            cmd.Parameters.AddWithValue("@Ten", user.GetTen());
            cmd.Parameters.AddWithValue("@Gioi_tinh", user.GetGioiTinh());
            cmd.Parameters.AddWithValue("@Ngay_sinh", user.GetNgaySinh().ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@Que_quan", user.GetQueQuan());
            cmd.Parameters.AddWithValue("@CCCD", user.GetCCCD());
            cmd.Parameters.AddWithValue("@Maluong", user.GetMaLuong());

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void EditUser(DTO.Nguoi_dung user)
        {
            string query = "UPDATE Nguoi_dung SET Ho = @Ho, Ten = @Ten, Gioi_tinh = @GioiTinh, Ngay_sinh = @NgaySinh, " +
                           "email = @Email, Que_quan = @QueQuan, CCCD = @CCCD WHERE Ma_nhan_vien = @MaNhanVien";
            SqlConnection connection = Connection.dbConnect();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ho", user.GetHo());
            command.Parameters.AddWithValue("@Ten", user.GetTen());
            command.Parameters.AddWithValue("@GioiTinh", user.GetGioiTinh());
            command.Parameters.AddWithValue("@NgaySinh", user.GetNgaySinh());
            command.Parameters.AddWithValue("@QueQuan", user.GetQueQuan());
            command.Parameters.AddWithValue("@CCCD", user.GetCCCD());
            command.Parameters.AddWithValue("@MaNhanVien", user.GetMaNhanVien());

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void DisableUser(string maNhanVien)
        {
            string query = "UPDATE Nguoi_dung SET Trang_thai = 0 WHERE Ma_nhan_vien = @MaNhanVien";
            using (SqlConnection conn = Connection.dbConnect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
