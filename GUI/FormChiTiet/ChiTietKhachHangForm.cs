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
    public partial class ChiTietKhachHangForm : Form
    {
        string context;
        KhachHangBUS khachHangBUS;
        KhachHang khachHang;
        KhachHangForm khachHangForm;

        public ChiTietKhachHangForm(string context, KhachHang khachHang, KhachHangForm khachHangForm)
        {
            InitializeComponent();

            khachHangBUS = new KhachHangBUS();
            this.context = context;
            this.khachHang = khachHang;
            this.khachHangForm = khachHangForm;
        }

        public ChiTietKhachHangForm(string context, KhachHangForm khachHangForm)
        {
            InitializeComponent();

            khachHangBUS = new KhachHangBUS();
            this.context = context;
            this.khachHangForm = khachHangForm;
        }

        private void ChiTietKhachHangForm_Load(object sender, EventArgs e)
        {
            trangThaiComboBox.SelectedIndex = 0;

            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết khách hàng";
                    maKhachHangTextBox.Text = khachHang.MaKhachHang;
                    hoTenTextBox.Text = khachHang.HoTen;
                    soDienThoaiTextBox.Text = khachHang.SoDienThoai;
                    diemThanhVienTextBox.Text = khachHang.DiemThanhVien.ToString();
                    hangThanhVienTextBox.Text = khachHang.HangThanhVien;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(khachHang.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maKhachHangTextBox.ReadOnly = true;
                    hoTenTextBox.ReadOnly = true;
                    soDienThoaiTextBox.ReadOnly = true;
                    diemThanhVienTextBox.ReadOnly = true;
                    hangThanhVienTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    Height -= huyBoButton.Height;
                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm khách hàng";
                    maKhachHangTextBox.Text = TaoMaTuDong.TaoMaKhachHang();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Đang hoạt động"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maKhachHangTextBox.ReadOnly = true;
                    diemThanhVienTextBox.ReadOnly = true;
                    hangThanhVienTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin khách hàng";
                    maKhachHangTextBox.Text = khachHang.MaKhachHang;
                    hoTenTextBox.Text = khachHang.HoTen;
                    soDienThoaiTextBox.Text = khachHang.SoDienThoai;
                    diemThanhVienTextBox.Text = khachHang.DiemThanhVien.ToString();
                    hangThanhVienTextBox.Text = khachHang.HangThanhVien;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(khachHang.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maKhachHangTextBox.ReadOnly = true;
                    diemThanhVienTextBox.ReadOnly = true;
                    hangThanhVienTextBox.ReadOnly = true;
                    if (!trangThaiComboBox.SelectedItem.ToString().Equals("Ngừng hoạt động"))
                        trangThaiComboBox.Enabled = false;
                    break;
            }
        }

        private void HuyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    hoTenTextBox.Text = khachHang.HoTen;
                    soDienThoaiTextBox.Text = khachHang.SoDienThoai;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(khachHang.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                }

                if (context.Equals("Thêm"))
                {
                    hoTenTextBox.Clear();
                    soDienThoaiTextBox.Clear();
                }
            }
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin khách hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                KhachHang khachHang = new();
                khachHang.MaKhachHang = maKhachHangTextBox.Text;
                khachHang.HoTen = hoTenTextBox.Text;
                khachHang.SoDienThoai = soDienThoaiTextBox.Text;
                khachHang.TrangThai = trangThaiComboBox.SelectedItem.ToString();

                string message = "";
                if (context.Equals("Thêm"))
                    message = khachHangBUS.ThemKhachHang(khachHang);
                if (context.Equals("Sửa"))
                    message = khachHangBUS.SuaKhachHang(khachHang);
                MessageBox.Show(message);
                if (message.Equals("Thêm khách hàng thành công!") || message.Equals("Chỉnh sửa thông tin khách hàng thành công!"))
                {
                    if (khachHangForm != null)
                    {
                        khachHangForm.LamMoiButton_Click(sender, e);
                        Close();
                    }
                }
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
