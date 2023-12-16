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
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void DangNhapButton_Click(object sender, EventArgs e)
        {
            new TrangChuForm().ShowDialog();
            this.Hide();
        }

        private void TenDangNhapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < 32 || e.KeyChar > 126 || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void MatKhauTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < 32 || e.KeyChar > 126 || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void MatKhauTextBox_MouseLeave(object sender, EventArgs e)
        {
            matKhauTextBox.UseSystemPasswordChar = true;
        }

        private void MatKhauTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            matKhauTextBox.UseSystemPasswordChar = false;
        }

        private void DangNhapForm_KeyDown(object sender, KeyEventArgs e)
        {
            DangNhapButton_Click(sender, e);
        }
    }
}
