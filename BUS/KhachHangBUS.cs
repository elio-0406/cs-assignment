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
    public class KhachHangBUS
    {
        KhachHangDAO khachHangDAO;

        public KhachHangBUS()
        {
            khachHangDAO = new();
        }

        public List<KhachHang> LayTatCaKhachHang()
        {
            return khachHangDAO.LayTatCaKhachHang();
        }

        public List<KhachHang> TimKiemKhachHang(string tuKhoa, string maKhachHang, string soDienThoai, string hangThanhVien, string trangThai)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            return khachHangDAO.TimKiemKhachHang(tuKhoa, maKhachHang, soDienThoai, hangThanhVien, trangThai);
        }

        public int DemKhachHang()
        {
            return khachHangDAO.DemKhachHang();
        }

        public bool KiemTraSoDienThoaiTonTai(string soDienThoai)
        {
            return khachHangDAO.KiemTraSoDienThoaiTonTai(soDienThoai);
        }

        public string ThemKhachHang(KhachHang khachHang)
        {
            if (string.IsNullOrEmpty(khachHang.HoTen) && string.IsNullOrEmpty(khachHang.SoDienThoai))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (string.IsNullOrEmpty(khachHang.HoTen))
                return "Họ tên không được để trống!";

            if (string.IsNullOrEmpty(khachHang.SoDienThoai))
                return "Số điện thoại không được để trống!";

            if (!KiemTraDinhDang.KiemTraSoDienThoai(khachHang.SoDienThoai))
                return "Vui lòng nhập đúng định dạng số điện thoại!";

            if (KiemTraSoDienThoaiTonTai(khachHang.SoDienThoai))
                return "Số điện thoại đã có người sử dụng, vui lòng đổi số khác!";

            if (khachHangDAO.ThemKhachHang(khachHang))
                return "Thêm khách hàng thành công!";
            else
                return "Thêm khách hàng thất bại!";
        }

        public string SuaKhachHang(KhachHang khachHang)
        {
            if (string.IsNullOrEmpty(khachHang.HoTen) && string.IsNullOrEmpty(khachHang.SoDienThoai))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (string.IsNullOrEmpty(khachHang.HoTen))
                return "Họ tên không được để trống!";

            if (string.IsNullOrEmpty(khachHang.SoDienThoai))
                return "Số điện thoại không được để trống!";

            if (!KiemTraDinhDang.KiemTraSoDienThoai(khachHang.SoDienThoai))
                return "Vui lòng nhập đúng định dạng số điện thoại!";

            if (KiemTraSoDienThoaiTonTai(khachHang.SoDienThoai) && !khachHang.SoDienThoai.Equals(TimKiemKhachHang("", khachHang.MaKhachHang, "", "", "")[0].SoDienThoai))
                return "Số điện thoại đã có người sử dụng, vui lòng đổi số khác!";

            if (khachHangDAO.SuaKhachHang(khachHang))
                return "Chỉnh sửa thông tin khách hàng thành công!";
            else
                return "Chỉnh sửa thông tin khách hàng thất bại!";
        }

        public string XoaKhachHang(string maKhachHang)
        {
            if (khachHangDAO.XoaKhachHang(maKhachHang))
                return "Xóa khách hàng thành công!";
            else
                return "Xóa khách hàng thất bại!";
        }
    }
}
