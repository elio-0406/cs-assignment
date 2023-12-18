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

            if (!KiemTraMatKhauChinhXac(tenDangNhap, matKhau))
                return "Thông tin đăng nhập không chính xác!";

            if (!KiemTraDangHoatDong(tenDangNhap))
                return "Người dùng đã ngừng hoạt động!";

            return "Đăng nhập thành công!";
        }
    }
}
