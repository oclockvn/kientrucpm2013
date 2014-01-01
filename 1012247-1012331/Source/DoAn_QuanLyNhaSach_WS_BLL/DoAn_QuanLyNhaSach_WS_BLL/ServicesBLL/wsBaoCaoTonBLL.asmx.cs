using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_BLL.BLL;
using DoAn_QuanLyNhaSach_WS_BLL.wsBaoCaoTonDAL;

namespace DoAn_QuanLyNhaSach_WS_BLL.ServicesBLL
{
    /// <summary>
    /// Summary description for wsBaoCaoTonBLL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsBaoCaoTonBLL : System.Web.Services.WebService
    {
        BaoCaoTonBLL _baocaotonBLL = new BaoCaoTonBLL();

        #region BaoCaoTon

        [WebMethod]
        public BaoCaoTonDTO[] getListBaoCaoTon()
        {
            return _baocaotonBLL.getListBaoCaoTon();
        }

        [WebMethod]
        public void insertBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            _baocaotonBLL.insertBaoCaoTon(baocaoDTO);
        }

        [WebMethod]
        public void deleteBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            _baocaotonBLL.deleteBaoCaoTon(baocaoDTO);
        }

        [WebMethod]
        public void updateBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            _baocaotonBLL.updateBaoCaoTon(baocaoDTO);
        }

        #endregion
    }
}
