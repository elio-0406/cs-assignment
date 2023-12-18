using BUS;
using BUS.ChucNangKhac;
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
    public partial class ChiTietNguoiDungForm : Form
    {
        string context;
        NguoiDungBUS nguoiDungBUS;
        NguoiDung nguoiDung;
        NguoiDungForm nguoiDungForm;

        public ChiTietNguoiDungForm(string context, NguoiDung nguoiDung, NguoiDungForm nguoiDungForm)
        {
            InitializeComponent();

            nguoiDungBUS = new();
            this.context = context;
            this.nguoiDung = nguoiDung;
            this.nguoiDungForm = nguoiDungForm;
        }

        public ChiTietNguoiDungForm(string context, NguoiDungForm nguoiDungForm)
        {
            InitializeComponent();

            nguoiDungBUS = new();
            this.context = context;
            this.nguoiDungForm = nguoiDungForm;
        }

        private void ChiTietNguoiDungForm_Load(object sender, EventArgs e)
        {
            phanQuyenComboBox.DataSource = new PhanQuyenBUS().LayTatCaPhanQuyen();
            phanQuyenComboBox.DisplayMember = "TenPhanQuyen";
            phanQuyenComboBox.SelectedIndex = -1;
            trangThaiComboBox.SelectedIndex = 0;

            switch (context)
            {
                case "Chi tiết":
                    maNguoiDungTextBox.Text = nguoiDung.MaNguoiDung;
                    foreach (var item in phanQuyenComboBox.Items)
                    {
                        PhanQuyen phanQuyen = item as PhanQuyen;

                        if (phanQuyen.MaPhanQuyen.Equals(nguoiDung.MaPhanQuyen))
                        {
                            phanQuyenComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    tenDangNhapTextBox.Text = nguoiDung.TenDangNhap;
                    matKhauTextBox.Text = nguoiDung.MatKhau;
                    hoTenTextBox.Text = nguoiDung.HoTen;
                    if (nguoiDung.GioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    if (nguoiDung.GioiTinh.Equals("Nữ"))
                        nuRadioButton.Checked = true;
                    if (nguoiDung.NgaySinh.HasValue)
                        ngaySinhDateTimePicker.Value = nguoiDung.NgaySinh.Value;
                    else
                        ngaySinhDateTimePicker.Checked = false;
                    soDienThoaiTextBox.Text = nguoiDung.SoDienThoai;
                    emailTextBox.Text = nguoiDung.Email;
                    diaChiTextBox.Text = nguoiDung.DiaChi;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(nguoiDung.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maNguoiDungTextBox.ReadOnly = true;
                    phanQuyenComboBox.Enabled = false;
                    tenDangNhapTextBox.ReadOnly = true;
                    matKhauTextBox.ReadOnly = true;
                    hoTenTextBox.ReadOnly = true;
                    namRadioButton.Enabled = false;
                    nuRadioButton.Enabled = false;
                    ngaySinhDateTimePicker.Enabled = false;
                    soDienThoaiTextBox.ReadOnly = true;
                    emailTextBox.ReadOnly = true;
                    diaChiTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;
                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm người dùng";
                    ngaySinhDateTimePicker.Checked = false;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Đang hoạt động"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maNguoiDungTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa người dùng";
                    maNguoiDungTextBox.Text = nguoiDung.MaNguoiDung;
                    foreach (var item in phanQuyenComboBox.Items)
                    {
                        PhanQuyen phanQuyen = item as PhanQuyen;

                        if (phanQuyen.MaPhanQuyen.Equals(nguoiDung.MaPhanQuyen))
                        {
                            phanQuyenComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    tenDangNhapTextBox.Text = nguoiDung.TenDangNhap;
                    matKhauTextBox.Text = nguoiDung.MatKhau;
                    hoTenTextBox.Text = nguoiDung.HoTen;
                    if (nguoiDung.GioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    if (nguoiDung.GioiTinh.Equals("Nữ"))
                        nuRadioButton.Checked = true;
                    if (nguoiDung.NgaySinh.HasValue)
                        ngaySinhDateTimePicker.Value = nguoiDung.NgaySinh.Value;
                    else
                        ngaySinhDateTimePicker.Checked = false;
                    soDienThoaiTextBox.Text = nguoiDung.SoDienThoai;
                    emailTextBox.Text = nguoiDung.Email;
                    diaChiTextBox.Text = nguoiDung.DiaChi;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(nguoiDung.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maNguoiDungTextBox.ReadOnly = true;
                    phanQuyenComboBox.Enabled = false;
                    trangThaiComboBox.Enabled = false;
                    break;
            }
        }

        private void PhanQuyenComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (phanQuyenComboBox.SelectedValue != null)
            {
                PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                maNguoiDungTextBox.Text = TaoMaTuDong.TaoMaNguoiDung(phanQuyen.MaPhanQuyen);
            }
        }

        private void HuyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    tenDangNhapTextBox.Text = nguoiDung.TenDangNhap;
                    matKhauTextBox.Text = nguoiDung.MatKhau;
                    hoTenTextBox.Text = nguoiDung.HoTen;
                    if (nguoiDung.GioiTinh.Equals("Nam"))
                        namRadioButton.Checked = true;
                    if (nguoiDung.GioiTinh.Equals("Nữ"))
                        nuRadioButton.Checked = true;
                    if (nguoiDung.NgaySinh.HasValue)
                        ngaySinhDateTimePicker.Value = nguoiDung.NgaySinh.Value;
                    else
                        ngaySinhDateTimePicker.Checked = false;
                    soDienThoaiTextBox.Text = nguoiDung.SoDienThoai;
                    emailTextBox.Text = nguoiDung.Email;
                    diaChiTextBox.Text = nguoiDung.DiaChi;
                }

                if (context.Equals("Thêm"))
                {
                    maNguoiDungTextBox.Clear();
                    tenDangNhapTextBox.Clear();
                    matKhauTextBox.Clear();
                    hoTenTextBox.Clear();
                    soDienThoaiTextBox.Clear();
                    emailTextBox.Clear();
                    diaChiTextBox.Clear();
                    phanQuyenComboBox.SelectedItem = null;
                    phanQuyenComboBox.SelectedIndex = -1;
                    namRadioButton.Checked = false;
                    nuRadioButton.Checked = false;
                    ngaySinhDateTimePicker.Checked = false;
                }
            }
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin người dùng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NguoiDung nguoiDung = new();
                nguoiDung.MaNguoiDung = maNguoiDungTextBox.Text;
                if (phanQuyenComboBox.SelectedValue != null)
                {
                    PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                    nguoiDung.MaPhanQuyen = phanQuyen.MaPhanQuyen;
                }
                nguoiDung.TenDangNhap = tenDangNhapTextBox.Text;
                nguoiDung.MatKhau = matKhauTextBox.Text;
                nguoiDung.HoTen = hoTenTextBox.Text;
                if (namRadioButton.Checked)
                    nguoiDung.GioiTinh = namRadioButton.Text;
                if (nuRadioButton.Checked)
                    nguoiDung.GioiTinh = nuRadioButton.Text;
                if (ngaySinhDateTimePicker.Checked)
                    nguoiDung.NgaySinh = ngaySinhDateTimePicker.Value;
                nguoiDung.SoDienThoai = soDienThoaiTextBox.Text;
                nguoiDung.Email = emailTextBox.Text;
                nguoiDung.DiaChi = diaChiTextBox.Text;
                nguoiDung.TrangThai = trangThaiComboBox.SelectedItem.ToString();

                string message = "";
                if (context.Equals("Thêm"))
                    message = nguoiDungBUS.ThemNguoiDung(nguoiDung);
                if (context.Equals("Sửa"))
                    message = nguoiDungBUS.SuaNguoiDung(nguoiDung);
                MessageBox.Show(message);
                if (message.Equals("Thêm người dùng thành công!") || message.Equals("Chỉnh sửa thông tin người dùng thành công!"))
                {
                    nguoiDungForm?.LamMoiButton_Click(sender, e);
                    Close();
                }
            }
        }

        private void TenDangNhapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < 32 || e.KeyChar > 126 || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void MatKhauTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < 32 || e.KeyChar > 126 || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void MatKhauTextBox_MouseLeave(object sender, EventArgs e)
        {
            matKhauTextBox.UseSystemPasswordChar = true;
        }

        private void MatKhauTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            matKhauTextBox.UseSystemPasswordChar = false;
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < 32 || e.KeyChar > 126 || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void SoDienThoaiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
