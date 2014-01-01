using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsPhieuThuTienDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class PhieuThuTienBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsPhieuThuTienSoapClient wsDAL = new wsPhieuThuTienSoapClient();

        public PhieuThuTienDTO[] getListPhieuThuTien()
        {
            return wsDAL.getListPhieuThuTien();
        }

        public void insertPhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            wsDAL.insertPhieuThuTien(phieuDTO);
        }

        public bool deletePhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            return wsDAL.deletePhieuThuTien(phieuDTO);
        }

        public void updatePhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            wsDAL.updatePhieuThuTien(phieuDTO);
        }
    }
}