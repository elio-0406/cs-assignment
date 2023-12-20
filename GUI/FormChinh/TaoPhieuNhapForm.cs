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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormChinh
{
    public partial class TaoPhieuNhapForm : Form
    {
        SanPhamBUS sanPhamBUS;
        internal List<SanPham> listSanPham;
        internal List<SanPham> listSanPhamNhap;
        internal NhaCungCap nhaCungCap;

        public TaoPhieuNhapForm()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.LayTatCaSanPham().Where(sanPham => sanPham.TrangThai != "Ngừng kinh doanh").ToList();
            listSanPhamNhap = new List<SanPham>();
            loaiSanPhamComboBox.DataSource = new LoaiSanPhamBUS().TimKiemLoaiSanPham("","", "Đang sử dụng");
            loaiSanPhamComboBox.DisplayMember = "TenLoaiSanPham";
            loaiSanPhamComboBox.SelectedIndex = -1;
        }

        private void TaoPhieuNhapForm_Load(object sender, EventArgs e)
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
                sanPhamFlowLayoutPanel.Controls.Add(new SanPhamNhapUserControl(sanPham, this));
            }
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

            if (!(string.IsNullOrEmpty(tuKhoa) && string.IsNullOrEmpty(maLoaiSanPham)))
            {
                listSanPham = sanPhamBUS.TimKiemSanPham(tuKhoa, "", maLoaiSanPham, "");
                LoadDataToFlowLayout(listSanPham);
            }
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
            listSanPham = sanPhamBUS.LayTatCaSanPham().Where(sanPham => sanPham.TrangThai != "Ngừng kinh doanh").ToList();
            LoadDataToFlowLayout(listSanPham);
        }

        private void ChonNhaCungCapButton_Click(object sender, EventArgs e)
        {
            new ChonNhaCungCapForm(this).ShowDialog();
        }

        private void LamMoiNhaCungCapButton_Click(object sender, EventArgs e)
        {
            nhaCungCap = null;
            maNhaCungCapLabel.Text = "Chưa chọn nhà cung cấp";
            tenNhaCungCapLabel.Text = "Chưa chọn nhà cung cấp";
        }

        private void HoanTatButton_Click(object sender, EventArgs e)
        {
            PhieuNhap phieuNhap = new();
            phieuNhap.MaPhieuNhap = TaoMaTuDong.TaoMaPhieuNhap();
            if (!maNhaCungCapLabel.Text.Equals("Chưa chọn nhà cung cấp"))
                phieuNhap.MaNhaCungCap = maNhaCungCapLabel.Text;
            phieuNhap.MaNguoiTao = DangNhapForm.nguoiDung.MaNguoiDung;
            phieuNhap.ThoiGianTao = DateTime.Now;
            phieuNhap.TongTien = decimal.Parse(tongTienLabel.Text.Replace(" đ", ""));

            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new();

            foreach (Control control in chiTietDonFlowLayoutPanel.Controls)
            {
                if (control is ChiTietNhapUserControl)
                {
                    ChiTietNhapUserControl chiTietNhapUserControl = (ChiTietNhapUserControl)control;

                    ChiTietPhieuNhap chiTietPhieuNhap = new();

                    chiTietPhieuNhap.MaPhieuNhap = phieuNhap.MaPhieuNhap;
                    chiTietPhieuNhap.MaSanPham = chiTietNhapUserControl.sanPham.MaSanPham;
                    chiTietPhieuNhap.SoLuong = (int)chiTietNhapUserControl.soLuongNumericUpDown.Value;
                    chiTietPhieuNhap.DonGia = int.Parse(chiTietNhapUserControl.giaNhapTextBox.Text);
                    chiTietPhieuNhap.ThanhTien = decimal.Parse(chiTietNhapUserControl.thanhTienLabel.Text.Replace(" đ", ""));

                    listChiTietPhieuNhap.Add(chiTietPhieuNhap);
                }
            }

            string message = new PhieuNhapBUS().ThemPhieuNhap(phieuNhap, listChiTietPhieuNhap);

            MessageBox.Show(message);

            if (message.Equals("Thêm phiếu nhập thành công!"))
            {
                listSanPhamNhap.Clear();
                nhaCungCap = null;
                maNhaCungCapLabel.Text = "Chưa chọn nhà cung cấp";
                tenNhaCungCapLabel.Text = "Chưa chọn nhà cung cấp";
                LamMoiSanPhamButton_Click(sender, e);
                List<Control> controlsToRemove = new List<Control>();

                foreach (Control control in chiTietDonFlowLayoutPanel.Controls)
                {
                    controlsToRemove.Add(control);
                }

                foreach (Control control in controlsToRemove)
                {
                    chiTietDonFlowLayoutPanel.Controls.Remove(control);
                    control.Dispose();
                }
                controlsToRemove.Clear();
                foreach (Control control in sanPhamFlowLayoutPanel.Controls)
                {
                    controlsToRemove.Add(control);
                }

                foreach (Control control in controlsToRemove)
                {
                    sanPhamFlowLayoutPanel.Controls.Remove(control);
                    control.Dispose();
                }
                tongTienLabel.Text = "0 đ";
                listSanPham = sanPhamBUS.LayTatCaSanPham().Where(sanPham => sanPham.TrangThai != "Ngừng kinh doanh").ToList();
                LoadDataToFlowLayout(listSanPham);
            }
        }
    }
}
