using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.Services
{
    /// <summary>
    /// Summary description for wsPhieuNhapSach
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPhieuNhapSach : System.Web.Services.WebService
    {
        PhieuNhapSachDAL _phieunhapsachDAL = new PhieuNhapSachDAL();

        #region PhieuNhapSach

        [WebMethod]

        public void insertPhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            _phieunhapsachDAL.insertPhieuNhapSach(phieuDTO);
        }

        [WebMethod]
        public bool deletePhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            return _phieunhapsachDAL.deletePhieuNhapSach(phieuDTO);
        }

        [WebMethod]
        public void updatePhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            _phieunhapsachDAL.updatePhieuNhapSach(phieuDTO);
        }

        #endregion
    }
}
