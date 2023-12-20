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
    public class KhuyenMaiDAO
    {
        public KhuyenMaiDAO() { }

        public List<KhuyenMai> LayTatCaKhuyenMai()
        {
            List<KhuyenMai> listKhuyenMai = [];

            string query = "select * from KhuyenMai";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    KhuyenMai khuyenMai = new()
                    {
                        MaKhuyenMai = row["maKhuyenMai"].ToString(),
                        TenKhuyenMai = row["tenKhuyenMai"].ToString(),
                        LoaiGiaTri = row["loaiGiaTri"].ToString(),
                        GiaTri = float.Parse(row["giaTri"].ToString()),
                        ThoiGianBatDau = (DateTime)row["thoiGianBatDau"],
                        ThoiGianKetThuc = (DateTime)row["thoiGianKetThuc"],
                    };
                    listKhuyenMai.Add(khuyenMai);
                }
            }

            return listKhuyenMai;
        }

        public List<KhuyenMai> TimKiemKhuyenMai(string tuKhoa, string maKhuyenMai, string loaiGiaTri, string tuyChonThoiGian, DateTime? thoiGian, string trangThai)
        {
            List<KhuyenMai> listKhuyenMai = [];

            string query = "select * from KhuyenMai " +
                           "where (@tuKhoa = '' or lower(maKhuyenMai) like @tuKhoa " +
                           "or tenKhuyenMai collate Latin1_General_CI_AI like @tuKhoa) " +
                           "and (@maKhuyenMai = '' or maKhuyenMai = @maKhuyenMai) " +
                           "and (@loaiGiaTri = '' or loaiGiaTri = @loaiGiaTri)";

            switch (trangThai)
            {
                case "Đang diễn ra":
                    query += " and thoiGianBatDau < GETDATE() and thoiGianKetThuc > GETDATE()";
                    break;
                case "Chưa diễn ra":
                    query += " and thoiGianBatDau > GETDATE() and thoiGianKetThuc > GETDATE()";
                    break;
                case "Đã kết thúc":
                    query += " and thoiGianKetThuc <= GETDATE()";
                    break;
            }

            if (thoiGian.HasValue)
            {
                switch (tuyChonThoiGian)
                {
                    case "Ngày":
                        query += " and cast(thoiGianBatDau as date) <= @ngay and cast(thoiGianKetThuc as date) >= @ngay";
                        break;
                    case "Tháng":
                        query += " and month(thoiGianBatDau) = @thang and year(thoiGianBatDau) = @nam " +
                                 "and month(thoiGianKetThuc) = @thang and year(thoiGianKetThuc) = @nam";
                        break;
                    case "Năm":
                        query += " and year(thoiGianBatDau) = @nam and year(thoiGianKetThuc) = @nam";
                        break;
                }
            }

            SqlParameter[] parameters =
            [
                new SqlParameter("@tuKhoa", SqlDbType.NVarChar) { Value = "%" + tuKhoa + "%" },
                new SqlParameter("@maKhuyenMai", SqlDbType.Char) { Value = maKhuyenMai },
                new SqlParameter("@loaiGiaTri", SqlDbType.NVarChar) { Value = loaiGiaTri },
                new SqlParameter("@ngay", SqlDbType.Date) { Value = thoiGian.HasValue ? thoiGian.Value.Date : DBNull.Value},
                new SqlParameter("@thang", SqlDbType.Int) { Value = thoiGian.HasValue ? thoiGian.Value.Month : DBNull.Value },
                new SqlParameter("@nam", SqlDbType.Int) { Value = thoiGian.HasValue ? thoiGian.Value.Year : DBNull.Value }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    KhuyenMai khuyenMai = new()
                    {
                        MaKhuyenMai = row["maKhuyenMai"].ToString(),
                        TenKhuyenMai = row["tenKhuyenMai"].ToString(),
                        LoaiGiaTri = row["loaiGiaTri"].ToString(),
                        GiaTri = float.Parse(row["giaTri"].ToString()),
                        ThoiGianBatDau = (DateTime)row["thoiGianBatDau"],
                        ThoiGianKetThuc = (DateTime)row["thoiGianKetThuc"],
                    };
                    listKhuyenMai.Add(khuyenMai);
                }
            }

            return listKhuyenMai;
        }

        public int DemKhuyenMai()
        {
            int soKhuyenMai = 0;

            string query = "select count(*) as soKhuyenMai from KhuyenMai";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
                soKhuyenMai = (int)dataTable.Rows[0]["soKhuyenMai"];
            return soKhuyenMai;
        }

        public bool ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            string query = "insert into KhuyenMai values (@maKhuyenMai, @tenKhuyenMai, @loaiGiaTri, @giaTri, @thoiGianBatDau, @thoiGianKetThuc)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maKhuyenMai", SqlDbType.Char) { Value = khuyenMai.MaKhuyenMai },
                new SqlParameter("@tenKhuyenMai", SqlDbType.NVarChar) { Value = khuyenMai.TenKhuyenMai },
                new SqlParameter("@loaiGiaTri", SqlDbType.NVarChar) { Value = khuyenMai.LoaiGiaTri },
                new SqlParameter("@giaTri", SqlDbType.Float) { Value = khuyenMai.GiaTri },
                new SqlParameter("@thoiGianBatDau", SqlDbType.DateTime2) { Value = khuyenMai.ThoiGianBatDau },
                new SqlParameter("@thoiGianKetThuc", SqlDbType.DateTime2) { Value = khuyenMai.ThoiGianKetThuc }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool XoaKhuyenMai(string maKhuyenMai)
        {
            string query = "update KhuyenMai set thoiGianKetThuc = GETDATE() where maKhuyenMai = @maKhuyenMai";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maKhuyenMai", SqlDbType.Char) { Value = maKhuyenMai }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            string query = "update KhuyenMai set tenKhuyenMai = @tenKhuyenMai, loaiGiaTri = @loaiGiaTri, giaTri = @giaTri, thoiGianBatDau = @thoiGianBatDau, thoiGianKetThuc = @thoiGianKetThuc where maKhuyenMai = @maKhuyenMai";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maKhuyenMai", SqlDbType.Char) { Value = khuyenMai.MaKhuyenMai },
                new SqlParameter("@tenKhuyenMai", SqlDbType.NVarChar) { Value = khuyenMai.TenKhuyenMai },
                new SqlParameter("@loaiGiaTri", SqlDbType.NVarChar) { Value = khuyenMai.LoaiGiaTri },
                new SqlParameter("@giaTri", SqlDbType.Float) { Value = khuyenMai.GiaTri },
                new SqlParameter("@thoiGianBatDau", SqlDbType.DateTime2) { Value = khuyenMai.ThoiGianBatDau },
                new SqlParameter("@thoiGianKetThuc", SqlDbType.DateTime2) { Value = khuyenMai.ThoiGianKetThuc }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
