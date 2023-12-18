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
    }
}
