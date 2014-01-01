using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsChiTietHoaDonDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsChiTietHoaDonBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsChiTietHoaDonBLL : System.Web.Services.WebService
    {

        ChiTietHoaDonBLL _chitiethoadonBLL = new ChiTietHoaDonBLL();

        #region ChiTietHoaDon

        [WebMethod]
        public ChiTietHoaDonDTO[] getListChiTietHoaDon()
        {
            return _chitiethoadonBLL.getListChiTietHoaDon();
        }

        [WebMethod]
        public bool insertChiTietHoaDon(ChiTietHoaDonDTO chitietDTO)
        {
            return _chitiethoadonBLL.insertChiTietHoaDon(chitietDTO);
        }

        [WebMethod]
        public int getMaChiTietHoaDon(string masach)
        {
            return _chitiethoadonBLL.getMaChiTietHoaDon(masach);
        }

        [WebMethod]
        public ChiTietHoaDonDTO[] deleteAllTableChiTietHoaDon()
        {
            return _chitiethoadonBLL.deleteAllTableChiTietHoaDon();
        }

        [WebMethod]
        public int getTongTien(string masach)
        {
            return _chitiethoadonBLL.getTongTien(masach);
        }

        #endregion
    }
}
