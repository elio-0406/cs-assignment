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
    public partial class KhuyenMaiForm : Form
    {
        KhuyenMaiBUS khuyenMaiBUS;
        List<KhuyenMai> listKhuyenMai;

        public KhuyenMaiForm()
        {
            InitializeComponent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMai("", "", "", "", null, "Đang diễn ra");
        }

        private void KhuyenMaiForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listKhuyenMai);

            trangThaiComboBox.SelectedIndex = 0;
            loaiGiaTriComboBox.SelectedIndex = -1;

            if (!DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ02"))
            {
                khuyenMaiDataGridView.Columns.Remove("xoaButtonColumn");
                khuyenMaiDataGridView.Columns.Remove("suaButtonColumn");
            }
        }

        private void LoadDataToDataGridView(List<KhuyenMai> listKhuyenMai)
        {
            khuyenMaiDataGridView.Rows.Clear();

            for (int i = 0; i < listKhuyenMai.Count; i++)
            {
                khuyenMaiDataGridView.Rows.Add(1);
                khuyenMaiDataGridView.Rows[i].Cells[0].Value = i + 1;
                khuyenMaiDataGridView.Rows[i].Cells[1].Value = listKhuyenMai[i].MaKhuyenMai;
                khuyenMaiDataGridView.Rows[i].Cells[2].Value = listKhuyenMai[i].TenKhuyenMai;
                khuyenMaiDataGridView.Rows[i].Cells[3].Value = listKhuyenMai[i].LoaiGiaTri;
                khuyenMaiDataGridView.Rows[i].Cells[4].Value = listKhuyenMai[i].GiaTri;
                if (listKhuyenMai[i].ThoiGianBatDau < DateTime.Now && listKhuyenMai[i].ThoiGianKetThuc > DateTime.Now)
                    khuyenMaiDataGridView.Rows[i].Cells[5].Value = "Đang diễn ra";
                if (listKhuyenMai[i].ThoiGianBatDau > DateTime.Now && listKhuyenMai[i].ThoiGianKetThuc > DateTime.Now)
                    khuyenMaiDataGridView.Rows[i].Cells[5].Value = "Chưa diễn ra";
                if (listKhuyenMai[i].ThoiGianKetThuc < DateTime.Now)
                    khuyenMaiDataGridView.Rows[i].Cells[5].Value = "Đã kết thúc";
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string trangThai = "";
            string loaiGiaTri = "";
            string tuyChonThoiGian = "";
            DateTime? thoiGian = null;
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();
            if (loaiGiaTriComboBox.SelectedItem != null)
                loaiGiaTri = loaiGiaTriComboBox.SelectedItem.ToString();
            if (tuyChonThoiGianComboBox.SelectedItem != null)
                tuyChonThoiGian = tuyChonThoiGianComboBox.SelectedItem.ToString();
            if (thoiGianDateTimePicker.Checked)
                thoiGian = thoiGianDateTimePicker.Value;

            if (!(string.IsNullOrEmpty(tuKhoa) && string.IsNullOrEmpty(trangThai) && string.IsNullOrEmpty(loaiGiaTri) && string.IsNullOrEmpty(tuyChonThoiGian) && !thoiGianDateTimePicker.Checked)) 
            {
                listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMai(tuKhoa, "", loaiGiaTri, tuyChonThoiGian, thoiGian, trangThai);
                LoadDataToDataGridView(listKhuyenMai);
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

        private void LoaiGiaTriComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (loaiGiaTriComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        private void TuyChonThoiGianComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (thoiGianDateTimePicker.Checked)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        private void ThoiGianDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (thoiGianDateTimePicker.Checked)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        internal void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            trangThaiComboBox.SelectedItem = null;
            loaiGiaTriComboBox.SelectedItem = null;
            tuyChonThoiGianComboBox.SelectedItem = null;
            trangThaiComboBox.SelectedIndex = 0;
            loaiGiaTriComboBox.SelectedIndex = -1;
            tuyChonThoiGianComboBox.SelectedIndex = -1;
            thoiGianDateTimePicker.Checked = false;

            listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMai("", "", "", "", null, "Đang diễn ra");
            LoadDataToDataGridView(listKhuyenMai);
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            new ChiTietKhuyenMaiForm("Thêm", this).Show();
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
                new XuatExcel(filePath).XuatExcelKhuyenMai(listKhuyenMai);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void KhuyenMaiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KhuyenMai khuyenMai = khuyenMaiBUS.TimKiemKhuyenMai("", khuyenMaiDataGridView.Rows[e.RowIndex].Cells["maKhuyenMaiColumn"].Value.ToString(), "", "", null, "")[0];

                string columnName = khuyenMaiDataGridView.Columns[e.ColumnIndex].Name;
                if (columnName.Equals("chiTietButtonColumn"))
                {
                    new ChiTietKhuyenMaiForm("Chi tiết", khuyenMai, this).Show();
                }

                if (columnName.Equals("suaButtonColumn"))
                {
                    new ChiTietKhuyenMaiForm("Sửa", khuyenMai, this).Show();
                }

                if (columnName.Equals("xoaButtonColumn"))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa khuyến mãi đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string maKhuyenMai = khuyenMaiDataGridView.Rows[e.RowIndex].Cells["maKhuyenMaiColumn"].Value.ToString();
                        MessageBox.Show(khuyenMaiBUS.XoaKhuyenMai(maKhuyenMai));

                        LamMoiButton_Click(sender, e);
                    }
                }
            }
        }

        
    }
}
