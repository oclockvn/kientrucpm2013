using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.Services
{
    /// <summary>
    /// Summary description for wsPhieuThuTien
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPhieuThuTien : System.Web.Services.WebService
    {
        PhieuThuTienDAL _phieuthutienDAL = new PhieuThuTienDAL();

        #region PhieuThuTien

        [WebMethod]
        public PhieuThuTienDTO[] getListPhieuThuTien()
        {
            return _phieuthutienDAL.getListPhieuThuTien();
        }

        [WebMethod]
        public void insertPhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            _phieuthutienDAL.insertPhieuThuTien(phieuDTO);
        }

        [WebMethod]
        public bool deletePhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            return _phieuthutienDAL.deletePhieuThuTien(phieuDTO);
        }

        [WebMethod]
        public void updatePhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            _phieuthutienDAL.updatePhieuThuTien(phieuDTO);
        }

        #endregion

    }
}
