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
    public partial class ChonKhuyenMaiForm : Form
    {
        KhuyenMaiBUS khuyenMaiBUS;
        List<KhuyenMai> listKhuyenMai;
        BanHangForm banHangForm;

        public ChonKhuyenMaiForm(BanHangForm banHangForm)
        {
            InitializeComponent();

            khuyenMaiBUS = new();
            listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMai("", "", "", "", null, "Đang diễn ra");
            this.banHangForm = banHangForm;
        }

        private void ChonKhuyenMaiForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listKhuyenMai);
        }

        private void LoadDataToDataGridView(List<KhuyenMai> listKhuyenMai)
        {
            khuyenMaiDataGridView.Rows.Clear();

            for (int i = 0; i < listKhuyenMai.Count; i++)
            {
                khuyenMaiDataGridView.Rows.Add(1);
                khuyenMaiDataGridView.Rows[i].Cells[0].Value = listKhuyenMai[i].MaKhuyenMai;
                khuyenMaiDataGridView.Rows[i].Cells[1].Value = listKhuyenMai[i].TenKhuyenMai;
                khuyenMaiDataGridView.Rows[i].Cells[2].Value = listKhuyenMai[i].LoaiGiaTri;
                khuyenMaiDataGridView.Rows[i].Cells[3].Value = listKhuyenMai[i].GiaTri.ToString("0");
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMai(tuKhoa, "", "", "", null, "Đang diễn ra");
            LoadDataToDataGridView(listKhuyenMai);
        }

        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            TimKiemButton_Click(sender, e);
        }

        private void KhuyenMaiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KhuyenMai khuyenMai = khuyenMaiBUS.TimKiemKhuyenMai("", khuyenMaiDataGridView["maKhuyenMaiColumn", e.RowIndex].Value.ToString(), "", "", null, "")[0];

                string columnName = khuyenMaiDataGridView.Columns[e.ColumnIndex].Name;
                if (columnName.Equals("chonButtonColumn"))
                {
                    if (banHangForm != null)
                    {
                        banHangForm.khuyenMai = khuyenMai;
                        Close();
                    }
                }
            }
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMai("", "", "", "", null, "Đang diễn ra");
            LoadDataToDataGridView(listKhuyenMai);
        }

        private void ChonKhuyenMaiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            decimal thanhTien = decimal.Parse((banHangForm.thanhTienLabel.Text.Replace(" đ", "")));
            decimal giamGia = decimal.Parse((banHangForm.giamGiaLabel.Text.Replace(" đ", "")));

            if (banHangForm.khuyenMai != null)
            {
                banHangForm.tenKhuyenMaiLabel.Text = string.Empty;
                banHangForm.giamGiaLabel.Text = "0 đ";

                giamGia = new KhuyenMaiBUS().ApDungKhuyenMai(banHangForm.khuyenMai.MaKhuyenMai, thanhTien);
                banHangForm.giamGiaLabel.Text = giamGia.ToString("0") + " đ";
                banHangForm.tenKhuyenMaiLabel.Text = banHangForm.khuyenMai.TenKhuyenMai;
                banHangForm.khuyenMaiThanhVienCheckBox.Checked = false;
            }
        }
    }
}
