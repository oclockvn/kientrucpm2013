using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_QuanLyNhaSach_WS_DAL.DTO
{
    public class TheLoaiSachDTO
    {
        int _maTheLoai;
        string _tenTheLoai;

        public string TenTheLoai
        {
            get { return _tenTheLoai; }
            set { _tenTheLoai = value; }
        }

        public int MaTheLoai
        {
            get { return _maTheLoai; }
            set { _maTheLoai = value; }
        }
    }
}