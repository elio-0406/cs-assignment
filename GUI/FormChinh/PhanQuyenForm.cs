using BUS;
using BUS.ChucNangKhac;
using DTO;
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
    public partial class PhanQuyenForm : Form
    {
        PhanQuyenBUS phanQuyenBUS;
        List<PhanQuyen> listPhanQuyen;

        public PhanQuyenForm()
        {
            InitializeComponent();

            phanQuyenBUS = new PhanQuyenBUS();
            listPhanQuyen = phanQuyenBUS.LayTatCaPhanQuyen();
        }

        private void PhanQuyenForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listPhanQuyen);
        }

        private void LoadDataToDataGridView(List<PhanQuyen> listPhanQuyen)
        {
            phanQuyenDataGridView.Rows.Clear();

            for (int i = 0; i < listPhanQuyen.Count; i++)
            {
                phanQuyenDataGridView.Rows.Add(1);
                phanQuyenDataGridView.Rows[i].Cells[0].Value = i + 1;
                phanQuyenDataGridView.Rows[i].Cells[1].Value = listPhanQuyen[i].MaPhanQuyen;
                phanQuyenDataGridView.Rows[i].Cells[2].Value = listPhanQuyen[i].TenPhanQuyen;
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            listPhanQuyen = phanQuyenBUS.TimKiemPhanQuyen(tuKhoa);
            LoadDataToDataGridView(listPhanQuyen);
        }

        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            TimKiemButton_Click(sender, e);
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();

            listPhanQuyen = phanQuyenBUS.LayTatCaPhanQuyen();
            LoadDataToDataGridView(listPhanQuyen);
        }

        private void XuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                new XuatExcel(filePath).XuatExcelPhanQuyen(listPhanQuyen);

                MessageBox.Show("File Excel đã được tạo tại: " + filePath);
            }
        }
    }
}
