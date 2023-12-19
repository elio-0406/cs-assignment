using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO sanPhamDAO;

        public SanPhamBUS()
        {
            sanPhamDAO = new SanPhamDAO();
        }

        public List<SanPham> LayTatCaSanPham()
        {
            return sanPhamDAO.LayTatCaSanPham();
        }

        public List<SanPham> TimKiemSanPham(string tuKhoa, string maSanPham, string maLoaiSanPham, string trangThai)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            return sanPhamDAO.TimKiemSanPham(tuKhoa, maSanPham, maLoaiSanPham, trangThai);
        }

        public int DemSanPham()
        {
            return sanPhamDAO.DemSanPham();
        }

        public string ThemSanPham(SanPham sanPham)
        {
            if (string.IsNullOrEmpty(sanPham.MaLoaiSanPham) && string.IsNullOrEmpty(sanPham.TenSanPham) && string.IsNullOrEmpty(sanPham.DonViTinh) && (sanPham.Anh == null || sanPham.Anh.Length <= 0))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (string.IsNullOrEmpty(sanPham.MaLoaiSanPham))
                return "Vui lòng chọn loại sản phẩm!";

            if (string.IsNullOrEmpty(sanPham.TenSanPham))
                return "Tên sản phẩm không được để trống!";

            if (string.IsNullOrEmpty(sanPham.DonViTinh))
                return "Đơn vị tính không được để trống!";

            if (sanPham.Anh == null || sanPham.Anh.Length <= 0)
                return "Vui lòng chọn ảnh sản phẩm!";

            if (sanPham.GiaBan == 0)
                return "Giá bán phải lớn hơn 0 đ!";

            if (sanPhamDAO.ThemSanPham(sanPham))
                return "Thêm sản phẩm thành công!";
            else
                return "Thêm sản phẩm thất bại!";
        }

        public string XoaSanPham(string maSanPham)
        {
            if (sanPhamDAO.XoaSanPham(maSanPham))
                return "Xóa sản phẩm thành công!";

            return "Xóa sản phẩm thất bại!";
        }

        public string SuaSanPham(SanPham sanPham)
        {
            if (string.IsNullOrEmpty(sanPham.MaLoaiSanPham) && string.IsNullOrEmpty(sanPham.TenSanPham) && string.IsNullOrEmpty(sanPham.DonViTinh) && (sanPham.Anh == null || sanPham.Anh.Length <= 0))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (string.IsNullOrEmpty(sanPham.MaLoaiSanPham))
                return "Vui lòng chọn loại sản phẩm!";

            if (string.IsNullOrEmpty(sanPham.TenSanPham))
                return "Tên sản phẩm không được để trống!";

            if (string.IsNullOrEmpty(sanPham.DonViTinh))
                return "Đơn vị tính không được để trống!";

            if (sanPham.Anh == null || sanPham.Anh.Length <= 0)
                return "Vui lòng chọn ảnh sản phẩm!";

            if (sanPham.GiaBan == 0)
                return "Giá bán phải lớn hơn 0 đ!";

            if (sanPhamDAO.SuaSanPham(sanPham))
                return "Chỉnh sửa thông tin sản phẩm thành công!";
            else
                return "Chỉnh sửa thông tin sản phẩm thất bại!";
        }
    }
}
