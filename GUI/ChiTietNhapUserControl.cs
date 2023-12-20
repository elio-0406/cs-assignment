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

namespace GUI
{
    public partial class ChiTietNhapUserControl : UserControl
    {
        internal SanPham sanPham;
        TaoPhieuNhapForm taoPhieuNhapForm;

        public ChiTietNhapUserControl(SanPham sanPham, TaoPhieuNhapForm taoPhieuNhapForm)
        {
            InitializeComponent();

            this.sanPham = sanPham;
            this.taoPhieuNhapForm = taoPhieuNhapForm;
        }

        private void TinhTien()
        {
            decimal tongTien = 0;

            foreach (Control control in taoPhieuNhapForm.chiTietDonFlowLayoutPanel.Controls)
            {
                if (control is ChiTietNhapUserControl)
                {
                    ChiTietNhapUserControl chiTietNhapUserControl = (ChiTietNhapUserControl)control;
                    decimal tongTienChiTiet = decimal.Parse((chiTietNhapUserControl.thanhTienLabel.Text.Replace(" đ", "")));
                    tongTien += tongTienChiTiet;
                }
            }

            taoPhieuNhapForm.tongTienLabel.Text = tongTien.ToString("0") + " đ";
        }

        private void GiaNhapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GiaNhapTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(giaNhapTextBox.Text))
            {
                giaNhapTextBox.Text = "0";
            }
        }

        private void ChiTietNhapUserControl_Load(object sender, EventArgs e)
        {
            tenSanPhamLabel.Text = sanPham.TenSanPham;
        }

        private void SoLuongNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal thanhTien = soLuongNumericUpDown.Value * decimal.Parse(giaNhapTextBox.Text);
            thanhTienLabel.Text = thanhTien.ToString("0") + " đ";
            TinhTien();
        }

        private void GiaNhapTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(giaNhapTextBox.Text))
                giaNhapTextBox.Text = "0";
            decimal thanhTien = soLuongNumericUpDown.Value * decimal.Parse(giaNhapTextBox.Text);
            thanhTienLabel.Text = thanhTien.ToString("0") + " đ";
            TinhTien();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            taoPhieuNhapForm.listSanPhamNhap.Remove(sanPham);
            taoPhieuNhapForm.chiTietDonFlowLayoutPanel.Controls.Remove(this);
            TinhTien();
            Dispose();
        }
    }
}
