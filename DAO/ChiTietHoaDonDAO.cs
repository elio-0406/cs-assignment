using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        public ChiTietHoaDonDAO() { }

        public List<ChiTietHoaDon> LayChiTietHoaDonTheoHoaDon(string maHoaDon)
        {
            List<ChiTietHoaDon> listChiTietHoaDon = [];

            string query = "select * from ChiTietHoaDon where maHoaDon = @maHoaDon";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maHoaDon", SqlDbType.Char) { Value = maHoaDon }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    ChiTietHoaDon chiTietHoaDon = new()
                    {
                        MaHoaDon = row["maHoaDon"].ToString(),
                        MaSanPham = row["maSanPham"].ToString(),
                        DonGia = (decimal)row["donGia"],
                        SoLuong = (int)row["soLuong"],
                        ThanhTien = (decimal)row["thanhTien"]
                    };
                    listChiTietHoaDon.Add(chiTietHoaDon);
                }
            }

            return listChiTietHoaDon;
        }

        public ChiTietHoaDon LayChiTietHoaDon(string maHoaDon, string maSanPham)
        {
            ChiTietHoaDon chiTietHoaDon = new();

            string query = "select * from ChiTietHoaDon where maHoaDon = @maHoaDon and maSanPham = @maSanPham";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maHoaDon", SqlDbType.Char) { Value = maHoaDon },
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = maSanPham }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    chiTietHoaDon.MaHoaDon = dataTable.Rows[0]["maHoaDon"].ToString();
                    chiTietHoaDon.MaSanPham = dataTable.Rows[0]["maSanPham"].ToString();
                    chiTietHoaDon.SoLuong = (int)dataTable.Rows[0]["soLuong"];
                    chiTietHoaDon.DonGia = (decimal)dataTable.Rows[0]["donGia"];
                    chiTietHoaDon.ThanhTien = (decimal)dataTable.Rows[0]["thanhTien"];
                }
            }

            return chiTietHoaDon;
        }

        public bool ThemChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            string query = "insert into ChiTietHoaDon values (@maHoaDon, @maSanPham, @soLuong, @donGia, @thanhTien)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maHoaDon", SqlDbType.Char) { Value = chiTietHoaDon.MaHoaDon },
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = chiTietHoaDon.MaSanPham },
                new SqlParameter("@donGia", SqlDbType.Money) { Value = chiTietHoaDon.DonGia },
                new SqlParameter("@soLuong", SqlDbType.Int) { Value = chiTietHoaDon.SoLuong },
                new SqlParameter("@thanhTien", SqlDbType.Money) { Value = chiTietHoaDon.ThanhTien }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
    }
}
