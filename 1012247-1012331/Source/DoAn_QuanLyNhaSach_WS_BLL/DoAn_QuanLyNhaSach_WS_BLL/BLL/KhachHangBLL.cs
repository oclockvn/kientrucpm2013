using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAn_QuanLyNhaSach_WS_BLL.wsKhachHangDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.BLL
{
    public class KhachHangBLL
    {
        //DoAn_WebService_DALSoapClient wsDAL = new DoAn_WebService_DALSoapClient();
        wsKhachHangSoapClient wsDAL = new wsKhachHangSoapClient();

        public KhachHangDTO[] getListKhachHang()
        {
            return wsDAL.getListKhachHang();
        }

        public bool insertKhachHang(KhachHangDTO kh)
        {
            return wsDAL.insertKhachHang(kh);
        }

        public void addNewKhachHang(KhachHangDTO khachhangDTO)
        {
            wsDAL.addNewKhachHang(khachhangDTO);
        }

        public void deleteKhachHang(KhachHangDTO kh)
        {
            wsDAL.deleteKhachHang(kh);
        }

        public bool updateKhachHang(KhachHangDTO kh)
        {
            return wsDAL.updateKhachHang(kh);
        }

        public int getMaKhachHang(string hoten)
        {
            return wsDAL.getMaKhachHang(hoten);
        }

        public KhachHangDTO getKhachHangInfo(int makhachhang)
        {
            return wsDAL.getKhachHangInfo(makhachhang);
        }
    }
}