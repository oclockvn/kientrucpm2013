using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.Services
{
    /// <summary>
    /// Summary description for wsChiTietPhieuNhapSach
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsChiTietPhieuNhapSach : System.Web.Services.WebService
    {
        ChiTietPhieuNhapSachDAL _chitietphieunhapsachDAL = new ChiTietPhieuNhapSachDAL();

        #region ChiTietPhieuNhapSach

        [WebMethod]
        public ChiTietPhieuNhapSachDTO[] getListChiTietPhieuNhapSach()
        {
            return _chitietphieunhapsachDAL.getListChiTietPhieuNhapSach();
        }

        [WebMethod]
        public void insertChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            _chitietphieunhapsachDAL.insertChiTietPhieuNhapSach(chitiet);
        }

        [WebMethod]
        public bool deleteChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            return _chitietphieunhapsachDAL.deleteChiTietPhieuNhapSach(chitiet);
        }

        [WebMethod]
        public void updateChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            _chitietphieunhapsachDAL.updateChiTietPhieuNhapSach(chitiet);
        }

        [WebMethod]
        public int getSoLuongSachNhap(string masach)
        {
            return _chitietphieunhapsachDAL.getSoLuongSachNhap(masach);
        }

        [WebMethod]
        public int getMaChiTietPhieuNhapSach(string masach)
        {
            return _chitietphieunhapsachDAL.getMaChiTietPhieuNhapSach(masach);
        }

        #endregion
    }
}
