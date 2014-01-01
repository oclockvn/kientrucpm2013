using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class SachDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private SachDTO getSachFromDataRow(DataRow row)
        {
            SachDTO sach = new SachDTO();
            sach.DonGia = int.Parse(row["DonGia"].ToString());
            sach.MaSach = row["MaSach"].ToString();
            sach.MaTheLoai = int.Parse(row["MaTheLoai"].ToString());
            try
            {
                sach.SoLuongTon = int.Parse(row["SoLuongTon"].ToString());
            }
            catch
            {
                sach.SoLuongTon = 0;
            }
            sach.TacGia = row["TacGia"].ToString();
            sach.TenSach = row["TenSach"].ToString();
            return sach;
        }

        public SachDTO[] getListSach()
        {
            string sql = "SELECT * FROM Sach";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            SachDTO[] list = new SachDTO[n];
            for (int i = 0; i < n; i++)
            {
                SachDTO sach = getSachFromDataRow(table.Rows[i]);
                list[i] = sach;
            }
            return list;
        }

        public bool insertSach(SachDTO sach)
        {
            try
            {
                string sql = "INSERT INTO Sach (MaSach, TenSach, MaTheLoai, TacGia, DonGia, SoLuongTon) VALUES (";
                sql += "'" + sach.MaSach + "', ";
                sql += "N'" + sach.TenSach + "', ";
                sql += sach.MaTheLoai + ", ";
                sql += "N'" + sach.TacGia + "', ";
                sql += sach.DonGia + ", ";
                sql += sach.SoLuongTon + ")";
                data.executeNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void deleteSach(SachDTO sach)
        {
            string sql = "DELETE FROM Sach WHERE MaSach = '" + sach.MaSach + "'";
            data.executeNonQuery(sql);
        }

        public bool updateSach(SachDTO sach)
        {
            try
            {
                string sql = "UPDATE Sach SET ";
                sql += "TenSach = N'" + sach.TenSach + "', ";
                sql += "MaTheLoai = " + sach.MaTheLoai + ", ";
                sql += "TacGia = N'" + sach.TacGia + "', ";
                sql += "DonGia = " + sach.DonGia + ", ";
                sql += "SoLuongTon = " + sach.SoLuongTon;
                sql += " WHERE MaSach = '" + sach.MaSach + "'";
                data.executeNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getSoLuongTon(string tensach)
        {
            try
            {
                int ketqua = 0;
                string sql = "SELECT * FROM Sach WHERE TenSach LIKE N'%" + tensach + "%'";
                DataTable table = getTable(sql);
                int n = table.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    SachDTO sach = getSachFromDataRow(table.Rows[i]);
                    ketqua += sach.SoLuongTon;
                }
                return ketqua;
                //return sach.SoLuongTon;
            }
            catch
            {
                return 0;
            }
        }

        public int getMaTheLoaiSach(string masach)
        {
            try
            {
                string sql = "SELECT * FROM Sach WHERE MaSach = '" + masach + "'";
                DataTable table = getTable(sql);
                SachDTO sachDTO = getSachFromDataRow(table.Rows[0]);
                return sachDTO.MaTheLoai;
            }
            catch (Exception)
            {
                return 0;
                //throw;
            }
        }

        public int getDonGiaSach(string tensach, string masach)
        {
            try
            {
                string sql = "SELECT * FROM Sach WHERE TenSach LIKE N'%" + tensach + "%' and MaSach = '" + masach + "'";
                DataTable table = getTable(sql);
                SachDTO sachDTO = getSachFromDataRow(table.Rows[0]);
                return sachDTO.DonGia;
            }
            catch (Exception)
            {
                return 0;
                //throw;
            }
        }

        public string getMaSach(string tensach)
        {
            string sql = "SELECT * FROM Sach WHERE TenSach LIKE N'%" + tensach + "%'";
            DataTable table = getTable(sql);
            SachDTO sach = getSachFromDataRow(table.Rows[0]);
            return sach.MaSach;
        }

        public bool checkIsExistBook(int masach)
        {
            string sql = "SELECT * FROM Sach WHERE MaSach = '" + masach + "'";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SachDTO[] searchSach(SachDTO sach)
        {
            //string sql = "SELECT * FROM Sach WHERE ";
            //if (sach.TenSach.Length != 0)
            //{
            //    sql += "TenSach LIKE N'%" + sach.TenSach + "%'";
            //}
            //else if (sach.TacGia.Length != 0)
            //{
            //    sql += "TacGia LIKE N'%" + sach.TacGia + "%'";
            //}
            //else if (sach.MaTheLoai != 0)
            //{
            //    sql += "MaTheLoai = " + sach.MaTheLoai;
            //}
            //else if (sach.TenSach.Length != 0 && sach.MaTheLoai != 0)
            //{
            //    sql += "MaTheLoai = " + sach.MaTheLoai + " and TenSach LIKE N'%" + sach.TenSach + "%'";
            //}
            string sql = "SELECT * FROM Sach WHERE ";
            if (sach.TenSach != null)
            {
                sql += "TenSach LIKE N'%" + sach.TenSach + "%'";
            }
            else if (sach.TacGia != null)
            {
                sql += "TacGia LIKE N'%" + sach.TacGia + "%'";
            }
            else if (sach.MaTheLoai != -1)
            {
                sql += "MaTheLoai = " + sach.MaTheLoai;
            }
            else if (sach.TenSach != "" && sach.MaTheLoai != -1)
            {
                sql += "MaTheLoai = " + sach.MaTheLoai + " and TenSach LIKE N'%" + sach.TenSach + "%'";
            }
            DataTable table = data.executeQuery(sql);
            int n = table.Rows.Count;
            SachDTO[] list = new SachDTO[n];
            for (int i = 0; i < n; i++)
            {
                SachDTO sachDTO = getSachFromDataRow(table.Rows[i]);
                list[i] = sachDTO;
            }
            return list;
        }

        public SachDTO[] searchSachByCatalog(SachDTO sach, string muc)
        {
            string sql = "SELECT * FROM Sach WHERE ";
            if (muc == "Tên sách")
            {
                sql += "TenSach LIKE N'%" + sach.TenSach + "%'";
            }
            else if (muc == "Tác giả")
            {
                sql += "TacGia LIKE N'%" + sach.TacGia + "%'";
            }
            else if (muc == "Thể loại")
            {
                sql += "MaTheLoai = " + sach.MaTheLoai;
            }
            else if (sach.TenSach.Length != 0 && sach.MaTheLoai != 0)
            {
                sql += "MaTheLoai = " + sach.MaTheLoai + " and TenSach LIKE N'%" + sach.TenSach + "%'";
            }
            DataTable table = data.executeQuery(sql);
            int n = table.Rows.Count;
            SachDTO[] list = new SachDTO[n];
            for (int i = 0; i < n; i++)
            {
                SachDTO sachDTO = getSachFromDataRow(table.Rows[i]);
                list[i] = sachDTO;
            }
            return list;
        }
    }
}