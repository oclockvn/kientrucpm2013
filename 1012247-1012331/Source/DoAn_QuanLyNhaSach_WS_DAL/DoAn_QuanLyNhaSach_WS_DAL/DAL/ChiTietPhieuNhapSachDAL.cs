using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class ChiTietPhieuNhapSachDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private ChiTietPhieuNhapSachDTO getChiTietPhieuNhapSachFromDataRow(DataRow row)
        {
            ChiTietPhieuNhapSachDTO chitiet = new ChiTietPhieuNhapSachDTO();
            chitiet.MaChiTietPhieuNhapSach = int.Parse(row["MaChiTietPhieuNhapSach"].ToString());
            chitiet.MaSach = row["MaSach"].ToString();
            chitiet.SoLuong = int.Parse(row["SoLuong"].ToString());
            return chitiet;
        }

        public ChiTietPhieuNhapSachDTO[] getListChiTietPhieuNhapSach()
        {
            string sql = "SELECT * FROM ChiTietPhieuNhapSach";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            ChiTietPhieuNhapSachDTO[] list = new ChiTietPhieuNhapSachDTO[n];
            for (int i = 0; i < n; i++)
            {
                ChiTietPhieuNhapSachDTO chitiet = getChiTietPhieuNhapSachFromDataRow(table.Rows[i]);
                list[i] = chitiet;
            }
            return list;
        }

        public void insertChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            string sql = "INSERT INTO ChiTietPhieuNhapSach (MaSach, SoLuong) VALUES (";
            sql += "'" + chitiet.MaSach + "', ";
            sql += chitiet.SoLuong + ")";
            data.executeNonQuery(sql);
        }

        public bool deleteChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            try
            {
                string sql = "DELETE FROM ChiTietPhieuNhapSach WHERE MaSach = '" + chitiet.MaSach + "'";
                data.executeNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public void updateChiTietPhieuNhapSach(ChiTietPhieuNhapSachDTO chitiet)
        {
            string sql = "UPDATE ChiTietPhieuNhapSach SET ";
            sql += "SoLuong = " + chitiet.SoLuong;
            sql += "WHERE MaSach = '" + chitiet.MaSach + "'";
        }

        public int getSoLuongSachNhap(string masach)
        {
            string sql = "SELECT * FROM ChiTietPhieuNhapSach WHERE MaSach = '" + masach + "'";
            DataTable table = getTable(sql);
            ChiTietPhieuNhapSachDTO chitiet = getChiTietPhieuNhapSachFromDataRow(table.Rows[0]);
            return chitiet.SoLuong;
        }

        public int getMaChiTietPhieuNhapSach(string masach)
        {
            string sql = "SELECT * FROM ChiTietPhieuNhapSach WHERE MaSach = '" + masach + "'";
            DataTable table = getTable(sql);
            ChiTietPhieuNhapSachDTO chitiet = getChiTietPhieuNhapSachFromDataRow(table.Rows[0]);
            return chitiet.MaChiTietPhieuNhapSach;
        }
    }
}