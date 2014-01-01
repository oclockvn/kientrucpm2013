using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class ChiTietHoaDonDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private ChiTietHoaDonDTO getChiTietHoaDonFromDataRow(DataRow row)
        {
            ChiTietHoaDonDTO chitietDTO = new ChiTietHoaDonDTO();
            chitietDTO.MaChiTietHoaDon = int.Parse(row["MaChiTietHoaDon"].ToString());
            chitietDTO.MaSach = row["MaSach"].ToString();
            chitietDTO.SoLuongBan = int.Parse(row["SoLuongBan"].ToString());
            chitietDTO.DonGia = int.Parse(row["DonGia"].ToString());
            return chitietDTO;
        }

        public ChiTietHoaDonDTO[] getListChiTietHoaDon()
        {
            string sql = "SELECT * FROM ChiTietHoaDon";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            ChiTietHoaDonDTO[] list = new ChiTietHoaDonDTO[n];
            for (int i = 0; i < n; i++)
            {
                ChiTietHoaDonDTO chitietDTO = getChiTietHoaDonFromDataRow(table.Rows[i]);
                list[i] = chitietDTO;
            }
            return list;
        }

        public bool insertChiTietHoaDon(ChiTietHoaDonDTO chitietDTO)
        {
            try
            {
                string sql = "INSERT INTO ChiTietHoaDon (MaSach, SoLuongBan, DonGia) VALUES ";
                sql += "('" + chitietDTO.MaSach + "', ";
                sql += chitietDTO.SoLuongBan + ", ";
                sql += chitietDTO.DonGia + ")";
                data.executeNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getMaChiTietHoaDon(string masach)
        {
            try
            {
                string sql = "SELECT * FROM ChiTietHoaDon WHERE MaSach = '" + masach + "'";
                DataTable table = getTable(sql);
                ChiTietHoaDonDTO chitietDTO = getChiTietHoaDonFromDataRow(table.Rows[0]);
                return chitietDTO.MaChiTietHoaDon;
            }
            catch (Exception)
            {
                return 0;
                //throw;
            }
        }

        public ChiTietHoaDonDTO[] deleteAllTableChiTietHoaDon()
        {
            string sql = "DELETE FROM ChiTietHoaDon";
            DataTable table = data.executeQuery(sql);
            int n = table.Rows.Count;
            ChiTietHoaDonDTO[] list = new ChiTietHoaDonDTO[n];
            for (int i = 0; i < n; i++)
            {
                ChiTietHoaDonDTO chitiet = getChiTietHoaDonFromDataRow(table.Rows[i]);
                list[i] = chitiet;
            }
            return list;
        }

        public int getTongTien(string masach)
        {
            try
            {
                int tongtien = 0;
                string sql = "SELECT * FROM ChiTietHoaDon WHERE MaSach = " + masach;
                DataTable table = getTable(sql);
                int n = table.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    ChiTietHoaDonDTO chitietDTO = getChiTietHoaDonFromDataRow(table.Rows[i]);
                    tongtien += chitietDTO.DonGia * chitietDTO.SoLuongBan;
                }
                return tongtien;
            }
            catch (Exception)
            {
                return 0;
                //throw;
            }
        }
    }
}