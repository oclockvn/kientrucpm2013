using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class SachBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsSachSoapClient wsDAL = new wsSachSoapClient();

        public SachDTO[] getListSach()
        {
            return wsDAL.getListSach();
        }

        public bool insertSach(SachDTO sach)
        {
            return wsDAL.insertSach(sach);
        }

        public void deleteSach(SachDTO sach)
        {
            wsDAL.deleteSach(sach);
        }

        public bool updateSach(SachDTO sach)
        {
            return wsDAL.updateSach(sach);
        }

        public int getSoLuongTon(string tensach)
        {
            return wsDAL.getSoLuongTon(tensach);
        }

        public int getDonGiaSach(string tensach, string masach)
        {
            return wsDAL.getDonGiaSach(tensach, masach);
        }

        public int getMaTheLoaiSach(string masach)
        {
            return wsDAL.getMaTheLoaiSach(masach);
        }

        public bool checkIsExistBook(int masach)
        {
            return wsDAL.checkIsExistBook(masach);
        }

        public SachDTO[] searchSach(SachDTO sach)
        {
            return wsDAL.searchSach(sach);
        }

        public SachDTO[] searchSachByCatalog(SachDTO sach, string muc)
        {
            return wsDAL.searchSachByCatalog(sach, muc);
        }

        public string getMaSach(string tensach)
        {
            return wsDAL.getMaSach(tensach);
        }
    }
}