using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class PhieuNhapSachDTO
    {
        int _maPhieuNhapSach;
        int _maChiTietPhieuNhapSach;
        string _ngayNhap;
        int _tongSoLuongNhap;

        public int TongSoLuongNhap
        {
            get { return _tongSoLuongNhap; }
            set { _tongSoLuongNhap = value; }
        }

        public string NgayNhap
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; }
        }

        public int MaChiTietPhieuNhapSach
        {
            get { return _maChiTietPhieuNhapSach; }
            set { _maChiTietPhieuNhapSach = value; }
        }

        public int MaPhieuNhapSach
        {
            get { return _maPhieuNhapSach; }
            set { _maPhieuNhapSach = value; }
        }
    }
}