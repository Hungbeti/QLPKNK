using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class InforManagement
    {
        public static DataSet DanhSachLeTan()
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;
            DataSet ds = new DataSet();


            cmd = new SqlCommand("SELECT nd.Ma_nhan_vien, nd.Ho, nd.Ten, nd.Gioi_tinh, nd.Hoatdong " +
                                "FROM Nguoi_dung nd " +
                                "JOIN Le_tan lt ON nd.Ma_nhan_vien = lt.Ma_le_tan", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            return ds;
        }

        public static DataSet DanhSachBacSi()
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;
            DataSet ds = new DataSet();


            cmd = new SqlCommand(@"SELECT nd.Ma_nhan_vien, nd.Ho, nd.Ten, nd.Gioi_tinh, bs.Chuyen_khoa, nd.Hoatdong 
                                FROM Nguoi_dung AS nd
                                JOIN Bac_si AS bs ON nd.Ma_nhan_vien = bs.Ma_bac_si", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            return ds;
        }

        public static DataSet DanhSachBenhNhan()
        {
            SqlConnection conn = Connection.dbConnect();
            conn.Open();
            SqlCommand cmd;
            DataSet ds = new DataSet();


            cmd = new SqlCommand(@"SELECT nk.STT, bn.Ho + ' ' + bn.Ten AS Ten_benh_nhan, bn.Gioi_tinh, bn.Ngay_sinh, nk.Ngay AS Ngay_kham
                                FROM Nguoi_kham AS nk
                                JOIN Benh_nhan AS bn ON bn.CCCD = nk.Ma_benh_nhan", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            return ds;
        }
    }
}
