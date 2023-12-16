using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public string MaHoaDon {  get; set; }
        public string MaNguoiTao { get; set; }
        public string? MaKhachHang { get; set; }
        public string? MaKhuyenMai {  get; set; }
        public string? TenKhuyenMai { get; set; }
        public DateTime ThoiGianTao {  get; set; }
        public decimal ThanhTien {  get; set; }
        public decimal GiamGia { get; set; }
        public decimal TongTien {  get; set; }
        public decimal TienNhan { get; set; }
        public decimal TienThua { get; set; }

        public HoaDon() 
        { 
            MaHoaDon = string.Empty;
            MaNguoiTao = string.Empty;
        }

        public HoaDon(string maHoaDon, string maNguoiTao, string? maKhachHang, string? maKhuyenMai, string? tenKhuyenMai, DateTime thoiGianTao, decimal thanhTien, decimal giamGia, decimal tongTien, decimal tienNhan, decimal tienThua)
        {
            MaHoaDon = maHoaDon;
            MaNguoiTao = maNguoiTao;
            MaKhachHang = maKhachHang;
            MaKhuyenMai = maKhuyenMai;
            TenKhuyenMai = tenKhuyenMai;
            ThoiGianTao = thoiGianTao;
            ThanhTien = thanhTien;
            GiamGia = giamGia;
            TongTien = tongTien;
            TienNhan = tienNhan;
            TienThua = tienThua;
        }
    }
}
