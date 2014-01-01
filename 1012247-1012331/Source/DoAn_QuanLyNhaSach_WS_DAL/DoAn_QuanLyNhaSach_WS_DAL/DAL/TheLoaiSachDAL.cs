using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class TheLoaiSachDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private TheLoaiSachDTO getTheLoaiSachFromDataRow(DataRow row)
        {
            TheLoaiSachDTO theloai = new TheLoaiSachDTO();
            theloai.MaTheLoai = int.Parse(row["MaTheLoai"].ToString());
            theloai.TenTheLoai = row["TenTheLoai"].ToString();
            return theloai;
        }

        public TheLoaiSachDTO[] getListTheLoaiSach()
        {
            string sql = "SELECT * FROM TheLoaiSach";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            TheLoaiSachDTO[] list = new TheLoaiSachDTO[n];
            for (int i = 0; i < n; i++)
            {
                TheLoaiSachDTO theloai = getTheLoaiSachFromDataRow(table.Rows[i]);
                list[i] = theloai;
            }
            return list;
        }

        public int getMaTheLoai(string tentheloai)
        {
            string sql = "SELECT * FROM TheLoaiSach WHERE TenTheLoai = N'" + tentheloai + "'";
            DataTable table = getTable(sql);
            TheLoaiSachDTO theloai = getTheLoaiSachFromDataRow(table.Rows[0]);
            return theloai.MaTheLoai;
        }

        public string getTenTheLoai(int matheloai)
        {
            string sql = "SELECT * FROM TheLoaiSach WHERE MaTheLoai = '" + matheloai + "'";
            DataTable table = getTable(sql);
            TheLoaiSachDTO theloai = getTheLoaiSachFromDataRow(table.Rows[0]);
            return theloai.TenTheLoai;
        }
    }
}