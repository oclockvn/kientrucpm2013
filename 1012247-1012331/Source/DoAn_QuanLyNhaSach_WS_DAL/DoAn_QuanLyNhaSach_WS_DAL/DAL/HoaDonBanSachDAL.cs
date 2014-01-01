using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class HoaDonBanSachDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private HoaDonBanSachDTO getHoaDonBanSachFromDataRow(DataRow row)
        {
            HoaDonBanSachDTO hoadonCurr = new HoaDonBanSachDTO();
            hoadonCurr.MaChiTietHoaDon = int.Parse(row["MaChiTietHoaDon"].ToString());
            hoadonCurr.MaHoaDon = int.Parse(row["MaHoaDon"].ToString());
            hoadonCurr.MaKhachHang = int.Parse(row["MaKhachHang"].ToString());
            hoadonCurr.NgayLapHoaDon = row["NgayLapHoaDon"].ToString();
            hoadonCurr.TongTien = int.Parse(row["TongTien"].ToString());
            return hoadonCurr;
        }

        public void addNewHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            string sql = "INSERT INTO HoaDonBanSach (NgayLapHoaDon, MaKhachHang, MaChiTietHoaDon, TongTien) VALUES ";
            sql += "('" + hoadonDTO.NgayLapHoaDon + "', ";
            sql += hoadonDTO.MaKhachHang + ", ";
            sql += "null, ";
            sql += hoadonDTO.TongTien + ")";
            data.executeNonQuery(sql);
        }

        public void insertHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            string sql = "INSERT INTO HoaDonBanSach (NgayLapHoaDon, MaKhachHang, MaChiTietHoaDon, TongTien) VALUES ";
            sql += "('" + hoadonDTO.NgayLapHoaDon + "', ";
            sql += hoadonDTO.MaKhachHang + ", ";
            sql += hoadonDTO.MaChiTietHoaDon + ", ";
            sql += hoadonDTO.TongTien + ")";
            data.executeNonQuery(sql);
        }

        public void updateHoaDonBanSach(HoaDonBanSachDTO hoadonDTO)
        {
            string sql = "UPDATE HoaDonBanSach SET ";
            //sql += " MaKhachHang = " + hoadonDTO.MaKhachHang + ", ";
            sql += " TongTien = " + hoadonDTO.TongTien + ", ";
            sql += " MaChiTietHoaDon = " + hoadonDTO.MaChiTietHoaDon;
            sql += " WHERE MaKhachHang = " + hoadonDTO.MaKhachHang;
            data.executeNonQuery(sql);
        }

        public int getTongTienHoaDonBanSach()
        {
            int tongtien = 0;
            string sql = "SELECT * FROM HoaDonBanSach";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                HoaDonBanSachDTO hoadonDTO = getHoaDonBanSachFromDataRow(table.Rows[i]);
                tongtien += hoadonDTO.TongTien;
            }

            return tongtien;
        }

        public HoaDonBanSachDTO[] deleteAllTableHoaDonBanSach()
        {
            string sql = "DELETE FROM HoaDonBanSach";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            HoaDonBanSachDTO[] list = new HoaDonBanSachDTO[n];
            for (int i = 0; i < n; i++)
            {
                HoaDonBanSachDTO hoadon = getHoaDonBanSachFromDataRow(table.Rows[i]);
                list[i] = hoadon;
            }
            return list;
        }
    }
}