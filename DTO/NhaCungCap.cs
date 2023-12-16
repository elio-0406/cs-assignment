using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        public string MaNhaCungCap {  get; set; }
        public string TenNhaCungCap {  set; get; }
        public string? SoDienThoai { set; get; }
        public string? Email {  set; get; }
        public string? DiaChi { set; get; }
        public string TrangThai {  set; get; }

        public NhaCungCap() 
        { 
            MaNhaCungCap = string.Empty;
            TenNhaCungCap = string.Empty;
            TrangThai = "Đang hợp tác";
        }

        public NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string? soDienThoai, string? email, string? diaChi, string trangThai)
        {
            MaNhaCungCap = maNhaCungCap;
            TenNhaCungCap = tenNhaCungCap;
            SoDienThoai = soDienThoai;
            Email = email;
            DiaChi = diaChi;
            TrangThai = trangThai;
        }
    }
}
