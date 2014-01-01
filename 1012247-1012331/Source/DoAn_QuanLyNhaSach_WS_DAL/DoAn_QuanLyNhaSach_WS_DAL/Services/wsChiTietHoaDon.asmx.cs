using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.Services
{
    /// <summary>
    /// Summary description for wsChiTietHoaDon
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsChiTietHoaDon : System.Web.Services.WebService
    {
        ChiTietHoaDonDAL _chitiethoadonDAL = new ChiTietHoaDonDAL();

        #region ChiTietHoaDon

        [WebMethod]
        public ChiTietHoaDonDTO[] getListChiTietHoaDon()
        {
            return _chitiethoadonDAL.getListChiTietHoaDon();
        }

        [WebMethod]
        public bool insertChiTietHoaDon(ChiTietHoaDonDTO chitietDTO)
        {
            return _chitiethoadonDAL.insertChiTietHoaDon(chitietDTO);
        }

        [WebMethod]
        public int getMaChiTietHoaDon(string masach)
        {
            return _chitiethoadonDAL.getMaChiTietHoaDon(masach);
        }

        [WebMethod]
        public ChiTietHoaDonDTO[] deleteAllTableChiTietHoaDon()
        {
            return _chitiethoadonDAL.deleteAllTableChiTietHoaDon();
        }

        [WebMethod]
        public int getTongTien(string masach)
        {
            return _chitiethoadonDAL.getTongTien(masach);
        }

        #endregion       
    }
}
