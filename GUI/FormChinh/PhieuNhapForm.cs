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
    public partial class PhieuNhapForm : Form
    {
        PhieuNhapBUS phieuNhapBUS;
        List<PhieuNhap> listPhieuNhap;

        public PhieuNhapForm()
        {
            InitializeComponent();
            phieuNhapBUS = new PhieuNhapBUS();
            listPhieuNhap = phieuNhapBUS.LayTatCaPhieuNhap().Where(phieuNhap => (phieuNhap.TrangThai != "Không duyệt")).ToList();
        }

        private void PhieuNhapForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listPhieuNhap);
        }

        private void LoadDataToDataGridView(List<PhieuNhap> listPhieuNhap)
        {
            phieuNhapDataGridView.Rows.Clear();

            for (int i = 0; i < listPhieuNhap.Count; i++)
            {
                phieuNhapDataGridView.Rows.Add(1);
                phieuNhapDataGridView.Rows[i].Cells[0].Value = i + 1;
                phieuNhapDataGridView.Rows[i].Cells[1].Value = listPhieuNhap[i].MaPhieuNhap;
                phieuNhapDataGridView.Rows[i].Cells[2].Value = listPhieuNhap[i].MaNhaCungCap;
                phieuNhapDataGridView.Rows[i].Cells[3].Value = listPhieuNhap[i].MaNguoiTao;
                phieuNhapDataGridView.Rows[i].Cells[4].Value = listPhieuNhap[i].ThoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
                phieuNhapDataGridView.Rows[i].Cells[5].Value = listPhieuNhap[i].TongTien.ToString() + " đ";
                phieuNhapDataGridView.Rows[i].Cells[6].Value = listPhieuNhap[i].TrangThai;
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string trangThai = "";
            string tuyChonThoiGian = "";
            DateTime? thoiGian = null;
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();
            if (tuyChonThoiGianComboBox.SelectedItem != null)
                tuyChonThoiGian = tuyChonThoiGianComboBox.SelectedItem.ToString();
            if (thoiGianDateTimePicker.Checked)
                thoiGian = thoiGianDateTimePicker.Value;

            if (!(tuKhoa == "" && trangThai == "" && string.IsNullOrEmpty(tuyChonThoiGian) && !thoiGianDateTimePicker.Checked))
            {

                listPhieuNhap = phieuNhapBUS.TimKiemPhieuNhap(tuKhoa, "", tuyChonThoiGian, thoiGian, trangThai);
                LoadDataToDataGridView(listPhieuNhap);
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
            trangThaiComboBox.SelectedIndex = -1;
            tuyChonThoiGianComboBox.SelectedIndex = -1;
            thoiGianDateTimePicker.Checked = false;
            listPhieuNhap = phieuNhapBUS.LayTatCaPhieuNhap().Where(phieuNhap => (phieuNhap.TrangThai != "Không duyệt")).ToList(); ;
            LoadDataToDataGridView(listPhieuNhap);
        }

        private void XuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelPhieuNhap(listPhieuNhap);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PhieuNhapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PhieuNhap phieuNhap = phieuNhapBUS.TimKiemPhieuNhap("", phieuNhapDataGridView["maPhieuNhapColumn", e.RowIndex].Value.ToString(), "", null, "")[0];

                string columnName = phieuNhapDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("chiTietButtonColumn"))
                {
                    new ChiTietPhieuNhapForm(phieuNhap.MaPhieuNhap, this).ShowDialog();
                }
            }
        }

        
    }
}
