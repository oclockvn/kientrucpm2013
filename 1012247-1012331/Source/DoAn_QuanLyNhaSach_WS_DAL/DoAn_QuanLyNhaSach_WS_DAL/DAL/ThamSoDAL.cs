using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class ThamSoDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        public int getSoLuongNhapMin()
        {
            string sql = "SELECT SoLuongNhapMin FROM THAMSO";
            DataTable table = getTable(sql);
            return int.Parse(table.Rows[0]["SoLuongNhapMin"].ToString());
        }

        public int getSoLuongTonMax()
        {
            string sql = "SELECT SoLuongTonMax FROM THAMSO";
            DataTable table = getTable(sql);
            return int.Parse(table.Rows[0]["SoLuongTonMax"].ToString());
        }

        public int getSoTienKhachHangNoMax()
        {
            string sql = "SELECT SoTienKhachHangNoMax FROM THAMSO";
            DataTable table = getTable(sql);
            return int.Parse(table.Rows[0]["SoTienKhachHangNoMax"].ToString());
        }

        public int getSoLuongTonSauBanMin()
        {
            string sql = "SELECT SoLuongTonSauBanMin FROM THAMSO";
            DataTable table = getTable(sql);
            return int.Parse(table.Rows[0]["SoLuongTonSauBanMin"].ToString());
        }
    }
}