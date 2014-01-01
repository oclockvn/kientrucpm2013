using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsPhieuThuTienDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsPhieuThuTienBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPhieuThuTienBLL : System.Web.Services.WebService
    {

        PhieuThuTienBLL _phieuthutienBLL = new PhieuThuTienBLL();

        #region PhieuThuTien

        [WebMethod]
        public PhieuThuTienDTO[] getListPhieuThuTien()
        {
            return _phieuthutienBLL.getListPhieuThuTien();
        }

        [WebMethod]
        public void insertPhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            _phieuthutienBLL.insertPhieuThuTien(phieuDTO);
        }

        [WebMethod]
        public bool deletePhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            return _phieuthutienBLL.deletePhieuThuTien(phieuDTO);
        }

        [WebMethod]
        public void updatePhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            _phieuthutienBLL.updatePhieuThuTien(phieuDTO);
        }

        #endregion
    }
}
