using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class BaoCaoNoCongDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private BaoCaoNoCongDTO getBaoCaoNoCongFromDataRow(DataRow row)
        {
            BaoCaoNoCongDTO baocaoDTO = new BaoCaoNoCongDTO();
            baocaoDTO.MaBaoCaoNoCong = int.Parse(row["MaBaoCaoNoCong"].ToString());
            baocaoDTO.MaKhachHang = int.Parse(row["MaKhachHang"].ToString());
            baocaoDTO.NoCuoi = int.Parse(row["NoCuoi"].ToString());
            baocaoDTO.NoDau = int.Parse(row["NoDau"].ToString());
            baocaoDTO.PhatSinh = int.Parse(row["PhatSinh"].ToString());
            baocaoDTO.Thang = row["Thang"].ToString();
            return baocaoDTO;
        }

        public BaoCaoNoCongDTO[] getListBaoCaoNoCong()
        {
            string sql = "SELECT * FROM BaoCaoNoCong";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            BaoCaoNoCongDTO[] list = new BaoCaoNoCongDTO[n];
            for (int i = 0; i < n; i++)
            {
                BaoCaoNoCongDTO baocaoDTO = getBaoCaoNoCongFromDataRow(table.Rows[i]);
                list[i] = baocaoDTO;
            }
            return list;
        }

        public void insertBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            string sql = "INSERT INTO BaoCaoNoCong (Thang, MaKhachHang, NoDau, PhatSinh, NoCuoi) VALUES ";
            sql += "('" + baocaoDTO.Thang + "', ";
            sql += baocaoDTO.MaKhachHang + ", ";
            sql += baocaoDTO.NoDau + ", ";
            sql += baocaoDTO.PhatSinh + ", ";
            sql += baocaoDTO.NoCuoi + ")";
            data.executeNonQuery(sql);
        }

        public void updateBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            string sql = "UPDATE BaoCaoNoCong SET ";
            sql += " Thang = '" + baocaoDTO.Thang + "', ";
            sql += " NoDau = " + baocaoDTO.NoDau + ", ";
            sql += " PhatSinh = " + baocaoDTO.PhatSinh + ", ";
            sql += " NoCuoi = " + baocaoDTO.NoCuoi;
            sql += " WHERE MaKhachHang = " + baocaoDTO.MaKhachHang;
        }

        public void deleteBaoCaoNoCong(BaoCaoNoCongDTO baocaoDTO)
        {
            string sql = "DELETE FROM BaoCaoNoCong WHERE MaKhachHang = " + baocaoDTO.MaKhachHang;
            data.executeNonQuery(sql);
        }
    }
}