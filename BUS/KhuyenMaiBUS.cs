using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAO khuyenMaiDAO;

        public KhuyenMaiBUS()
        {
            khuyenMaiDAO = new KhuyenMaiDAO();
        }

        public List<KhuyenMai> LayTatCaKhuyenMai()
        {
            return khuyenMaiDAO.LayTatCaKhuyenMai();
        }

        public List<KhuyenMai> TimKiemKhuyenMai(string tuKhoa, string maKhuyenMai, string loaiGiaTri, string tuyChonThoiGian, DateTime? thoiGian, string trangThai)
        {
            tuKhoa = tuKhoa.Trim().ToLower();
            return khuyenMaiDAO.TimKiemKhuyenMai(tuKhoa, maKhuyenMai, loaiGiaTri, tuyChonThoiGian, thoiGian, trangThai);
        }

        public int DemSoKhuyenMai()
        {
            return khuyenMaiDAO.DemKhuyenMai();
        }

        public string ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            if (string.IsNullOrEmpty(khuyenMai.TenKhuyenMai) || string.IsNullOrEmpty(khuyenMai.LoaiGiaTri))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (string.IsNullOrEmpty(khuyenMai.TenKhuyenMai))
                return "Tên khuyến mãi không được để trống!";

            if (string.IsNullOrEmpty(khuyenMai.LoaiGiaTri))
                return "Loại giá trị không được để trống!";

            if (khuyenMai.ThoiGianBatDau >= khuyenMai.ThoiGianKetThuc)
                return "Thời gian bắt đầu phải diễn ra trước thời gian kết thúc!";

            if (khuyenMai.ThoiGianBatDau <= DateTime.Now)
                return "Thời gian bắt đầu không được diễn ra trước thời điểm hiện tại!";

            if (khuyenMai.GiaTri <= 0)
                return "Giá trị phải lớn hơn 0!";

            if (khuyenMaiDAO.ThemKhuyenMai(khuyenMai))
                return "Thêm khuyến mãi thành công!";
            else
                return "Thêm khuyến mãi thất bại!";
        }

        public string XoaKhuyenMai(string maKhuyenMai)
        {
            if (khuyenMaiDAO.XoaKhuyenMai(maKhuyenMai))
                return "Xóa khuyến mãi thành công!";
            return "Xóa khuyến mãi thất bại!";
        }

        public string SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            if (string.IsNullOrEmpty(khuyenMai.TenKhuyenMai) || string.IsNullOrEmpty(khuyenMai.LoaiGiaTri))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (string.IsNullOrEmpty(khuyenMai.TenKhuyenMai))
                return "Tên khuyến mãi không được để trống!";

            if (string.IsNullOrEmpty(khuyenMai.LoaiGiaTri))
                return "Loại giá trị không được để trống!";

            if (khuyenMai.ThoiGianBatDau >= khuyenMai.ThoiGianKetThuc)
                return "Thời gian bắt đầu phải diễn ra trước thời gian kết thúc!";

            KhuyenMai khuyenMaiBanDau = TimKiemKhuyenMai("", khuyenMai.MaKhuyenMai, "", "", null, "")[0];

            //Nếu khuyến mãi đang diễn ra thì chỉ chỉnh sửa được thời gian kết thúc, kiểm tra thời gian kết thúc > hiện tại
            if ((khuyenMaiBanDau.ThoiGianBatDau < DateTime.Now && khuyenMaiBanDau.ThoiGianKetThuc > DateTime.Now) && khuyenMai.ThoiGianKetThuc <= DateTime.Now)
                return "Thời gian kết thúc không được diễn ra trước thời điểm hiện tại!";

            //Nếu khuyến mãi chưa diễn ra thì chỉnh sửa được thời gian bắt đầu và kết thúc, kiểm tra thời gian bắt đầu > hiện tại
            if ((khuyenMaiBanDau.ThoiGianBatDau > DateTime.Now && khuyenMaiBanDau.ThoiGianKetThuc > DateTime.Now) && khuyenMai.ThoiGianBatDau <= DateTime.Now)
                return "Thời gian bắt đầu không được diễn ra trước thời điểm hiện tại!";

            if (khuyenMai.GiaTri <= 0)
                return "Giá trị phải lớn hơn 0!";

            if (khuyenMaiDAO.SuaKhuyenMai(khuyenMai))
                return "Chỉnh sửa thông tin khuyến mãi thành công!";
            else
                return "Chỉnh sửa thông tin khuyến mãi thất bại!";
        }
    }
}
