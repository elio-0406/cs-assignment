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
    public partial class BanHangForm : Form
    {
        public BanHangForm()
        {
            InitializeComponent();
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {

        }

        private void TimKiemSanPhamButton_Click(object sender, EventArgs e)
        {

        }

        private void TimKiemSanPhamTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoaiSanPhamComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void LamMoiSanPhamButton_Click(object sender, EventArgs e)
        {

        }

        private void ChonKhachHangButton_Click(object sender, EventArgs e)
        {

        }

        private void LamMoiKhachHangButton_Click(object sender, EventArgs e)
        {

        }

        private void KhuyenMaiThanhVienCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GiamGiaLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void TienNhanTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TienThuaLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThanhTienLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChonKhuyenMaiButton_Click(object sender, EventArgs e)
        {

        }

        private void HoanTatButton_Click(object sender, EventArgs e)
        {

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
    }
}
