using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class PhieuNhapSachDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private PhieuNhapSachDTO getPhieuNhapSachFromDataRow(DataRow row)
        {
            PhieuNhapSachDTO phieuDTO = new PhieuNhapSachDTO();
            phieuDTO.MaChiTietPhieuNhapSach = int.Parse(row["MaChiTietPhieuNhapSach"].ToString());
            phieuDTO.MaPhieuNhapSach = int.Parse(row["MaPhieuNhapSach"].ToString());
            phieuDTO.NgayNhap = row["NgayNhap"].ToString();
            phieuDTO.TongSoLuongNhap = int.Parse(row["TongSoLuongNhap"].ToString());
            return phieuDTO;
        }

        public void insertPhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            string sql = "INSERT INTO PhieuNhapSach (MaChiTietPhieuNhapSach, NgayNhap, TongSoLuongNhap) VALUES (";
            sql += phieuDTO.MaChiTietPhieuNhapSach + ", '";
            sql += phieuDTO.NgayNhap + "', ";
            sql += phieuDTO.TongSoLuongNhap + ")";
            data.executeNonQuery(sql);
        }

        public bool deletePhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            try
            {
                string sql = "DELETE FROM PhieuNhapSach WHERE MaChiTietPhieuNhapSach = " + phieuDTO.MaChiTietPhieuNhapSach;
                data.executeNonQuery(sql);
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }

        public void updatePhieuNhapSach(PhieuNhapSachDTO phieuDTO)
        {
            string sql = "UPDATE PhieuNhapSach SET ";
            //sql += "MaChiTietPhieuNhapSach = " + phieuDTO.MaChiTietPhieuNhapSach + ", ";
            sql += " NgayNhap = '" + phieuDTO.NgayNhap + "', ";
            sql += " TongSoLuongNhap = " + phieuDTO.TongSoLuongNhap;
            sql += " WHERE MaChiTietPhieuNhapSach = " + phieuDTO.MaChiTietPhieuNhapSach;
            data.executeNonQuery(sql);
        }
    }
}