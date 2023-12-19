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
    public partial class NhaCungCapForm : Form
    {
        NhaCungCapBUS nhaCungCapBUS;
        List<NhaCungCap> listNhaCungCap;

        public NhaCungCapForm()
        {
            InitializeComponent();

            nhaCungCapBUS = new NhaCungCapBUS();
            listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap("", "", "Đang hợp tác");
        }

        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listNhaCungCap);
            trangThaiComboBox.SelectedIndex = 0;

            if (!DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ02"))
            {
                nhaCungCapDataGridView.Columns.RemoveAt(5);
                nhaCungCapDataGridView.Columns.RemoveAt(6);
            }
        }

        private void LoadDataToDataGridView(List<NhaCungCap> listNhaCungCap)
        {
            nhaCungCapDataGridView.Rows.Clear();

            for (int i = 0; i < listNhaCungCap.Count; i++)
            {
                nhaCungCapDataGridView.Rows.Add(1);
                nhaCungCapDataGridView.Rows[i].Cells[0].Value = i + 1;
                nhaCungCapDataGridView.Rows[i].Cells[1].Value = listNhaCungCap[i].MaNhaCungCap;
                nhaCungCapDataGridView.Rows[i].Cells[2].Value = listNhaCungCap[i].TenNhaCungCap;
                nhaCungCapDataGridView.Rows[i].Cells[3].Value = listNhaCungCap[i].TrangThai;
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
                listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap(tuKhoa, "", trangThai);
                LoadDataToDataGridView(listNhaCungCap);
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

        internal void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            trangThaiComboBox.SelectedItem = null;
            trangThaiComboBox.SelectedIndex = 0;

            listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap("", "", "Đang hợp tác");
            LoadDataToDataGridView(listNhaCungCap);
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            new ChiTietNhaCungCapForm("Thêm", this).ShowDialog();
        }

        private void XuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelNhaCungCap(listNhaCungCap);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NhaCungCapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NhaCungCap nhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap("",nhaCungCapDataGridView["maNhaCungCapColumn", e.RowIndex].Value.ToString(), "")[0];

                string columnName = nhaCungCapDataGridView.Columns[e.ColumnIndex].Name;
                if (columnName.Equals("chiTietButtonColumn"))
                {
                    new ChiTietNhaCungCapForm("Chi tiết", nhaCungCap, this).ShowDialog();
                }

                if (columnName.Equals("suaButtonColumn"))
                {
                    new ChiTietNhaCungCapForm("Sửa", nhaCungCap, this).ShowDialog();
                }

                if (columnName.Equals("xoaButtonColumn"))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà cung cấp đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string message = nhaCungCapBUS.XoaNhaCungCap(nhaCungCap.MaNhaCungCap);
                        MessageBox.Show(message);
                        if (message.Equals("Xóa nhà cung cấp thành công!"))
                            LamMoiButton_Click(sender, e);
                    }
                }
            }
        }
    }
}
