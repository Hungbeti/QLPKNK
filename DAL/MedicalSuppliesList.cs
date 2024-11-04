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
    public class MedicalSuppliesList
    {
        public static DataSet DanhSachDungCu()
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;
            DataSet ds = new DataSet();


            cmd = new SqlCommand("SELECT * from Dung_cu", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            return ds;
        }

        public static DataSet DanhSachThuoc()
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;
            DataSet ds = new DataSet();


            cmd = new SqlCommand("SELECT * from Thuoc", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            return ds;
        }

        public static DataSet DanhSachDichVu()
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;
            DataSet ds = new DataSet();


            cmd = new SqlCommand("SELECT * from Dich_vu", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            return ds;

        }
        public static string AddDungCu(string ten, string mausac, string kichco, string dvt, string gia, string soluong, string ghichu, string loai)
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("SELECT COUNT(*) FROM Dung_cu WHERE Ten_dung_cu = @Ten_dung_cu", conn);
            cmd.Parameters.AddWithValue("@Ten_dung_cu", ten);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int count = dr.GetInt32(0);
                if (count > 0)
                {
                    dr.Close();
                    conn.Close();
                    return "Dụng cụ đã tồn tại";
                }
            }
            dr.Close();
            cmd = new SqlCommand("ThemDungCu", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ten_dung_cu", ten);
            cmd.Parameters.AddWithValue("@Mau_sac", mausac);
            cmd.Parameters.AddWithValue("@Kich_co", float.Parse(kichco));
            cmd.Parameters.AddWithValue("@DVT", dvt);
            cmd.Parameters.AddWithValue("@Gia", float.Parse(gia)); // Assuming gia is a string representing a float value
            cmd.Parameters.AddWithValue("@So_luong", int.Parse(soluong)); // Assuming soluong is a string representing an integer value
            cmd.Parameters.AddWithValue("@Ghi_chu", ghichu);
            cmd.Parameters.AddWithValue("@Loai", loai);


            cmd.ExecuteNonQuery();
            dr.Close();
            conn.Close();

            return "Thêm dụng cụ thành công";
        }
        public static string AddDichVu(string ten, string dtv, string dongia, string ghichu, string tendanhmuc)
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("SELECT COUNT(*) FROM Dich_vu WHERE Ten_dich_vu = @Ten_dich_vu", conn);
            cmd.Parameters.AddWithValue("@Ten_dich_vu", ten);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int count = dr.GetInt32(0);
                if (count > 0)
                {
                    dr.Close();
                    conn.Close();
                    return "Dịch vụ đã tồn tại";
                }
            }
            dr.Close();
            cmd = new SqlCommand("ThemDichVu", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ten_dich_vu", ten);
            cmd.Parameters.AddWithValue("@Don_vi_tinh", dtv);
            cmd.Parameters.AddWithValue("@Don_gia", float.Parse(dongia)); // Assuming dongia is a string representing a float value
            cmd.Parameters.AddWithValue("@Ghi_chu", ghichu);
            cmd.Parameters.AddWithValue("@Ten_danh_muc", tendanhmuc);



            cmd.ExecuteNonQuery();
            dr.Close();
            conn.Close();

            return "Thêm dịch vụ thành công";
        }
        public static string AddThuoc(string ten, string dvt, string soluong, string giaban, string hamluong, string ghichu, string loai)
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("SELECT COUNT(*) FROM Thuoc WHERE Ten_thuoc = @Ten_thuoc", conn);
            cmd.Parameters.AddWithValue("@Ten_thuoc", ten);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int count = dr.GetInt32(0);
                if (count > 0)
                {
                    dr.Close();
                    conn.Close();
                    return "Thuốc đã tồn tại";
                }
            }
            dr.Close();
            cmd = new SqlCommand("ThemThuoc", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ten_thuoc", ten);
            cmd.Parameters.AddWithValue("@DVT", dvt);
            cmd.Parameters.AddWithValue("@So_luong", int.Parse(soluong)); // Assuming soluong is a string representing an integer value
            cmd.Parameters.AddWithValue("@Gia_ban", float.Parse(giaban)); // Assuming giaban is a string representing a float value
            cmd.Parameters.AddWithValue("@Ham_luong", hamluong);
            cmd.Parameters.AddWithValue("@Ghi_chu", ghichu);
            cmd.Parameters.AddWithValue("@Ten_loai  ", loai);



            cmd.ExecuteNonQuery();
            conn.Close();

            return "Thêm thuốc thành công";
        }
        public static string EditDungCu(string ten, string mausac, string kichco, string dvt, string gia, string soluong, string ghichu, string loai)
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;

            cmd = new SqlCommand("UPDATE Dung_cu SET Mau_sac = @Mau_sac, Kich_co = @Kich_co, DVT = @DVT, Gia = @Gia, So_luong = @So_luong, Ghi_chu = @Ghi_chu, Loai = @Loai WHERE Ten_dung_cu = @Ten_dung_cu", conn);
            cmd.Parameters.AddWithValue("@Ten_dung_cu", ten);
            cmd.Parameters.AddWithValue("@Mau_sac", mausac);
            cmd.Parameters.AddWithValue("@Kich_co", float.Parse(kichco));
            cmd.Parameters.AddWithValue("@DVT", dvt);
            cmd.Parameters.AddWithValue("@Gia", float.Parse(gia));
            cmd.Parameters.AddWithValue("@So_luong", int.Parse(soluong));
            cmd.Parameters.AddWithValue("@Ghi_chu", ghichu);
            cmd.Parameters.AddWithValue("@Loai", loai);

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
                return "Sửa dụng cụ thành công";
            else
                return "Không tìm thấy dụng cụ để sửa";
        }

        public static string EditDichVu(string ten, string dtv, string dongia, string ghichu, string tendanhmuc)
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;

            cmd = new SqlCommand("UPDATE Dich_vu SET Don_vi_tinh = @Don_vi_tinh, Don_gia = @Don_gia, Ghi_chu = @Ghi_chu, Ten_danh_muc = @Ten_danh_muc WHERE Ten_dich_vu = @Ten_dich_vu", conn);
            cmd.Parameters.AddWithValue("@Ten_dich_vu", ten);
            cmd.Parameters.AddWithValue("@Don_vi_tinh", dtv);
            cmd.Parameters.AddWithValue("@Don_gia", float.Parse(dongia));
            cmd.Parameters.AddWithValue("@Ghi_chu", ghichu);
            cmd.Parameters.AddWithValue("@Ten_danh_muc", tendanhmuc);

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
                return "Sửa dịch vụ thành công";
            else
                return "Không tìm thấy dịch vụ để sửa";
        }

        public static string EditThuoc(string ten, string dvt, string soluong, string giaban, string hamluong, string ghichu, string loai)
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;

            cmd = new SqlCommand("UPDATE Thuoc SET DVT = @DVT, So_luong = @So_luong, Gia_ban = @Gia_ban, Ham_luong = @Ham_luong, Ghi_chu = @Ghi_chu, Ten_loai = @Ten_loai WHERE Ten_thuoc = @Ten_thuoc", conn);
            cmd.Parameters.AddWithValue("@Ten_thuoc", ten);
            cmd.Parameters.AddWithValue("@DVT", dvt);
            cmd.Parameters.AddWithValue("@So_luong", int.Parse(soluong));
            cmd.Parameters.AddWithValue("@Gia_ban", float.Parse(giaban));
            cmd.Parameters.AddWithValue("@Ham_luong", hamluong);
            cmd.Parameters.AddWithValue("@Ghi_chu", ghichu);
            cmd.Parameters.AddWithValue("@Ten_loai", loai);

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
                return "Sửa thuốc thành công";
            else
                return "Không tìm thấy thuốc để sửa";
        }

        public static string DeleteThuoc(string ten)
        {
            //using (SqlConnection conn = Connection.dbConnect())
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("DELETE FROM Thuoc WHERE Ten_thuoc = @Ten_thuoc", conn);
            //    cmd.Parameters.AddWithValue("@Ten_thuoc", ten);

            //    int rowsAffected = cmd.ExecuteNonQuery();
            //    conn.Close();

            //    return rowsAffected > 0 ? "Xóa thuốc thành công" : "Không tìm thấy thuốc để xóa";
            //}

            using (SqlConnection conn = Connection.dbConnect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Thuoc WHERE Ten_thuoc = @Ten_thuoc", conn);
                cmd.Parameters.AddWithValue("@Ten_thuoc", ten);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0 ? "Xóa thuốc thành công" : "Không tìm thấy thuốc để xóa";
            }

        }


        public static DTO.Thuoc GetThuoc(string id)
        {
            DTO.Thuoc thuoc = null;
            string query = "SELECT * FROM Thuoc WHERE Ten_thuoc = @Id";

            SqlConnection connection = Connection.dbConnect();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                thuoc = new DTO.Thuoc(
                    reader["Ten_thuoc"].ToString(),
                    reader["DVT"].ToString() ?? "", // Replace null with empty string
                    reader["So_luong"] != DBNull.Value ? Convert.ToInt32(reader["So_luong"]) : 0, // Replace null with 0
                    reader["Gia_ban"] != DBNull.Value ? Convert.ToSingle(reader["Gia_ban"]) : 0, // Replace null with 0
                    reader["Ham_luong"].ToString() ?? "", // Replace null with empty string
                    reader["Ghi_chu"].ToString() ?? "", // Replace null with empty string
                    reader["Ten_loai"].ToString() ?? "" // Replace null with empty string
                );
            }

            reader.Close();
            connection.Close();
            return thuoc;
        }

        public static DTO.Dich_vu GetDichVu(string id)
        {
            DTO.Dich_vu dichVu = null;
            string query = "SELECT * FROM Dich_vu WHERE Ten_dich_vu = @Id";

            SqlConnection connection = Connection.dbConnect();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Initialize DTO.Dich_vu object using constructor
                dichVu = new DTO.Dich_vu(
                    reader["Ten_dich_vu"].ToString(),
                    reader["Don_vi_tinh"].ToString() ?? "", // Replace null with empty string
                    reader["Don_gia"] != DBNull.Value ? Convert.ToSingle(reader["Don_gia"]) : 0, // Replace null with 0
                    reader["Ghi_chu"].ToString() ?? "", // Replace null with empty string
                    reader["Ten_danh_muc"].ToString() ?? "" // Replace null with empty string
                );
            }

            reader.Close();
            connection.Close();

            return dichVu;
        }

        public static DTO.Dung_cu GetVatLieu(string id)
        {
            DTO.Dung_cu vatLieu = null;
            string query = "SELECT * FROM Vat_lieu WHERE Ten_dung_cu = @Id";
            SqlConnection connection = Connection.dbConnect();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Initialize DTO.Vat_lieu object using constructor
                vatLieu = new DTO.Dung_cu(
                    reader["Ten_dung_cu"].ToString(),
                    reader["Mau_sac"].ToString() ?? "", // Replace null with empty string
                    reader["Kich_co"] != DBNull.Value ? Convert.ToSingle(reader["Kich_co"]) : 0, // Replace null with 0
                    reader["DVT"].ToString() ?? "", // Replace null with empty string
                    reader["Gia"] != DBNull.Value ? Convert.ToSingle(reader["Gia"]) : 0, // Replace null with 0
                    reader["So_luong"] != DBNull.Value ? Convert.ToInt32(reader["So_luong"]) : 0, // Replace null with 0
                    reader["Ghi_chu"].ToString() ?? "", // Replace null with empty string
                    reader["Loai"].ToString() ?? "" // Replace null with empty string
                );
            }

            reader.Close();
            connection.Close();

            return vatLieu;
        }
    }
}
