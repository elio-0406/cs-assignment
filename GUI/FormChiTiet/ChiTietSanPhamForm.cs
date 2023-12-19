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
    public partial class ChiTietSanPhamForm : Form
    {
        string context;
        SanPhamBUS sanPhamBUS;
        SanPham sanPham;
        SanPhamForm sanPhamForm;
        List<LoaiSanPham> listLoaiSanPham;

        public ChiTietSanPhamForm(string context, SanPham sanPham, SanPhamForm sanPhamForm)
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            this.context = context;
            this.sanPham = sanPham;
            this.sanPhamForm = sanPhamForm;
        }

        public ChiTietSanPhamForm(string context, SanPhamForm sanPhamForm)
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            this.context = context;
            this.sanPhamForm = sanPhamForm;
        }

        private void ChiTietSanPhamForm_Load(object sender, EventArgs e)
        {
            listLoaiSanPham = new LoaiSanPhamBUS().TimKiemLoaiSanPham("", "", "Đang sử dụng");
            loaiSanPhamComboBox.DataSource = listLoaiSanPham;
            loaiSanPhamComboBox.DisplayMember = "tenLoaiSanPham";
            loaiSanPhamComboBox.SelectedIndex = -1;

            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết sản phẩm";
                    maSanPhamTextBox.Text = sanPham.MaSanPham;
                    tenSanPhamTextBox.Text = sanPham.TenSanPham;
                    foreach (var item in loaiSanPhamComboBox.Items)
                    {
                        LoaiSanPham loaiSanPham = item as LoaiSanPham;
                        if (loaiSanPham.MaLoaiSanPham.Equals(sanPham.MaLoaiSanPham))
                        {
                            loaiSanPhamComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    donViTinhTextBox.Text = sanPham.DonViTinh;
                    giaBanTextBox.Text = sanPham.GiaBan.ToString("0");
                    soLuongTextBox.Text = sanPham.SoLuong.ToString();
                    sanPhamPictureBox.Image = XuLyHinhAnh.DieuChinhKichThuoc(XuLyHinhAnh.ByteSangAnh(sanPham.Anh), sanPhamPictureBox.Width, sanPhamPictureBox.Height);
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(sanPham.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maSanPhamTextBox.ReadOnly = true;
                    tenSanPhamTextBox.ReadOnly = true;
                    loaiSanPhamComboBox.Enabled = false;
                    donViTinhTextBox.ReadOnly = true;
                    soLuongTextBox.ReadOnly = true;
                    giaBanTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    chonAnhButton.Visible = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;
                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm sản phẩm";
                    maSanPhamTextBox.Text = TaoMaTuDong.TaoMaSanPham();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Chờ xử lý"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maSanPhamTextBox.ReadOnly = true;
                    soLuongTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin sản phẩm";
                    maSanPhamTextBox.Text = sanPham.MaSanPham;
                    tenSanPhamTextBox.Text = sanPham.TenSanPham;
                    foreach (var item in loaiSanPhamComboBox.Items)
                    {
                        LoaiSanPham loaiSanPham = item as LoaiSanPham;
                        if (loaiSanPham.MaLoaiSanPham.Equals(sanPham.MaLoaiSanPham))
                        {
                            loaiSanPhamComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    donViTinhTextBox.Text = sanPham.DonViTinh;
                    giaBanTextBox.Text = sanPham.GiaBan.ToString("0");
                    soLuongTextBox.Text = sanPham.SoLuong.ToString();
                    sanPhamPictureBox.Image = XuLyHinhAnh.DieuChinhKichThuoc(XuLyHinhAnh.ByteSangAnh(sanPham.Anh), sanPhamPictureBox.Width, sanPhamPictureBox.Height);
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(sanPham.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    if (sanPham.TrangThai.Equals("Ngừng kinh doanh"))
                    {
                        foreach (var item in trangThaiComboBox.Items)
                        {
                            if (!item.ToString().Equals("Chờ xử lý"))
                                trangThaiComboBox.Items.Remove(item);
                        }
                    }

                    maSanPhamTextBox.ReadOnly = true;
                    soLuongTextBox.ReadOnly = true;
                    if (!trangThaiComboBox.SelectedItem.ToString().Equals("Ngừng kinh doanh"))
                        trangThaiComboBox.Enabled = false;
                    break;
            }
        }

        private void ChonAnhButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = new Bitmap(openFileDialog.FileName);
                sanPhamPictureBox.Image = XuLyHinhAnh.DieuChinhKichThuoc(selectedImage, sanPhamPictureBox.Width, sanPhamPictureBox.Height);
            }
        }

        private void HuyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    tenSanPhamTextBox.Text = sanPham.TenSanPham;
                    foreach (var item in loaiSanPhamComboBox.Items)
                    {
                        LoaiSanPham loaiSanPham = item as LoaiSanPham;
                        if (loaiSanPham.MaLoaiSanPham.Equals(sanPham.MaLoaiSanPham))
                        {
                            loaiSanPhamComboBox.SelectedItem = item;
                            break;
                        }
                    }
                    donViTinhTextBox.Text = sanPham.DonViTinh;
                    giaBanTextBox.Text = sanPham.GiaBan.ToString("0");
                    sanPhamPictureBox.Image = XuLyHinhAnh.DieuChinhKichThuoc(XuLyHinhAnh.ByteSangAnh(sanPham.Anh), sanPhamPictureBox.Width, sanPhamPictureBox.Height);
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(sanPham.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }

                if (context.Equals("Thêm"))
                {
                    tenSanPhamTextBox.Clear();
                    donViTinhTextBox.Clear();
                    giaBanTextBox.Text = "0";
                    loaiSanPhamComboBox.SelectedItem = null;
                    loaiSanPhamComboBox.SelectedIndex = -1;
                    sanPhamPictureBox.Image = null;
                }
            }
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SanPham sanPham = new();
                sanPham.MaSanPham = maSanPhamTextBox.Text;
                sanPham.TenSanPham = tenSanPhamTextBox.Text;
                if (loaiSanPhamComboBox.SelectedValue != null)
                {
                    LoaiSanPham loaiSanPham = loaiSanPhamComboBox.SelectedValue as LoaiSanPham;
                    sanPham.MaLoaiSanPham = loaiSanPham.MaLoaiSanPham;
                }
                sanPham.DonViTinh = donViTinhTextBox.Text;
                sanPham.GiaBan = decimal.Parse(giaBanTextBox.Text);
                sanPham.SoLuong = int.Parse(soLuongTextBox.Text);
                if (sanPhamPictureBox.Image != null)
                {
                    try
                    {
                        sanPham.Anh = XuLyHinhAnh.AnhSangByte(sanPhamPictureBox.Image);
                    }
                    catch
                    {
                        sanPham.Anh = sanPham.Anh;
                    }
                }
                sanPham.TrangThai = trangThaiComboBox.SelectedItem.ToString();

                string message = "";
                if (context.Equals("Thêm"))
                    message = sanPhamBUS.ThemSanPham(sanPham);
                if (context.Equals("Sửa"))
                    message = sanPhamBUS.SuaSanPham(sanPham);
                MessageBox.Show(message);
                if (message.Equals("Thêm sản phẩm thành công!") || message.Equals("Chỉnh sửa thông tin sản phẩm thành công!"))
                {
                    if (sanPhamForm != null)
                        sanPhamForm.LamMoiButton_Click(sender, e);
                    Close();
                }
            }
        }

        private void GiaBanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GiaBanTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(giaBanTextBox.Text))
                giaBanTextBox.Text = "0";
        }
    }
}
