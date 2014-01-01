using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class BaoCaoTonDTO
    {
        int _maBaoCaoTon;
        string _thang;
        string _maSach;
        int _tonDau;
        int _phatSinh;
        int _tonCuoi;

        public int TonCuoi
        {
            get { return _tonCuoi; }
            set { _tonCuoi = value; }
        }

        public int PhatSinh
        {
            get { return _phatSinh; }
            set { _phatSinh = value; }
        }

        public int TonDau
        {
            get { return _tonDau; }
            set { _tonDau = value; }
        }

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }

        public string Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }

        public int MaBaoCaoTon
        {
            get { return _maBaoCaoTon; }
            set { _maBaoCaoTon = value; }
        }
    }
}