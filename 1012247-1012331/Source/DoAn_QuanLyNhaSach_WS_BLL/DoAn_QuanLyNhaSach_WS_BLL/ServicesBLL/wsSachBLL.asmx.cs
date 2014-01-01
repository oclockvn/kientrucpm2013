using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsSachBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsSachBLL : System.Web.Services.WebService
    {

        SachBLL _sachBLL = new SachBLL();

        #region Sach

        [WebMethod]
        public SachDTO[] getListSach()
        {
            return _sachBLL.getListSach();
        }

        [WebMethod]
        public bool insertSach(SachDTO sach)
        {
            return _sachBLL.insertSach(sach);
        }

        [WebMethod]
        public void deleteSach(SachDTO sach)
        {
            _sachBLL.deleteSach(sach);
        }

        [WebMethod]
        public bool updateSach(SachDTO sach)
        {
            return _sachBLL.updateSach(sach);
        }

        [WebMethod]
        public int getSoLuongTon(string tensach)
        {
            return _sachBLL.getSoLuongTon(tensach);
        }

        [WebMethod]
        public int getDonGiaSach(string tensach, string masach)
        {
            return _sachBLL.getDonGiaSach(tensach, masach);
        }

        [WebMethod]
        public int getMaTheLoaiSach(string masach)
        {
            return _sachBLL.getMaTheLoaiSach(masach);
        }

        [WebMethod]
        public bool checkIsExistBook(int masach)
        {
            return _sachBLL.checkIsExistBook(masach);
        }

        [WebMethod]
        public SachDTO[] searchSach(SachDTO sach)
        {
            return _sachBLL.searchSach(sach);
        }

        [WebMethod]
        public SachDTO[] searchSachByCatalog(SachDTO sach, string muc)
        {
            return _sachBLL.searchSachByCatalog(sach, muc);
        }

        [WebMethod]
        public string getMaSach(string tensach)
        {
            return _sachBLL.getMaSach(tensach);
        }

        #endregion
    }
}
