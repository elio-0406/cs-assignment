using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        public string MaPhieuNhap {  get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public ChiTietPhieuNhap() 
        { 
            MaPhieuNhap = string.Empty;
            MaSanPham = string.Empty;
        }

        public ChiTietPhieuNhap(string maPhieuNhap, string maSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            MaPhieuNhap = maPhieuNhap;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
    }
}
