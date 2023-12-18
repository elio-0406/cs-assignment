using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiSanPhamDAO
    {
        public LoaiSanPhamDAO() { }

        public List<LoaiSanPham> LayTatCaLoaiSanPham()
        {
            List<LoaiSanPham> listLoaiSanPham = [];

            string query = "select * from LoaiSanPham";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    LoaiSanPham loaiSanPham = new()
                    {
                        MaLoaiSanPham = row["maLoaiSanPham"].ToString(),
                        TenLoaiSanPham = row["tenLoaiSanPham"].ToString(),
                        TrangThai = row["trangThai"].ToString()
                    };

                    listLoaiSanPham.Add(loaiSanPham);
                }
            }

            return listLoaiSanPham;
        }

        public List<LoaiSanPham> TimKiemLoaiSanPham(string tuKhoa, string maLoaiSanPham, string trangThai)
        {
            List<LoaiSanPham> listLoaiSanPham = [];

            string query = "select * from LoaiSanPham " +
                           "where (@tuKhoa = '' or lower(maLoaiSanPham) like @tuKhoa " +
                           "or tenLoaiSanPham collate Latin1_General_CI_AI like @tuKhoa) " +
                           "and (@maLoaiSanPham = '' or maLoaiSanPham = @maLoaiSanPham) " +
                           "and (@trangThai = '' or trangThai = @trangThai)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@tuKhoa", SqlDbType.NVarChar) { Value = "%" + tuKhoa + "%" },
                new SqlParameter("@maLoaiSanPham", SqlDbType.Char) { Value = maLoaiSanPham },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = trangThai }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    LoaiSanPham loaiSanPham = new()
                    {
                        MaLoaiSanPham = row["maLoaiSanPham"].ToString(),
                        TenLoaiSanPham = row["tenLoaiSanPham"].ToString(),
                        TrangThai = row["trangThai"].ToString()
                    };
                    listLoaiSanPham.Add(loaiSanPham);
                }
            }

            return listLoaiSanPham;
        }

        public int DemLoaiSanPham()
        {
            int soLoaiSanPham = 0;

            string query = "select count(*) as soLoaiSanPham from LoaiSanPham";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
                soLoaiSanPham = (int)dataTable.Rows[0]["soLoaiSanPham"];

            return soLoaiSanPham;
        }

        public bool ThemLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            string query = "insert into LoaiSanPham values (@maLoaiSanPham, @tenLoaiSanPham, @trangThai)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maLoaiSanPham", SqlDbType.Char) { Value = loaiSanPham.MaLoaiSanPham },
                new SqlParameter("@tenLoaiSanPham", SqlDbType.NVarChar) { Value = loaiSanPham.TenLoaiSanPham },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = loaiSanPham.TrangThai }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool XoaLoaiSanPham(string maLoaiSanPham)
        {
            string query = "update LoaiSanPham set trangThai = N'Ngừng sử dụng' where maLoaiSanPham = @maLoaiSanPham";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maLoaiSanPham", SqlDbType.Char) { Value = maLoaiSanPham }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool SuaLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            string query = "update LoaiSanPham set tenLoaiSanPham = @tenLoaiSanPham, trangThai = @trangThai where maLoaiSanPham = @maLoaiSanPham";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maLoaiSanPham", SqlDbType.Char) { Value = loaiSanPham.MaLoaiSanPham },
                new SqlParameter("@tenLoaiSanPham", SqlDbType.NVarChar) { Value = loaiSanPham.TenLoaiSanPham },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = loaiSanPham.TrangThai }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
