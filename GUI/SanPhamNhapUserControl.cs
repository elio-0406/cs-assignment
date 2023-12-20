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
    public partial class SanPhamNhapUserControl : UserControl
    {
        SanPham sanPham;
        TaoPhieuNhapForm taoPhieuNhapForm;

        public SanPhamNhapUserControl(SanPham sanPham, TaoPhieuNhapForm taoPhieuNhapForm)
        {
            InitializeComponent();

            this.sanPham = sanPham;
            this.taoPhieuNhapForm = taoPhieuNhapForm;
        }

        private void SanPhamNhapUserControl_Load(object sender, EventArgs e)
        {
            tenSanPhamLabel.Text = sanPham.TenSanPham;
            sanPhamPictureBox.Image = XuLyHinhAnh.DieuChinhKichThuoc(XuLyHinhAnh.ByteSangAnh(sanPham.Anh), sanPhamPictureBox.Width, sanPhamPictureBox.Height);
        }

        private void ChonButton_Click(object sender, EventArgs e)
        {
            if (taoPhieuNhapForm.listSanPhamNhap != null && taoPhieuNhapForm.listSanPhamNhap.Contains(sanPham))
            {
                foreach (Control control in taoPhieuNhapForm.chiTietDonFlowLayoutPanel.Controls)
                {
                    if (control is ChiTietNhapUserControl)
                    {
                        ChiTietNhapUserControl chiTietNhapUserControl = (ChiTietNhapUserControl)control;
                        if (chiTietNhapUserControl.sanPham == sanPham)
                            chiTietNhapUserControl.soLuongNumericUpDown.Value++;
                    }
                }
            }
            else
            {
                taoPhieuNhapForm.listSanPhamNhap.Add(sanPham);
                taoPhieuNhapForm.chiTietDonFlowLayoutPanel.Controls.Add(new ChiTietNhapUserControl(sanPham, taoPhieuNhapForm));
            }
        }
    }
}
