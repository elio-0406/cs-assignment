using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiSanPhamBUS
    {
        LoaiSanPhamDAO loaiSanPhamDAO;

        public LoaiSanPhamBUS() 
        { 
            loaiSanPhamDAO = new LoaiSanPhamDAO();
        }

        public List<LoaiSanPham> LayTatCaLoaiSanPham()
        {
            return loaiSanPhamDAO.LayTatCaLoaiSanPham();
        }

        public List<LoaiSanPham> TimKiemLoaiSanPham(string tuKhoa, string maLoaiSanPham, string trangThai)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            return loaiSanPhamDAO.TimKiemLoaiSanPham(tuKhoa, maLoaiSanPham, trangThai);
        }

        public int DemLoaiSanPham()
        {
            return loaiSanPhamDAO.DemLoaiSanPham();
        }

        public string ThemLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            if (string.IsNullOrEmpty(loaiSanPham.TenLoaiSanPham))
                return "Tên loại sản phẩm không được để trống!";

            if (loaiSanPhamDAO.ThemLoaiSanPham(loaiSanPham))
                return "Thêm loại sản phẩm thành công!";
            else
                return "Thêm loại sản phẩm thất bại!";
        }

        public string XoaLoaiSanPham(string maLoaiSanPham)
        {
            if (loaiSanPhamDAO.XoaLoaiSanPham(maLoaiSanPham))
                return "Xóa loại sản phẩm thành công!";

            return "Xóa loại sản phẩm thất bại!";
        }

        public string SuaLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            if (string.IsNullOrEmpty(loaiSanPham.TenLoaiSanPham))
                return "Tên loại sản phẩm không được để trống!";

            if (loaiSanPhamDAO.SuaLoaiSanPham(loaiSanPham))
                return "Chỉnh sửa thông tin loại sản phẩm thành công!";
            else
                return "Chỉnh sửa thông tin loại sản phẩm thất bại!";
        }
    }
}
