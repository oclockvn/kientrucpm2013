using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class SachDTO
    {
        string _maSach;
        string _tenSach;
        int _maTheLoai;
        string _tacGia;
        int _donGia;
        int _soLuongTon;

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }

        public int DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }

        public int MaTheLoai
        {
            get { return _maTheLoai; }
            set { _maTheLoai = value; }
        }

        public string TenSach
        {
            get { return _tenSach; }
            set { _tenSach = value; }
        }

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
    }
}