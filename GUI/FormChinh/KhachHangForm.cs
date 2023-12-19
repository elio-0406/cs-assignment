using BUS;
using BUS.ChucNangKhac;
using DTO;
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
    public partial class KhachHangForm : Form
    {
        KhachHangBUS khachHangBUS;
        List<KhachHang> listKhachHang;

        public KhachHangForm()
        {
            InitializeComponent();

            khachHangBUS = new KhachHangBUS();
            listKhachHang = khachHangBUS.TimKiemKhachHang("", "", "", "", "Đang hoạt động");
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listKhachHang);

            hangThanhVienComboBox.SelectedIndex = -1;
            trangThaiComboBox.SelectedIndex = 0;

            if (!DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ03"))
            {
                khachHangDataGridView.Columns.Remove("suaButtonColumn");
                khachHangDataGridView.Columns.Remove("xoaButtonColumn");
            }
        }

        private void LoadDataToDataGridView(List<KhachHang> listKhachHang)
        {
            khachHangDataGridView.Rows.Clear();

            for (int i = 0; i < listKhachHang.Count; i++)
            {
                khachHangDataGridView.Rows.Add(1);
                khachHangDataGridView.Rows[i].Cells[0].Value = i + 1;
                khachHangDataGridView.Rows[i].Cells[1].Value = listKhachHang[i].MaKhachHang;
                khachHangDataGridView.Rows[i].Cells[2].Value = listKhachHang[i].HoTen;
                khachHangDataGridView.Rows[i].Cells[3].Value = listKhachHang[i].SoDienThoai;
                khachHangDataGridView.Rows[i].Cells[4].Value = listKhachHang[i].HangThanhVien;
                khachHangDataGridView.Rows[i].Cells[5].Value = listKhachHang[i].TrangThai;
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string hangThanhVien = "";
            if (hangThanhVienComboBox.SelectedItem != null)
                hangThanhVien = hangThanhVienComboBox.SelectedItem.ToString();
            string trangThai = "";
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();

            if (!(string.IsNullOrEmpty(tuKhoa) && string.IsNullOrEmpty(hangThanhVien) && string.IsNullOrEmpty(trangThai)))
            {
                listKhachHang = khachHangBUS.TimKiemKhachHang(tuKhoa, "", "", hangThanhVien, trangThai);
                LoadDataToDataGridView(listKhachHang);
            }
        }

        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            TimKiemButton_Click(sender, e);
        }

        private void TrangThaiComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (trangThaiComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        private void HangThanhVienComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (hangThanhVienComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        internal void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            hangThanhVienComboBox.SelectedItem = null;
            trangThaiComboBox.SelectedItem = null;
            hangThanhVienComboBox.SelectedIndex = -1;
            trangThaiComboBox.SelectedIndex = 0;

            listKhachHang = khachHangBUS.TimKiemKhachHang("", "", "", "", "Đang hoạt động");
            LoadDataToDataGridView(listKhachHang);
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            new ChiTietKhachHangForm("Thêm", this).ShowDialog();
        }

        private void XuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                Title = "Chọn vị trí lưu file Excel"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelKhachHang(listKhachHang);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void KhachHangDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KhachHang khachHang = khachHangBUS.TimKiemKhachHang("",khachHangDataGridView["maKhachHangColumn", e.RowIndex].Value.ToString(), "", "", "")[0];

                string columnName = khachHangDataGridView.Columns[e.ColumnIndex].Name;
                if (columnName.Equals("chiTietButtonColumn"))
                {
                    new ChiTietKhachHangForm("Chi tiết", khachHang, this).ShowDialog();
                }

                if (columnName.Equals("suaButtonColumn"))
                {
                    new ChiTietKhachHangForm("Sửa", khachHang, this).ShowDialog();
                }

                if (columnName.Equals("xoaButtonColumn"))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string message = khachHangBUS.XoaKhachHang(khachHang.MaKhachHang);
                        MessageBox.Show(message);
                        LamMoiButton_Click(sender, e);
                    }
                }
            }
        }
    }
}
