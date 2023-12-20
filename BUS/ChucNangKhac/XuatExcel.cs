using ClosedXML.Excel;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ChucNangKhac
{
    public class XuatExcel
    {
        string filePath = "";

        public XuatExcel() { }

        public XuatExcel(string filePath)
        {
            this.filePath = filePath;
        }

        public void XuatExcelPhanQuyen(List<PhanQuyen> listPhanQuyen)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("DataSheet");

            worksheet.Cell(1, 1).Value = "Mã phân quyền";
            worksheet.Cell(1, 2).Value = "Tên phân quyền";

            int row = 2;
            foreach (PhanQuyen phanQuyen in listPhanQuyen)
            {
                worksheet.Cell(row, 1).Value = phanQuyen.MaPhanQuyen;
                worksheet.Cell(row, 2).Value = phanQuyen.TenPhanQuyen;
                row++;
            }

            foreach (var item in worksheet.ColumnsUsed())
            {
                item.AdjustToContents();
            }

            workbook.SaveAs(filePath);
        }

        public void XuatExcelNguoiDung(List<NguoiDung> listNguoiDung)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("DataSheet");

            worksheet.Cell(1, 1).Value = "Mã người dùng";
            worksheet.Cell(1, 2).Value = "Mã phân quyền";
            worksheet.Cell(1, 3).Value = "Tên đăng nhập";
            worksheet.Cell(1, 4).Value = "Họ tên";
            worksheet.Cell(1, 5).Value = "Giới tính";
            worksheet.Cell(1, 6).Value = "Ngày sinh";
            worksheet.Cell(1, 7).Value = "Số điện thoại";
            worksheet.Cell(1, 8).Value = "Email";
            worksheet.Cell(1, 9).Value = "Địa chỉ";
            worksheet.Cell(1, 10).Value = "Trạng thái";

            int row = 2;
            foreach (NguoiDung nguoiDung in listNguoiDung)
            {
                worksheet.Cell(row, 1).Value = nguoiDung.MaNguoiDung;
                worksheet.Cell(row, 2).Value = nguoiDung.MaPhanQuyen;
                worksheet.Cell(row, 3).Value = nguoiDung.TenDangNhap;
                worksheet.Cell(row, 4).Value = nguoiDung.HoTen;
                worksheet.Cell(row, 5).Value = nguoiDung.GioiTinh;
                worksheet.Cell(row, 6).Value = nguoiDung.NgaySinh?.ToString("dd/MM/yyyy");
                worksheet.Cell(row, 7).Value = nguoiDung.SoDienThoai;
                worksheet.Cell(row, 8).Value = nguoiDung.Email;
                worksheet.Cell(row, 9).Value = nguoiDung.DiaChi;
                worksheet.Cell(row, 10).Value = nguoiDung.TrangThai;

                row++;
            }

            foreach (var item in worksheet.ColumnsUsed())
            {
                item.AdjustToContents();
            }

            workbook.SaveAs(filePath);
        }

        public void XuatExcelLoaiSanPham(List<LoaiSanPham> listLoaiSanPham)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("DataSheet");

            worksheet.Cell(1, 1).Value = "Mã loại sản phẩm";
            worksheet.Cell(1, 2).Value = "Tên loại sản phẩm";
            worksheet.Cell(1, 3).Value = "Trạng thái";

            int row = 2;
            foreach (LoaiSanPham loaiSanPham in listLoaiSanPham)
            {
                worksheet.Cell(row, 1).Value = loaiSanPham.MaLoaiSanPham;
                worksheet.Cell(row, 2).Value = loaiSanPham.TenLoaiSanPham;
                worksheet.Cell(row, 3).Value = loaiSanPham.TrangThai;

                row++;
            }

            foreach (var item in worksheet.ColumnsUsed())
            {
                item.AdjustToContents();
            }

            workbook.SaveAs(filePath);
        }

        public void XuatExcelSanPham(List<SanPham> listSanPham)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã sản phẩm";
                worksheet.Cell(1, 2).Value = "Loại sản phẩm";
                worksheet.Cell(1, 3).Value = "Tên sản phẩm";
                worksheet.Cell(1, 4).Value = "Đơn vị tính";
                worksheet.Cell(1, 5).Value = "Số lượng";
                worksheet.Cell(1, 6).Value = "Giá bán";
                worksheet.Cell(1, 7).Value = "Trạng thái";

                int row = 2;
                foreach (SanPham sanPham in listSanPham)
                {
                    worksheet.Cell(row, 1).Value = sanPham.MaSanPham;
                    worksheet.Cell(row, 2).Value = new LoaiSanPhamBUS().TimKiemLoaiSanPham("",sanPham.MaLoaiSanPham, "")[0].TenLoaiSanPham;
                    worksheet.Cell(row, 3).Value = sanPham.TenSanPham;
                    worksheet.Cell(row, 4).Value = sanPham.DonViTinh;
                    worksheet.Cell(row, 6).Value = sanPham.GiaBan;
                    worksheet.Cell(row, 5).Value = sanPham.SoLuong;
                    worksheet.Cell(row, 7).Value = sanPham.TrangThai;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelNhaCungCap(List<NhaCungCap> listNhaCungCap)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("DataSheet");

            worksheet.Cell(1, 1).Value = "Mã nhà cung cấp";
            worksheet.Cell(1, 2).Value = "Tên nhà cung cấp";
            worksheet.Cell(1, 3).Value = "Số điện thoại";
            worksheet.Cell(1, 4).Value = "Email";
            worksheet.Cell(1, 5).Value = "Địa chỉ";
            worksheet.Cell(1, 6).Value = "Trạng thái";

            int row = 2;
            foreach (NhaCungCap nhaCungCap in listNhaCungCap)
            {
                worksheet.Cell(row, 1).Value = nhaCungCap.MaNhaCungCap;
                worksheet.Cell(row, 2).Value = nhaCungCap.TenNhaCungCap;
                worksheet.Cell(row, 3).Value = nhaCungCap.SoDienThoai;
                worksheet.Cell(row, 4).Value = nhaCungCap.Email;
                worksheet.Cell(row, 5).Value = nhaCungCap.DiaChi;
                worksheet.Cell(row, 6).Value = nhaCungCap.TrangThai;

                row++;
            }

            foreach (var item in worksheet.ColumnsUsed())
            {
                item.AdjustToContents();
            }

            workbook.SaveAs(filePath);
        }

        public void XuatExcelKhachHang(List<KhachHang> listKhachHang)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã khách hàng";
                worksheet.Cell(1, 2).Value = "Tên khách hàng";
                worksheet.Cell(1, 3).Value = "Số điện thoại";
                worksheet.Cell(1, 4).Value = "Hạng thành viên";
                worksheet.Cell(1, 5).Value = "Điểm thành viên";
                worksheet.Cell(1, 6).Value = "Trạng thái";

                int row = 2;
                foreach (KhachHang khachHang in listKhachHang)
                {
                    worksheet.Cell(row, 1).Value = khachHang.MaKhachHang;
                    worksheet.Cell(row, 2).Value = khachHang.HoTen;
                    worksheet.Cell(row, 3).Value = khachHang.SoDienThoai;
                    worksheet.Cell(row, 4).Value = khachHang.HangThanhVien;
                    worksheet.Cell(row, 5).Value = khachHang.DiemThanhVien;
                    worksheet.Cell(row, 6).Value = khachHang.TrangThai;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelKhuyenMai(List<KhuyenMai> listKhuyenMai)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã khuyến mãi";
                worksheet.Cell(1, 2).Value = "Tên khuyến mãi";
                worksheet.Cell(1, 3).Value = "Loại giá trị";
                worksheet.Cell(1, 4).Value = "Giá trị";
                worksheet.Cell(1, 5).Value = "Thời gian bắt đầu";
                worksheet.Cell(1, 6).Value = "Thời gian kết thúc";

                int row = 2;
                foreach (KhuyenMai khuyenMai in listKhuyenMai)
                {
                    worksheet.Cell(row, 1).Value = khuyenMai.MaKhuyenMai;
                    worksheet.Cell(row, 2).Value = khuyenMai.TenKhuyenMai;
                    worksheet.Cell(row, 3).Value = khuyenMai.LoaiGiaTri;
                    worksheet.Cell(row, 4).Value = khuyenMai.GiaTri;
                    worksheet.Cell(row, 5).Value = khuyenMai.ThoiGianBatDau.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(row, 6).Value = khuyenMai.ThoiGianKetThuc.ToString("dd/MM/yyyy HH:mm:ss");

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public void XuatExcelPhieuNhap(List<PhieuNhap> listPhieuNhap)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DataSheet");

                worksheet.Cell(1, 1).Value = "Mã phiếu nhập";
                worksheet.Cell(1, 2).Value = "Mã nhà cung cấp";
                worksheet.Cell(1, 3).Value = "Mã người tạo";
                worksheet.Cell(1, 4).Value = "Mã người duyệt";
                worksheet.Cell(1, 5).Value = "Mã người nhập";
                worksheet.Cell(1, 6).Value = "Thời gian tạo";
                worksheet.Cell(1, 7).Value = "Thời gian duyệt";
                worksheet.Cell(1, 8).Value = "Thời gian nhập";
                worksheet.Cell(1, 9).Value = "Thành tiền";
                worksheet.Cell(1, 10).Value = "Trạng thái";

                int row = 2;
                foreach (PhieuNhap phieuNhap in listPhieuNhap)
                {
                    worksheet.Cell(row, 1).Value = phieuNhap.MaPhieuNhap;
                    worksheet.Cell(row, 2).Value = phieuNhap.MaNhaCungCap;
                    worksheet.Cell(row, 3).Value = phieuNhap.MaNguoiTao;
                    worksheet.Cell(row, 4).Value = phieuNhap.MaNguoiDuyet;
                    worksheet.Cell(row, 5).Value = phieuNhap.MaNguoiNhap;
                    worksheet.Cell(row, 6).Value = phieuNhap.ThoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(row, 7).Value = phieuNhap.ThoiGianDuyet?.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(row, 8).Value = phieuNhap.ThoiGianNhap?.ToString("dd/MM/yyyy HH:mm:ss");
                    worksheet.Cell(row, 9).Value = phieuNhap.TongTien;
                    worksheet.Cell(row, 10).Value = phieuNhap.TrangThai;

                    row++;
                }

                foreach (var item in worksheet.ColumnsUsed())
                {
                    item.AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }
    }
}
