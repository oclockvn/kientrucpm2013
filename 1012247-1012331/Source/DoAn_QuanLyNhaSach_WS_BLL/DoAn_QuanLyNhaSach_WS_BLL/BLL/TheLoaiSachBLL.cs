using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsTheLoaiSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class TheLoaiSachBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsTheLoaiSachSoapClient wsDAL = new wsTheLoaiSachSoapClient();

        public TheLoaiSachDTO[] getListTheLoaiSach()
        {
            return wsDAL.getListTheLoaiSach();
        }

        public int getMaTheLoai(string tentheloai)
        {
            return wsDAL.getMaTheLoai(tentheloai);
        }

        public string getTenTheLoai(int matheloai)
        {
            return wsDAL.getTenTheLoai(matheloai);
        }
    }
}