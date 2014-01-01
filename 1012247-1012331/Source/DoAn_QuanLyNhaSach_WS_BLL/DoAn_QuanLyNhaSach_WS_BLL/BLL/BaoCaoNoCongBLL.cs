using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsBaoCaoNoCongDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class BaoCaoNoCongBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsBaoCaoNoCongSoapClient wsDAL = new wsBaoCaoNoCongSoapClient();
        

        public BaoCaoNoCongDTO[] getListBaoCaoNoCong()
        {
            return wsDAL.getListBaoCaoNoCong();            
        }

        public void insertBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            wsDAL.insertBaoCaoNoCong(baocaoDTO);
        }

        public void updateBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            wsDAL.updateBaoCaoNoCong(baocaoDTO);
        }

        public void deleteBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            wsDAL.deleteBaoCaoNoCong(baocaoDTO);
        }
    }
}