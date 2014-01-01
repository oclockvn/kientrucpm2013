using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class KhachHangDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private KhachHangDTO getKhachHangFromDataRow(DataRow row)
        {
            KhachHangDTO khachhang = new KhachHangDTO();
            khachhang.DiaChi = row["DiaChi"].ToString();
            khachhang.DienThoai = row["DienThoai"].ToString();
            khachhang.Email = row["Email"].ToString();
            khachhang.HoTen = row["HoTen"].ToString();
            khachhang.MaKhachHang = int.Parse(row["MaKhachHang"].ToString());
            khachhang.SoTienNo = int.Parse(row["SoTienNo"].ToString());
            return khachhang;
        }

        public KhachHangDTO[] getListKhachHang()
        {
            string sql = "SELECT * FROM KhachHang";
            DataTable dt = getTable(sql);
            int n = dt.Rows.Count;
            KhachHangDTO[] dsKhachHang = new KhachHangDTO[n];
            for (int i = 0; i < n; i++)
            {
                KhachHangDTO kh = getKhachHangFromDataRow(dt.Rows[i]);
                dsKhachHang[i] = kh;
            }
            return dsKhachHang;
        }

        public bool insertKhachHang(KhachHangDTO khachhangDTO)
        {
            try
            {
                string sql = "INSERT INTO KhachHang (HoTen, DiaChi, DienThoai, Email, SoTienNo) VALUES ";
                sql += "(N'" + khachhangDTO.HoTen + "', ";
                sql += "N'" + khachhangDTO.DiaChi + "', ";
                sql += "'" + khachhangDTO.DienThoai + "', ";
                sql += "'" + khachhangDTO.Email + "', ";
                sql += khachhangDTO.SoTienNo + ")";
                data.executeQuery(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }

        public void addNewKhachHang(KhachHangDTO khachhangDTO)
        {
            string sql = "INSERT INTO KhachHang (HoTen, DiaChi, DienThoai, Email, SoTienNo) VALUES ";
            sql += " (N'" + khachhangDTO.HoTen + "', null, null, null, 0)";
            data.executeNonQuery(sql);
        }

        public void deleteKhachHang(KhachHangDTO kh)
        {
            try
            {
                string sql = "DELETE FROM KhachHang WHERE HoTen LIKE N'%" + kh.HoTen + "%'";
                data.executeQuery(sql);
                //return true;
            }
            catch (Exception)
            {
                //return false;
                //throw;
            }
        }

        public bool updateKhachHang(KhachHangDTO kh)
        {
            try
            {
                string sql = "UPDATE KhachHang SET ";
                //sql += " HoTen = N'" + kh.HoTen + "', ";
                sql += " DiaChi = N'" + kh.DiaChi + "', ";
                sql += " DienThoai = '" + kh.DienThoai + "', ";
                sql += " Email = N'" + kh.Email + "', ";
                sql += " SoTienNo = " + kh.SoTienNo;
                sql += " WHERE HoTen LIKE N'%" + kh.HoTen + "%'";
                data.executeQuery(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }

        public int getMaKhachHang(string hoten)
        {
            try
            {
                string sql = "SELECT * FROM KhachHang WHERE HoTen LIKE N'%" + hoten + "%'";
                DataTable table = getTable(sql);
                KhachHangDTO kh = getKhachHangFromDataRow(table.Rows[0]);
                return kh.MaKhachHang;
            }
            catch (Exception)
            {
                return 0;
                //throw;
            }
        }

        public KhachHangDTO getKhachHangInfo(int makhachhang)
        {
            string sql = "SELECT * FROM KhachHang WHERE MaKhachHang = " + makhachhang;
            DataTable table = getTable(sql);
            KhachHangDTO khachhangDTO = getKhachHangFromDataRow(table.Rows[0]);
            return khachhangDTO;
        }
    }
}