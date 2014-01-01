using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.Services
{
    /// <summary>
    /// Summary description for wsBaoCaoTon
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsBaoCaoTon : System.Web.Services.WebService
    {
        BaoCaoTonDAL _baocaotonDAL = new BaoCaoTonDAL();

        #region BaoCaoTon

        [WebMethod]
        public BaoCaoTonDTO[] getListBaoCaoTon()
        {
            return _baocaotonDAL.getListBaoCaoTon();
        }

        [WebMethod]
        public void insertBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            _baocaotonDAL.insertBaoCaoTon(baocaoDTO);
        }

        [WebMethod]
        public void deleteBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            _baocaotonDAL.deleteBaoCaoTon(baocaoDTO);
        }

        [WebMethod]
        public void updateBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            _baocaotonDAL.updateBaoCaoTon(baocaoDTO);
        }

        #endregion
    }
}
