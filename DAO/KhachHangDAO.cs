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
    public class KhachHangDAO
    {
        public KhachHangDAO() { }

        public List<KhachHang> LayTatCaKhachHang()
        {
            List<KhachHang> listKhachHang = [];

            string query = "select * from KhachHang";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    KhachHang khachHang = new()
                    {
                        MaKhachHang = row["maKhachHang"].ToString(),
                        HoTen = row["hoTen"].ToString(),
                        SoDienThoai = row["soDienThoai"].ToString(),
                        HangThanhVien = row["hangThanhVien"].ToString(),
                        DiemThanhVien = (int)row["diemThanhVien"],
                        TrangThai = row["trangThai"].ToString()
                    };
                    listKhachHang.Add(khachHang);
                }
            }

            return listKhachHang;
        }

        public List<KhachHang> TimKiemKhachHang(string tuKhoa, string maKhachHang, string soDienThoai, string hangThanhVien, string trangThai)
        {
            List<KhachHang> listKhachHang = [];

            string query = "select * from KhachHang " +
                           "where (@tuKhoa = '' or lower(maKhachHang) like @tuKhoa " +
                           "or hoTen collate Latin1_General_CI_AI like @tuKhoa) " +
                           "and (@maKhachHang = '' or maKhachHang = @maKhachHang) " +
                           "and (@soDienThoai = '' or soDienThoai = @soDienThoai) " +
                           "and (@hangThanhVien = '' or hangThanhVien = @hangThanhVien) " +
                           "and (@trangThai = '' or trangThai = @trangThai)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@tuKhoa", SqlDbType.NVarChar) { Value = "%" + tuKhoa + "%" },
                new SqlParameter("@maKhachHang", SqlDbType.Char) { Value = maKhachHang },
                new SqlParameter("@soDienThoai", SqlDbType.VarChar) { Value = soDienThoai },
                new SqlParameter("@hangThanhVien", SqlDbType.NVarChar) { Value = hangThanhVien },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = trangThai }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    KhachHang khachHang = new()
                    {
                        MaKhachHang = row["maKhachHang"].ToString(),
                        HoTen = row["hoTen"].ToString(),
                        SoDienThoai = row["soDienThoai"].ToString(),
                        HangThanhVien = row["hangThanhVien"].ToString(),
                        DiemThanhVien = (int)row["diemThanhVien"],
                        TrangThai = row["trangThai"].ToString()
                    };
                    listKhachHang.Add(khachHang);
                }
            }

            return listKhachHang;
        }

        public int DemKhachHang()
        {
            int soKhachHang = 0;

            string query = "select count(*) as soKhachHang from KhachHang";

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
                soKhachHang = (int)dataTable.Rows[0]["soKhachHang"];
            return soKhachHang;
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            string query = "insert into KhachHang values (@maKhachHang, @hoTen, @soDienThoai, @hangThanhVien, @diemThanhVien, @trangThai)";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maKhachHang", SqlDbType.Char) { Value = khachHang.MaKhachHang },
                new SqlParameter("@hoTen", SqlDbType.NVarChar) { Value = khachHang.HoTen },
                new SqlParameter("@soDienThoai", SqlDbType.VarChar) { Value = khachHang.SoDienThoai },
                new SqlParameter("@hangThanhVien", SqlDbType.NVarChar) { Value = khachHang.HangThanhVien },
                new SqlParameter("@diemThanhVien", SqlDbType.Int) { Value = khachHang.DiemThanhVien },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = khachHang.TrangThai }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool XoaKhachHang(string maKhachHang)
        {
            string query = "update KhachHang set trangThai = N'Ngừng hoạt động', hangThanhVien = N'Đồng', diemThanhVien = 0 where maKhachHang = @maKhachHang";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maKhachHang", SqlDbType.Char) { Value = maKhachHang }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool SuaKhachHang(KhachHang khachHang)
        {
            string query = "update KhachHang set hoTen = @hoTen, soDienThoai = @soDienThoai, trangThai = @trangThai where maKhachHang = @maKhachHang";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maKhachHang", SqlDbType.Char) { Value = khachHang.MaKhachHang },
                new SqlParameter("@hoTen", SqlDbType.NVarChar) { Value = khachHang.HoTen },
                new SqlParameter("@soDienThoai", SqlDbType.VarChar) { Value = khachHang.SoDienThoai },
                new SqlParameter("@trangThai", SqlDbType.NVarChar) { Value = khachHang.TrangThai }
            ];

            int rowsAffected = XuLyDatabase.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool KiemTraSoDienThoaiTonTai(string soDienThoai)
        {
            bool tonTai = false;

            string query = "select * from KhachHang where soDienThoai = @soDienThoai";

            SqlParameter[] parameters =
            [
                new SqlParameter("@soDienThoai", SqlDbType.VarChar) { Value = soDienThoai }
            ];

            DataTable dataTable = XuLyDatabase.ExecuteQuery(query, parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
                tonTai = true;
            return tonTai;
        }

        public decimal TichDiem(KhachHang khachHang, decimal thanhTien)
        {
            int diemTichLuy = 0;

            switch (khachHang.HangThanhVien)
            {
                case "Đồng":
                    diemTichLuy = (int)(thanhTien * 0.5m / 100);
                    khachHang.DiemThanhVien += diemTichLuy;

                    if (khachHang.DiemThanhVien >= 5000 && khachHang.DiemThanhVien < 10000)
                        khachHang.HangThanhVien = "Bạc";
                    else if (khachHang.DiemThanhVien >= 10000)
                        khachHang.HangThanhVien = "Vàng";

                    break;

                case "Bạc":
                    diemTichLuy = (int)(thanhTien * 0.25m / 100);
                    khachHang.DiemThanhVien += diemTichLuy;

                    if (khachHang.DiemThanhVien >= 10000)
                        khachHang.HangThanhVien = "Vàng";

                    break;
            }

            string query = "update KhachHang set hangThanhVien = @hangThanhVien,  " +
                           "diemThanhVien = case when diemThanhVien > 10000 then 10000 else @diemThanhVien end " +
                           "where maKhachHang = @maKhachHang";

            SqlParameter[] parameters =
            [
                new SqlParameter("@maKhachHang", SqlDbType.Char) { Value = khachHang.MaKhachHang },
                new SqlParameter("@hangThanhVien", SqlDbType.NVarChar) { Value = khachHang.HangThanhVien },
                new SqlParameter("@diemThanhVien", SqlDbType.Int) { Value = khachHang.DiemThanhVien },
            ];

            XuLyDatabase.ExecuteNonQuery(query, parameters);

            return diemTichLuy;
        }
    }
}
