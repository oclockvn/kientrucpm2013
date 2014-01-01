using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsChiTietHoaDonDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class ChiTietHoaDonBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsChiTietHoaDonSoapClient wsDAL = new wsChiTietHoaDonSoapClient();

        public ChiTietHoaDonDTO[] getListChiTietHoaDon()
        {
            return wsDAL.getListChiTietHoaDon();
        }

        public bool insertChiTietHoaDon(ChiTietHoaDonDTO chitietDTO)
        {
            return wsDAL.insertChiTietHoaDon(chitietDTO);
        }

        public int getMaChiTietHoaDon(string masach)
        {
            return wsDAL.getMaChiTietHoaDon(masach);
        }

        public ChiTietHoaDonDTO[] deleteAllTableChiTietHoaDon()
        {
            return wsDAL.deleteAllTableChiTietHoaDon();
        }

        public int getTongTien(string masach)
        {
            return wsDAL.getTongTien(masach);
        }
    }
}