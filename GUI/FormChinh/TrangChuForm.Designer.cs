namespace GUI.FormChinh
{
    partial class TrangChuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            phanQuyenButton = new Button();
            nguoiDungButton = new Button();
            loaiSanPhamButton = new Button();
            sanPhamButton = new Button();
            nhaCungCapButton = new Button();
            phieuNhapButton = new Button();
            khachHangButton = new Button();
            khuyenMaiButton = new Button();
            banHangButton = new Button();
            taoPhieuNhapButton = new Button();
            hoaDonButton = new Button();
            panel5 = new Panel();
            dangXuatButton = new Button();
            panel4 = new Panel();
            phanQuyenLabel = new Label();
            tenNguoiDungLabel = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 712);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(phanQuyenButton);
            flowLayoutPanel1.Controls.Add(nguoiDungButton);
            flowLayoutPanel1.Controls.Add(loaiSanPhamButton);
            flowLayoutPanel1.Controls.Add(sanPhamButton);
            flowLayoutPanel1.Controls.Add(nhaCungCapButton);
            flowLayoutPanel1.Controls.Add(phieuNhapButton);
            flowLayoutPanel1.Controls.Add(khachHangButton);
            flowLayoutPanel1.Controls.Add(khuyenMaiButton);
            flowLayoutPanel1.Controls.Add(banHangButton);
            flowLayoutPanel1.Controls.Add(taoPhieuNhapButton);
            flowLayoutPanel1.Controls.Add(hoaDonButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 100);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 555);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // phanQuyenButton
            // 
            phanQuyenButton.AutoSize = true;
            phanQuyenButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            phanQuyenButton.Location = new Point(0, 20);
            phanQuyenButton.Margin = new Padding(0, 20, 0, 0);
            phanQuyenButton.Name = "phanQuyenButton";
            phanQuyenButton.Size = new Size(200, 35);
            phanQuyenButton.TabIndex = 0;
            phanQuyenButton.Text = "Phân quyền";
            phanQuyenButton.UseVisualStyleBackColor = true;
            phanQuyenButton.Click += PhanQuyenButton_Click;
            // 
            // nguoiDungButton
            // 
            nguoiDungButton.AutoSize = true;
            nguoiDungButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nguoiDungButton.Location = new Point(0, 55);
            nguoiDungButton.Margin = new Padding(0);
            nguoiDungButton.Name = "nguoiDungButton";
            nguoiDungButton.Size = new Size(200, 35);
            nguoiDungButton.TabIndex = 1;
            nguoiDungButton.Text = "Người dùng";
            nguoiDungButton.UseVisualStyleBackColor = true;
            nguoiDungButton.Click += NguoiDungButton_Click;
            // 
            // loaiSanPhamButton
            // 
            loaiSanPhamButton.AutoSize = true;
            loaiSanPhamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            loaiSanPhamButton.Location = new Point(0, 90);
            loaiSanPhamButton.Margin = new Padding(0);
            loaiSanPhamButton.Name = "loaiSanPhamButton";
            loaiSanPhamButton.Size = new Size(200, 35);
            loaiSanPhamButton.TabIndex = 2;
            loaiSanPhamButton.Text = "Loại sản phẩm";
            loaiSanPhamButton.UseVisualStyleBackColor = true;
            loaiSanPhamButton.Click += LoaiSanPhamButton_Click;
            // 
            // sanPhamButton
            // 
            sanPhamButton.AutoSize = true;
            sanPhamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            sanPhamButton.Location = new Point(0, 125);
            sanPhamButton.Margin = new Padding(0);
            sanPhamButton.Name = "sanPhamButton";
            sanPhamButton.Size = new Size(200, 35);
            sanPhamButton.TabIndex = 3;
            sanPhamButton.Text = "Sản phẩm";
            sanPhamButton.UseVisualStyleBackColor = true;
            sanPhamButton.Click += SanPhamButton_Click;
            // 
            // nhaCungCapButton
            // 
            nhaCungCapButton.AutoSize = true;
            nhaCungCapButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nhaCungCapButton.Location = new Point(0, 160);
            nhaCungCapButton.Margin = new Padding(0);
            nhaCungCapButton.Name = "nhaCungCapButton";
            nhaCungCapButton.Size = new Size(200, 35);
            nhaCungCapButton.TabIndex = 4;
            nhaCungCapButton.Text = "Nhà cung cấp";
            nhaCungCapButton.UseVisualStyleBackColor = true;
            nhaCungCapButton.Click += NhaCungCapButton_Click;
            // 
            // phieuNhapButton
            // 
            phieuNhapButton.AutoSize = true;
            phieuNhapButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            phieuNhapButton.Location = new Point(0, 195);
            phieuNhapButton.Margin = new Padding(0);
            phieuNhapButton.Name = "phieuNhapButton";
            phieuNhapButton.Size = new Size(200, 35);
            phieuNhapButton.TabIndex = 5;
            phieuNhapButton.Text = "Phiếu nhập";
            phieuNhapButton.UseVisualStyleBackColor = true;
            phieuNhapButton.Click += PhieuNhapButton_Click;
            // 
            // khachHangButton
            // 
            khachHangButton.AutoSize = true;
            khachHangButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            khachHangButton.Location = new Point(0, 230);
            khachHangButton.Margin = new Padding(0);
            khachHangButton.Name = "khachHangButton";
            khachHangButton.Size = new Size(200, 35);
            khachHangButton.TabIndex = 6;
            khachHangButton.Text = "Khách hàng";
            khachHangButton.UseVisualStyleBackColor = true;
            khachHangButton.Click += KhachHangButton_Click;
            // 
            // khuyenMaiButton
            // 
            khuyenMaiButton.AutoSize = true;
            khuyenMaiButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            khuyenMaiButton.Location = new Point(0, 265);
            khuyenMaiButton.Margin = new Padding(0);
            khuyenMaiButton.Name = "khuyenMaiButton";
            khuyenMaiButton.Size = new Size(200, 35);
            khuyenMaiButton.TabIndex = 7;
            khuyenMaiButton.Text = "Khuyến mãi";
            khuyenMaiButton.UseVisualStyleBackColor = true;
            khuyenMaiButton.Click += KhuyenMaiButton_Click;
            // 
            // banHangButton
            // 
            banHangButton.AutoSize = true;
            banHangButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            banHangButton.Location = new Point(0, 300);
            banHangButton.Margin = new Padding(0);
            banHangButton.Name = "banHangButton";
            banHangButton.Size = new Size(200, 35);
            banHangButton.TabIndex = 8;
            banHangButton.Text = "Bán hàng";
            banHangButton.UseVisualStyleBackColor = true;
            banHangButton.Click += BanHangButton_Click;
            // 
            // taoPhieuNhapButton
            // 
            taoPhieuNhapButton.AutoSize = true;
            taoPhieuNhapButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            taoPhieuNhapButton.Location = new Point(0, 335);
            taoPhieuNhapButton.Margin = new Padding(0);
            taoPhieuNhapButton.Name = "taoPhieuNhapButton";
            taoPhieuNhapButton.Size = new Size(200, 35);
            taoPhieuNhapButton.TabIndex = 9;
            taoPhieuNhapButton.Text = "Tạo phiếu nhập";
            taoPhieuNhapButton.UseVisualStyleBackColor = true;
            taoPhieuNhapButton.Click += TaoPhieuNhapButton_Click;
            // 
            // hoaDonButton
            // 
            hoaDonButton.AutoSize = true;
            hoaDonButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            hoaDonButton.Location = new Point(0, 370);
            hoaDonButton.Margin = new Padding(0);
            hoaDonButton.Name = "hoaDonButton";
            hoaDonButton.Size = new Size(200, 35);
            hoaDonButton.TabIndex = 10;
            hoaDonButton.Text = "Hóa đơn";
            hoaDonButton.UseVisualStyleBackColor = true;
            hoaDonButton.Click += HoaDonButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(dangXuatButton);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 655);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 57);
            panel5.TabIndex = 1;
            // 
            // dangXuatButton
            // 
            dangXuatButton.Dock = DockStyle.Fill;
            dangXuatButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dangXuatButton.Location = new Point(0, 0);
            dangXuatButton.Margin = new Padding(0);
            dangXuatButton.Name = "dangXuatButton";
            dangXuatButton.Size = new Size(200, 57);
            dangXuatButton.TabIndex = 0;
            dangXuatButton.Text = "Đăng xuất";
            dangXuatButton.UseVisualStyleBackColor = true;
            dangXuatButton.Click += DangXuatButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(phanQuyenLabel);
            panel4.Controls.Add(tenNguoiDungLabel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 0;
            // 
            // phanQuyenLabel
            // 
            phanQuyenLabel.Dock = DockStyle.Bottom;
            phanQuyenLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            phanQuyenLabel.Location = new Point(0, 67);
            phanQuyenLabel.Margin = new Padding(0);
            phanQuyenLabel.Name = "phanQuyenLabel";
            phanQuyenLabel.Size = new Size(200, 33);
            phanQuyenLabel.TabIndex = 1;
            phanQuyenLabel.Text = "Phân quyền";
            // 
            // tenNguoiDungLabel
            // 
            tenNguoiDungLabel.Dock = DockStyle.Top;
            tenNguoiDungLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tenNguoiDungLabel.Location = new Point(0, 0);
            tenNguoiDungLabel.Margin = new Padding(0);
            tenNguoiDungLabel.Name = "tenNguoiDungLabel";
            tenNguoiDungLabel.Size = new Size(200, 67);
            tenNguoiDungLabel.TabIndex = 0;
            tenNguoiDungLabel.Text = "Tên người dùng";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 712);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 52);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1144, 660);
            panel6.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1144, 52);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(1144, 52);
            label1.TabIndex = 0;
            label1.Text = "Tiêu đề form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrangChuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 712);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TrangChuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += TrangChuForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Panel panel6;
        private Panel panel3;
        private Button phanQuyenButton;
        private Button nguoiDungButton;
        private Button loaiSanPhamButton;
        private Button sanPhamButton;
        private Button nhaCungCapButton;
        private Button phieuNhapButton;
        private Button khachHangButton;
        private Button khuyenMaiButton;
        private Button banHangButton;
        private Button taoPhieuNhapButton;
        private Button hoaDonButton;
        private Button dangXuatButton;
        private Label phanQuyenLabel;
        private Label tenNguoiDungLabel;
        private Label label1;
    }
}