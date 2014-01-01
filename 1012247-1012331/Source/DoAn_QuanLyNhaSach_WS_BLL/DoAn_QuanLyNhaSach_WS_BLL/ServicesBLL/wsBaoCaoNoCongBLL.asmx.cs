using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsBaoCaoNoCongDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsBaoCaoNoCongBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsBaoCaoNoCongBLL : System.Web.Services.WebService
    {

        BaoCaoNoCongBLL _baocaonocongBLL = new BaoCaoNoCongBLL();

        #region BaoCaoNoCong

        [WebMethod]
        public BaoCaoNoCongDTO[] getListBaoCaoNoCong()
        {
            return _baocaonocongBLL.getListBaoCaoNoCong();
        }

        [WebMethod]
        public void insertBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            _baocaonocongBLL.insertBaoCaoNoCong(baocaoDTO);
        }

        [WebMethod]
        public void updateBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            _baocaonocongBLL.updateBaoCaoNoCong(baocaoDTO);
        }

        [WebMethod]
        public void deleteBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            _baocaonocongBLL.deleteBaoCaoNoCong(baocaoDTO);
        }

        #endregion
    }
}
