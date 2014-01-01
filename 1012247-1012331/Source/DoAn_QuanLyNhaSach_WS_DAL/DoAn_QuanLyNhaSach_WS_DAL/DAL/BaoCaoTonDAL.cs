using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DoAn_QuanLyNhaSach_WS_DAL.DTO;

namespace DoAn_QuanLyNhaSach_WS_DAL.DAL
{
    public class BaoCaoTonDAL
    {
        DataProvider data = new DataProvider();

        private DataTable getTable(string sql)
        {
            DataTable table = data.executeQuery(sql);
            return table;
        }

        private BaoCaoTonDTO getBaoCaoTonFromDataRow(DataRow row)
        {
            BaoCaoTonDTO baocaoDTO = new BaoCaoTonDTO();
            baocaoDTO.MaBaoCaoTon = int.Parse(row["MaBaoCaoTon"].ToString());
            baocaoDTO.MaSach = row["MaSach"].ToString();
            baocaoDTO.PhatSinh = int.Parse(row["PhatSinh"].ToString());
            baocaoDTO.Thang = row["Thang"].ToString();
            baocaoDTO.TonCuoi = int.Parse(row["TonCuoi"].ToString());
            baocaoDTO.TonDau = int.Parse(row["TonDau"].ToString());
            return baocaoDTO;
        }

        public BaoCaoTonDTO[] getListBaoCaoTon()
        {
            string sql = "SELECT * FROM BaoCaoTon";
            DataTable table = getTable(sql);
            int n = table.Rows.Count;
            BaoCaoTonDTO[] list = new BaoCaoTonDTO[n];
            for (int i = 0; i < n; i++)
            {
                BaoCaoTonDTO baocaoDTO = getBaoCaoTonFromDataRow(table.Rows[i]);
                list[i] = baocaoDTO;
            }
            return list;
        }

        public void insertBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            string sql = "INSERT INTO BaoCaoTon (Thang, MaSach, TonDau, PhatSinh, TonCuoi) VALUES ";
            sql += "('" + baocaoDTO.Thang + "', ";
            sql += "'" + baocaoDTO.MaSach + "', ";
            sql += baocaoDTO.TonDau + ", ";
            sql += baocaoDTO.PhatSinh + ", ";
            sql += baocaoDTO.TonCuoi + ")";
            data.executeNonQuery(sql);
        }

        public void deleteBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            string sql = "DELETE FROM BaoCaoTon WHERE MaSach = '" + baocaoDTO.MaSach + "'";
            data.executeNonQuery(sql);
        }

        public void updateBaoCaoTon(BaoCaoTonDTO baocaoDTO)
        {
            string sql = "UPDATE BaoCaoTon SET ";
            sql += " Thang = '" + baocaoDTO.Thang + "', ";
            sql += " TonDay = " + baocaoDTO.TonDau + ", ";
            sql += " PhatSinh = " + baocaoDTO.PhatSinh + ", ";
            sql += " TonCuoi = " + baocaoDTO.TonCuoi;
            sql += " WHERE MaSach = '" + baocaoDTO.MaSach + "'";
        }
    }
}