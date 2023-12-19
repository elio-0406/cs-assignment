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
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nhaCungCapDAO;

        public NhaCungCapBUS()
        {
            nhaCungCapDAO = new NhaCungCapDAO();
        }

        public List<NhaCungCap> LayTatCaNhaCungCap()
        {
            return nhaCungCapDAO.LayTatCaNhaCungCap();
        }

        public List<NhaCungCap> TimKiemNhaCungCap(string tuKhoa, string maNhaCungCap, string trangThai)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            return nhaCungCapDAO.TimKiemNhaCungCap(tuKhoa, maNhaCungCap, trangThai);
        }

        public int DemNhaCungCap()
        {
            return nhaCungCapDAO.DemNhaCungCap();
        }

        public string ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (string.IsNullOrEmpty(nhaCungCap.TenNhaCungCap))
                return "Tên nhà cung cấp không được để trống!";

            if (!string.IsNullOrEmpty(nhaCungCap.SoDienThoai) && !KiemTraDinhDang.KiemTraSoDienThoai(nhaCungCap.SoDienThoai))
                return "Vui lòng nhập số điện thoại đúng định dạng!";

            if (!string.IsNullOrEmpty(nhaCungCap.Email) && !KiemTraDinhDang.KiemTraEmail(nhaCungCap.Email))
                return "Vui lòng nhập email đúng định dạng!";

            if (nhaCungCapDAO.ThemNhaCungCap(nhaCungCap))
                return "Thêm nhà cung cấp thành công!";
            else
                return "Thêm nhà cung cấp thất bại!";
        }

        public string XoaNhaCungCap(string maNhaCungCap)
        {
            if (nhaCungCapDAO.XoaNhaCungCap(maNhaCungCap))
                return "Xóa nhà cung cấp thành công!";
            else
                return "Xóa nhà cung cấp thất bại!";
        }

        public string SuaNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (string.IsNullOrEmpty(nhaCungCap.TenNhaCungCap))
                return "Tên nhà cung cấp không được để trống!";

            if (!string.IsNullOrEmpty(nhaCungCap.SoDienThoai) && !KiemTraDinhDang.KiemTraSoDienThoai(nhaCungCap.SoDienThoai))
                return "Vui lòng nhập số điện thoại đúng định dạng!";

            if (!string.IsNullOrEmpty(nhaCungCap.Email) && !KiemTraDinhDang.KiemTraEmail(nhaCungCap.Email))
                return "Vui lòng nhập email đúng định dạng!";

            if (nhaCungCapDAO.SuaNhaCungCap(nhaCungCap))
                return "Chỉnh sửa thông tin nhà cung cấp thành công!";
            else
                return "Chỉnh sửa thông tin nhà cung cấp thất bại!";
        }
    }
}
