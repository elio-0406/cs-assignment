using BUS.ChucNangKhac;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguoiDungBUS
    {
        NguoiDungDAO nguoiDungDAO;

        public NguoiDungBUS()
        {
            nguoiDungDAO = new();
        }

        public List<NguoiDung> LayTatCaNguoiDung()
        {
            return nguoiDungDAO.LayTatCaNguoiDung();
        }

        public List<NguoiDung> TimKiemNguoiDung(string tuKhoa, string maNguoiDung, string maPhanQuyen, string tenDangNhap, string gioiTinh, string trangThai)
        {
            return nguoiDungDAO.TimKiemNguoiDung(tuKhoa, maNguoiDung, maPhanQuyen, tenDangNhap, gioiTinh, trangThai);
        }

        public int DemNguoiDungTheoPhanQuyen(string maPhanQuyen)
        {
            return nguoiDungDAO.DemNguoiDungTheoPhanQuyen(maPhanQuyen);
        }

        public bool KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            return nguoiDungDAO.KiemTraTenDangNhapTonTai(tenDangNhap);
        }

        public bool KiemTraDangHoatDong(string tenDangNhap)
        {
            return nguoiDungDAO.KiemTraDangHoatDong(tenDangNhap);
        }

        public bool KiemTraMatKhauChinhXac(string tenDangNhap, string matKhau)
        {
            return nguoiDungDAO.KiemTraMatKhauChinhXac(tenDangNhap, matKhau);
        }

        public string DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (string.IsNullOrEmpty(tenDangNhap))
                return "Tên đăng nhập không được để trống!";

            if (string.IsNullOrEmpty(matKhau))
                return "Mật khẩu không được để trống!";

            if (!KiemTraMatKhauChinhXac(tenDangNhap, matKhau))
                return "Thông tin đăng nhập không chính xác!";

            if (!KiemTraDangHoatDong(tenDangNhap))
                return "Người dùng đã ngừng hoạt động!";

            return "Đăng nhập thành công!";
        }

        public string ThemNguoiDung(NguoiDung nguoiDung)
        {
            if (string.IsNullOrEmpty(nguoiDung.MaPhanQuyen) && string.IsNullOrEmpty(nguoiDung.TenDangNhap) && string.IsNullOrEmpty(nguoiDung.MatKhau) && string.IsNullOrEmpty(nguoiDung.HoTen))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (string.IsNullOrEmpty(nguoiDung.MaPhanQuyen))
                return "Vui lòng chọn phân quyền!";

            if (string.IsNullOrEmpty(nguoiDung.TenDangNhap))
                return "Tên đăng nhập không được để trống!";

            if (string.IsNullOrEmpty(nguoiDung.MatKhau))
                return "Mật khẩu không được để trống!";

            if (string.IsNullOrEmpty(nguoiDung.HoTen))
                return "Họ tên không được để trống!";

            if (KiemTraTenDangNhapTonTai(nguoiDung.TenDangNhap))
                return "Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!";

            if (!string.IsNullOrEmpty(nguoiDung.SoDienThoai) && !KiemTraDinhDang.KiemTraSoDienThoai(nguoiDung.SoDienThoai))
                return "Vui lòng nhập đúng định dạng số điện thoại!";

            if (!string.IsNullOrEmpty(nguoiDung.Email) && !KiemTraDinhDang.KiemTraEmail(nguoiDung.Email))
                return "Vui lòng nhập đúng định dạng email!";

            if (nguoiDung.NgaySinh.HasValue)
                nguoiDung.NgaySinh = DateTime.ParseExact(nguoiDung.NgaySinh?.ToString("yyyy/MM/dd"), "yyyy/MM/dd", null);

            if (nguoiDungDAO.ThemNguoiDung(nguoiDung))
                return "Thêm người dùng thành công!";
            else
                return "Thêm người dùng thất bại!";
        }

        public string SuaNguoiDung(NguoiDung nguoiDung)
        {
            if (string.IsNullOrEmpty(nguoiDung.TenDangNhap) && string.IsNullOrEmpty(nguoiDung.MatKhau) && string.IsNullOrEmpty(nguoiDung.HoTen))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (string.IsNullOrEmpty(nguoiDung.TenDangNhap))
                return "Tên đăng nhập không được để trống!";

            if (string.IsNullOrEmpty(nguoiDung.MatKhau))
                return "Mật khẩu không được để trống!";

            if (string.IsNullOrEmpty(nguoiDung.HoTen))
                return "Họ tên không được để trống!";

            if (KiemTraTenDangNhapTonTai(nguoiDung.TenDangNhap) && !TimKiemNguoiDung("", nguoiDung.MaNguoiDung, "", "", "", "")[0].TenDangNhap.Equals(nguoiDung.TenDangNhap))
                return "Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!";

            if (!string.IsNullOrEmpty(nguoiDung.SoDienThoai) && !KiemTraDinhDang.KiemTraSoDienThoai(nguoiDung.SoDienThoai))
                return "Vui lòng nhập đúng định dạng số điện thoại!";

            if (!string.IsNullOrEmpty(nguoiDung.Email) && !KiemTraDinhDang.KiemTraEmail(nguoiDung.Email))
                return "Vui lòng nhập đúng định dạng email!";

            if (nguoiDung.NgaySinh.HasValue)
                nguoiDung.NgaySinh = DateTime.ParseExact(nguoiDung.NgaySinh?.ToString("yyyy/MM/dd"), "yyyy/MM/dd", null);

            if (nguoiDungDAO.SuaNguoiDung(nguoiDung))
                return "Chỉnh sửa thông tin người dùng thành công!";
            else
                return "Chỉnh sửa thông tin người dùng thất bại!";
        }

        public string XoaNguoiDung(string maNguoiDung = "")
        {
            if (DemNguoiDungTheoPhanQuyen("PQ01") == 1 && TimKiemNguoiDung("", maNguoiDung, "", "", "", "")[0].MaPhanQuyen.Equals("PQ01"))
                return "Admin duy nhất, không thể xóa!";

            if (nguoiDungDAO.XoaNguoiDung(maNguoiDung))
                return "Xóa người dùng thành công!";
            else
                return "Xóa người dùng thất bại!";
        }
    }
}
