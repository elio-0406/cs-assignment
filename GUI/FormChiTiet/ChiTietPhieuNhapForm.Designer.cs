namespace GUI.FormChiTiet
{
    partial class ChiTietPhieuNhapForm
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
            phieuNhapDataGridView = new DataGridView();
            panel1 = new Panel();
            nhapHangButton = new Button();
            khongDuyetButton = new Button();
            duyetButton = new Button();
            maNhaCungCapTextBox = new TextBox();
            label10 = new Label();
            thanhTienTextBox = new TextBox();
            label9 = new Label();
            trangThaiTextBox = new TextBox();
            label8 = new Label();
            maNguoiTaoTextBox = new TextBox();
            label7 = new Label();
            maNguoiDuyetTextBox = new TextBox();
            label6 = new Label();
            maNguoiNhapTextBox = new TextBox();
            label5 = new Label();
            thoiGianTaoTextBox = new TextBox();
            label4 = new Label();
            thoiGianDuyetTextBox = new TextBox();
            label3 = new Label();
            thoiGianNhapHangTextBox = new TextBox();
            label2 = new Label();
            maPhieuNhapTextBox = new TextBox();
            label1 = new Label();
            maSanPhamColumn = new DataGridViewTextBoxColumn();
            donGiaColumn = new DataGridViewTextBoxColumn();
            soLuongColumn = new DataGridViewTextBoxColumn();
            thanhTienColumn = new DataGridViewTextBoxColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)phieuNhapDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // phieuNhapDataGridView
            // 
            phieuNhapDataGridView.AllowUserToAddRows = false;
            phieuNhapDataGridView.AllowUserToDeleteRows = false;
            phieuNhapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phieuNhapDataGridView.Columns.AddRange(new DataGridViewColumn[] { maSanPhamColumn, donGiaColumn, soLuongColumn, thanhTienColumn, suaButtonColumn });
            phieuNhapDataGridView.Dock = DockStyle.Bottom;
            phieuNhapDataGridView.Location = new Point(0, 272);
            phieuNhapDataGridView.Margin = new Padding(0);
            phieuNhapDataGridView.Name = "phieuNhapDataGridView";
            phieuNhapDataGridView.RowHeadersVisible = false;
            phieuNhapDataGridView.RowHeadersWidth = 62;
            phieuNhapDataGridView.Size = new Size(878, 282);
            phieuNhapDataGridView.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(nhapHangButton);
            panel1.Controls.Add(khongDuyetButton);
            panel1.Controls.Add(duyetButton);
            panel1.Controls.Add(maNhaCungCapTextBox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(thanhTienTextBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(trangThaiTextBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(maNguoiTaoTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(maNguoiDuyetTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(maNguoiNhapTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(thoiGianTaoTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(thoiGianDuyetTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(thoiGianNhapHangTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(maPhieuNhapTextBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 273);
            panel1.TabIndex = 24;
            // 
            // nhapHangButton
            // 
            nhapHangButton.Location = new Point(587, 224);
            nhapHangButton.Name = "nhapHangButton";
            nhapHangButton.Size = new Size(112, 34);
            nhapHangButton.TabIndex = 45;
            nhapHangButton.Text = "Nhập hàng";
            nhapHangButton.UseVisualStyleBackColor = true;
            // 
            // khongDuyetButton
            // 
            khongDuyetButton.AutoSize = true;
            khongDuyetButton.Location = new Point(457, 224);
            khongDuyetButton.Name = "khongDuyetButton";
            khongDuyetButton.Size = new Size(124, 35);
            khongDuyetButton.TabIndex = 44;
            khongDuyetButton.Text = "Không duyệt";
            khongDuyetButton.UseVisualStyleBackColor = true;
            // 
            // duyetButton
            // 
            duyetButton.Location = new Point(339, 225);
            duyetButton.Name = "duyetButton";
            duyetButton.Size = new Size(112, 34);
            duyetButton.TabIndex = 43;
            duyetButton.Text = "Duyệt";
            duyetButton.UseVisualStyleBackColor = true;
            // 
            // maNhaCungCapTextBox
            // 
            maNhaCungCapTextBox.Location = new Point(67, 103);
            maNhaCungCapTextBox.Name = "maNhaCungCapTextBox";
            maNhaCungCapTextBox.Size = new Size(150, 31);
            maNhaCungCapTextBox.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(67, 75);
            label10.Name = "label10";
            label10.Size = new Size(148, 25);
            label10.TabIndex = 41;
            label10.Text = "Mã nhà cung cấp";
            // 
            // thanhTienTextBox
            // 
            thanhTienTextBox.Location = new Point(67, 165);
            thanhTienTextBox.Name = "thanhTienTextBox";
            thanhTienTextBox.Size = new Size(150, 31);
            thanhTienTextBox.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 137);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 39;
            label9.Text = "Thành tiền";
            // 
            // trangThaiTextBox
            // 
            trangThaiTextBox.Location = new Point(67, 227);
            trangThaiTextBox.Name = "trangThaiTextBox";
            trangThaiTextBox.Size = new Size(150, 31);
            trangThaiTextBox.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(67, 199);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 37;
            label8.Text = "Trạng thái";
            // 
            // maNguoiTaoTextBox
            // 
            maNguoiTaoTextBox.Location = new Point(339, 41);
            maNguoiTaoTextBox.Name = "maNguoiTaoTextBox";
            maNguoiTaoTextBox.Size = new Size(150, 31);
            maNguoiTaoTextBox.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 13);
            label7.Name = "label7";
            label7.Size = new Size(120, 25);
            label7.TabIndex = 35;
            label7.Text = "Mã người tạo";
            // 
            // maNguoiDuyetTextBox
            // 
            maNguoiDuyetTextBox.Location = new Point(339, 103);
            maNguoiDuyetTextBox.Name = "maNguoiDuyetTextBox";
            maNguoiDuyetTextBox.Size = new Size(150, 31);
            maNguoiDuyetTextBox.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 75);
            label6.Name = "label6";
            label6.Size = new Size(139, 25);
            label6.TabIndex = 33;
            label6.Text = "Mã người duyệt";
            // 
            // maNguoiNhapTextBox
            // 
            maNguoiNhapTextBox.Location = new Point(339, 165);
            maNguoiNhapTextBox.Name = "maNguoiNhapTextBox";
            maNguoiNhapTextBox.Size = new Size(150, 31);
            maNguoiNhapTextBox.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 137);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 31;
            label5.Text = "Mã người nhập";
            // 
            // thoiGianTaoTextBox
            // 
            thoiGianTaoTextBox.Location = new Point(562, 41);
            thoiGianTaoTextBox.Name = "thoiGianTaoTextBox";
            thoiGianTaoTextBox.Size = new Size(250, 31);
            thoiGianTaoTextBox.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(562, 13);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 29;
            label4.Text = "Thời gian tạo";
            // 
            // thoiGianDuyetTextBox
            // 
            thoiGianDuyetTextBox.Location = new Point(562, 103);
            thoiGianDuyetTextBox.Name = "thoiGianDuyetTextBox";
            thoiGianDuyetTextBox.Size = new Size(250, 31);
            thoiGianDuyetTextBox.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 75);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 27;
            label3.Text = "Thời gian duyệt";
            // 
            // thoiGianNhapHangTextBox
            // 
            thoiGianNhapHangTextBox.Location = new Point(562, 165);
            thoiGianNhapHangTextBox.Name = "thoiGianNhapHangTextBox";
            thoiGianNhapHangTextBox.Size = new Size(250, 31);
            thoiGianNhapHangTextBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(562, 137);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 25;
            label2.Text = "Thời gian nhập hàng";
            // 
            // maPhieuNhapTextBox
            // 
            maPhieuNhapTextBox.Location = new Point(67, 41);
            maPhieuNhapTextBox.Name = "maPhieuNhapTextBox";
            maPhieuNhapTextBox.Size = new Size(200, 31);
            maPhieuNhapTextBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 13);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 23;
            label1.Text = "Mã phiếu nhập";
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
            // suaButtonColumn
            // 
            suaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            suaButtonColumn.HeaderText = "Sửa";
            suaButtonColumn.MinimumWidth = 8;
            suaButtonColumn.Name = "suaButtonColumn";
            suaButtonColumn.Width = 48;
            // 
            // ChiTietPhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 554);
            Controls.Add(panel1);
            Controls.Add(phieuNhapDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietPhieuNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)phieuNhapDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView phieuNhapDataGridView;
        private DataGridViewTextBoxColumn maSanPhamColumn;
        private DataGridViewTextBoxColumn donGiaColumn;
        private DataGridViewTextBoxColumn soLuongColumn;
        private DataGridViewTextBoxColumn thanhTienColumn;
        private DataGridViewButtonColumn suaButtonColumn;
        private Panel panel1;
        private Button nhapHangButton;
        private Button khongDuyetButton;
        private Button duyetButton;
        private TextBox maNhaCungCapTextBox;
        private Label label10;
        private TextBox thanhTienTextBox;
        private Label label9;
        private TextBox trangThaiTextBox;
        private Label label8;
        private TextBox maNguoiTaoTextBox;
        private Label label7;
        private TextBox maNguoiDuyetTextBox;
        private Label label6;
        private TextBox maNguoiNhapTextBox;
        private Label label5;
        private TextBox thoiGianTaoTextBox;
        private Label label4;
        private TextBox thoiGianDuyetTextBox;
        private Label label3;
        private TextBox thoiGianNhapHangTextBox;
        private Label label2;
        private TextBox maPhieuNhapTextBox;
        private Label label1;
    }
}