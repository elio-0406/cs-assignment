using BUS;
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

namespace GUI.FormChon
{
    public partial class ChonKhachHangForm : Form
    {
        KhachHangBUS khachHangBUS;
        List<KhachHang> listKhachHang;
        BanHangForm banHangForm;

        public ChonKhachHangForm(BanHangForm banHangForm)
        {
            InitializeComponent();

            khachHangBUS = new();
            listKhachHang = khachHangBUS.TimKiemKhachHang("", "", "", "", "Đang hoạt động");
            this.banHangForm = banHangForm;
        }

        private void ChonKhachHangForm_Load(object sender, EventArgs e)
        {

            LoadDataToDataGridView(listKhachHang);
        }

        private void LoadDataToDataGridView(List<KhachHang> listKhachHang)
        {
            khachHangDataGridView.Rows.Clear();

            for (int i = 0; i < listKhachHang.Count; i++)
            {
                khachHangDataGridView.Rows.Add(1);
                khachHangDataGridView.Rows[i].Cells[0].Value = listKhachHang[i].MaKhachHang;
                khachHangDataGridView.Rows[i].Cells[1].Value = listKhachHang[i].SoDienThoai;
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            listKhachHang = khachHangBUS.TimKiemKhachHang("", "", "", "", "Đang hoạt động");
            LoadDataToDataGridView(listKhachHang);
        }

        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            TimKiemButton_Click(sender, e);
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            listKhachHang = khachHangBUS.TimKiemKhachHang("", "", "", "", "Đang hoạt động");
            LoadDataToDataGridView(listKhachHang);
        }

        private void KhachHangDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KhachHang khachHang = khachHangBUS.TimKiemKhachHang("", khachHangDataGridView["maKhachHangColumn", e.RowIndex].Value.ToString(), "", "", "")[0];

                string columnName = khachHangDataGridView.Columns[e.ColumnIndex].Name;
                if (columnName.Equals("chonButtonColumn"))
                {
                    if (banHangForm != null)
                    {
                        banHangForm.khachHang = khachHang;
                        banHangForm.maKhachHangLabel.Text = khachHang.MaKhachHang;
                        banHangForm.soDienThoaiLabel.Text = khachHang.SoDienThoai;
                        Close();
                    }
                }
            }
        }
    }
}
