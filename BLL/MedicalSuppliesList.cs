using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public static class MedicalSuppliesList
    {
        public static DataSet DanhSachDungCu()
        {
            return DAL.MedicalSuppliesList.DanhSachDungCu(); ;
        }

        public static DataSet DanhSachThuoc()
        {
            return DAL.MedicalSuppliesList.DanhSachThuoc();
        }

        public static DataSet DanhSachDichVu()
        {
            return DAL.MedicalSuppliesList.DanhSachDichVu(); ;
        }

        public static DTO.Thuoc GetThuoc(string id)
        {
            return DAL.MedicalSuppliesList.GetThuoc(id);
        }
        public static DTO.Dich_vu GetDichVu(string id)
        {
            return DAL.MedicalSuppliesList.GetDichVu(id);
        }

        public static DTO.Dung_cu GetDungCu(string id)
        {
            return DAL.MedicalSuppliesList.GetDungCu(id);
        }

        public static string AddDungCu(string ten, string mausac, string kichco, string dvt, string gia, string soluong, string ghichu, string loai)
        {
            return DAL.MedicalSuppliesList.AddDungCu(ten, mausac, kichco, dvt, gia, soluong, ghichu, loai);
        }
        public static string AddDichVu(string ten, string dtv, string dongia, string ghichu, string tendanhmuc)
        {
            return DAL.MedicalSuppliesList.AddDichVu(ten, dtv, dongia, ghichu, tendanhmuc);
        }
        public static string AddThuoc(string ten, string dvt, string soluong, string giaban, string hamluong, string ghichu, string loai)
        {
            return DAL.MedicalSuppliesList.AddThuoc(ten, dvt, soluong, giaban, hamluong, ghichu, loai);
        }

        public static string EditDungCu(string ten, string mausac, string kichco, string dvt, string gia, string soluong, string ghichu, string loai)
        {
            return DAL.MedicalSuppliesList.EditDungCu(ten, mausac, kichco, dvt, gia, soluong, ghichu, loai);
        }
        public static string EditDichVu(string ten, string dtv, string dongia, string ghichu, string tendanhmuc)
        {
            return DAL.MedicalSuppliesList.EditDichVu(ten, dtv, dongia, ghichu, tendanhmuc);
        }
        public static string EditThuoc(string ten, string dvt, string soluong, string giaban, string hamluong, string ghichu, string loai)
        {
            return DAL.MedicalSuppliesList.EditThuoc(ten, dvt, soluong, giaban, hamluong, ghichu, loai);
        }
    }
}
