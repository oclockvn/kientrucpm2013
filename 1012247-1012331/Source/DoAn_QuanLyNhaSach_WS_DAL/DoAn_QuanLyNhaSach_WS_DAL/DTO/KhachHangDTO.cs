using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class KhachHangDTO
    {
        int _maKhachHang;
        string _hoTen;
        string _diaChi;
        string _dienThoai;
        string _email;
        int _soTienNo;

        public int SoTienNo
        {
            get { return _soTienNo; }
            set { _soTienNo = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public int MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }
    }
}