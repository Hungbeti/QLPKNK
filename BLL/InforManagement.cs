using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public static class InforManagement
    {
        public static DataSet DanhSachLeTan()
        {
            return DAL.InforManagement.DanhSachLeTan(); ;
        }

        public static DataSet DanhSachBacSi()
        {
            return DAL.InforManagement.DanhSachBacSi();
        }

        public static DataSet DanhSachBenhNhan()
        {
            return DAL.InforManagement.DanhSachBenhNhan();
        }

        //public static DTO.Thuoc GetThuoc(string id)
        //{
        //    return DAL.StafInfor.GetThuoc(id);
        //}
        //public static DTO.Dich_vu GetDichVu(string id)
        //{
        //    return DAL.StafInfor.GetDichVu(id);
        //}

        //public static string AddDungCu(string ten, string mausac, string kichco, string dvt, string gia, string soluong, string ghichu, string loai)
        //{
        //    return DAL.StafInfor.AddDungCu(ten, mausac, kichco, dvt, gia, soluong, ghichu, loai);
        //}
        //public static string AddDichVu(string ten, string dtv, string dongia, string ghichu, string tendanhmuc)
        //{
        //    return DAL.StafInfor.AddDichVu(ten, dtv, dongia, ghichu, tendanhmuc);
        //}

        //public static string EditDungCu(string ten, string mausac, string kichco, string dvt, string gia, string soluong, string ghichu, string loai)
        //{
        //    return DAL.StafInfor.EditDungCu(ten, mausac, kichco, dvt, gia, soluong, ghichu, loai);
        //}
        //public static string EditDichVu(string ten, string dtv, string dongia, string ghichu, string tendanhmuc)
        //{
        //    return DAL.StafInfor.EditDichVu(ten, dtv, dongia, ghichu, tendanhmuc);
        //}
    }
}
