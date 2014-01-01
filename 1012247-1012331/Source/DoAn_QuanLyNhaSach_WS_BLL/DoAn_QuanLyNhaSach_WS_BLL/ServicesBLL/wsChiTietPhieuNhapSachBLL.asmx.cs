using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsChiTietPhieuNhapSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsChiTietPhieuNhapSachBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsChiTietPhieuNhapSachBLL : System.Web.Services.WebService
    {
        ChiTietPhieuNhapSachBLL _chitietphieunhapsachBLL = new ChiTietPhieuNhapSachBLL();

        #region ChiTietPhieuNhapSach

        [WebMethod]
        public void insertChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            _chitietphieunhapsachBLL.insertChiTietPhieuNhapSach(chitiet);
        }

        [WebMethod]
        public int getSoLuongSachNhap(string masach)
        {
            return _chitietphieunhapsachBLL.getSoLuongSachNhap(masach);
        }

        [WebMethod]
        public ChiTietPhieuNhapSachDTO[] getListChiTietPhieuNhapSach()
        {
            return _chitietphieunhapsachBLL.getListChiTietPhieuNhapSach();
        }

        [WebMethod]
        public bool deleteChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            return _chitietphieunhapsachBLL.deleteChiTietPhieuNhapSach(chitiet);
        }

        [WebMethod]
        public void updateChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            _chitietphieunhapsachBLL.updateChiTietPhieuNhapSach(chitiet);
        }

        [WebMethod]
        public int getMaChiTietPhieuNhapSach(string masach)
        {
            return _chitietphieunhapsachBLL.getMaChiTietPhieuNhapSach(masach);
        }

        #endregion
    }
}
