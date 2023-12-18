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
    public partial class LoaiSanPhamForm : Form
    {
        LoaiSanPhamBUS loaiSanPhamBUS;
        List<LoaiSanPham> listLoaiSanPham;

        public LoaiSanPhamForm()
        {
            InitializeComponent();

            loaiSanPhamBUS = new LoaiSanPhamBUS();
            listLoaiSanPham = loaiSanPhamBUS.TimKiemLoaiSanPham("", "", "Đang sử dụng");
        }

        private void LoaiSanPhamForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listLoaiSanPham);
            trangThaiComboBox.SelectedIndex = 0;

            if (!DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ02"))
            {
                loaiSanPhamDataGridView.Columns.RemoveAt(4);
                loaiSanPhamDataGridView.Columns.RemoveAt(5);
            }
        }

        private void LoadDataToDataGridView(List<LoaiSanPham> listLoaiSanPham)
        {
            loaiSanPhamDataGridView.Rows.Clear();

            for (int i = 0; i < listLoaiSanPham.Count; i++)
            {
                loaiSanPhamDataGridView.Rows.Add(1);
                loaiSanPhamDataGridView.Rows[i].Cells[0].Value = i + 1;
                loaiSanPhamDataGridView.Rows[i].Cells[1].Value = listLoaiSanPham[i].MaLoaiSanPham;
                loaiSanPhamDataGridView.Rows[i].Cells[2].Value = listLoaiSanPham[i].TenLoaiSanPham;
                loaiSanPhamDataGridView.Rows[i].Cells[3].Value = listLoaiSanPham[i].TrangThai;
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string trangThai = "";
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();

            if (!(string.IsNullOrEmpty(tuKhoa) && string.IsNullOrEmpty(trangThai)))
            {
                listLoaiSanPham = loaiSanPhamBUS.TimKiemLoaiSanPham(tuKhoa, "", trangThai);
                LoadDataToDataGridView(listLoaiSanPham);
            }
        }

        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            TimKiemButton_Click(sender, e);
        }

        private void TrangThaiComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (trangThaiComboBox.SelectedItem != null)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        internal void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            trangThaiComboBox.SelectedIndex = 0;

            listLoaiSanPham = loaiSanPhamBUS.TimKiemLoaiSanPham("", "", "Đang sử dụng");
            LoadDataToDataGridView(listLoaiSanPham);
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            new ChiTietLoaiSanPhamForm("Thêm", this).ShowDialog();
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
                new XuatExcel(filePath).XuatExcelLoaiSanPham(listLoaiSanPham);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoaiSanPhamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LoaiSanPham loaiSanPham = loaiSanPhamBUS.TimKiemLoaiSanPham("", loaiSanPhamDataGridView["maLoaiSanPhamColumn", e.RowIndex].Value.ToString(), "")[0];

                string columnName = loaiSanPhamDataGridView.Columns[e.ColumnIndex].Name;
                if (columnName.Equals("suaButtonColumn"))
                {
                    new ChiTietLoaiSanPhamForm("Sửa", loaiSanPham, this).ShowDialog();
                }

                if (columnName.Equals("xoaButtonColumn"))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa loại sản phẩm đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string message = loaiSanPhamBUS.XoaLoaiSanPham(loaiSanPham.MaLoaiSanPham);

                        MessageBox.Show(message);

                        if (message.Equals("Xóa loại sản phẩm thành công!"))
                            LamMoiButton_Click(sender, e);
                    }
                }
            }
        }
    }
}
