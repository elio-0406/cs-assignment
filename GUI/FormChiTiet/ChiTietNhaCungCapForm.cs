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
    public partial class ChiTietNhaCungCapForm : Form
    {
        string context;
        NhaCungCapBUS nhaCungCapBUS;
        NhaCungCap nhaCungCap;
        NhaCungCapForm nhaCungCapForm;

        public ChiTietNhaCungCapForm(string context, NhaCungCap nhaCungCap, NhaCungCapForm nhaCungCapForm)
        {
            InitializeComponent();

            this.nhaCungCapBUS = new();
            this.context = context;
            this.nhaCungCap = nhaCungCap;
            this.nhaCungCapForm = nhaCungCapForm;
        }

        public ChiTietNhaCungCapForm(string context, NhaCungCapForm nhaCungCapForm)
        {
            InitializeComponent();

            this.nhaCungCapBUS = new();
            this.context = context;
            this.nhaCungCapForm = nhaCungCapForm;
        }

        private void ChiTietNhaCungCapForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết nhà cung cấp";
                    maNhaCungCapTextBox.Text = nhaCungCap.MaNhaCungCap;
                    tenNhaCungCapTextBox.Text = nhaCungCap.TenNhaCungCap;
                    soDienThoaiTextBox.Text = nhaCungCap.SoDienThoai;
                    emailTextBox.Text = nhaCungCap.Email;
                    diaChiTextBox.Text = nhaCungCap.DiaChi;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(nhaCungCap.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maNhaCungCapTextBox.ReadOnly = true;
                    tenNhaCungCapTextBox.ReadOnly = true;
                    soDienThoaiTextBox.ReadOnly = true;
                    emailTextBox.ReadOnly = true;
                    diaChiTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    luuButton.Visible = false;
                    huyBoButton.Visible = false;
                    this.Height -= huyBoButton.Height;
                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm nhà cung cấp";
                    maNhaCungCapTextBox.Text = TaoMaTuDong.TaoMaNhaCungCap();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Đang hợp tác"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maNhaCungCapTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin nhà cung cấp";
                    maNhaCungCapTextBox.Text = nhaCungCap.MaNhaCungCap;
                    tenNhaCungCapTextBox.Text = nhaCungCap.TenNhaCungCap;
                    soDienThoaiTextBox.Text = nhaCungCap.SoDienThoai;
                    emailTextBox.Text = nhaCungCap.Email;
                    diaChiTextBox.Text = nhaCungCap.DiaChi;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(nhaCungCap.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maNhaCungCapTextBox.ReadOnly = true;
                    if (!trangThaiComboBox.SelectedItem.ToString().Equals("Ngừng hợp tác"))
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
                    tenNhaCungCapTextBox.Text = nhaCungCap.TenNhaCungCap;
                    soDienThoaiTextBox.Text = nhaCungCap.SoDienThoai;
                    emailTextBox.Text = nhaCungCap.Email;
                    diaChiTextBox.Text = nhaCungCap.DiaChi;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(nhaCungCap.TrangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (context.Equals("Thêm"))
                {
                    tenNhaCungCapTextBox.Clear();
                    soDienThoaiTextBox.Clear();
                    emailTextBox.Clear();
                    diaChiTextBox.Clear();
                }
            }
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin nhà cung cấp không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                NhaCungCap nhaCungCap = new();
                nhaCungCap.MaNhaCungCap = maNhaCungCapTextBox.Text;
                nhaCungCap.TenNhaCungCap = tenNhaCungCapTextBox.Text;
                nhaCungCap.SoDienThoai = soDienThoaiTextBox.Text;
                nhaCungCap.Email = emailTextBox.Text;
                nhaCungCap.DiaChi = diaChiTextBox.Text;
                nhaCungCap.TrangThai = trangThaiComboBox.SelectedItem.ToString();

                string message = "";
                if (context.Equals("Thêm"))
                    message = nhaCungCapBUS.ThemNhaCungCap(nhaCungCap);
                if (context.Equals("Sửa"))
                    message = nhaCungCapBUS.SuaNhaCungCap(nhaCungCap);

                MessageBox.Show(message);

                if (message.Equals("Thêm nhà cung cấp thành công!") || message.Equals("Chỉnh sửa thông tin nhà cung cấp thành công!"))
                {
                    if (nhaCungCapForm != null)
                        nhaCungCapForm.LamMoiButton_Click(sender, e);

                    /*if (nhapHangForm != null)
                    {
                        nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoMa(maNhaCungCap);
                        nhapHangForm.nhaCungCap = nhaCungCap;
                        nhapHangForm.maNhaCungCapTextBox.Text = nhaCungCap.maNhaCungCap;
                        nhapHangForm.tenNhaCungCapTextBox.Text = nhaCungCap.tenNhaCungCap;
                        nhapHangForm.canhBaoLabel.Visible = false;
                    }*/
                    this.Close();
                }
            }
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
