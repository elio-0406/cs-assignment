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
    public partial class SanPhamForm : Form
    {
        SanPhamBUS sanPhamBUS;
        internal List<SanPham> listSanPham;

        public SanPhamForm()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.TimKiemSanPham("", "", "", "Đang bán");
            List<LoaiSanPham> listLoaiSanPham = new LoaiSanPhamBUS().TimKiemLoaiSanPham("","", "Đang sử dụng");
            loaiSanPhamComboBox.DataSource = listLoaiSanPham;
            loaiSanPhamComboBox.DisplayMember = "tenLoaiSanPham";
        }

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listSanPham);

            trangThaiComboBox.SelectedIndex = 0;
            loaiSanPhamComboBox.SelectedIndex = -1;

            if (!DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ02"))
            {
                sanPhamDataGridView.Columns.Remove("xoaButtonColumn");
                sanPhamDataGridView.Columns.Remove("suaButtonColumn");
            }
        }

        private void LoadDataToDataGridView(List<SanPham> listSanPham)
        {
            sanPhamDataGridView.Rows.Clear();

            for (int i = 0; i < listSanPham.Count; i++)
            {
                sanPhamDataGridView.Rows.Add(1);
                sanPhamDataGridView.Rows[i].Cells[0].Value = i + 1;
                sanPhamDataGridView.Rows[i].Cells[1].Value = listSanPham[i].MaSanPham;
                sanPhamDataGridView.Rows[i].Cells[2].Value = new LoaiSanPhamBUS().TimKiemLoaiSanPham("",listSanPham[i].MaLoaiSanPham, "")[0].TenLoaiSanPham;
                sanPhamDataGridView.Rows[i].Cells[3].Value = listSanPham[i].TenSanPham;
                sanPhamDataGridView.Rows[i].Cells[4].Value = listSanPham[i].GiaBan.ToString("0") + " đ";
                sanPhamDataGridView.Rows[i].Cells[5].Value = listSanPham[i].SoLuong;
                sanPhamDataGridView.Rows[i].Cells[6].Value = listSanPham[i].TrangThai;
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string trangThai = "";
            string maLoaiSanPham = "";
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                LoaiSanPham loaiSanPham = loaiSanPhamComboBox.SelectedValue as LoaiSanPham;
                maLoaiSanPham = loaiSanPham.MaLoaiSanPham;
            }

            listSanPham = sanPhamBUS.TimKiemSanPham(tuKhoa, "", maLoaiSanPham, trangThai);
            LoadDataToDataGridView(listSanPham);
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

        private void LoaiSanPhamComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (loaiSanPhamComboBox.SelectedItem != null)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        internal void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            trangThaiComboBox.SelectedItem = null;
            loaiSanPhamComboBox.SelectedItem = null;
            trangThaiComboBox.SelectedIndex = 0;
            loaiSanPhamComboBox.SelectedIndex = -1;

            listSanPham = sanPhamBUS.TimKiemSanPham("", "", "", "Đang bán");

            LoadDataToDataGridView(listSanPham);
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            new ChiTietSanPhamForm("Thêm", this).ShowDialog();
        }

        private void XuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                new XuatExcel(filePath).XuatExcelSanPham(listSanPham);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath);
            }
        }

        private void SanPhamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SanPham sanPham = sanPhamBUS.TimKiemSanPham("",sanPhamDataGridView.Rows[e.RowIndex].Cells["maSanPhamColumn"].Value.ToString(), "", "")[0];

                string columnName = sanPhamDataGridView.Columns[e.ColumnIndex].Name;
                if (columnName.Equals("chiTietButtonColumn"))
                {
                    new ChiTietSanPhamForm("Chi tiết", sanPham, this).ShowDialog();
                }

                if (columnName.Equals("suaButtonColumn"))
                {
                    new ChiTietSanPhamForm("Sửa", sanPham, this).ShowDialog();
                }

                if (columnName.Equals("xoaButtonColumn"))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string maSanPham = sanPhamDataGridView.Rows[e.RowIndex].Cells["maSanPhamColumn"].Value.ToString();
                        MessageBox.Show(sanPhamBUS.XoaSanPham(maSanPham));
                        LamMoiButton_Click(sender, e);
                    }
                }
            }
        }
    }
}
