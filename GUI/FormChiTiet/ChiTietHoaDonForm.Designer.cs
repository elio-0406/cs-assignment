namespace GUI.FormChiTiet
{
    partial class ChiTietHoaDonForm
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
            chiTietHoaDonDataGridView = new DataGridView();
            maSanPhamColumn = new DataGridViewTextBoxColumn();
            donGiaColumn = new DataGridViewTextBoxColumn();
            soLuongColumn = new DataGridViewTextBoxColumn();
            thanhTienColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            maHoaDonTextBox = new TextBox();
            label4 = new Label();
            thoiGianTaoTextBox = new TextBox();
            label5 = new Label();
            tenKhuyenMaiTextBox = new TextBox();
            label6 = new Label();
            maKhuyenMaiTextBox = new TextBox();
            label7 = new Label();
            maKhachHangTextBox = new TextBox();
            label9 = new Label();
            thanhTienTextBox = new TextBox();
            label10 = new Label();
            maNhanVienTextBox = new TextBox();
            label11 = new Label();
            tongTienTextBox = new TextBox();
            label3 = new Label();
            tienThuaTextBox = new TextBox();
            label2 = new Label();
            giamGiaTextBox = new TextBox();
            label12 = new Label();
            tienNhanTextBox = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chiTietHoaDonDataGridView
            // 
            chiTietHoaDonDataGridView.AllowUserToAddRows = false;
            chiTietHoaDonDataGridView.AllowUserToDeleteRows = false;
            chiTietHoaDonDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            chiTietHoaDonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chiTietHoaDonDataGridView.Columns.AddRange(new DataGridViewColumn[] { maSanPhamColumn, donGiaColumn, soLuongColumn, thanhTienColumn });
            chiTietHoaDonDataGridView.Dock = DockStyle.Bottom;
            chiTietHoaDonDataGridView.Location = new Point(0, 272);
            chiTietHoaDonDataGridView.Margin = new Padding(0);
            chiTietHoaDonDataGridView.Name = "chiTietHoaDonDataGridView";
            chiTietHoaDonDataGridView.RowHeadersVisible = false;
            chiTietHoaDonDataGridView.RowHeadersWidth = 62;
            chiTietHoaDonDataGridView.Size = new Size(878, 282);
            chiTietHoaDonDataGridView.TabIndex = 25;
            // 
            // maSanPhamColumn
            // 
            maSanPhamColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maSanPhamColumn.HeaderText = "Mã sản phẩm";
            maSanPhamColumn.MinimumWidth = 8;
            maSanPhamColumn.Name = "maSanPhamColumn";
            maSanPhamColumn.Width = 156;
            // 
            // donGiaColumn
            // 
            donGiaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            donGiaColumn.HeaderText = "Đơn giá";
            donGiaColumn.MinimumWidth = 8;
            donGiaColumn.Name = "donGiaColumn";
            // 
            // soLuongColumn
            // 
            soLuongColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            soLuongColumn.HeaderText = "Số lượng";
            soLuongColumn.MinimumWidth = 8;
            soLuongColumn.Name = "soLuongColumn";
            // 
            // thanhTienColumn
            // 
            thanhTienColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            thanhTienColumn.HeaderText = "Thành tiền";
            thanhTienColumn.MinimumWidth = 8;
            thanhTienColumn.Name = "thanhTienColumn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(78, 14);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 23;
            label1.Text = "Mã hóa đơn";
            // 
            // maHoaDonTextBox
            // 
            maHoaDonTextBox.Location = new Point(78, 42);
            maHoaDonTextBox.Name = "maHoaDonTextBox";
            maHoaDonTextBox.Size = new Size(200, 31);
            maHoaDonTextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(78, 138);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 29;
            label4.Text = "Thời gian tạo";
            // 
            // thoiGianTaoTextBox
            // 
            thoiGianTaoTextBox.Location = new Point(78, 166);
            thoiGianTaoTextBox.Name = "thoiGianTaoTextBox";
            thoiGianTaoTextBox.Size = new Size(250, 31);
            thoiGianTaoTextBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(392, 76);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 31;
            label5.Text = "Tên khuyến mãi";
            // 
            // tenKhuyenMaiTextBox
            // 
            tenKhuyenMaiTextBox.Location = new Point(392, 104);
            tenKhuyenMaiTextBox.Name = "tenKhuyenMaiTextBox";
            tenKhuyenMaiTextBox.Size = new Size(200, 31);
            tenKhuyenMaiTextBox.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(392, 14);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 33;
            label6.Text = "Mã khuyến mãi";
            // 
            // maKhuyenMaiTextBox
            // 
            maKhuyenMaiTextBox.Location = new Point(392, 42);
            maKhuyenMaiTextBox.Name = "maKhuyenMaiTextBox";
            maKhuyenMaiTextBox.Size = new Size(150, 31);
            maKhuyenMaiTextBox.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(78, 200);
            label7.Name = "label7";
            label7.Size = new Size(135, 25);
            label7.TabIndex = 35;
            label7.Text = "Mã khách hàng";
            // 
            // maKhachHangTextBox
            // 
            maKhachHangTextBox.Location = new Point(78, 228);
            maKhachHangTextBox.Name = "maKhachHangTextBox";
            maKhachHangTextBox.Size = new Size(150, 31);
            maKhachHangTextBox.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(392, 200);
            label9.Name = "label9";
            label9.Size = new Size(100, 25);
            label9.TabIndex = 39;
            label9.Text = "Thành tiền";
            // 
            // thanhTienTextBox
            // 
            thanhTienTextBox.Location = new Point(392, 228);
            thanhTienTextBox.Name = "thanhTienTextBox";
            thanhTienTextBox.Size = new Size(150, 31);
            thanhTienTextBox.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(78, 76);
            label10.Name = "label10";
            label10.Size = new Size(124, 25);
            label10.TabIndex = 41;
            label10.Text = "Mã nhân viên";
            // 
            // maNhanVienTextBox
            // 
            maNhanVienTextBox.Location = new Point(78, 104);
            maNhanVienTextBox.Name = "maNhanVienTextBox";
            maNhanVienTextBox.Size = new Size(150, 31);
            maNhanVienTextBox.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.Location = new Point(650, 138);
            label11.Name = "label11";
            label11.Size = new Size(93, 25);
            label11.TabIndex = 46;
            label11.Text = "Tổng tiền";
            // 
            // tongTienTextBox
            // 
            tongTienTextBox.Location = new Point(650, 166);
            tongTienTextBox.Name = "tongTienTextBox";
            tongTienTextBox.Size = new Size(150, 31);
            tongTienTextBox.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(650, 76);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 48;
            label3.Text = "Tiền thừa";
            // 
            // tienThuaTextBox
            // 
            tienThuaTextBox.Location = new Point(650, 104);
            tienThuaTextBox.Name = "tienThuaTextBox";
            tienThuaTextBox.Size = new Size(150, 31);
            tienThuaTextBox.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(392, 138);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 50;
            label2.Text = "Giảm giá";
            // 
            // giamGiaTextBox
            // 
            giamGiaTextBox.Location = new Point(392, 166);
            giamGiaTextBox.Name = "giamGiaTextBox";
            giamGiaTextBox.Size = new Size(150, 31);
            giamGiaTextBox.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label12.Location = new Point(650, 14);
            label12.Name = "label12";
            label12.Size = new Size(94, 25);
            label12.TabIndex = 52;
            label12.Text = "Tiền nhận";
            // 
            // tienNhanTextBox
            // 
            tienNhanTextBox.Location = new Point(650, 42);
            tienNhanTextBox.Name = "tienNhanTextBox";
            tienNhanTextBox.Size = new Size(150, 31);
            tienNhanTextBox.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(tienNhanTextBox);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(giamGiaTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tienThuaTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tongTienTextBox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(maNhanVienTextBox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(thanhTienTextBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(maKhachHangTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(maKhuyenMaiTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tenKhuyenMaiTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(thoiGianTaoTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(maHoaDonTextBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 273);
            panel1.TabIndex = 26;
            // 
            // ChiTietHoaDonForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 554);
            Controls.Add(panel1);
            Controls.Add(chiTietHoaDonDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietHoaDonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết hóa đơn";
            Load += ChiTietHoaDonForm_Load;
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView chiTietHoaDonDataGridView;
        private Label label1;
        private TextBox maHoaDonTextBox;
        private Label label4;
        private TextBox thoiGianTaoTextBox;
        private Label label5;
        private TextBox tenKhuyenMaiTextBox;
        private Label label6;
        private TextBox maKhuyenMaiTextBox;
        private Label label7;
        private TextBox maKhachHangTextBox;
        private Label label9;
        private TextBox thanhTienTextBox;
        private Label label10;
        private TextBox maNhanVienTextBox;
        private Label label11;
        private TextBox tongTienTextBox;
        private Label label3;
        private TextBox tienThuaTextBox;
        private Label label2;
        private TextBox giamGiaTextBox;
        private Label label12;
        private TextBox tienNhanTextBox;
        private Panel panel1;
        private DataGridViewTextBoxColumn maSanPhamColumn;
        private DataGridViewTextBoxColumn donGiaColumn;
        private DataGridViewTextBoxColumn soLuongColumn;
        private DataGridViewTextBoxColumn thanhTienColumn;
    }
}