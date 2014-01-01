using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class PhieuThuTienDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private PhieuThuTienDTO getPhieuThuTienFromDataRow(DataRow row)
        {
            PhieuThuTienDTO phieuthuDTO = new PhieuThuTienDTO();
            phieuthuDTO.MaKhachHang = int.Parse(row["MaKhachHang"].ToString());
            phieuthuDTO.MaPhieuThu = int.Parse(row["MaPhieuThuTien"].ToString());
            phieuthuDTO.NgayThu = row["NgayThu"].ToString();
            phieuthuDTO.SoTienThu = int.Parse(row["SoTienThu"].ToString());
            return phieuthuDTO;
        }

        public PhieuThuTienDTO[] getListPhieuThuTien()
        {
            string sql = "SELECT * FROM PhieuThuTien";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            PhieuThuTienDTO[] list = new PhieuThuTienDTO[n];
            for (int i = 0; i < n; i++)
            {
                PhieuThuTienDTO phieuthuDTO = getPhieuThuTienFromDataRow(table.Rows[i]);
                list[i] = phieuthuDTO;
            }
            return list;
        }

        public void insertPhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            string sql = "INSERT INTO PhieuThuTien (NgayThu, SoTienThu, MaKhachHang) VALUES";
            sql += "('" + phieuDTO.NgayThu + "', ";
            sql += phieuDTO.SoTienThu + ", ";
            sql += phieuDTO.MaKhachHang + ")";
            data.executeNonQuery(sql);
        }

        public bool deletePhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            try
            {
                string sql = "DELETE FROM PhieuThuTien WHERE MaKhachHang = " + phieuDTO.MaKhachHang;
                data.executeNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void updatePhieuThuTien(PhieuThuTienDTO phieuDTO)
        {
            string sql = "UPDATE PhieuThuTien SET ";
            sql += " SoTienThu = " + phieuDTO.SoTienThu;
            sql += " WHERE MaKhachHang = " + phieuDTO.MaKhachHang;
            data.executeNonQuery(sql);
        }
    }
}