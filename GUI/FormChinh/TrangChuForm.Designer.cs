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
            banHangButton = new Button();
            taoPhieuNhapButton = new Button();
            sanPhamButton = new Button();
            loaiSanPhamButton = new Button();
            khachHangButton = new Button();
            khuyenMaiButton = new Button();
            nhaCungCapButton = new Button();
            hoaDonButton = new Button();
            phieuNhapButton = new Button();
            panel5 = new Panel();
            dangXuatButton = new Button();
            panel4 = new Panel();
            phanQuyenLabel = new Label();
            tenNguoiDungLabel = new Label();
            panel2 = new Panel();
            childFormPanel = new Panel();
            panel3 = new Panel();
            tieuDeFormLabel = new Label();
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
            flowLayoutPanel1.BackColor = Color.FromArgb(223, 243, 252);
            flowLayoutPanel1.Controls.Add(phanQuyenButton);
            flowLayoutPanel1.Controls.Add(nguoiDungButton);
            flowLayoutPanel1.Controls.Add(banHangButton);
            flowLayoutPanel1.Controls.Add(taoPhieuNhapButton);
            flowLayoutPanel1.Controls.Add(sanPhamButton);
            flowLayoutPanel1.Controls.Add(loaiSanPhamButton);
            flowLayoutPanel1.Controls.Add(khachHangButton);
            flowLayoutPanel1.Controls.Add(khuyenMaiButton);
            flowLayoutPanel1.Controls.Add(nhaCungCapButton);
            flowLayoutPanel1.Controls.Add(hoaDonButton);
            flowLayoutPanel1.Controls.Add(phieuNhapButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 100);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 555);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // phanQuyenButton
            // 
            phanQuyenButton.AutoSize = true;
            phanQuyenButton.BackColor = Color.FromArgb(0, 79, 111);
            phanQuyenButton.FlatAppearance.BorderSize = 0;
            phanQuyenButton.FlatStyle = FlatStyle.Flat;
            phanQuyenButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            phanQuyenButton.ForeColor = Color.White;
            phanQuyenButton.Location = new Point(0, 0);
            phanQuyenButton.Margin = new Padding(0);
            phanQuyenButton.Name = "phanQuyenButton";
            phanQuyenButton.Size = new Size(200, 50);
            phanQuyenButton.TabIndex = 0;
            phanQuyenButton.Text = "Phân quyền";
            phanQuyenButton.UseVisualStyleBackColor = false;
            phanQuyenButton.Visible = false;
            phanQuyenButton.Click += PhanQuyenButton_Click;
            // 
            // nguoiDungButton
            // 
            nguoiDungButton.AutoSize = true;
            nguoiDungButton.BackColor = Color.FromArgb(0, 79, 111);
            nguoiDungButton.FlatAppearance.BorderSize = 0;
            nguoiDungButton.FlatStyle = FlatStyle.Flat;
            nguoiDungButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nguoiDungButton.ForeColor = Color.White;
            nguoiDungButton.Location = new Point(0, 50);
            nguoiDungButton.Margin = new Padding(0);
            nguoiDungButton.Name = "nguoiDungButton";
            nguoiDungButton.Size = new Size(200, 50);
            nguoiDungButton.TabIndex = 1;
            nguoiDungButton.Text = "Người dùng";
            nguoiDungButton.UseVisualStyleBackColor = false;
            nguoiDungButton.Visible = false;
            nguoiDungButton.Click += NguoiDungButton_Click;
            // 
            // banHangButton
            // 
            banHangButton.AutoSize = true;
            banHangButton.BackColor = Color.FromArgb(0, 79, 111);
            banHangButton.FlatAppearance.BorderSize = 0;
            banHangButton.FlatStyle = FlatStyle.Flat;
            banHangButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            banHangButton.ForeColor = Color.White;
            banHangButton.Location = new Point(0, 100);
            banHangButton.Margin = new Padding(0);
            banHangButton.Name = "banHangButton";
            banHangButton.Size = new Size(200, 50);
            banHangButton.TabIndex = 8;
            banHangButton.Text = "Bán hàng";
            banHangButton.UseVisualStyleBackColor = false;
            banHangButton.Visible = false;
            banHangButton.Click += BanHangButton_Click;
            // 
            // taoPhieuNhapButton
            // 
            taoPhieuNhapButton.AutoSize = true;
            taoPhieuNhapButton.BackColor = Color.FromArgb(0, 79, 111);
            taoPhieuNhapButton.FlatAppearance.BorderSize = 0;
            taoPhieuNhapButton.FlatStyle = FlatStyle.Flat;
            taoPhieuNhapButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            taoPhieuNhapButton.ForeColor = Color.White;
            taoPhieuNhapButton.Location = new Point(0, 150);
            taoPhieuNhapButton.Margin = new Padding(0);
            taoPhieuNhapButton.Name = "taoPhieuNhapButton";
            taoPhieuNhapButton.Size = new Size(200, 50);
            taoPhieuNhapButton.TabIndex = 9;
            taoPhieuNhapButton.Text = "Tạo phiếu nhập";
            taoPhieuNhapButton.UseVisualStyleBackColor = false;
            taoPhieuNhapButton.Visible = false;
            taoPhieuNhapButton.Click += TaoPhieuNhapButton_Click;
            // 
            // sanPhamButton
            // 
            sanPhamButton.AutoSize = true;
            sanPhamButton.BackColor = Color.FromArgb(0, 79, 111);
            sanPhamButton.FlatAppearance.BorderSize = 0;
            sanPhamButton.FlatStyle = FlatStyle.Flat;
            sanPhamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            sanPhamButton.ForeColor = Color.White;
            sanPhamButton.Location = new Point(0, 200);
            sanPhamButton.Margin = new Padding(0);
            sanPhamButton.Name = "sanPhamButton";
            sanPhamButton.Size = new Size(200, 50);
            sanPhamButton.TabIndex = 3;
            sanPhamButton.Text = "Sản phẩm";
            sanPhamButton.UseVisualStyleBackColor = false;
            sanPhamButton.Visible = false;
            sanPhamButton.Click += SanPhamButton_Click;
            // 
            // loaiSanPhamButton
            // 
            loaiSanPhamButton.AutoSize = true;
            loaiSanPhamButton.BackColor = Color.FromArgb(0, 79, 111);
            loaiSanPhamButton.FlatAppearance.BorderSize = 0;
            loaiSanPhamButton.FlatStyle = FlatStyle.Flat;
            loaiSanPhamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            loaiSanPhamButton.ForeColor = Color.White;
            loaiSanPhamButton.Location = new Point(0, 250);
            loaiSanPhamButton.Margin = new Padding(0);
            loaiSanPhamButton.Name = "loaiSanPhamButton";
            loaiSanPhamButton.Size = new Size(200, 50);
            loaiSanPhamButton.TabIndex = 2;
            loaiSanPhamButton.Text = "Loại sản phẩm";
            loaiSanPhamButton.UseVisualStyleBackColor = false;
            loaiSanPhamButton.Visible = false;
            loaiSanPhamButton.Click += LoaiSanPhamButton_Click;
            // 
            // khachHangButton
            // 
            khachHangButton.AutoSize = true;
            khachHangButton.BackColor = Color.FromArgb(0, 79, 111);
            khachHangButton.FlatAppearance.BorderSize = 0;
            khachHangButton.FlatStyle = FlatStyle.Flat;
            khachHangButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            khachHangButton.ForeColor = Color.White;
            khachHangButton.Location = new Point(0, 300);
            khachHangButton.Margin = new Padding(0);
            khachHangButton.Name = "khachHangButton";
            khachHangButton.Size = new Size(200, 50);
            khachHangButton.TabIndex = 6;
            khachHangButton.Text = "Khách hàng";
            khachHangButton.UseVisualStyleBackColor = false;
            khachHangButton.Visible = false;
            khachHangButton.Click += KhachHangButton_Click;
            // 
            // khuyenMaiButton
            // 
            khuyenMaiButton.AutoSize = true;
            khuyenMaiButton.BackColor = Color.FromArgb(0, 79, 111);
            khuyenMaiButton.FlatAppearance.BorderSize = 0;
            khuyenMaiButton.FlatStyle = FlatStyle.Flat;
            khuyenMaiButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            khuyenMaiButton.ForeColor = Color.White;
            khuyenMaiButton.Location = new Point(0, 350);
            khuyenMaiButton.Margin = new Padding(0);
            khuyenMaiButton.Name = "khuyenMaiButton";
            khuyenMaiButton.Size = new Size(200, 50);
            khuyenMaiButton.TabIndex = 7;
            khuyenMaiButton.Text = "Khuyến mãi";
            khuyenMaiButton.UseVisualStyleBackColor = false;
            khuyenMaiButton.Visible = false;
            khuyenMaiButton.Click += KhuyenMaiButton_Click;
            // 
            // nhaCungCapButton
            // 
            nhaCungCapButton.AutoSize = true;
            nhaCungCapButton.BackColor = Color.FromArgb(0, 79, 111);
            nhaCungCapButton.FlatAppearance.BorderSize = 0;
            nhaCungCapButton.FlatStyle = FlatStyle.Flat;
            nhaCungCapButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nhaCungCapButton.ForeColor = Color.White;
            nhaCungCapButton.Location = new Point(0, 400);
            nhaCungCapButton.Margin = new Padding(0);
            nhaCungCapButton.Name = "nhaCungCapButton";
            nhaCungCapButton.Size = new Size(200, 50);
            nhaCungCapButton.TabIndex = 4;
            nhaCungCapButton.Text = "Nhà cung cấp";
            nhaCungCapButton.UseVisualStyleBackColor = false;
            nhaCungCapButton.Visible = false;
            nhaCungCapButton.Click += NhaCungCapButton_Click;
            // 
            // hoaDonButton
            // 
            hoaDonButton.AutoSize = true;
            hoaDonButton.BackColor = Color.FromArgb(0, 79, 111);
            hoaDonButton.FlatAppearance.BorderSize = 0;
            hoaDonButton.FlatStyle = FlatStyle.Flat;
            hoaDonButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            hoaDonButton.ForeColor = Color.White;
            hoaDonButton.Location = new Point(0, 450);
            hoaDonButton.Margin = new Padding(0);
            hoaDonButton.Name = "hoaDonButton";
            hoaDonButton.Size = new Size(200, 50);
            hoaDonButton.TabIndex = 10;
            hoaDonButton.Text = "Hóa đơn";
            hoaDonButton.UseVisualStyleBackColor = false;
            hoaDonButton.Visible = false;
            hoaDonButton.Click += HoaDonButton_Click;
            // 
            // phieuNhapButton
            // 
            phieuNhapButton.AutoSize = true;
            phieuNhapButton.BackColor = Color.FromArgb(0, 79, 111);
            phieuNhapButton.FlatAppearance.BorderSize = 0;
            phieuNhapButton.FlatStyle = FlatStyle.Flat;
            phieuNhapButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            phieuNhapButton.ForeColor = Color.White;
            phieuNhapButton.Location = new Point(0, 500);
            phieuNhapButton.Margin = new Padding(0);
            phieuNhapButton.Name = "phieuNhapButton";
            phieuNhapButton.Size = new Size(200, 55);
            phieuNhapButton.TabIndex = 5;
            phieuNhapButton.Text = "Phiếu nhập";
            phieuNhapButton.UseVisualStyleBackColor = false;
            phieuNhapButton.Visible = false;
            phieuNhapButton.Click += PhieuNhapButton_Click;
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
            dangXuatButton.BackColor = Color.Red;
            dangXuatButton.Dock = DockStyle.Fill;
            dangXuatButton.FlatAppearance.BorderSize = 0;
            dangXuatButton.FlatStyle = FlatStyle.Flat;
            dangXuatButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dangXuatButton.Location = new Point(0, 0);
            dangXuatButton.Margin = new Padding(0);
            dangXuatButton.Name = "dangXuatButton";
            dangXuatButton.Size = new Size(200, 57);
            dangXuatButton.TabIndex = 0;
            dangXuatButton.Text = "Đăng xuất";
            dangXuatButton.UseVisualStyleBackColor = false;
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
            phanQuyenLabel.BackColor = Color.FromArgb(0, 50, 90);
            phanQuyenLabel.Dock = DockStyle.Bottom;
            phanQuyenLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            phanQuyenLabel.ForeColor = Color.White;
            phanQuyenLabel.Location = new Point(0, 67);
            phanQuyenLabel.Margin = new Padding(0);
            phanQuyenLabel.Name = "phanQuyenLabel";
            phanQuyenLabel.Size = new Size(200, 33);
            phanQuyenLabel.TabIndex = 1;
            phanQuyenLabel.Text = "Phân quyền";
            // 
            // tenNguoiDungLabel
            // 
            tenNguoiDungLabel.BackColor = Color.FromArgb(0, 50, 90);
            tenNguoiDungLabel.Dock = DockStyle.Top;
            tenNguoiDungLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tenNguoiDungLabel.ForeColor = Color.White;
            tenNguoiDungLabel.Location = new Point(0, 0);
            tenNguoiDungLabel.Margin = new Padding(0);
            tenNguoiDungLabel.Name = "tenNguoiDungLabel";
            tenNguoiDungLabel.Size = new Size(200, 67);
            tenNguoiDungLabel.TabIndex = 0;
            tenNguoiDungLabel.Text = "Tên người dùng";
            tenNguoiDungLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(childFormPanel);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 712);
            panel2.TabIndex = 1;
            // 
            // childFormPanel
            // 
            childFormPanel.BackColor = Color.FromArgb(223, 243, 252);
            childFormPanel.Dock = DockStyle.Fill;
            childFormPanel.Location = new Point(0, 52);
            childFormPanel.Margin = new Padding(0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1144, 660);
            childFormPanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(tieuDeFormLabel);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1144, 52);
            panel3.TabIndex = 0;
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.BackColor = Color.FromArgb(0, 50, 90);
            tieuDeFormLabel.Dock = DockStyle.Fill;
            tieuDeFormLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tieuDeFormLabel.ForeColor = Color.White;
            tieuDeFormLabel.Location = new Point(0, 0);
            tieuDeFormLabel.Margin = new Padding(0);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(1144, 52);
            tieuDeFormLabel.TabIndex = 0;
            tieuDeFormLabel.Text = "Tiêu đề form";
            tieuDeFormLabel.TextAlign = ContentAlignment.MiddleCenter;
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
        private Panel childFormPanel;
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
        private Label tieuDeFormLabel;
    }
}