using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class ChiTietHoaDonDTO
    {
        int _maChiTietHoaDon;
        string _maSach;
        int _soLuongBan;
        int _donGia;

        public int DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        public int SoLuongBan
        {
            get { return _soLuongBan; }
            set { _soLuongBan = value; }
        }

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }

        public int MaChiTietHoaDon
        {
            get { return _maChiTietHoaDon; }
            set { _maChiTietHoaDon = value; }
        }
    }
}