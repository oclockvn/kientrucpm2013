using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL
{
    /// <summary>
    /// Summary description for wsSach
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsSach : System.Web.Services.WebService
    {

        SachDAL _sachDAL = new SachDAL();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        #region Sach

        [WebMethod]
        public SachDTO[] getListSach()
        {
            return _sachDAL.getListSach();
        }

        [WebMethod]
        public bool insertSach(SachDTO sach)
        {
            return _sachDAL.insertSach(sach);
        }

        [WebMethod]
        public void deleteSach(SachDTO sach)
        {
            _sachDAL.deleteSach(sach);
        }

        [WebMethod]
        public bool updateSach(SachDTO sach)
        {
            return _sachDAL.updateSach(sach);
        }

        [WebMethod]
        public int getSoLuongTon(string tensach)
        {
            return _sachDAL.getSoLuongTon(tensach);
        }

        [WebMethod]
        public int getDonGiaSach(string tensach, string masach)
        {
            return _sachDAL.getDonGiaSach(tensach, masach);
        }

        [WebMethod]
        public int getMaTheLoaiSach(string masach)
        {
            return _sachDAL.getMaTheLoaiSach(masach);
        }

        [WebMethod]
        public bool checkIsExistBook(int masach)
        {
            return _sachDAL.checkIsExistBook(masach);
        }

        [WebMethod]
        public SachDTO[] searchSach(SachDTO sach)
        {
            return _sachDAL.searchSach(sach);
        }

        [WebMethod]
        public SachDTO[] searchSachByCatalog(SachDTO sach, string muc)
        {
            return _sachDAL.searchSachByCatalog(sach, muc);
        }

        [WebMethod]
        public string getMaSach(string tensach)
        {
            return _sachDAL.getMaSach(tensach);
        }

        #endregion
    }
}
