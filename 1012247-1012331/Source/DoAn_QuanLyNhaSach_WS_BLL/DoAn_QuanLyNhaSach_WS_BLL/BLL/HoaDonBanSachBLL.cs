using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsHoaDonBanSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class HoaDonBanSachBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsHoaDonBanSachSoapClient wsDAL = new wsHoaDonBanSachSoapClient();

        public void insertHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            wsDAL.insertHoaDonBanSach(hoadonDTO);
        }

        public void addNewHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            wsDAL.addNewHoaDonBanSach(hoadonDTO);
        }

        public void updateHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            wsDAL.updateHoaDonBanSach(hoadonDTO);
        }

        public int getTongTienHoaDonBanSach()
        {
            return wsDAL.getTongTienHoaDonBanSach();
        }

        public HoaDonBanSachDTO[] deleteAllTableHoaDonBanSach()
        {
            return wsDAL.deleteAllTableHoaDonBanSach();
        }
    }
}