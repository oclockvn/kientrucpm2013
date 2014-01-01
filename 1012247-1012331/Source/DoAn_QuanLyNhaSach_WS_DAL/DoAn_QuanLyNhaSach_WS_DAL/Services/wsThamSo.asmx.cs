using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;

namespace DoAn_QuanLyNhaSach_WS_DAL.Services
{
    /// <summary>
    /// Summary description for wsThamSo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsThamSo : System.Web.Services.WebService
    {

        ThamSoDAL _thamsoDAL = new ThamSoDAL();

        #region ThamSo

        [WebMethod]
        public int getSoLuongNhapMin()
        {
            return _thamsoDAL.getSoLuongNhapMin();
        }

        [WebMethod]
        public int getSoLuongTonMax()
        {
            return _thamsoDAL.getSoLuongTonMax();
        }

        [WebMethod]
        public int getSoTienKhachHangNoMax()
        {
            return _thamsoDAL.getSoTienKhachHangNoMax();
        }

        [WebMethod]
        public int getSoLuongTonSauBanMin()
        {
            return _thamsoDAL.getSoLuongTonSauBanMin();
        }

        #endregion
    }
}
