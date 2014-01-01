using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class ChiTietPhieuNhapSachDTO
    {
        int _maChiTietPhieuNhapSach;
        string _maSach;
        int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }

        public int MaChiTietPhieuNhapSach
        {
            get { return _maChiTietPhieuNhapSach; }
            set { _maChiTietPhieuNhapSach = value; }
        }
    }
}