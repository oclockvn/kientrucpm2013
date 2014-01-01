using System.Web.Services;
using DoAn_QuanLyNhaSach_WS_DAL.DAL;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class wsHoaDonBanSach : System.Web.Services.WebService
    {
        HoaDonBanSachDAL _hoadonbansachDAL = new HoaDonBanSachDAL();

        #region HoaDonBanSach

        [WebMethod]
        public void addNewHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            _hoadonbansachDAL.addNewHoaDonBanSach(hoadonDTO);
        }

        [WebMethod]
        public void insertHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            _hoadonbansachDAL.insertHoaDonBanSach(hoadonDTO);
        }

        [WebMethod]
        public void updateHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            _hoadonbansachDAL.updateHoaDonBanSach(hoadonDTO);
        }

        [WebMethod]
        public int getTongTienHoaDonBanSach()
        {
            return _hoadonbansachDAL.getTongTienHoaDonBanSach();
        }

        [WebMethod]
        public HoaDonBanSachDTO[] deleteAllTableHoaDonBanSach()
        {
            return _hoadonbansachDAL.deleteAllTableHoaDonBanSach();
        }

        #endregion
    }
}
