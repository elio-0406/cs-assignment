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
    public partial class NguoiDungForm : Form
    {
        NguoiDungBUS nguoiDungBUS;
        List<NguoiDung> listNguoiDung;

        public NguoiDungForm()
        {
            InitializeComponent();

            nguoiDungBUS = new NguoiDungBUS();
            if (DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ02"))
                listNguoiDung = nguoiDungBUS.TimKiemNguoiDung("", "", "", "", "", "Đang hoạt động").Where(nguoiDung => (nguoiDung.MaPhanQuyen.Equals("PQ03") || nguoiDung.MaPhanQuyen.Equals("PQ04"))).ToList();
            else
                listNguoiDung = nguoiDungBUS.TimKiemNguoiDung("", "", "", "", "", "Đang hoạt động");
        }

        private void NguoiDungForm_Load(object sender, EventArgs e)
        {
            List<PhanQuyen> listPhanQuyen = [];
            if (DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ02"))
                listPhanQuyen = new PhanQuyenBUS().LayTatCaPhanQuyen().Where(phanQuyen => (phanQuyen.MaPhanQuyen.Equals("PQ03") || phanQuyen.MaPhanQuyen.Equals("PQ04"))).ToList();
            else
                listPhanQuyen = new PhanQuyenBUS().LayTatCaPhanQuyen();
            phanQuyenComboBox.DataSource = listPhanQuyen;
            phanQuyenComboBox.DisplayMember = "TenPhanQuyen";
            phanQuyenComboBox.SelectedIndex = -1;
            trangThaiComboBox.SelectedIndex = 0;
            gioiTinhComboBox.SelectedIndex = -1;

            LoadDataToDataGridView(listNguoiDung);
        }

        private void LoadDataToDataGridView(List<NguoiDung> listNguoiDung)
        {
            nguoiDungDataGridView.Rows.Clear();

            for (int i = 0; i < listNguoiDung.Count; i++)
            {
                nguoiDungDataGridView.Rows.Add(1);
                nguoiDungDataGridView.Rows[i].Cells[0].Value = i + 1;
                nguoiDungDataGridView.Rows[i].Cells[1].Value = listNguoiDung[i].MaNguoiDung;
                nguoiDungDataGridView.Rows[i].Cells[2].Value = new PhanQuyenBUS().TimKiemPhanQuyen("", listNguoiDung[i].MaPhanQuyen)[0].TenPhanQuyen;
                nguoiDungDataGridView.Rows[i].Cells[3].Value = listNguoiDung[i].TenDangNhap;
                nguoiDungDataGridView.Rows[i].Cells[4].Value = listNguoiDung[i].HoTen;
                nguoiDungDataGridView.Rows[i].Cells[5].Value = listNguoiDung[i].TrangThai;
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string maPhanQuyen = "";
            string gioiTinh = "";
            string trangThai = "";

            if (phanQuyenComboBox.SelectedValue != null)
            {
                PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                maPhanQuyen = phanQuyen.MaPhanQuyen;
            }
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();
            if (gioiTinhComboBox.SelectedItem != null)
                gioiTinh = gioiTinhComboBox.SelectedItem.ToString();

            if (!(string.IsNullOrEmpty(tuKhoa) && string.IsNullOrEmpty(maPhanQuyen) && string.IsNullOrEmpty(trangThai) && string.IsNullOrEmpty(gioiTinh)))
            {
                if (DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ02"))
                    listNguoiDung = nguoiDungBUS.TimKiemNguoiDung(tuKhoa, "", maPhanQuyen, "", gioiTinh, trangThai).Where(nguoiDung => (nguoiDung.MaPhanQuyen.Equals("PQ03") || nguoiDung.MaPhanQuyen.Equals("PQ04"))).ToList();
                else
                    listNguoiDung = nguoiDungBUS.TimKiemNguoiDung(tuKhoa, "", maPhanQuyen, "", gioiTinh, trangThai);
                LoadDataToDataGridView(listNguoiDung);
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

        private void PhanQuyenComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (phanQuyenComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        private void GioiTinhComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (gioiTinhComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        internal void LamMoiButton_Click(object sender, EventArgs e)
        {
            phanQuyenComboBox.SelectedItem = null;
            trangThaiComboBox.SelectedItem = null;
            gioiTinhComboBox.SelectedItem = null;
            phanQuyenComboBox.SelectedIndex = -1;
            trangThaiComboBox.SelectedIndex = 0;
            gioiTinhComboBox.SelectedIndex = -1;
            timKiemTextBox.Clear();

            if (DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ02"))
                listNguoiDung = nguoiDungBUS.TimKiemNguoiDung("", "", "", "", "", "Đang hoạt động").Where(nguoiDung => (nguoiDung.MaPhanQuyen.Equals("PQ03") || nguoiDung.MaPhanQuyen.Equals("PQ04"))).ToList();
            else
                listNguoiDung = nguoiDungBUS.TimKiemNguoiDung("", "", "", "", "", "Đang hoạt động");
            LoadDataToDataGridView(listNguoiDung);
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            new ChiTietNguoiDungForm("Thêm", this).ShowDialog();
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
                new XuatExcel(filePath).XuatExcelNguoiDung(listNguoiDung);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NguoiDungDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NguoiDung nguoiDung = nguoiDungBUS.TimKiemNguoiDung("", nguoiDungDataGridView["maNguoiDungColumn", e.RowIndex].Value.ToString(), "", "", "", "")[0];
                string columnName = nguoiDungDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("chiTietButtonColumn"))
                    new ChiTietNguoiDungForm("Chi tiết", nguoiDung, this).ShowDialog();

                if (columnName.Equals("suaButtonColumn"))
                    new ChiTietNguoiDungForm("Sửa", nguoiDung, this).ShowDialog();

                if (columnName.Equals("xoaButtonColumn"))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa người dùng đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string message = nguoiDungBUS.XoaNguoiDung(nguoiDung.MaNguoiDung);
                        MessageBox.Show(message);
                        LamMoiButton_Click(sender, e);
                    }
                }
            }
        }
    }
}
