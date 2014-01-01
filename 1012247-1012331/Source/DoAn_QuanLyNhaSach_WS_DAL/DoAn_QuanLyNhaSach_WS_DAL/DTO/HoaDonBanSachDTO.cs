using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class HoaDonBanSachDTO
    {
        int _maHoaDon;
        string _ngayLapHoaDon;
        int _maKhachHang;
        int _maChiTietHoaDon;
        int _tongTien;

        public int TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }

        public int MaChiTietHoaDon
        {
            get { return _maChiTietHoaDon; }
            set { _maChiTietHoaDon = value; }
        }

        public int MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }

        public string NgayLapHoaDon
        {
            get { return _ngayLapHoaDon; }
            set { _ngayLapHoaDon = value; }
        }

        public int MaHoaDon
        {
            get { return _maHoaDon; }
            set { _maHoaDon = value; }
        }
    }
}