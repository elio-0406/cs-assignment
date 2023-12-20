using BUS;
using DTO;
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
    public partial class SuaChiTietPhieuNhapForm : Form
    {
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS;
        ChiTietPhieuNhap chiTietPhieuNhap;
        ChiTietPhieuNhapForm chiTietPhieuNhapForm;

        public SuaChiTietPhieuNhapForm(ChiTietPhieuNhap chiTietPhieuNhap, ChiTietPhieuNhapForm chiTietPhieuNhapForm)
        {
            InitializeComponent();

            chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
            this.chiTietPhieuNhap = chiTietPhieuNhap;
            this.chiTietPhieuNhapForm = chiTietPhieuNhapForm;
        }

        private void SuaChiTietPhieuNhapForm_Load(object sender, EventArgs e)
        {
            maSanPhamTextBox.Text = chiTietPhieuNhap.MaSanPham;
            donGiaTextBox.Text = chiTietPhieuNhap.DonGia.ToString("0");
            soLuongNumericUpDown.Value = chiTietPhieuNhap.SoLuong;
            thanhTienLabel.Text = chiTietPhieuNhap.ThanhTien.ToString("0");
        }

        private void TinhTien()
        {
            int soLuong = (int)soLuongNumericUpDown.Value;
            decimal donGia = decimal.Parse(donGiaTextBox.Text);
            decimal thanhTien = 0;

            thanhTien = donGia * soLuong;
            thanhTienLabel.Text = thanhTien.ToString("0");
        }

        private void DonGiaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(donGiaTextBox.Text))
            {
                donGiaTextBox.Text = "0";
            }

            TinhTien();
        }

        private void DonGiaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DonGiaTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(donGiaTextBox.Text))
            {
                donGiaTextBox.Text = "0";
            }
        }

        private void SoLuongNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void HuyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                soLuongNumericUpDown.Value = chiTietPhieuNhap.SoLuong;
                donGiaTextBox.Text = chiTietPhieuNhap.DonGia.ToString("0");
                thanhTienLabel.Text = chiTietPhieuNhap.ThanhTien.ToString("0");
            }
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin chi tiết phiếu nhập không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                chiTietPhieuNhap.SoLuong = (int)soLuongNumericUpDown.Value;
                chiTietPhieuNhap.DonGia = decimal.Parse(donGiaTextBox.Text);
                chiTietPhieuNhap.ThanhTien = decimal.Parse(thanhTienLabel.Text.Replace(" đ", ""));

                string message = chiTietPhieuNhapBUS.SuaChiTietPhieuNhap(chiTietPhieuNhap);
                MessageBox.Show(message);
                if (message.Equals("Chỉnh sửa chi tiết phiếu nhập thành công!"))
                {
                    chiTietPhieuNhapForm.listChiTietPhieuNhap = chiTietPhieuNhapBUS.LayChiTietPhieuNhapTheoPhieuNhap(chiTietPhieuNhap.MaPhieuNhap);
                    chiTietPhieuNhapForm.LoadDataToDataGridView(chiTietPhieuNhapForm.listChiTietPhieuNhap);
                    Close();
                }
            }
        }
    }
}
