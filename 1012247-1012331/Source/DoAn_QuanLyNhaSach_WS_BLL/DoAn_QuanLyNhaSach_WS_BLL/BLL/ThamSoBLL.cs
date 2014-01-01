using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsThamSoDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class ThamSoBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsThamSoSoapClient wsDAL = new wsThamSoSoapClient();

        public int getSoLuongNhapMin()
        {
            return wsDAL.getSoLuongNhapMin();
        }

        public int getSoLuongTonMax()
        {
            return wsDAL.getSoLuongTonMax();
        }

        public int getSoTienKhachHangNoMax()
        {
            return wsDAL.getSoTienKhachHangNoMax();
        }

        public int getSoLuongTonSauBanMin()
        {
            return wsDAL.getSoLuongTonSauBanMin();
        }
    }
}