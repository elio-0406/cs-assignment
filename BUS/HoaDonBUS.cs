using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO;

        public HoaDonBUS()
        {
            hoaDonDAO = new HoaDonDAO();
        }

        public List<HoaDon> LayTatCaHoaDon()
        {
            return hoaDonDAO.LayTatCaHoaDon();
        }

        public int DemHoaDonTheoNgay(DateTime ngay)
        {
            return hoaDonDAO.DemHoaDonTheoNgay(ngay);
        }

        public string ThemHoaDon(HoaDon hoaDon, List<ChiTietHoaDon> listChiTietHoaDon)
        {
            if (listChiTietHoaDon == null || listChiTietHoaDon.Count <= 0)
                return "Vui lòng chọn sản phẩm cần mua!";

            if (hoaDon.TienNhan <= hoaDon.TongTien)
                return "Khách hàng chưa thanh toán đủ!";

            if (hoaDonDAO.ThemHoaDon(hoaDon, listChiTietHoaDon))
                return "Tạo hóa đơn thành công!";
            else
                return "Tạo hóa đơn thất bại!";
        }

        public List<HoaDon> TimKiemHoaDon(string tuKhoa, string maHoaDon, string tuyChonThoiGian, DateTime? thoiGian)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            return hoaDonDAO.TimKiemHoaDon(tuKhoa, maHoaDon, tuyChonThoiGian, thoiGian);
        }
    }
}
