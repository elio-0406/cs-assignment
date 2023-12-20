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
    public class HoaDonDAO
    {
        public HoaDonDAO() { }

        public List<HoaDon> LayTatCaHoaDon()
        {
            List<HoaDon> listHoaDon = [];

            string query = "select * from HoaDon";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    HoaDon hoaDon = new()
                    {
                        MaHoaDon = row["maHoaDon"].ToString(),
                        MaNguoiTao = row["maNguoiTao"].ToString(),
                        MaKhachHang = row["maKhachHang"]?.ToString(),
                        MaKhuyenMai = row["maKhuyenMai"]?.ToString(),
                        TenKhuyenMai = row["tenKhuyenMai"]?.ToString(),
                        ThoiGianTao = (DateTime)row["thoiGianTao"],
                        ThanhTien = decimal.Parse(row["thanhTien"].ToString()),
                        GiamGia = decimal.Parse(row["giamGia"].ToString()),
                        TongTien = decimal.Parse(row["tongTien"].ToString()),
                        TienNhan = decimal.Parse(row["tienNhan"].ToString()),
                        TienThua = decimal.Parse(row["tienThua"].ToString())
                    };

                    listHoaDon.Add(hoaDon);
                }
            }

            return listHoaDon;
        }

        public int DemHoaDonTheoNgay(DateTime ngay)
        {
            int soHoaDon = 0;

            string query = "select count(*) as soHoaDon from HoaDon where cast(thoiGianTao as date) = @ngay";

            SqlParameter[] parameters =
            [
                new SqlParameter("@ngay", SqlDbType.Date) { Value = ngay.Date }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
                soHoaDon = (int)dataTable.Rows[0]["soHoaDon"];
            return soHoaDon;
        }

        public bool ThemHoaDon(HoaDon hoaDon, List<ChiTietHoaDon> listChiTietHoaDon)
        {
            int rowsAffected = 0;

            string query = "insert into HoaDon values (@maHoaDon, @maNguoiTao, @maKhachHang, @maKhuyenMai, @tenKhuyenMai, @thoiGianTao, @thanhTien, @giamGia, @tongTien, @tienNhan, @tienThua)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maHoaDon", SqlDbType.Char) { Value = hoaDon.MaHoaDon },
                new SqlParameter("@maNguoiTao", SqlDbType.Char) { Value = hoaDon.MaNguoiTao },

                new SqlParameter("@maKhachHang", SqlDbType.Char) { Value = string.IsNullOrEmpty(hoaDon.MaKhachHang) ? DBNull.Value : hoaDon.MaKhachHang },
                new SqlParameter("@maKhuyenMai", SqlDbType.Char) { Value = string.IsNullOrEmpty(hoaDon.MaKhuyenMai) ? DBNull.Value : hoaDon.MaKhuyenMai },
                new SqlParameter("@tenKhuyenMai", SqlDbType.NVarChar) { Value = string.IsNullOrEmpty(hoaDon.TenKhuyenMai) ? DBNull.Value : hoaDon.TenKhuyenMai },

                new SqlParameter("@thoiGianTao", SqlDbType.DateTime2) { Value = hoaDon.ThoiGianTao },
                new SqlParameter("@thanhTien", SqlDbType.Money) { Value = hoaDon.ThanhTien },
                new SqlParameter("@giamGia", SqlDbType.Money) { Value = hoaDon.GiamGia },
                new SqlParameter("@tongTien", SqlDbType.Money) { Value = hoaDon.TongTien },
                new SqlParameter("@tienNhan", SqlDbType.Money) { Value = hoaDon.TienNhan },
                new SqlParameter("@tienThua", SqlDbType.Money) { Value = hoaDon.TienThua }
            ];

            rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);

            if (rowsAffected <= 0)
                return false;

            parameters = [];

            ChiTietHoaDonDAO chiTietHoaDonDAO = new();

            foreach (ChiTietHoaDon chiTietHoaDon in listChiTietHoaDon)
            {
                if (!chiTietHoaDonDAO.ThemChiTietHoaDon(chiTietHoaDon))
                    return false;
                
                SanPham sanPham = new SanPhamDAO().TimKiemSanPham("", chiTietHoaDon.MaSanPham, "", "")[0];
                sanPham.SoLuong -= chiTietHoaDon.SoLuong;
                if (!new SanPhamDAO().SuaSoLuong(sanPham))
                    return false;

                rowsAffected += 1;
            }

            return rowsAffected == listChiTietHoaDon.Count + 1;
        }

        public List<HoaDon> TimKiemHoaDon(string tuKhoa, string maHoaDon, string tuyChonThoiGian, DateTime? thoiGian)
        {
            List<HoaDon> listHoaDon = [];

            string query = "select * from HoaDon " +
                           "where (@tuKhoa = '' or lower(maHoaDon) like @tuKhoa) " +
                           "and (@maHoaDon = '' or maHoaDon = @maHoaDon)";

            if (thoiGian.HasValue)
            {
                switch (tuyChonThoiGian)
                {
                    case "Ngày":
                        query += " and cast(thoiGianTao as date) = @ngay";
                        break;
                    case "Tháng":
                        query += " and month(thoiGianTao) = @thang and year(thoiGianTao) = @nam";
                        break;
                    case "Năm":
                        query += " and year(thoiGianTao) = @nam";
                        break;
                }
            }


            SqlParameter[] parameters =
            [
                new SqlParameter("@tuKhoa", SqlDbType.NVarChar) { Value = "%" + tuKhoa + "%" },
                new SqlParameter("@maHoaDon", SqlDbType.Char) { Value = maHoaDon },
                new SqlParameter("@ngay", SqlDbType.Date) { Value = thoiGian.HasValue ? thoiGian.Value.Date : DBNull.Value },
                new SqlParameter("@thang", SqlDbType.Int) { Value = thoiGian.HasValue ? thoiGian.Value.Month : DBNull.Value },
                new SqlParameter("@nam", SqlDbType.Int) { Value = thoiGian.HasValue ? thoiGian.Value.Year : DBNull.Value }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    HoaDon hoaDon = new()
                    {
                        MaHoaDon = row["maHoaDon"].ToString(),
                        MaNguoiTao = row["maNguoiTao"].ToString(),
                        ThoiGianTao = (DateTime)row["thoiGianTao"],
                        MaKhachHang = row["maKhachHang"]?.ToString(),
                        MaKhuyenMai = row["maKhuyenMai"]?.ToString(),
                        TenKhuyenMai = row["tenKhuyenMai"]?.ToString(),
                        ThanhTien = (decimal)row["thanhTien"],
                        GiamGia = (decimal)row["giamGia"],
                        TongTien = (decimal)row["tongTien"],
                        TienNhan = (decimal)row["tienNhan"],
                        TienThua = (decimal)row["tienThua"],
                    };
                    listHoaDon.Add(hoaDon);
                }
            }

            return listHoaDon;
        }
    }
}
