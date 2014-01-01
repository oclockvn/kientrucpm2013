using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class ThamSoDTO
    {
        int _soLuongNhapMin;
        int _soLuongNhapMax;
        int _soTienKhachHangNoMax;
        int _soLuongTonSauBanMin;

        public int SoLuongTonSauBanMin
        {
            get { return _soLuongTonSauBanMin; }
            set { _soLuongTonSauBanMin = value; }
        }

        public int SoTienKhachHangNoMax
        {
            get { return _soTienKhachHangNoMax; }
            set { _soTienKhachHangNoMax = value; }
        }

        public int SoLuongNhapMax
        {
            get { return _soLuongNhapMax; }
            set { _soLuongNhapMax = value; }
        }

        public int SoLuongNhapMin
        {
            get { return _soLuongNhapMin; }
            set { _soLuongNhapMin = value; }
        }
    }
}