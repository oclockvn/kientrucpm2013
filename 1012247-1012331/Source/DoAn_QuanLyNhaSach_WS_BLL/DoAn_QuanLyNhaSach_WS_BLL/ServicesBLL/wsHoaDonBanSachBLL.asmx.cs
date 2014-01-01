using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsHoaDonBanSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsHoaDonBanSachBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsHoaDonBanSachBLL : System.Web.Services.WebService
    {

        HoaDonBanSachBLL _hoadonbansachBLL = new HoaDonBanSachBLL();

        #region HoaDonBanSach

        [WebMethod]
        public void insertHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            _hoadonbansachBLL.insertHoaDonBanSach(hoadonDTO);
        }

        [WebMethod]
        public void addNewHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            _hoadonbansachBLL.addNewHoaDonBanSach(hoadonDTO);
        }

        [WebMethod]
        public void updateHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            _hoadonbansachBLL.updateHoaDonBanSach(hoadonDTO);
        }

        [WebMethod]
        public int getTongTienHoaDonBanSach()
        {
            return _hoadonbansachBLL.getTongTienHoaDonBanSach();
        }

        [WebMethod]
        public HoaDonBanSachDTO[] deleteAllTableHoaDonBanSach()
        {
            return _hoadonbansachBLL.deleteAllTableHoaDonBanSach();
        }

        #endregion
    }
}
