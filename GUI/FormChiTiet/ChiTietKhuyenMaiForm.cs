using BUS;
using BUS.ChucNangKhac;
using DTO;
using GUI.FormChinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormChiTiet
{
    public partial class ChiTietKhuyenMaiForm : Form
    {
        string context;
        KhuyenMaiBUS khuyenMaiBUS;
        KhuyenMai khuyenMai;
        KhuyenMaiForm khuyenMaiForm;

        public ChiTietKhuyenMaiForm(string context, KhuyenMai khuyenMai, KhuyenMaiForm khuyenMaiForm)
        {
            InitializeComponent();
            CenterToParent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            this.context = context;
            this.khuyenMai = khuyenMai;
            this.khuyenMaiForm = khuyenMaiForm;
        }

        public ChiTietKhuyenMaiForm(string context, KhuyenMaiForm khuyenMaiForm)
        {
            InitializeComponent();
            CenterToParent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            this.context = context;
            this.khuyenMaiForm = khuyenMaiForm;
        }

        private void ChiTietKhuyenMaiForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết khuyến mãi";
                    maKhuyenMaiTextBox.Text = khuyenMai.MaKhuyenMai;
                    tenKhuyenMaiTextBox.Text = khuyenMai.TenKhuyenMai;
                    if (khuyenMai.LoaiGiaTri.Equals("Phần trăm"))
                        phanTramRadioButton.Checked = true;
                    if (khuyenMai.LoaiGiaTri.Equals("Cụ thể"))
                        cuTheRadioButton.Checked = true;
                    giaTriTextBox.Text = khuyenMai.GiaTri.ToString();
                    ngayBatDauDateTimePicker.Value = khuyenMai.ThoiGianBatDau;
                    ngayKetThucDateTimePicker.Value = khuyenMai.ThoiGianKetThuc;
                    gioBatDauDateTimePicker.Value = khuyenMai.ThoiGianBatDau;
                    gioKetThucDateTimePicker.Value = khuyenMai.ThoiGianKetThuc;

                    maKhuyenMaiTextBox.ReadOnly = true;
                    tenKhuyenMaiTextBox.ReadOnly = true;
                    phanTramRadioButton.Enabled = false;
                    cuTheRadioButton.Enabled = false;
                    giaTriTextBox.ReadOnly = true;
                    ngayBatDauDateTimePicker.Enabled = false;
                    ngayKetThucDateTimePicker.Enabled = false;
                    gioBatDauDateTimePicker.Enabled = false;
                    gioKetThucDateTimePicker.Enabled = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    Height -= huyBoButton.Height;
                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm khuyến mãi";
                    maKhuyenMaiTextBox.Text = TaoMaTuDong.TaoMaKhuyenMai();
                    ngayBatDauDateTimePicker.Value = DateTime.Now;
                    ngayKetThucDateTimePicker.Value = DateTime.Now;
                    gioBatDauDateTimePicker.Value = DateTime.Now;
                    gioKetThucDateTimePicker.Value = DateTime.Now;

                    ngayBatDauDateTimePicker.MinDate = DateTime.Now;
                    ngayKetThucDateTimePicker.MinDate = DateTime.Now;

                    maKhuyenMaiTextBox.ReadOnly = true;
                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin khuyến mãi";
                    maKhuyenMaiTextBox.Text = khuyenMai.MaKhuyenMai;
                    tenKhuyenMaiTextBox.Text = khuyenMai.TenKhuyenMai;
                    if (khuyenMai.LoaiGiaTri.Equals("Phần trăm"))
                        phanTramRadioButton.Checked = true;
                    if (khuyenMai.LoaiGiaTri.Equals("Cụ thể"))
                        cuTheRadioButton.Checked = true;
                    giaTriTextBox.Text = khuyenMai.GiaTri.ToString();
                    ngayBatDauDateTimePicker.Value = khuyenMai.ThoiGianBatDau;
                    ngayKetThucDateTimePicker.Value = khuyenMai.ThoiGianKetThuc;
                    gioBatDauDateTimePicker.Value = khuyenMai.ThoiGianBatDau;
                    gioKetThucDateTimePicker.Value = khuyenMai.ThoiGianKetThuc;

                    maKhuyenMaiTextBox.ReadOnly = true;
                    //Nếu đang diễn ra thì chỉ được sửa thời gian kết thúc
                    if (khuyenMai.ThoiGianBatDau < DateTime.Now && khuyenMai.ThoiGianKetThuc > DateTime.Now)
                    {
                        ngayBatDauDateTimePicker.Enabled = false;
                        gioBatDauDateTimePicker.Enabled = false;
                    }
                    //Nếu đã kết thúc thì không được sửa thời gian
                    if (khuyenMai.ThoiGianKetThuc < DateTime.Now)
                    {
                        ngayBatDauDateTimePicker.Enabled = false;
                        gioBatDauDateTimePicker.Enabled = false;
                        ngayKetThucDateTimePicker.Enabled = false;
                        gioKetThucDateTimePicker.Enabled = false;
                    }
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
                    tenKhuyenMaiTextBox.Text = khuyenMai.TenKhuyenMai;
                    if (khuyenMai.LoaiGiaTri.Equals("Phần trăm"))
                        phanTramRadioButton.Checked = true;
                    if (khuyenMai.LoaiGiaTri.Equals("Cụ thể"))
                        cuTheRadioButton.Checked = true;
                    giaTriTextBox.Text = khuyenMai.GiaTri.ToString();
                    ngayBatDauDateTimePicker.Value = khuyenMai.ThoiGianBatDau;
                    ngayKetThucDateTimePicker.Value = khuyenMai.ThoiGianKetThuc;
                    gioBatDauDateTimePicker.Value = khuyenMai.ThoiGianBatDau;
                    gioKetThucDateTimePicker.Value = khuyenMai.ThoiGianKetThuc;
                }
                
                if (context.Equals("Thêm"))
                {
                    tenKhuyenMaiTextBox.Clear();
                    phanTramRadioButton.Checked = false;
                    cuTheRadioButton.Checked = false;
                    giaTriTextBox.Text = "0";
                    ngayBatDauDateTimePicker.Value = DateTime.Now;
                    ngayKetThucDateTimePicker.Value = DateTime.Now;
                    gioBatDauDateTimePicker.Value = DateTime.Now;
                    gioKetThucDateTimePicker.Value = DateTime.Now;
                }
            }
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin khuyến mãi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                KhuyenMai khuyenMai = new();
                khuyenMai.MaKhuyenMai = maKhuyenMaiTextBox.Text;
                khuyenMai.TenKhuyenMai = tenKhuyenMaiTextBox.Text;
                if (phanTramRadioButton.Checked)
                    khuyenMai.LoaiGiaTri = "Phần trăm";
                if (cuTheRadioButton.Checked)
                    khuyenMai.LoaiGiaTri = "Cụ thể";
                khuyenMai.GiaTri = float.Parse(giaTriTextBox.Text);
                DateTime ngayBatDau = DateTime.ParseExact(ngayBatDauDateTimePicker.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime gioBatDau = DateTime.ParseExact(gioBatDauDateTimePicker.Value.ToString("HH:mm:ss"), "HH:mm:ss", CultureInfo.InvariantCulture);
                khuyenMai.ThoiGianBatDau = ngayBatDau.Add(new TimeSpan(gioBatDau.Hour, gioBatDau.Minute, gioBatDau.Second));
                DateTime ngayKetThuc = DateTime.ParseExact(ngayKetThucDateTimePicker.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime gioKetThuc = DateTime.ParseExact(gioKetThucDateTimePicker.Value.ToString("HH:mm:ss"), "HH:mm:ss", CultureInfo.InvariantCulture);
                khuyenMai.ThoiGianKetThuc = ngayKetThuc.Add(new TimeSpan(gioKetThuc.Hour, gioKetThuc.Minute, gioKetThuc.Second));

                string message = "";
                if (context.Equals("Thêm"))
                    message = khuyenMaiBUS.ThemKhuyenMai(khuyenMai);
                if (context.Equals("Sửa"))
                    message = khuyenMaiBUS.SuaKhuyenMai(khuyenMai);
                MessageBox.Show(message);
                if (message.Equals("Thêm khuyến mãi thành công!") || message.Equals("Chỉnh sửa thông tin khuyến mãi thành công!"))
                {
                    khuyenMaiForm.LamMoiButton_Click(sender, e);
                    Close();
                }
            }
        }

        private void GiaTriTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GiaTriTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(giaTriTextBox.Text))
                giaTriTextBox.Text = "0";
        }
    }
}
