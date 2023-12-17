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
        public ChiTietNhapUserControl()
        {
            InitializeComponent();
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
    }
}
