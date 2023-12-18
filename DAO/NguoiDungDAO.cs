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
    public class NguoiDungDAO
    {
        public NguoiDungDAO() { }

        public List<NguoiDung> LayTatCaNguoiDung()
        {
            List<NguoiDung> listNguoiDung = [];

            string query = "select * from NguoiDung";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    NguoiDung nguoiDung = new()
                    {
                        MaNguoiDung = row["maNguoiDung"].ToString(),
                        MaPhanQuyen = row["maPhanQuyen"].ToString(),
                        TenDangNhap = row["tenDangNhap"].ToString(),
                        MatKhau = row["matKhau"].ToString(),
                        HoTen = row["hoTen"].ToString(),
                        NgaySinh = row["ngaySinh"] == DBNull.Value ? null : (DateTime?)row["ngaySinh"],
                        GioiTinh = row["gioiTinh"]?.ToString(),
                        SoDienThoai = row["soDienThoai"]?.ToString(),
                        Email = row["email"]?.ToString(),
                        DiaChi = row["diaChi"]?.ToString(),
                        TrangThai = row["trangThai"].ToString()
                    };
                    listNguoiDung.Add(nguoiDung);
                }
            }

            return listNguoiDung;
        }

        public List<NguoiDung> TimKiemNguoiDung(string tuKhoa, string maNguoiDung, string maPhanQuyen, string tenDangNhap, string gioiTinh, string trangThai)
        {
            List<NguoiDung> listNguoiDung = [];

            string query = "select * from NguoiDung " +
                           "where (@tuKhoa = '' or lower(maNguoiDung) like @tuKhoa " +
                           "or lower(tenDangNhap) like @tuKhoa " +
                           "or hoTen collate Latin1_General_CI_AI like @tuKhoa) " +
                           "and (@maNguoiDung = '' or maNguoiDung = @maNguoiDung) " +
                           "and (@maPhanQuyen = '' or maPhanQuyen = @maPhanQuyen) " +
                           "and (@tenDangNhap = '' or tenDangNhap = @tenDangNhap) " +
                           "and (@gioiTinh = '' or gioiTinh = @gioiTinh) " +
                           "and (@trangThai = '' or trangThai = @trangThai)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@tuKhoa", SqlDbType.NVarChar) { Value = "%" + tuKhoa + "%" },
                new SqlParameter("@maNguoiDung", SqlDbType.Char) { Value = maNguoiDung },
                new SqlParameter("@maPhanQuyen", SqlDbType.Char) { Value = maPhanQuyen },
                new SqlParameter("@tenDangNhap", SqlDbType.VarChar) { Value = tenDangNhap },
                new SqlParameter("@gioiTinh", SqlDbType.NVarChar) { Value = gioiTinh },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = trangThai },
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    NguoiDung nguoiDung = new()
                    {
                        MaNguoiDung = row["maNguoiDung"].ToString(),
                        MaPhanQuyen = row["maPhanQuyen"].ToString(),
                        TenDangNhap = row["tenDangNhap"].ToString(),
                        MatKhau = row["matKhau"].ToString(),
                        HoTen = row["hoTen"].ToString(),
                        NgaySinh = row["ngaySinh"] == DBNull.Value ? null : (DateTime?)row["ngaySinh"],
                        GioiTinh = row["gioiTinh"]?.ToString(),
                        SoDienThoai = row["soDienThoai"]?.ToString(),
                        Email = row["email"]?.ToString(),
                        DiaChi = row["diaChi"]?.ToString(),
                        TrangThai = row["trangThai"].ToString()
                    };
                    listNguoiDung.Add(nguoiDung);
                }
            }

            return listNguoiDung;
        }

        public bool KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            bool tonTai = false;

            string query = "select * from NguoiDung where tenDangNhap = @tenDangNhap";

            SqlParameter[] parameters =
            [
                new SqlParameter("@tenDangNhap", SqlDbType.VarChar) { Value = tenDangNhap }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
                tonTai = true;

            return tonTai;
        }

        public bool KiemTraMatKhauChinhXac(string tenDangNhap, string matKhau)
        {
            bool chinhXac = false;

            string query = "select * from NguoiDung where tenDangNhap = @tenDangNhap and matKhau = @matKhau";

            SqlParameter[] parameters =
            [
                new SqlParameter("@tenDangNhap", SqlDbType.VarChar) { Value = tenDangNhap },
                new SqlParameter("@matKhau", SqlDbType.VarChar) { Value = matKhau }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
                chinhXac = true;

            return chinhXac;
        }

        public bool KiemTraDangHoatDong(string tenDangNhap)
        {
            bool dangHoatDong = false;

            string query = "select * from NguoiDung where tenDangNhap = @tenDangNhap and trangThai = N'Đang hoạt động'";

            SqlParameter[] parameters =
            [
                new SqlParameter("@tenDangNhap", SqlDbType.VarChar) { Value = tenDangNhap }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
                dangHoatDong = true;

            return dangHoatDong;
        }

        public int DemNguoiDungTheoPhanQuyen(string maPhanQuyen)
        {
            int soNguoiDung = 0;

            string query = "select count(*) as soNguoiDung from NguoiDung where maPhanQuyen = @maPhanQuyen";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maPhanQuyen", SqlDbType.Char) { Value = maPhanQuyen }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
                soNguoiDung = (int)dataTable.Rows[0]["soNguoiDung"];

            return soNguoiDung;
        }
    }
}
