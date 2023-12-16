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

        private void tenDangNhapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar > 127 || e.KeyChar == ' ')
            {
                e.Handled = true; 
            }
        }

        private void matKhauTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar > 127 || e.KeyChar == ' ')
            {
                e.Handled = true; 
            }
        }

        private void dangNhapButton_Click(object sender, EventArgs e)
        {

        }

        private void DangNhapForm_KeyDown(object sender, KeyEventArgs e)
        {
            dangNhapButton_Click(sender, e);
        }
    }
}
