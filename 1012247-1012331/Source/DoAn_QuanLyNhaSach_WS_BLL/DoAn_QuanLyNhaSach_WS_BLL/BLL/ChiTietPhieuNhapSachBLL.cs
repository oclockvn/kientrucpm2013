using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsChiTietPhieuNhapSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class ChiTietPhieuNhapSachBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsChiTietPhieuNhapSachSoapClient wsDAL = new wsChiTietPhieuNhapSachSoapClient();

        public void insertChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            wsDAL.insertChiTietPhieuNhapSach(chitiet);
        }

        public int getSoLuongSachNhap(string masach)
        {
            return wsDAL.getSoLuongSachNhap(masach);
        }

        public ChiTietPhieuNhapSachDTO[] getListChiTietPhieuNhapSach()
        {
            return wsDAL.getListChiTietPhieuNhapSach();
        }

        public bool deleteChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            return wsDAL.deleteChiTietPhieuNhapSach(chitiet);
        }

        public void updateChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            wsDAL.updateChiTietPhieuNhapSach(chitiet);
        }

        public int getMaChiTietPhieuNhapSach(string masach)
        {
            return wsDAL.getMaChiTietPhieuNhapSach(masach);
        }
    }
}