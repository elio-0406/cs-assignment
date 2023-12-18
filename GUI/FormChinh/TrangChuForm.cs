using BUS;
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
    public partial class TrangChuForm : Form
    {
        Form currentChildForm;

        public TrangChuForm()
        {
            InitializeComponent();
        }

        private void TrangChuForm_Load(object sender, EventArgs e)
        {
            HienThiTheoPhanQuyen();

            tenNguoiDungLabel.Text = DangNhapForm.nguoiDung.HoTen;
            phanQuyenLabel.Text = new PhanQuyenBUS().TimKiemPhanQuyen("", DangNhapForm.nguoiDung.MaPhanQuyen)[0].TenPhanQuyen;
        }

        private void HienThiTheoPhanQuyen()
        {
            switch (DangNhapForm.nguoiDung.MaPhanQuyen)
            {
                case "PQ01":
                    phanQuyenButton.Visible = true;
                    nguoiDungButton.Visible = true;
                    break;

                case "PQ02":
                    sanPhamButton.Visible = true;
                    loaiSanPhamButton.Visible = true;
                    nhaCungCapButton.Visible = true;
                    khuyenMaiButton.Visible = true;
                    khachHangButton.Visible = true;
                    phieuNhapButton.Visible = true;
                    hoaDonButton.Visible = true;
                    break;

                case "PQ03":
                    banHangButton.Visible = true;
                    sanPhamButton.Visible = true;
                    loaiSanPhamButton.Visible = true;
                    khachHangButton.Visible = true;
                    khuyenMaiButton.Visible = true;
                    hoaDonButton.Visible = true;
                    break;

                case "PQ04":
                    taoPhieuNhapButton.Visible = true;
                    sanPhamButton.Visible = true;
                    loaiSanPhamButton.Visible = true;
                    nhaCungCapButton.Visible = true;
                    phieuNhapButton.Visible = true;
                    break;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm?.Hide();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DangXuatButton_Click(object sender, EventArgs e)
        {
            FormCollection allForms = Application.OpenForms;

            foreach (Form form in allForms)
            {
                if (form is DangNhapForm form1 && !form.Visible)
                {
                    form1.tenDangNhapTextBox.Clear();
                    form1.matKhauTextBox.Clear();
                    form1.Show();
                    Close();
                }
            }
        }

        private void DongCacFormHienTai()
        {
            FormCollection allForms = Application.OpenForms;

            foreach (Form form in allForms)
            {
                if (form !is DangNhapForm && form !is TrangChuForm)
                {
                    Close();
                }
            }
        }

        private void PhanQuyenButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Quản lý phân quyền";
            OpenChildForm(new PhanQuyenForm());
        }

        private void NguoiDungButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Quản lý người dùng";
            OpenChildForm(new NguoiDungForm());
        }

        private void LoaiSanPhamButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Quản lý loại sản phẩm";
            OpenChildForm(new LoaiSanPhamForm());
        }

        private void SanPhamButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Quản lý sản phẩm";
            OpenChildForm(new SanPhamForm());
        }

        private void NhaCungCapButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Quản lý nhà cung cấp";
            OpenChildForm(new NhaCungCapForm());
        }

        private void PhieuNhapButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Quản lý phiếu nhập";
            OpenChildForm(new PhieuNhapForm());
        }

        private void KhachHangButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Quản lý khách hàng";
            OpenChildForm(new KhachHangForm());
        }

        private void KhuyenMaiButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Quản lý khuyến mãi";
            OpenChildForm(new KhuyenMaiForm());
        }

        private void BanHangButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Bán hàng";
            OpenChildForm(new BanHangForm());
        }

        private void TaoPhieuNhapButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Tạo phiếu nhập";
            OpenChildForm(new TaoPhieuNhapForm());
        }

        private void HoaDonButton_Click(object sender, EventArgs e)
        {
            DongCacFormHienTai();
            tieuDeFormLabel.Text = "Quản lý hóa đơn";
            OpenChildForm(new HoaDonForm());
        }
    }
}
