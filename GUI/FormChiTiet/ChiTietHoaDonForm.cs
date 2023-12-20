using BUS;
using DTO;
using GUI.FormChinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormChiTiet
{
    public partial class ChiTietHoaDonForm : Form
    {
        ChiTietHoaDonBUS chiTietHoaDonBUS;
        HoaDonBUS hoaDonBUS;
        HoaDon hoaDon;
        List<ChiTietHoaDon> listChiTietHoaDon;

        public ChiTietHoaDonForm(string maHoaDon)
        {
            InitializeComponent();

            hoaDonBUS = new();
            chiTietHoaDonBUS = new();
            hoaDon = hoaDonBUS.TimKiemHoaDon("", maHoaDon, "", null)[0];
            listChiTietHoaDon = chiTietHoaDonBUS.LayChiTietHoaDonTheoHoaDon(maHoaDon);
        }

        private void ChiTietHoaDonForm_Load(object sender, EventArgs e)
        {
            maHoaDonTextBox.Text = hoaDon.MaHoaDon;
            maNhanVienTextBox.Text = hoaDon.MaNguoiTao;
            maKhachHangTextBox.Text = hoaDon.MaKhachHang;
            maKhuyenMaiTextBox.Text = hoaDon.MaKhuyenMai;
            tenKhuyenMaiTextBox.Text = hoaDon.TenKhuyenMai;
            thoiGianTaoTextBox.Text = hoaDon.ThoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
            thanhTienTextBox.Text = hoaDon.ThanhTien.ToString("0") + " đ";
            giamGiaTextBox.Text = hoaDon.GiamGia.ToString("0") + " đ";
            tongTienTextBox.Text = hoaDon.TongTien.ToString("0") + " đ";
            tienNhanTextBox.Text = hoaDon.TienNhan.ToString("0") + " đ";
            tienThuaTextBox.Text = hoaDon.TienThua.ToString("0") + " đ";

            maHoaDonTextBox.ReadOnly = true;
            maNhanVienTextBox.ReadOnly = true;
            maKhachHangTextBox.ReadOnly = true;
            maKhuyenMaiTextBox.ReadOnly = true;
            tenKhuyenMaiTextBox.ReadOnly = true;
            thoiGianTaoTextBox.ReadOnly = true;
            thanhTienTextBox.ReadOnly = true;
            giamGiaTextBox.ReadOnly = true;
            tongTienTextBox.ReadOnly = true;
            tienNhanTextBox.ReadOnly = true;
            tienThuaTextBox.ReadOnly = true;

            LoadDataToDataGridView(listChiTietHoaDon);
        }

        private void LoadDataToDataGridView(List<ChiTietHoaDon> listChiTietHoaDon)
        {
            chiTietHoaDonDataGridView.Rows.Clear();

            for (int i = 0; i < listChiTietHoaDon.Count; i++)
            {
                chiTietHoaDonDataGridView.Rows.Add(1);
                chiTietHoaDonDataGridView.Rows[i].Cells[0].Value = listChiTietHoaDon[i].MaSanPham;
                chiTietHoaDonDataGridView.Rows[i].Cells[1].Value = listChiTietHoaDon[i].DonGia.ToString("0") + " đ";
                chiTietHoaDonDataGridView.Rows[i].Cells[2].Value = listChiTietHoaDon[i].SoLuong;
                chiTietHoaDonDataGridView.Rows[i].Cells[3].Value = listChiTietHoaDon[i].ThanhTien.ToString("0") + " đ";
            }
        }
    }
}
