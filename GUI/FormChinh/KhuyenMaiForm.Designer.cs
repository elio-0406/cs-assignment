namespace GUI.FormChinh
{
    partial class KhuyenMaiForm
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
            label2 = new Label();
            tuyChonThoiGianComboBox = new ComboBox();
            khuyenMaiDataGridView = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            maKhuyenMaiColumn = new DataGridViewTextBoxColumn();
            tenKhuyenMaiColumn = new DataGridViewTextBoxColumn();
            loaiGiaTriColumn = new DataGridViewTextBoxColumn();
            giaTriColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            xoaButtonColumn = new DataGridViewButtonColumn();
            panel1 = new Panel();
            label3 = new Label();
            loaiGiaTriComboBox = new ComboBox();
            themButton = new Button();
            thoiGianDateTimePicker = new DateTimePicker();
            label1 = new Label();
            trangThaiComboBox = new ComboBox();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)khuyenMaiDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(457, 30);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 10;
            label2.Text = "Tùy chọn thời gian";
            // 
            // tuyChonThoiGianComboBox
            // 
            tuyChonThoiGianComboBox.FormattingEnabled = true;
            tuyChonThoiGianComboBox.Items.AddRange(new object[] { "Ngày", "Tháng", "Năm" });
            tuyChonThoiGianComboBox.Location = new Point(457, 58);
            tuyChonThoiGianComboBox.Name = "tuyChonThoiGianComboBox";
            tuyChonThoiGianComboBox.Size = new Size(182, 33);
            tuyChonThoiGianComboBox.TabIndex = 9;
            tuyChonThoiGianComboBox.SelectionChangeCommitted += TuyChonThoiGianComboBox_SelectionChangeCommitted;
            // 
            // khuyenMaiDataGridView
            // 
            khuyenMaiDataGridView.AllowUserToAddRows = false;
            khuyenMaiDataGridView.AllowUserToDeleteRows = false;
            khuyenMaiDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            khuyenMaiDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            khuyenMaiDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maKhuyenMaiColumn, tenKhuyenMaiColumn, loaiGiaTriColumn, giaTriColumn, trangThaiColumn, chiTietButtonColumn, suaButtonColumn, xoaButtonColumn });
            khuyenMaiDataGridView.Dock = DockStyle.Fill;
            khuyenMaiDataGridView.Location = new Point(0, 170);
            khuyenMaiDataGridView.Margin = new Padding(0);
            khuyenMaiDataGridView.Name = "khuyenMaiDataGridView";
            khuyenMaiDataGridView.ReadOnly = true;
            khuyenMaiDataGridView.RowHeadersVisible = false;
            khuyenMaiDataGridView.RowHeadersWidth = 62;
            khuyenMaiDataGridView.Size = new Size(1144, 490);
            khuyenMaiDataGridView.TabIndex = 7;
            khuyenMaiDataGridView.CellContentClick += KhuyenMaiDataGridView_CellContentClick;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Width = 76;
            // 
            // maKhuyenMaiColumn
            // 
            maKhuyenMaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maKhuyenMaiColumn.HeaderText = "Mã khuyến mãi";
            maKhuyenMaiColumn.MinimumWidth = 8;
            maKhuyenMaiColumn.Name = "maKhuyenMaiColumn";
            maKhuyenMaiColumn.ReadOnly = true;
            maKhuyenMaiColumn.Width = 129;
            // 
            // tenKhuyenMaiColumn
            // 
            tenKhuyenMaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenKhuyenMaiColumn.HeaderText = "Tên khuyến mãi";
            tenKhuyenMaiColumn.MinimumWidth = 8;
            tenKhuyenMaiColumn.Name = "tenKhuyenMaiColumn";
            tenKhuyenMaiColumn.ReadOnly = true;
            // 
            // loaiGiaTriColumn
            // 
            loaiGiaTriColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loaiGiaTriColumn.HeaderText = "Loại giá trị";
            loaiGiaTriColumn.MinimumWidth = 8;
            loaiGiaTriColumn.Name = "loaiGiaTriColumn";
            loaiGiaTriColumn.ReadOnly = true;
            loaiGiaTriColumn.Width = 80;
            // 
            // giaTriColumn
            // 
            giaTriColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            giaTriColumn.HeaderText = "Giá trị";
            giaTriColumn.MinimumWidth = 8;
            giaTriColumn.Name = "giaTriColumn";
            giaTriColumn.ReadOnly = true;
            giaTriColumn.Width = 73;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 8;
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.ReadOnly = true;
            trangThaiColumn.Resizable = DataGridViewTriState.True;
            trangThaiColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            trangThaiColumn.Width = 86;
            // 
            // chiTietButtonColumn
            // 
            chiTietButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chiTietButtonColumn.FillWeight = 30F;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
            chiTietButtonColumn.ReadOnly = true;
            chiTietButtonColumn.Resizable = DataGridViewTriState.True;
            chiTietButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            chiTietButtonColumn.Text = "Chi tiết";
            chiTietButtonColumn.UseColumnTextForButtonValue = true;
            chiTietButtonColumn.Width = 73;
            // 
            // suaButtonColumn
            // 
            suaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            suaButtonColumn.FillWeight = 30F;
            suaButtonColumn.HeaderText = "Sửa";
            suaButtonColumn.MinimumWidth = 8;
            suaButtonColumn.Name = "suaButtonColumn";
            suaButtonColumn.ReadOnly = true;
            suaButtonColumn.Resizable = DataGridViewTriState.True;
            suaButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            suaButtonColumn.Text = "Sửa";
            suaButtonColumn.UseColumnTextForButtonValue = true;
            suaButtonColumn.Width = 78;
            // 
            // xoaButtonColumn
            // 
            xoaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            xoaButtonColumn.FillWeight = 30F;
            xoaButtonColumn.HeaderText = "Xóa";
            xoaButtonColumn.MinimumWidth = 8;
            xoaButtonColumn.Name = "xoaButtonColumn";
            xoaButtonColumn.ReadOnly = true;
            xoaButtonColumn.Resizable = DataGridViewTriState.True;
            xoaButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            xoaButtonColumn.Text = "Xóa";
            xoaButtonColumn.UseColumnTextForButtonValue = true;
            xoaButtonColumn.Width = 79;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(loaiGiaTriComboBox);
            panel1.Controls.Add(themButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tuyChonThoiGianComboBox);
            panel1.Controls.Add(thoiGianDateTimePicker);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trangThaiComboBox);
            panel1.Controls.Add(xuatExcel);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(timKiemButton);
            panel1.Controls.Add(timKiemTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 170);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(262, 30);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 13;
            label3.Text = "Loại giá trị";
            // 
            // loaiGiaTriComboBox
            // 
            loaiGiaTriComboBox.FormattingEnabled = true;
            loaiGiaTriComboBox.Items.AddRange(new object[] { "Phần trăm", "Cụ thể" });
            loaiGiaTriComboBox.Location = new Point(262, 58);
            loaiGiaTriComboBox.Margin = new Padding(0);
            loaiGiaTriComboBox.Name = "loaiGiaTriComboBox";
            loaiGiaTriComboBox.Size = new Size(182, 33);
            loaiGiaTriComboBox.TabIndex = 12;
            loaiGiaTriComboBox.SelectionChangeCommitted += LoaiGiaTriComboBox_SelectionChangeCommitted;
            // 
            // themButton
            // 
            themButton.BackColor = Color.Teal;
            themButton.FlatAppearance.BorderSize = 0;
            themButton.FlatStyle = FlatStyle.Flat;
            themButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            themButton.ForeColor = Color.White;
            themButton.Location = new Point(839, 106);
            themButton.Name = "themButton";
            themButton.Size = new Size(112, 34);
            themButton.TabIndex = 11;
            themButton.Text = "Thêm";
            themButton.UseVisualStyleBackColor = false;
            themButton.Click += ThemButton_Click;
            // 
            // thoiGianDateTimePicker
            // 
            thoiGianDateTimePicker.Checked = false;
            thoiGianDateTimePicker.Location = new Point(642, 58);
            thoiGianDateTimePicker.Name = "thoiGianDateTimePicker";
            thoiGianDateTimePicker.ShowCheckBox = true;
            thoiGianDateTimePicker.Size = new Size(324, 31);
            thoiGianDateTimePicker.TabIndex = 8;
            thoiGianDateTimePicker.ValueChanged += ThoiGianDateTimePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(69, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 7;
            label1.Text = "Trạng thái";
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang diễn ra", "Chưa diễn ra", "Đã kết thúc" });
            trangThaiComboBox.Location = new Point(69, 58);
            trangThaiComboBox.Margin = new Padding(0);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.Size = new Size(182, 33);
            trangThaiComboBox.TabIndex = 4;
            trangThaiComboBox.SelectionChangeCommitted += TrangThaiComboBox_SelectionChangeCommitted;
            // 
            // xuatExcel
            // 
            xuatExcel.BackColor = Color.ForestGreen;
            xuatExcel.FlatAppearance.BorderSize = 0;
            xuatExcel.FlatStyle = FlatStyle.Flat;
            xuatExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            xuatExcel.ForeColor = Color.White;
            xuatExcel.Location = new Point(963, 106);
            xuatExcel.Margin = new Padding(0);
            xuatExcel.Name = "xuatExcel";
            xuatExcel.Size = new Size(112, 34);
            xuatExcel.TabIndex = 3;
            xuatExcel.Text = "Xuất Excel";
            xuatExcel.UseVisualStyleBackColor = false;
            xuatExcel.Click += XuatExcel_Click;
            // 
            // lamMoiButton
            // 
            lamMoiButton.BackColor = Color.SkyBlue;
            lamMoiButton.FlatAppearance.BorderSize = 0;
            lamMoiButton.FlatStyle = FlatStyle.Flat;
            lamMoiButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lamMoiButton.Location = new Point(670, 106);
            lamMoiButton.Margin = new Padding(0);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(112, 34);
            lamMoiButton.TabIndex = 2;
            lamMoiButton.Text = "Làm mới";
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += LamMoiButton_Click;
            // 
            // timKiemButton
            // 
            timKiemButton.BackColor = Color.Gold;
            timKiemButton.FlatAppearance.BorderSize = 0;
            timKiemButton.FlatStyle = FlatStyle.Flat;
            timKiemButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            timKiemButton.Location = new Point(549, 106);
            timKiemButton.Margin = new Padding(0);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(112, 34);
            timKiemButton.TabIndex = 1;
            timKiemButton.Text = "Tìm kiếm";
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += TimKiemButton_Click;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.Location = new Point(69, 106);
            timKiemTextBox.Margin = new Padding(0);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(471, 31);
            timKiemTextBox.TabIndex = 0;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // KhuyenMaiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(khuyenMaiDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhuyenMaiForm";
            Text = "KhuyenMaiForm";
            Load += KhuyenMaiForm_Load;
            ((System.ComponentModel.ISupportInitialize)khuyenMaiDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private ComboBox tuyChonThoiGianComboBox;
        private DataGridView khuyenMaiDataGridView;
        private Panel panel1;
        private DateTimePicker thoiGianDateTimePicker;
        private Label label1;
        private ComboBox trangThaiComboBox;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
        private Button themButton;
        private Label label3;
        private ComboBox loaiGiaTriComboBox;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maKhuyenMaiColumn;
        private DataGridViewTextBoxColumn tenKhuyenMaiColumn;
        private DataGridViewTextBoxColumn loaiGiaTriColumn;
        private DataGridViewTextBoxColumn giaTriColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewButtonColumn chiTietButtonColumn;
        private DataGridViewButtonColumn suaButtonColumn;
        private DataGridViewButtonColumn xoaButtonColumn;
    }
}