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
    public partial class ChiTietLoaiSanPhamForm : Form
    {
        string context;
        LoaiSanPhamBUS loaiSanPhamBUS;
        LoaiSanPham loaiSanPham;
        LoaiSanPhamForm loaiSanPhamForm;

        public ChiTietLoaiSanPhamForm(string context, LoaiSanPham loaiSanPham, LoaiSanPhamForm loaiSanPhamForm)
        {
            InitializeComponent();

            loaiSanPhamBUS = new();
            this.context = context;
            this.loaiSanPham = loaiSanPham;
            this.loaiSanPhamForm = loaiSanPhamForm;
        }

        public ChiTietLoaiSanPhamForm(string context, LoaiSanPhamForm loaiSanPhamForm)
        {
            InitializeComponent();

            loaiSanPhamBUS = new LoaiSanPhamBUS();
            this.context = context;
            this.loaiSanPhamForm = loaiSanPhamForm;
        }

        private void ChiTietLoaiSanPhamForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết loại sản phẩm";
                    maLoaiSanPhamTextBox.Text = loaiSanPham.MaLoaiSanPham;
                    tenLoaiSanPhamTextBox.Text = loaiSanPham.TenLoaiSanPham;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(loaiSanPham.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maLoaiSanPhamTextBox.ReadOnly = true;
                    tenLoaiSanPhamTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;
                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm loại sản phẩm";
                    maLoaiSanPhamTextBox.Text = TaoMaTuDong.TaoMaLoaiSanPham();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Đang sử dụng"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maLoaiSanPhamTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa loại sản phẩm";

                    maLoaiSanPhamTextBox.Text = loaiSanPham.MaLoaiSanPham;
                    tenLoaiSanPhamTextBox.Text = loaiSanPham.TenLoaiSanPham;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(loaiSanPham.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maLoaiSanPhamTextBox.ReadOnly = true;
                    if (!trangThaiComboBox.SelectedItem.ToString().Equals("Ngừng sử dụng"))
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
                    maLoaiSanPhamTextBox.Text = loaiSanPham.MaLoaiSanPham;
                    tenLoaiSanPhamTextBox.Text = loaiSanPham.TenLoaiSanPham;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(loaiSanPham.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }
                
                if (context.Equals("Thêm"))
                {
                    tenLoaiSanPhamTextBox.Clear();
                }
            }
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin loại sản phẩm không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                LoaiSanPham loaiSanPham = new()
                {
                    MaLoaiSanPham = maLoaiSanPhamTextBox.Text,
                    TenLoaiSanPham = tenLoaiSanPhamTextBox.Text,
                    TrangThai = trangThaiComboBox.SelectedItem.ToString()
                };

                string message = "";
                if (context.Equals("Thêm"))
                    message = loaiSanPhamBUS.ThemLoaiSanPham(loaiSanPham);
                if (context.Equals("Sửa"))
                    message = loaiSanPhamBUS.SuaLoaiSanPham(loaiSanPham);
                MessageBox.Show(message);
                if (message.Equals("Thêm loại sản phẩm thành công!") || message.Equals("Chỉnh sửa thông tin loại sản phẩm thành công!"))
                {
                    loaiSanPhamForm.LamMoiButton_Click(sender, e);
                    this.Close();
                }
            }
        }
    }
}
