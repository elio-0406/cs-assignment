using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO chiTietHoaDonDAO;
        public ChiTietHoaDonBUS()
        {
            chiTietHoaDonDAO = new();
        }

        public List<ChiTietHoaDon> LayChiTietHoaDonTheoHoaDon(string maHoaDon)
        {
            return chiTietHoaDonDAO.LayChiTietHoaDonTheoHoaDon(maHoaDon);
        }

        public ChiTietHoaDon LayChiTietHoaDon(string maHoaDon, string maSanPham)
        {
            return chiTietHoaDonDAO.LayChiTietHoaDon(maHoaDon, maSanPham);
        }
    }
}
