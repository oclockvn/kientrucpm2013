using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsThamSoBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsThamSoBLL : System.Web.Services.WebService
    {
        ThamSoBLL _thamsoBLL = new ThamSoBLL();

        #region ThamSo

        [WebMethod]
        public int getSoLuongNhapMin()
        {
            return _thamsoBLL.getSoLuongNhapMin();
        }

        [WebMethod]
        public int getSoLuongTonMax()
        {
            return _thamsoBLL.getSoLuongTonMax();
        }

        [WebMethod]
        public int getSoTienKhachHangNoMax()
        {
            return _thamsoBLL.getSoTienKhachHangNoMax();
        }

        [WebMethod]
        public int getSoLuongTonSauBanMin()
        {
            return _thamsoBLL.getSoLuongTonSauBanMin();
        }

        #endregion
    }
}
