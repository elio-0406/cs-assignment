using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ChucNangKhac
{
    public class TaoMaTuDong
    {
        public TaoMaTuDong() { }

        public static string TaoMaNguoiDung(string maPhanQuyen)
        {
            int soNguoiDung = new NguoiDungBUS().DemNguoiDungTheoPhanQuyen(maPhanQuyen);

            string maNguoiDung = "";

            switch (maPhanQuyen)
            {
                case "PQ01":
                    maNguoiDung = string.Format("ADM{0:D4}", ++soNguoiDung);
                    break;
                case "PQ02":
                    maNguoiDung = string.Format("QLY{0:D4}", ++soNguoiDung);
                    break;
                case "PQ03":
                    maNguoiDung = string.Format("NBH{0:D4}", ++soNguoiDung);
                    break;
                case "PQ04":
                    maNguoiDung = string.Format("NVK{0:D4}", ++soNguoiDung);
                    break;
            }

            return maNguoiDung;
        }

        public static string TaoMaLoaiSanPham()
        {
            int soLoaiSanPham = new LoaiSanPhamBUS().DemLoaiSanPham();
            string maLoaiSanPham = string.Format("LSP{0:D4}", ++soLoaiSanPham);
            return maLoaiSanPham;
        }

        public static string TaoMaSanPham()
        {
            int soSanPham = new SanPhamBUS().DemSanPham();
            string maSanPham = string.Format("SPH{0:D4}", ++soSanPham);
            return maSanPham;
        }

        public static string TaoMaNhaCungCap()
        {
            int soNhaCungCap = new NhaCungCapBUS().DemNhaCungCap();

            string maNhaCungCap = string.Format("NCC{0:D4}", ++soNhaCungCap);

            return maNhaCungCap;
        }

        public static string TaoMaKhachHang()
        {
            int soKhachHang = new KhachHangBUS().DemKhachHang();

            string maKhachHang = string.Format("KHH{0:D4}", ++soKhachHang);

            return maKhachHang;
        }

        public static string TaoMaKhuyenMai()
        {
            int soKhuyenMai = new KhuyenMaiBUS().DemSoKhuyenMai();
            string maKhuyenMai = string.Format("KHM{0:D4}", ++soKhuyenMai);
            return maKhuyenMai;
        }

        public static string TaoMaPhieuNhap()
        {
            int soPhieuNhap = new PhieuNhapBUS().DemPhieuNhapTheoNgay(DateTime.Now);
            string maPhieuNhap = string.Format("{0}-PN{1:D2}", DateTime.Now.ToString("dd/MM/yyyy"), ++soPhieuNhap);
            return maPhieuNhap;
        }
    }
}
