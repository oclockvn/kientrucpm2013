using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.Services
{
    /// <summary>
    /// Summary description for wsBaoCaoNoCong
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsBaoCaoNoCong : System.Web.Services.WebService
    {
        BaoCaoNoCongDAL _baocaonocongDAL = new BaoCaoNoCongDAL();

        #region BaoCaoNoCong

        [WebMethod]
        public BaoCaoNoCongDTO[] getListBaoCaoNoCong()
        {
            return _baocaonocongDAL.getListBaoCaoNoCong();
        }

        [WebMethod]
        public void insertBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            _baocaonocongDAL.insertBaoCaoNoCong(baocaoDTO);
        }

        [WebMethod]
        public void updateBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            _baocaonocongDAL.updateBaoCaoNoCong(baocaoDTO);
        }

        [WebMethod]
        public void deleteBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            _baocaonocongDAL.deleteBaoCaoNoCong(baocaoDTO);
        }

        #endregion
    }
}
