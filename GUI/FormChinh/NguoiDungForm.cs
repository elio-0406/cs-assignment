using GUI.FormChiTiet;
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
    public partial class NguoiDungForm : Form
    {
        public NguoiDungForm()
        {
            InitializeComponent();
        }

        private void NguoiDungForm_Load(object sender, EventArgs e)
        {

        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {

        }

        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrangThaiComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void PhanQuyenComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void GioiTinhComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {

        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            new ChiTietNguoiDungForm().ShowDialog();
        }

        private void XuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void NguoiDungDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
