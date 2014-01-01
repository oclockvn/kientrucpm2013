using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsPhieuNhapSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsPhieuNhapSachBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPhieuNhapSachBLL : System.Web.Services.WebService
    {

        PhieuNhapSachBLL _phieunhapsachBLL = new PhieuNhapSachBLL();

        #region PhieuNhapSach

        [WebMethod]
        public void insertPhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            _phieunhapsachBLL.insertPhieuNhapSach(phieuDTO);
        }

        [WebMethod]
        public bool deletePhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            return _phieunhapsachBLL.deletePhieuNhapSach(phieuDTO);
        }

        [WebMethod]
        public void updatePhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            _phieunhapsachBLL.updatePhieuNhapSach(phieuDTO);
        }

        #endregion
    }
}
