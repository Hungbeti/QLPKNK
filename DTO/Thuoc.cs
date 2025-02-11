﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc
    {
        private string Ten_thuoc;
        private string DVT;
        private int So_luong;
        private float Gia_ban;
        private string Ham_luong;
        private string Ghi_chu;
        private string Ten_loai;

        public Thuoc() { }

        public Thuoc(string ten_thuoc, string dvt, int so_luong, float gia_ban, string ham_luong, string ghi_chu, string ten_loai)
        {
            Ten_thuoc = ten_thuoc;
            DVT = dvt;
            So_luong = so_luong;
            Gia_ban = gia_ban;
            Ham_luong = ham_luong;
            Ghi_chu = ghi_chu;
            Ten_loai = ten_loai;
        }

        public string getTen_thuoc()
        {
            return Ten_thuoc;
        }

        public string getDVT()
        {
            return DVT;
        }

        public int getSo_luong()
        {
            return So_luong;
        }

        public float getGia_ban()
        {
            return Gia_ban;
        }

        public string getHam_luong()
        {
            return Ham_luong;
        }

        public string getGhi_chu()
        {
            return Ghi_chu;
        }

        public string getTen_loai()
        {
            return Ten_loai;
        }

        public void setTen_thuoc(string ten_thuoc) 
        { 
            Ten_thuoc = ten_thuoc; 
        }
        public void setDVT(string dvt) 
        { 
            DVT = dvt;
        }
        public void setSo_luong(int so_luong)
        { 
            So_luong = so_luong;
        }
        public void setGia_ban(float gia_ban)
        { 
            Gia_ban = gia_ban;
        }
        public void setHam_luong(string ham_luong) 
        {
            Ham_luong = ham_luong;
        }
        public void setGhi_chu(string ghi_chu) 
        { 
            Ghi_chu = ghi_chu; 
        }
        public void setTen_loai(string ten_loai) 
        { 
            Ten_loai = ten_loai; 
        }
    }
}
