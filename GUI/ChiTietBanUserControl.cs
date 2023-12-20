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
    public partial class ChiTietBanUserControl : UserControl
    {

        internal SanPham sanPham;
        BanHangForm banHangForm;

        public ChiTietBanUserControl(SanPham sanPham, BanHangForm banHangForm)
        {
            InitializeComponent();

            this.sanPham = sanPham;
            this.banHangForm = banHangForm;
        }


        private void ChiTietBanUserControl_Load(object sender, EventArgs e)
        {
            soLuongNumericUpDown.Maximum = sanPham.SoLuong;
            tenSanPhamLabel.Text = sanPham.TenSanPham;
            thanhTienLabel.Text = sanPham.GiaBan.ToString("0") + " đ";

            TinhTien();
        }

        private void TinhTien()
        {
            decimal tongTien = 0;

            foreach (Control control in banHangForm.chiTietFlowLayoutPanel.Controls)
            {
                if (control is ChiTietBanUserControl)
                {
                    ChiTietBanUserControl chiTietBanUserControl = (ChiTietBanUserControl)control;
                    decimal thanhTien = decimal.Parse((chiTietBanUserControl.thanhTienLabel.Text.Replace(" đ", "")));
                    tongTien += thanhTien;
                }
            }

            banHangForm.thanhTienLabel.Text = tongTien.ToString("0") + " đ";
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            banHangForm.listSanPhamDonHang.Remove(sanPham);
            banHangForm.chiTietFlowLayoutPanel.Controls.Remove(this);

            TinhTien();

            if (banHangForm.listSanPhamDonHang.Count <= 0)
            {
                banHangForm.LamMoiKhuyenMaiButton_Click(sender, e);
            }

            Dispose();
        }

        private void SoLuongNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            thanhTienLabel.Text = (sanPham.GiaBan * soLuongNumericUpDown.Value).ToString("0") + " đ";

            TinhTien();
        }
    }
}
