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

namespace GUI.FormChiTiet
{
    public partial class ChiTietPhieuNhapForm : Form
    {
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS;
        PhieuNhapBUS phieuNhapBUS;
        PhieuNhap phieuNhap;
        PhieuNhapForm phieuNhapForm;
        internal List<ChiTietPhieuNhap> listChiTietPhieuNhap;

        public ChiTietPhieuNhapForm(string maPhieuNhap, PhieuNhapForm phieuNhapForm)
        {
            InitializeComponent();

            phieuNhapBUS = new PhieuNhapBUS();
            chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
            phieuNhap = phieuNhapBUS.TimKiemPhieuNhap("", maPhieuNhap, "", null, "")[0];
            listChiTietPhieuNhap = chiTietPhieuNhapBUS.LayChiTietPhieuNhapTheoPhieuNhap(maPhieuNhap);
            this.phieuNhapForm = phieuNhapForm;
        }

        private void ChiTietPhieuNhapForm_Load(object sender, EventArgs e)
        {
            maPhieuNhapTextBox.Text = phieuNhap.MaPhieuNhap;
            maNhaCungCapTextBox.Text = phieuNhap.MaNhaCungCap;
            maNguoiTaoTextBox.Text = phieuNhap.MaNguoiTao;
            maNguoiDuyetTextBox.Text = phieuNhap.MaNguoiDuyet;
            maNguoiNhapTextBox.Text = phieuNhap.MaNguoiNhap;
            thoiGianTaoTextBox.Text = phieuNhap.ThoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
            if (phieuNhap.ThoiGianDuyet.HasValue)
                thoiGianDuyetTextBox.Text = phieuNhap.ThoiGianDuyet?.ToString("dd/MM/yyyy HH:mm:ss");
            if (phieuNhap.ThoiGianNhap.HasValue)
                thoiGianNhapHangTextBox.Text = phieuNhap.ThoiGianNhap?.ToString("dd/MM/yyyy HH:mm:ss");
            thanhTienTextBox.Text = phieuNhap.TongTien.ToString("0") + " đ";
            trangThaiTextBox.Text = phieuNhap.TrangThai;

            maPhieuNhapTextBox.ReadOnly = true;
            maNhaCungCapTextBox.ReadOnly = true;
            maNguoiTaoTextBox.ReadOnly = true;
            maNguoiDuyetTextBox.ReadOnly = true;
            maNguoiNhapTextBox.ReadOnly = true;
            thoiGianTaoTextBox.ReadOnly = true;
            thoiGianDuyetTextBox.ReadOnly = true;
            thoiGianNhapHangTextBox.ReadOnly = true;
            thanhTienTextBox.ReadOnly = true;
            trangThaiTextBox.ReadOnly = true;

            if (!DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ02"))
            {
                duyetButton.Visible = false;
                khongDuyetButton.Visible = false;
                chiTietPhieuNhapDataGridView.Columns.Remove("suaButtonColumn");
            }


            if (!DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ04"))
            {
                nhapHangButton.Visible = false;
            }

            if (DangNhapForm.nguoiDung.MaPhanQuyen.Equals("PQ04") && !phieuNhap.TrangThai.Equals("Đã duyệt"))
            {
                nhapHangButton.Visible = false;
            }

            LoadDataToDataGridView(listChiTietPhieuNhap);
        }

        internal void LoadDataToDataGridView(List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            chiTietPhieuNhapDataGridView.Rows.Clear();

            for (int i = 0; i < listChiTietPhieuNhap.Count; i++)
            {
                chiTietPhieuNhapDataGridView.Rows.Add(1);
                chiTietPhieuNhapDataGridView.Rows[i].Cells[0].Value = listChiTietPhieuNhap[i].MaSanPham;
                chiTietPhieuNhapDataGridView.Rows[i].Cells[1].Value = listChiTietPhieuNhap[i].DonGia.ToString("0") + " đ";
                chiTietPhieuNhapDataGridView.Rows[i].Cells[2].Value = listChiTietPhieuNhap[i].SoLuong;
                chiTietPhieuNhapDataGridView.Rows[i].Cells[3].Value = listChiTietPhieuNhap[i].ThanhTien.ToString("0") + " đ";
            }
        }

        private void DuyetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn duyệt phiếu nhập này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                phieuNhap.TrangThai = "Đã duyệt";
                phieuNhap.MaNguoiDuyet = DangNhapForm.nguoiDung.MaNguoiDung;
                phieuNhap.ThoiGianDuyet = DateTime.Now;

                string message = phieuNhapBUS.DuyetPhieuNhap(phieuNhap, "Đã duyệt");
                MessageBox.Show(message);
                if (message.Equals("Duyệt phiếu nhập thành công!"))
                {
                    phieuNhapForm.LamMoiButton_Click(sender, e);
                    Close();
                }

                phieuNhap = phieuNhapBUS.TimKiemPhieuNhap("", phieuNhap.MaPhieuNhap, "", null, "")[0];
            }
        }

        private void KhongDuyetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn không duyệt phiếu nhập này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                phieuNhap.TrangThai = "Không duyệt";
                phieuNhap.MaNguoiDuyet = DangNhapForm.nguoiDung.MaNguoiDung;
                phieuNhap.ThoiGianDuyet = DateTime.Now;

                string message = phieuNhapBUS.DuyetPhieuNhap(phieuNhap, "Không duyệt");
                MessageBox.Show(message);
                phieuNhapForm.LamMoiButton_Click(sender, e);
                Close();
            }
        }

        private void NhapHangButton_Click(object sender, EventArgs e)
        {
            phieuNhap.TrangThai = "Đã nhập hàng";
            phieuNhap.MaNguoiNhap = DangNhapForm.nguoiDung.MaNguoiDung;
            phieuNhap.ThoiGianNhap = DateTime.Now;

            string message = phieuNhapBUS.NhapHang(phieuNhap);
            MessageBox.Show(message);

            if (message.Equals("Nhập hàng thành công!"))
            {
                phieuNhapForm.LamMoiButton_Click(sender, e);
                Close();
            }

            phieuNhap = phieuNhapBUS.TimKiemPhieuNhap("", phieuNhap.MaPhieuNhap, "", null, "")[0];
        }

        private void ChiTietPhieuNhapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = chiTietPhieuNhapBUS.LayChiTietPhieuNhap(phieuNhap.MaPhieuNhap, chiTietPhieuNhapDataGridView["maSanPhamColumn", e.RowIndex].Value.ToString());

                string columnName = chiTietPhieuNhapDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("suaButtonColumn"))
                {
                    new SuaChiTietPhieuNhapForm(chiTietPhieuNhap, this).ShowDialog();
                }
            }
        }
    }
}
