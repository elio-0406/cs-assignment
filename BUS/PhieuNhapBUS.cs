using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapBUS
    {
        PhieuNhapDAO PhieuNhapDAO { get; set; }

        public PhieuNhapBUS()
        {
            PhieuNhapDAO = new PhieuNhapDAO();
        }

        public List<PhieuNhap> LayTatCaPhieuNhap()
        {
            return PhieuNhapDAO.LayTatCaPhieuNhap();
        }

        public int DemPhieuNhapTheoNgay(DateTime dateTime)
        {
            return PhieuNhapDAO.DemPhieuNhapTheoNgay(dateTime);
        }

        public List<PhieuNhap> TimKiemPhieuNhap(string tuKhoa, string maPhieuNhap, string trangThai)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            return PhieuNhapDAO.TimKiemPhieuNhap(tuKhoa, maPhieuNhap, trangThai);
        }

        public string ThemPhieuNhap(PhieuNhap phieuNhap, List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            if (string.IsNullOrEmpty(phieuNhap.MaNhaCungCap))
                return "Vui lòng chọn nhà cung cấp!";

            if (listChiTietPhieuNhap == null || listChiTietPhieuNhap.Count <= 0)
                return "Vui lòng chọn sản phẩm cần nhập!";

            foreach (ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                if (chiTietPhieuNhap.DonGia == 0)
                    return "Có sản phẩm giá nhập nhỏ hơn 0 đ, vui lòng kiểm tra lại!";
            }

            if (PhieuNhapDAO.ThemPhieuNhap(phieuNhap, listChiTietPhieuNhap))
                return "Thêm phiếu nhập thành công!";
            else
                return "Thêm phiếu nhập thất bại!";
        }

        public bool SuaPhieuNhap(PhieuNhap phieuNhap)
        {
            return PhieuNhapDAO.SuaPhieuNhap(phieuNhap);
        }

        public string DuyetPhieuNhap(PhieuNhap phieuNhap, string trangThai)
        {
            if (trangThai.Equals("Đã duyệt"))
            {
                if (SuaPhieuNhap(phieuNhap) && trangThai.Equals("Đã duyệt"))
                    return "Duyệt phiếu nhập thành công!";
                else
                    return "Duyệt phiếu nhập thất bại!";
            }

            else
            {
                if (SuaPhieuNhap(phieuNhap) && trangThai.Equals("Không duyệt"))
                    return "Không duyệt phiếu nhập thành công!";
                else
                    return "Không duyệt phiếu nhập thất bại!";
            }
        }

        public string NhapHang(PhieuNhap phieuNhap)
        {
            if (PhieuNhapDAO.NhapHang(phieuNhap))
                return "Nhập hàng thành công!";
            return "Nhập hàng thất bại!";
        }
    }
}
