using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class PhieuThuTienDTO
    {
        int _maPhieuThu;
        string _ngayThu;
        int _soTienThu;
        int _maKhachHang;

        public int MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }

        public int SoTienThu
        {
            get { return _soTienThu; }
            set { _soTienThu = value; }
        }

        public string NgayThu
        {
            get { return _ngayThu; }
            set { _ngayThu = value; }
        }

        public int MaPhieuThu
        {
            get { return _maPhieuThu; }
            set { _maPhieuThu = value; }
        }
    }
}