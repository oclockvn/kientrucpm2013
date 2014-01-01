using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsKhachHangDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsKhachHangBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsKhachHangBLL : System.Web.Services.WebService
    {

        KhachHangBLL _khachhangBLL = new KhachHangBLL();

        #region KhachHang

        [WebMethod]
        public KhachHangDTO[] getListKhachHang()
        {
            return _khachhangBLL.getListKhachHang();
        }

        [WebMethod]
        public bool insertKhachHang(KhachHangDTO kh)
        {
            return _khachhangBLL.insertKhachHang(kh);
        }

        [WebMethod]
        public void addNewKhachHang(KhachHangDTO khachhangDTO)
        {
            _khachhangBLL.addNewKhachHang(khachhangDTO);
        }

        [WebMethod]
        public void deleteKhachHang(KhachHangDTO kh)
        {
            _khachhangBLL.deleteKhachHang(kh);
        }

        [WebMethod]
        public bool updateKhachHang(KhachHangDTO kh)
        {
            return _khachhangBLL.updateKhachHang(kh);
        }

        [WebMethod]
        public int getMaKhachHang(string hoten)
        {
            return _khachhangBLL.getMaKhachHang(hoten);
        }

        [WebMethod]
        public KhachHangDTO getKhachHangInfo(int makhachhang)
        {
            return _khachhangBLL.getKhachHangInfo(makhachhang);
        }

        #endregion
    }
}
