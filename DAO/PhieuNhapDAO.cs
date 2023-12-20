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
    public class PhieuNhapDAO
    {
        public PhieuNhapDAO() { }

        public List<PhieuNhap> LayTatCaPhieuNhap()
        {
            List<PhieuNhap> listPhieuNhap = [];

            string query = "select * from PhieuNhap";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap PhieuNhap = new()
                    {
                        MaPhieuNhap = row["maPhieuNhap"].ToString(),
                        MaNhaCungCap = row["maNhaCungCap"].ToString(),
                        MaNguoiTao = row["maNguoiTao"].ToString(),
                        MaNguoiDuyet = row["maNguoiDuyet"]?.ToString(),
                        MaNguoiNhap = row["maNguoiNhap"]?.ToString(),
                        ThoiGianTao = (DateTime)row["thoiGianTao"],
                        ThoiGianDuyet = row["thoiGianDuyet"] == DBNull.Value ? null : (DateTime?)row["thoiGianDuyet"],
                        ThoiGianNhap = row["thoiGianNhap"] == DBNull.Value ? null : (DateTime?)row["thoiGianNhap"],
                        TongTien = (decimal)row["tongTien"],
                        TrangThai = row["trangThai"].ToString()
                    };
                    listPhieuNhap.Add(PhieuNhap);
                }
            }

            return listPhieuNhap;
        }

        public List<PhieuNhap> TimKiemPhieuNhap(string tuKhoa, string maPhieuNhap, string trangThai)
        {
            List<PhieuNhap> listPhieuNhap = [];

            string query = "select * from PhieuNhap " +
                           "where (@tuKhoa = '' or lower(maPhieuNhap) like @tuKhoa) " +
                           "and (@maPhieuNhap = '' or maPhieuNhap = @maPhieuNhap) " +
                           "and (@trangThai = '' or trangThai = @trangThai)";
                           

            SqlParameter[] parameters =
            [
                new SqlParameter("@tuKhoa", SqlDbType.NVarChar) { Value = "%" + tuKhoa + "%" },
                new SqlParameter("@maPhieuNhap", SqlDbType.Char) { Value = maPhieuNhap },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = trangThai }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap PhieuNhap = new()
                    {
                        MaPhieuNhap = row["maPhieuNhap"].ToString(),
                        MaNhaCungCap = row["maNhaCungCap"].ToString(),
                        MaNguoiTao = row["maNguoiTao"].ToString(),
                        MaNguoiDuyet = row["maNguoiDuyet"]?.ToString(),
                        MaNguoiNhap = row["maNguoiNhap"]?.ToString(),
                        ThoiGianTao = (DateTime)row["thoiGianTao"],
                        ThoiGianDuyet = row["thoiGianDuyet"] == DBNull.Value ? null : (DateTime?)row["thoiGianDuyet"],
                        ThoiGianNhap = row["thoiGianNhap"] == DBNull.Value ? null : (DateTime?)row["thoiGianNhap"],
                        TongTien = (decimal)row["tongTien"],
                        TrangThai = row["trangThai"].ToString()
                    };
                    listPhieuNhap.Add(PhieuNhap);
                }
            }

            return listPhieuNhap;
        }

        public int DemPhieuNhapTheoNgay(DateTime ngay)
        {
            int soPhieuNhap = 0;

            string query = "select count(*) as soPhieuNhap from PhieuNhap where convert(DATE, thoiGianTao) = @ngay";

            SqlParameter[] parameters =
            [
                new SqlParameter("@ngay", SqlDbType.Date) { Value = ngay.Date }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
                soPhieuNhap = (int)dataTable.Rows[0]["soPhieuNhap"];
            return soPhieuNhap;
        }

        public bool ThemPhieuNhap(PhieuNhap phieuNhap, List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            int rowsAffected = 0;

            string query = "insert into phieuNhap values (@maPhieuNhap, @maNhaCungCap, @maNguoiTao, @maNguoiDuyet, @maNguoiNhap, @thoiGianTao, @thoiGianDuyet, @thoiGianNhap, @tongTien, @trangThai)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maPhieuNhap", SqlDbType.Char) { Value = phieuNhap.MaPhieuNhap },
                new SqlParameter("@maNhaCungCap", SqlDbType.Char) { Value = phieuNhap.MaNhaCungCap },
                new SqlParameter("@maNguoiTao", SqlDbType.Char) { Value = phieuNhap.MaNguoiTao },

                new SqlParameter("@maNguoiDuyet", SqlDbType.Char) { Value = string.IsNullOrEmpty(phieuNhap.MaNguoiDuyet) ? DBNull.Value : phieuNhap.MaNguoiDuyet },
                new SqlParameter("@maNguoiNhap", SqlDbType.Char) { Value = string.IsNullOrEmpty(phieuNhap.MaNguoiNhap) ? DBNull.Value : phieuNhap.MaNguoiNhap },

                new SqlParameter("@thoiGianTao", SqlDbType.DateTime2) { Value = phieuNhap.ThoiGianTao },
                new SqlParameter("@thoiGianDuyet", SqlDbType.DateTime2) { Value = phieuNhap.ThoiGianDuyet.HasValue ? phieuNhap.ThoiGianDuyet : DBNull.Value },
                new SqlParameter("@thoiGianNhap", SqlDbType.DateTime2) { Value = phieuNhap.ThoiGianNhap.HasValue ? phieuNhap.ThoiGianNhap : DBNull.Value },

                new SqlParameter("@tongTien", SqlDbType.Money) { Value = phieuNhap.TongTien },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = phieuNhap.TrangThai }
            ];

            rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);

            if (rowsAffected <= 0)
                return false;

            parameters = [];

            ChiTietPhieuNhapDAO chiTietPhieuNhapDAO = new();

            foreach (ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                if (!chiTietPhieuNhapDAO.ThemChiTietPhieuNhap(chiTietPhieuNhap))
                    return false;
                rowsAffected += 1;
            }

            return rowsAffected == listChiTietPhieuNhap.Count + 1;
        }

        public bool SuaPhieuNhap(PhieuNhap phieuNhap)
        {
            string query = "update PhieuNhap set maNhaCungCap = @maNhaCungCap, thanhTien = @thanhTien, trangThai = @trangThai, thoiGianDuyet = @thoiGianDuyet, maNguoiDuyet = @maNguoiDuyet  where maPhieuNhap = @maPhieuNhap";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maPhieuNhap", SqlDbType.Char) { Value = phieuNhap.MaPhieuNhap },
                new SqlParameter("@maNhaCungCap", SqlDbType.Char) { Value = phieuNhap.MaNhaCungCap },
                new SqlParameter("@tongTien", SqlDbType.Money) { Value = phieuNhap.TongTien },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = phieuNhap.TrangThai },
                new SqlParameter("@thoiGianDuyet", SqlDbType.DateTime2) { Value = phieuNhap.ThoiGianDuyet.HasValue ? phieuNhap.ThoiGianDuyet : DBNull.Value },
                new SqlParameter("@maNguoiDuyet", SqlDbType.Char) { Value = string.IsNullOrEmpty(phieuNhap.MaNguoiDuyet) ? DBNull.Value : phieuNhap.MaNguoiDuyet },
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool NhapHang(PhieuNhap phieuNhap)
        {
            string query = "update PhieuNhap set trangThai = N'Đã nhập hàng', maNguoiNhap = @maNguoiNhap, thoiGianNhap = @thoiGianNhap where maPhieuNhap = @maPhieuNhap;";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maPhieuNhap", SqlDbType.Char) { Value = phieuNhap.MaPhieuNhap },
                new SqlParameter("@thoiGianNhap", SqlDbType.DateTime2) { Value = phieuNhap.ThoiGianNhap },
                new SqlParameter("@maNguoiNhap", SqlDbType.Char) { Value = phieuNhap.MaNguoiNhap },
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);

            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new ChiTietPhieuNhapDAO().LayChiTietPhieuNhapTheoPhieuNhap(phieuNhap.MaPhieuNhap);
            foreach (ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                SanPham sanPham = new SanPhamDAO().TimKiemSanPham("", chiTietPhieuNhap.MaSanPham, "", "")[0];
                sanPham.SoLuong += chiTietPhieuNhap.SoLuong;
                if (!new SanPhamDAO().SuaSoLuong(sanPham))
                    return false;
            }

            return rowsAffected > 0;
        }
    }
}
