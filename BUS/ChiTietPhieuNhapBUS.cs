using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAO chiTietPhieuNhapDAO;
        public ChiTietPhieuNhapBUS()
        {
            chiTietPhieuNhapDAO = new();
        }

        public List<ChiTietPhieuNhap> LayChiTietPhieuNhapTheoPhieuNhap(string maPhieuNhap)
        {
            return chiTietPhieuNhapDAO.LayChiTietPhieuNhapTheoPhieuNhap(maPhieuNhap);
        }

        public ChiTietPhieuNhap LayChiTietPhieuNhap(string maPhieuNhap, string maSanPham)
        {
            return chiTietPhieuNhapDAO.LayChiTietPhieuNhap(maPhieuNhap, maSanPham);
        }

        public string SuaChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            if (chiTietPhieuNhap.SoLuong == 0)
                return "Số lượng phải lớn hơn 0!";

            if (chiTietPhieuNhap.DonGia == 0)
                return "Giá nhập phải lớn hơn 0 đ!";

            if (chiTietPhieuNhapDAO.SuaChiTietPhieuNhap(chiTietPhieuNhap))
                return "Chỉnh sửa chi tiết phiếu nhập thành công!";
            else
                return "Chỉnh sửa chi tiết phiếu nhập thất bại!";
        }
    }
}
