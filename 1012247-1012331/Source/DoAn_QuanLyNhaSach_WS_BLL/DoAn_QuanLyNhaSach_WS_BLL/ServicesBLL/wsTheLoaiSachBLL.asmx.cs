using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsTheLoaiSachDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsTheLoaiSachBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTheLoaiSachBLL : System.Web.Services.WebService
    {
        TheLoaiSachBLL _theloaisachBLL = new TheLoaiSachBLL();


        #region TheLoaiSach

        [WebMethod]
        public TheLoaiSachDTO[] getListTheLoaiSach()
        {
            return _theloaisachBLL.getListTheLoaiSach();
        }

        [WebMethod]
        public int getMaTheLoai(string tentheloai)
        {
            return _theloaisachBLL.getMaTheLoai(tentheloai);
        }

        [WebMethod]
        public string getTenTheLoai(int matheloai)
        {
            return _theloaisachBLL.getTenTheLoai(matheloai);
        }

        #endregion
      
    }
}
