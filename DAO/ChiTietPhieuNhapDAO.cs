using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        public ChiTietPhieuNhapDAO() { }

        public List<ChiTietPhieuNhap> LayChiTietPhieuNhapTheoPhieuNhap(string maPhieuNhap)
        {
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = [];

            string query = "select * from ChiTietPhieuNhap where maPhieuNhap = @maPhieuNhap";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maPhieuNhap", SqlDbType.Char) { Value = maPhieuNhap }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                   ChiTietPhieuNhap chiTietPhieuNhap = new()
                    {
                        MaPhieuNhap = row["maPhieuNhap"].ToString(),
                        MaSanPham = row["maSanPham"].ToString(),
                        DonGia = (decimal)row["donGia"],
                        SoLuong = (int)row["soLuong"],
                        ThanhTien = (decimal)row["thanhTien"]
                    };
                    listChiTietPhieuNhap.Add(chiTietPhieuNhap);
                }
            }

            return listChiTietPhieuNhap;
        }

        public ChiTietPhieuNhap LayChiTietPhieuNhap(string maPhieuNhap, string maSanPham)
        {
            ChiTietPhieuNhap chiTietPhieuNhap = new();

            string query = "select * from ChiTietPhieuNhap where maPhieuNhap = @maPhieuNhap and maSanPham = @maSanPham";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maPhieuNhap", SqlDbType.Char) { Value = maPhieuNhap },
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = maSanPham }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    chiTietPhieuNhap.MaPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                    chiTietPhieuNhap.MaSanPham = dataTable.Rows[0]["maSanPham"].ToString();
                    chiTietPhieuNhap.SoLuong = (int)dataTable.Rows[0]["soLuong"];
                    chiTietPhieuNhap.DonGia = (decimal)dataTable.Rows[0]["donGia"];
                    chiTietPhieuNhap.ThanhTien = (decimal)dataTable.Rows[0]["thanhTien"];
                }
            }

            return chiTietPhieuNhap;
        }

        public bool SuaChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            PhieuNhapDAO phieuNhapDAO = new();

            PhieuNhap phieuNhap = phieuNhapDAO.TimKiemPhieuNhap("", chiTietPhieuNhap.MaPhieuNhap, "", null, "")[0];

            phieuNhap.TongTien -= LayChiTietPhieuNhap(chiTietPhieuNhap.MaPhieuNhap, chiTietPhieuNhap.MaSanPham).ThanhTien;

            string query = "update ChiTietPhieuNhap set soLuong = @soLuong, donGia = @donGia, thanhTien = @soLuong * @donGia where maPhieuNhap = @maPhieuNhap and maSanPham = @maSanPham";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maPhieuNhap", SqlDbType.Char) { Value = chiTietPhieuNhap.MaPhieuNhap },
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = chiTietPhieuNhap.MaSanPham },
                new SqlParameter("@donGia", SqlDbType.Money) { Value = chiTietPhieuNhap.DonGia },
                new SqlParameter("@soLuong", SqlDbType.Int) { Value = chiTietPhieuNhap.SoLuong },
                new SqlParameter("@thanhTien", SqlDbType.Money) { Value = chiTietPhieuNhap.ThanhTien }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);

            if (rowsAffected <= 0)
                return false;

            phieuNhap.TongTien += LayChiTietPhieuNhap(chiTietPhieuNhap.MaPhieuNhap, chiTietPhieuNhap.MaSanPham).ThanhTien;

            phieuNhapDAO.SuaPhieuNhap(phieuNhap);

            return phieuNhapDAO.SuaPhieuNhap(phieuNhap);
        }

        public bool ThemChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            string query = "insert into ChiTietPhieuNhap values (@maPhieuNhap, @maSanPham, @soLuong, @donGia, @thanhTien)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maPhieuNhap", SqlDbType.Char) { Value = chiTietPhieuNhap.MaPhieuNhap },
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = chiTietPhieuNhap.MaSanPham },
                new SqlParameter("@donGia", SqlDbType.Money) { Value = chiTietPhieuNhap.DonGia },
                new SqlParameter("@soLuong", SqlDbType.Int) { Value = chiTietPhieuNhap.SoLuong },
                new SqlParameter("@thanhTien", SqlDbType.Money) { Value = chiTietPhieuNhap.ThanhTien }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);

            return rowsAffected > 0;
        }
    }
}
