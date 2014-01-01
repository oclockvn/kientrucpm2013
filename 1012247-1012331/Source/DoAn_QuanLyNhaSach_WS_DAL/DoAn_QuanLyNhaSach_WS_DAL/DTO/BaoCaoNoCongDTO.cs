using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class BaoCaoNoCongDTO
    {
        int _maBaoCaoNoCong;
        string _thang;
        int _maKhachHang;
        int _noDau;
        int _phatSinh;
        int _noCuoi;

        public int NoCuoi
        {
            get { return _noCuoi; }
            set { _noCuoi = value; }
        }

        public int PhatSinh
        {
            get { return _phatSinh; }
            set { _phatSinh = value; }
        }

        public int NoDau
        {
            get { return _noDau; }
            set { _noDau = value; }
        }

        public int MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }

        public string Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }

        public int MaBaoCaoNoCong
        {
            get { return _maBaoCaoNoCong; }
            set { _maBaoCaoNoCong = value; }
        }
    }
}