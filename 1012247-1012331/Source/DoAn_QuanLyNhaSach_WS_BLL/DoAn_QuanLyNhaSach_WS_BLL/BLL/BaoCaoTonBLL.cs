using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsBaoCaoTonDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class BaoCaoTonBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsBaoCaoTonSoapClient wsDAL = new wsBaoCaoTonSoapClient();

        public BaoCaoTonDTO[] getListBaoCaoTon()
        {
            return wsDAL.getListBaoCaoTon();
        }

        public void insertBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            wsDAL.insertBaoCaoTon(baocaoDTO);
        }

        public void deleteBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            wsDAL.deleteBaoCaoTon(baocaoDTO);
        }

        public void updateBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            wsDAL.updateBaoCaoTon(baocaoDTO);
        }
    }
}