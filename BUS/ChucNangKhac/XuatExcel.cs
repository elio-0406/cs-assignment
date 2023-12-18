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
    }
}
