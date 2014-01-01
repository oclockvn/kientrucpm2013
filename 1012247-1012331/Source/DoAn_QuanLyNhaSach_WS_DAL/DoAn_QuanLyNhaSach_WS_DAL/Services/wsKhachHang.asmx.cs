using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.Services
{
    /// <summary>
    /// Summary description for wsKhachHang
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsKhachHang : System.Web.Services.WebService
    {
        KhachHangDAL _khachhangDAL = new KhachHangDAL();

        #region KhachHang

        [WebMethod]
        public KhachHangDTO[] getListKhachHang()
        {
            return _khachhangDAL.getListKhachHang();
        }

        [WebMethod]
        public bool insertKhachHang(KhachHangDTO khachhangDTO)
        {
            return _khachhangDAL.insertKhachHang(khachhangDTO);
        }

        [WebMethod]
        public void addNewKhachHang(KhachHangDTO khachhangDTO)
        {
            _khachhangDAL.addNewKhachHang(khachhangDTO);
        }

        [WebMethod]
        public void deleteKhachHang(KhachHangDTO kh)
        {
            _khachhangDAL.deleteKhachHang(kh);
        }

        [WebMethod]
        public bool updateKhachHang(KhachHangDTO kh)
        {
            return _khachhangDAL.updateKhachHang(kh);
        }

        [WebMethod]
        public int getMaKhachHang(string hoten)
        {
            return _khachhangDAL.getMaKhachHang(hoten);
        }

        [WebMethod]
        public KhachHangDTO getKhachHangInfo(int makhachhang)
        {
            return _khachhangDAL.getKhachHangInfo(makhachhang);
        }

        #endregion        
    }
}
