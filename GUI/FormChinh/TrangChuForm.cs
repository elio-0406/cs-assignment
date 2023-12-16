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
    public partial class TrangChuForm : Form
    {
        public TrangChuForm()
        {
            InitializeComponent();
        }

        private void TrangChuForm_Load(object sender, EventArgs e)
        {

        }

        private void DangXuatButton_Click(object sender, EventArgs e)
        {
            Close();
            new DangNhapForm().Show();
        }

        private void PhanQuyenButton_Click(object sender, EventArgs e)
        {

        }

        private void NguoiDungButton_Click(object sender, EventArgs e)
        {

        }

        private void LoaiSanPhamButton_Click(object sender, EventArgs e)
        {

        }

        private void SanPhamButton_Click(object sender, EventArgs e)
        {

        }

        private void NhaCungCapButton_Click(object sender, EventArgs e)
        {

        }

        private void PhieuNhapButton_Click(object sender, EventArgs e)
        {

        }

        private void KhachHangButton_Click(object sender, EventArgs e)
        {

        }

        private void KhuyenMaiButton_Click(object sender, EventArgs e)
        {

        }

        private void BanHangButton_Click(object sender, EventArgs e)
        {

        }

        private void TaoPhieuNhapButton_Click(object sender, EventArgs e)
        {

        }

        private void HoaDonButton_Click(object sender, EventArgs e)
        {

        }
    }
}
