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
    public partial class ChonNhaCungCapForm : Form
    {
        NhaCungCapBUS nhaCungCapBUS;
        List<NhaCungCap> listNhaCungCap;
        TaoPhieuNhapForm taoPhieuNhapForm;

        public ChonNhaCungCapForm(TaoPhieuNhapForm taoPhieuNhapForm)
        {
            InitializeComponent();

            nhaCungCapBUS = new NhaCungCapBUS();
            listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap("", "", "Đang hợp tác");
            this.taoPhieuNhapForm = taoPhieuNhapForm;
        }

        private void ChonNhaCungCapForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listNhaCungCap);
        }

        private void LoadDataToDataGridView(List<NhaCungCap> listNhaCungCap)
        {
            nhaCungCapDataGridView.Rows.Clear();

            for (int i = 0; i < listNhaCungCap.Count; i++)
            {
                nhaCungCapDataGridView.Rows.Add(1);
                nhaCungCapDataGridView.Rows[i].Cells[0].Value = listNhaCungCap[i].MaNhaCungCap;
                nhaCungCapDataGridView.Rows[i].Cells[1].Value = listNhaCungCap[i].TenNhaCungCap;
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap(tuKhoa, "", "");
            LoadDataToDataGridView(listNhaCungCap);
        }

        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            TimKiemButton_Click(sender, e);
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap("", "", "Đang hợp tác");
            LoadDataToDataGridView(listNhaCungCap);
        }

        private void NhaCungCapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NhaCungCap nhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap("",nhaCungCapDataGridView["maNhaCungCapColumn", e.RowIndex].Value.ToString(), "")[0];

                string columnName = nhaCungCapDataGridView.Columns[e.ColumnIndex].Name;
                if (columnName.Equals("chonButtonColumn"))
                {
                    if (taoPhieuNhapForm != null)
                    {
                        taoPhieuNhapForm.nhaCungCap = nhaCungCap;
                        taoPhieuNhapForm.maNhaCungCapLabel.Text = nhaCungCap.MaNhaCungCap;
                        taoPhieuNhapForm.tenNhaCungCapLabel.Text = nhaCungCap.TenNhaCungCap;
                        Close();
                    }
                }
            }
        }
    }
}
