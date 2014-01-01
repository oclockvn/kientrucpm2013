using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL
{
    /// <summary>
    /// Summary description for wsTheLoaiSach
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTheLoaiSach : System.Web.Services.WebService
    {
        TheLoaiSachDAL _theloaisahDAL = new TheLoaiSachDAL();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        #region TheLoaiSach

        [WebMethod]
        public TheLoaiSachDTO[] getListTheLoaiSach()
        {
            return _theloaisahDAL.getListTheLoaiSach();
        }

        [WebMethod]
        public int getMaTheLoai(string tentheloai)
        {
            return _theloaisahDAL.getMaTheLoai(tentheloai);
        }

        [WebMethod]
        public string getTenTheLoai(int matheloai)
        {
            return _theloaisahDAL.getTenTheLoai(matheloai);
        }

        #endregion
    }
}
