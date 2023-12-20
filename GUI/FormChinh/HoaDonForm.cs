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
    public partial class HoaDonForm : Form
    {
        HoaDonBUS hoaDonBUS;
        List<HoaDon> listHoaDon;
        public HoaDonForm()
        {
            InitializeComponent();

            hoaDonBUS = new();
            listHoaDon = hoaDonBUS.LayTatCaHoaDon();
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listHoaDon);
        }

        private void LoadDataToDataGridView(List<HoaDon> listHoaDon)
        {
            hoaDonDataGridView.Rows.Clear();

            for (int i = 0; i < listHoaDon.Count; i++)
            {
                hoaDonDataGridView.Rows.Add(1);
                hoaDonDataGridView.Rows[i].Cells[0].Value = i + 1;
                hoaDonDataGridView.Rows[i].Cells[1].Value = listHoaDon[i].MaHoaDon;
                hoaDonDataGridView.Rows[i].Cells[2].Value = listHoaDon[i].MaNguoiTao;
                hoaDonDataGridView.Rows[i].Cells[3].Value = listHoaDon[i].ThoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
                hoaDonDataGridView.Rows[i].Cells[4].Value = listHoaDon[i].ThanhTien.ToString("0") + " đ";
                hoaDonDataGridView.Rows[i].Cells[5].Value = listHoaDon[i].GiamGia.ToString("0") + " đ";
                hoaDonDataGridView.Rows[i].Cells[6].Value = listHoaDon[i].TongTien.ToString("0") + " đ";
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string tuyChonThoiGian = "";
            DateTime? thoiGian = null;
            if (tuyChonThoiGianComboBox.SelectedItem != null)
                tuyChonThoiGian = tuyChonThoiGianComboBox.SelectedItem.ToString();
            if (thoiGianTaoDateTimePicker.Checked)
                thoiGian = thoiGianTaoDateTimePicker.Value;

            if (!(tuKhoa == "" && string.IsNullOrEmpty(tuyChonThoiGian) && !thoiGianTaoDateTimePicker.Checked))
            {

                listHoaDon = hoaDonBUS.TimKiemHoaDon(tuKhoa, "", tuyChonThoiGian, thoiGian);
                LoadDataToDataGridView(listHoaDon);
            }
        }

        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            TimKiemButton_Click(sender, e);
        }

        private void TuyChonThoiGianComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (thoiGianTaoDateTimePicker.Checked)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        private void ThoiGianTaoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (thoiGianTaoDateTimePicker.Checked)
            {
                timKiemTextBox.Clear();
                TimKiemButton_Click(sender, e);
            }
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            tuyChonThoiGianComboBox.SelectedIndex = -1;
            thoiGianTaoDateTimePicker.Checked = false;
            listHoaDon = hoaDonBUS.LayTatCaHoaDon();
            LoadDataToDataGridView(listHoaDon);
        }

        private void XuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelHoaDon(listHoaDon);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HoaDonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                HoaDon hoaDon = hoaDonBUS.TimKiemHoaDon("", hoaDonDataGridView["maHoaDonColumn", e.RowIndex].Value.ToString(), "", null)[0];

                string columnName = hoaDonDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("chiTietButtonColumn"))
                {
                    new ChiTietHoaDonForm(hoaDon.MaHoaDon).ShowDialog();
                }
            }
        }
    }
}
