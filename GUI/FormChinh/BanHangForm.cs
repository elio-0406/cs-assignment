using BUS;
using BUS.ChucNangKhac;
using DTO;
using GUI.FormChon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormChinh
{
    public partial class BanHangForm : Form
    {
        SanPhamBUS sanPhamBUS;
        List<SanPham> listSanPham;
        internal List<SanPham> listSanPhamDonHang;
        internal KhachHang khachHang;
        internal KhuyenMai khuyenMai;

        public BanHangForm()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.TimKiemSanPham("", "", "", "Đang bán");
            listSanPhamDonHang = new List<SanPham>();
            loaiSanPhamComboBox.DataSource = new LoaiSanPhamBUS().TimKiemLoaiSanPham("", "", "Đang sử dụng");
            loaiSanPhamComboBox.DisplayMember = "TenLoaiSanPham";
            loaiSanPhamComboBox.SelectedIndex = -1;
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            LoadDataToFlowLayout(listSanPham);
        }

        private void LoadDataToFlowLayout(List<SanPham> listSanPham)
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in sanPhamFlowLayoutPanel.Controls)
            {
                controlsToRemove.Add(control);
            }

            foreach (Control control in controlsToRemove)
            {
                sanPhamFlowLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }

            foreach (SanPham sanPham in listSanPham)
            {
                sanPhamFlowLayoutPanel.Controls.Add(new SanPhamBanUserControl(sanPham, this));
            }
        }

        private void TinhTien()
        {
            decimal thanhTien = decimal.Parse((thanhTienLabel.Text.Replace(" đ", "")));
            decimal giamGia = 0;
            if (khuyenMai != null)
                giamGia = new KhuyenMaiBUS().ApDungKhuyenMai(khuyenMai.MaKhuyenMai, thanhTien);
            if (khuyenMai == null && khachHang != null && !giamGiaLabel.Text.Equals("0 đ"))
                giamGia = new KhachHangBUS().GiamGiaThanhVien(khachHang.MaKhachHang, thanhTien);
            decimal tongTien = 0;
            decimal tienThua = 0;
            decimal tienNhan = 0;
            if (!tienNhanTextBox.Text.Equals("0"))
                tienNhan = decimal.Parse((tienNhanTextBox.Text.Replace(" đ", "")));
            tienThua = decimal.Parse((tienThuaLabel.Text.Replace(" đ", "")));

            tongTien = thanhTien - giamGia;
            tienThua = tienNhan - tongTien;

            tongTienLabel.Text = tongTien.ToString("0") + " đ";
            tienThuaLabel.Text = tienThua.ToString("0") + " đ";
            giamGiaLabel.Text = giamGia.ToString("0") + " đ";
        }

        private void TimKiemSanPhamButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemSanPhamTextBox.Text;
            string maLoaiSanPham = "";
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                LoaiSanPham loaiSanPham = loaiSanPhamComboBox.SelectedValue as LoaiSanPham;
                maLoaiSanPham = loaiSanPham.MaLoaiSanPham;
            }

            listSanPham = sanPhamBUS.TimKiemSanPham(tuKhoa, "", maLoaiSanPham, "Đang bán");

            LoadDataToFlowLayout(listSanPham);
        }

        private void TimKiemSanPhamTextBox_TextChanged(object sender, EventArgs e)
        {
            TimKiemSanPhamButton_Click(sender, e);
        }

        private void LoaiSanPhamComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                timKiemSanPhamTextBox.Clear();
                TimKiemSanPhamButton_Click(sender, e);
            }
        }

        private void LamMoiSanPhamButton_Click(object sender, EventArgs e)
        {
            timKiemSanPhamTextBox.Clear();
            loaiSanPhamComboBox.SelectedItem = null;
            loaiSanPhamComboBox.SelectedIndex = -1;

            listSanPham = sanPhamBUS.TimKiemSanPham("", "", "", "Đang bán");

            LoadDataToFlowLayout(listSanPham);
        }

        private void ChonKhachHangButton_Click(object sender, EventArgs e)
        {
            new ChonKhachHangForm(this).ShowDialog();
        }

        private void LamMoiKhachHangButton_Click(object sender, EventArgs e)
        {
            khachHang = null;
            maKhachHangLabel.Text = "Chưa chọn khách hàng";
            soDienThoaiLabel.Text = "Chưa chọn khách hàng";


            if (khuyenMaiThanhVienCheckBox.Checked)
            {
                khuyenMaiThanhVienCheckBox.Checked = false;
                tenKhuyenMaiLabel.Text = "Chưa chọn khuyến mãi";
                giamGiaLabel.Text = "0 đ";
            }
        }

        private void KhuyenMaiThanhVienCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            decimal thanhTien = decimal.Parse((thanhTienLabel.Text.Replace(" đ", "")));

            if (khachHang != null && khuyenMaiThanhVienCheckBox.Checked)
            {
                khuyenMai = null;
                decimal giamGia = new KhachHangBUS().GiamGiaThanhVien(khachHang.MaKhachHang, thanhTien);
                giamGiaLabel.Text = giamGia.ToString("0") + " đ";

                switch (khachHang.HangThanhVien)
                {
                    case "Đồng":
                        tenKhuyenMaiLabel.Text = "Khuyến mãi thành viên hạng đồng 2% tổng giá trị hóa đơn!";
                        break;
                    case "Bạc":
                        tenKhuyenMaiLabel.Text = "Khuyến mãi thành viên hạng bạc 3% tổng giá trị hóa đơn!";
                        break;
                    case "Vàng":
                        tenKhuyenMaiLabel.Text = "Khuyến mãi thành viên hạng vàng 5% tổng giá trị hóa đơn!";
                        break;
                }
            }

            if (khachHang == null)
            {
                khuyenMaiThanhVienCheckBox.Checked = false;

            }

            if (!khuyenMaiThanhVienCheckBox.Checked && khuyenMai == null)
            {
                tenKhuyenMaiLabel.Text = "Chưa chọn khuyến mãi";
                giamGiaLabel.Text = "0 đ";
            }
        }

        private void ThanhTienLabel_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void GiamGiaLabel_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void TienNhanTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tienNhanTextBox.Text))
                tienNhanTextBox.Text = "0";
            TinhTien();
        }

        private void ChonKhuyenMaiButton_Click(object sender, EventArgs e)
        {
            new ChonKhuyenMaiForm(this).ShowDialog();
        }

        private void HoanTatButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HoaDon hoaDon = new();
                hoaDon.MaHoaDon = TaoMaTuDong.TaoMaHoaDon();
                hoaDon.MaNguoiTao = DangNhapForm.nguoiDung.MaNguoiDung;
                hoaDon.ThoiGianTao = DateTime.Now;
                if (khachHang != null)
                    hoaDon.MaKhachHang = khachHang.MaKhachHang;
                if (khuyenMai != null)
                    hoaDon.MaKhuyenMai = khuyenMai.MaKhuyenMai;
                if (!string.IsNullOrEmpty(tenKhuyenMaiLabel.Text))
                    hoaDon.TenKhuyenMai = tenKhuyenMaiLabel.Text;
                hoaDon.ThanhTien = decimal.Parse(thanhTienLabel.Text.Replace(" đ", ""));
                hoaDon.GiamGia = decimal.Parse(giamGiaLabel.Text.Replace(" đ", ""));
                hoaDon.TongTien = decimal.Parse(tongTienLabel.Text.Replace(" đ", ""));
                hoaDon.TienNhan = decimal.Parse(tienNhanTextBox.Text);
                hoaDon.TienThua = decimal.Parse(tienThuaLabel.Text.Replace(" đ", ""));

                List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();

                foreach (Control control in chiTietFlowLayoutPanel.Controls)
                {
                    if (control is ChiTietBanUserControl)
                    {
                        ChiTietBanUserControl chiTietBanUserControl = (ChiTietBanUserControl)control;

                        ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                        chiTietHoaDon.MaHoaDon = hoaDon.MaHoaDon;
                        chiTietHoaDon.MaSanPham = chiTietBanUserControl.sanPham.MaSanPham;
                        chiTietHoaDon.SoLuong = (int)chiTietBanUserControl.soLuongNumericUpDown.Value;
                        chiTietHoaDon.DonGia = chiTietBanUserControl.sanPham.GiaBan;
                        chiTietHoaDon.ThanhTien = decimal.Parse(chiTietBanUserControl.thanhTienLabel.Text.Replace(" đ", ""));

                        listChiTietHoaDon.Add(chiTietHoaDon);
                    }
                }

                string message = new HoaDonBUS().ThemHoaDon(hoaDon, listChiTietHoaDon);

                MessageBox.Show(message);

                if (message.Equals("Tạo hóa đơn thành công!"))
                {
                    listSanPham = sanPhamBUS.TimKiemSanPham("", "", "", "Đang bán");
                    LoadDataToFlowLayout(listSanPham);
                    LamMoiSanPhamButton_Click(sender, e);
                    LamMoiKhachHangButton_Click(sender, e);
                    LamMoiKhuyenMaiButton_Click(sender, e);
                    List<Control> controlsToRemove = new List<Control>();

                    foreach (Control control in chiTietFlowLayoutPanel.Controls)
                    {
                        controlsToRemove.Add(control);
                    }

                    foreach (Control control in controlsToRemove)
                    {
                        chiTietFlowLayoutPanel.Controls.Remove(control);
                        control.Dispose();
                    }
                    thanhTienLabel.Text = "0 đ";
                    tienNhanTextBox.Text = "0";
                }
            }
        }

        private void TienNhanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TienNhanTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tienNhanTextBox.Text))
            {
                tienNhanTextBox.Text = "0";
            }
        }

        internal void LamMoiKhuyenMaiButton_Click(object sender, EventArgs e)
        {
            khuyenMai = null;
            if (!khuyenMaiThanhVienCheckBox.Checked)
            {
                tenKhuyenMaiLabel.Text = "Chưa chọn khuyến mãi";
                giamGiaLabel.Text = "0 đ";
            }
        }
    }
}
