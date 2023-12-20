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
    public class SanPhamDAO
    {
        public SanPhamDAO() { }

        public List<SanPham> LayTatCaSanPham()
        {
            List<SanPham> listSanPham = [];

            string query = "select * from SanPham";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    SanPham sanPham = new()
                    {
                        MaSanPham = row["maSanPham"].ToString(),
                        MaLoaiSanPham = row["maLoaiSanPham"].ToString(),
                        TenSanPham = row["tenSanPham"].ToString(),
                        DonViTinh = row["donViTinh"].ToString(),
                        SoLuong = (int)row["soLuong"],
                        GiaBan = (decimal)row["giaBan"],
                        Anh = (byte[])row["anh"],
                        TrangThai = row["trangThai"].ToString()
                    };
                    listSanPham.Add(sanPham);
                }
            }

            return listSanPham;
        }

        public List<SanPham> TimKiemSanPham(string tuKhoa, string maSanPham, string maLoaiSanPham, string trangThai)
        {
            List<SanPham> listSanPham = [];

            string query = "select * from SanPham " +
                "where (@tuKhoa = '' or lower(maSanPham) like @tuKhoa " +
                "or tenSanPham collate Latin1_General_CI_AI like @tuKhoa) " +
                "and (@maSanPham = '' or maSanPham = @maSanPham) " +
                "and (@maLoaiSanPham = '' or maLoaiSanPham = @maLoaiSanPham) " +
                "and (@trangThai = '' or trangThai = @trangThai)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@tuKhoa", SqlDbType.NVarChar) { Value = "%" + tuKhoa + "%" },
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = maSanPham },
                new SqlParameter("@maLoaiSanPham", SqlDbType.Char) { Value = maLoaiSanPham },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = trangThai }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    SanPham sanPham = new()
                    {
                        MaSanPham = row["maSanPham"].ToString(),
                        MaLoaiSanPham = row["maLoaiSanPham"].ToString(),
                        TenSanPham = row["tenSanPham"].ToString(),
                        DonViTinh = row["donViTinh"].ToString(),
                        SoLuong = (int)row["soLuong"],
                        GiaBan = (decimal)row["giaBan"],
                        Anh = (byte[])row["anh"],
                        TrangThai = row["trangThai"].ToString()
                    };
                    listSanPham.Add(sanPham);
                }
            }

            return listSanPham;
        }

        public int DemSanPham()
        {
            int soSanPham = 0;

            string query = "select count(*) as soSanPham from SanPham";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
                soSanPham = (int)dataTable.Rows[0]["soSanPham"];

            return soSanPham;
        }

        public bool ThemSanPham(SanPham sanPham)
        {
            string query = "insert into SanPham values (@maSanPham, @maLoaiSanPham, @tenSanPham, @donViTinh, @giaBan, @soLuong, @anh, @trangThai)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = sanPham.MaSanPham },
                new SqlParameter("@maLoaiSanPham", SqlDbType.Char) { Value = sanPham.MaLoaiSanPham },
                new SqlParameter("@tenSanPham", SqlDbType.NVarChar) { Value = sanPham.TenSanPham },
                new SqlParameter("@donViTinh", SqlDbType.NVarChar) { Value = sanPham.DonViTinh },
                new SqlParameter("@giaBan", SqlDbType.Money) { Value = sanPham.GiaBan },
                new SqlParameter("@soLuong", SqlDbType.Int) { Value = sanPham.SoLuong },
                new SqlParameter("@anh", SqlDbType.Image) { Value = sanPham.Anh },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = sanPham.TrangThai }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool XoaSanPham(string maSanPham)
        {
            string query = "update SanPham set trangThai = N'Ngừng kinh doanh' where maSanPham = @maSanPham";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = maSanPham }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool SuaSanPham(SanPham sanPham)
        {
            string query = "update SanPham set maLoaiSanPham = @maLoaiSanPham, tenSanPham = @tenSanPham, donViTinh = @donViTinh, giaBan = @giaBan, anh = @anh, trangThai = @trangThai where maSanPham = @maSanPham";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = sanPham.MaSanPham },
                new SqlParameter("@maLoaiSanPham", SqlDbType.Char) { Value = sanPham.MaLoaiSanPham },
                new SqlParameter("@tenSanPham", SqlDbType.NVarChar) { Value = sanPham.TenSanPham },
                new SqlParameter("@donViTinh", SqlDbType.NVarChar) { Value = sanPham.DonViTinh },
                new SqlParameter("@giaBan", SqlDbType.Money) { Value = sanPham.GiaBan },
                new SqlParameter("@anh", SqlDbType.Image) { Value = sanPham.Anh },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = sanPham.TrangThai }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool SuaSoLuong(SanPham sanPham)
        {
            string query = "update SanPham set soLuong = @soLuong where maSanPham = @maSanPham; " +
                           "update SanPham set trangThai= N'Đang bán' where soLuong > 0 and maSanPham = @maSanPham; " +
                           "update SanPham set trangThai= N'Hết hàng' where soLuong = 0 and maSanPham = @maSanPham";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maSanPham", SqlDbType.Char) { Value = sanPham.MaSanPham },
                new SqlParameter("@soLuong", SqlDbType.Int) { Value = sanPham.SoLuong }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
