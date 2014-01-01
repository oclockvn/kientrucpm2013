using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class PhieuNhapSachBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsPhieuNhapSachSoapClient wsDAL = new wsPhieuNhapSachSoapClient();

        public void insertPhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            wsDAL.insertPhieuNhapSach(phieuDTO);
        }

        public bool deletePhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            return wsDAL.deletePhieuNhapSach(phieuDTO);
        }

        public void updatePhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            wsDAL.updatePhieuNhapSach(phieuDTO);
        }
    }
}