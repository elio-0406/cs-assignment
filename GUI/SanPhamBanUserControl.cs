using BUS.ChucNangKhac;
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
    public partial class SanPhamBanUserControl : UserControl
    {
        SanPham sanPham;
        BanHangForm banHangForm;

        public SanPhamBanUserControl(SanPham sanPham, BanHangForm banHangForm)
        {
            InitializeComponent();

            this.sanPham = sanPham;
            this.banHangForm = banHangForm;
        }

        private void SanPhamBanUserControl_Load(object sender, EventArgs e)
        {
            tenSanPhamLabel.Text = sanPham.TenSanPham;
            giaBanLabel.Text = sanPham.GiaBan.ToString("0") + " đ";
            sanPhamPictureBox.Image = XuLyHinhAnh.ByteSangAnh(sanPham.Anh);
        }

        private void ChonButton_Click(object sender, EventArgs e)
        {
            if (banHangForm.listSanPhamDonHang.Contains(sanPham))
            {
                foreach (Control control in banHangForm.chiTietFlowLayoutPanel.Controls)
                {
                    if (control is ChiTietBanUserControl)
                    {
                        ChiTietBanUserControl chiTietBanUserControl = (ChiTietBanUserControl)control;
                        if (chiTietBanUserControl.sanPham == sanPham && sanPham.SoLuong > chiTietBanUserControl.soLuongNumericUpDown.Value)
                            chiTietBanUserControl.soLuongNumericUpDown.Value++;
                    }
                }
            }
            else
            {
                banHangForm.listSanPhamDonHang.Add(sanPham);
                banHangForm.chiTietFlowLayoutPanel.Controls.Add(new ChiTietBanUserControl(sanPham, banHangForm));
            }
        }
    }
}
