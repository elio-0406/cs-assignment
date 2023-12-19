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
            stt = new DataGridViewTextBoxColumn();
            maKhuyenMaiColumn = new DataGridViewTextBoxColumn();
            tenKhuyenMaiColumn = new DataGridViewTextBoxColumn();
            loaiGiaTriColumn = new DataGridViewTextBoxColumn();
            giaTriColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            xoaButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)khuyenMaiDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 30);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
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
            khuyenMaiDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            khuyenMaiDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maKhuyenMaiColumn, tenKhuyenMaiColumn, loaiGiaTriColumn, giaTriColumn, trangThaiColumn, chiTietButtonColumn, suaButtonColumn, xoaButtonColumn });
            khuyenMaiDataGridView.Dock = DockStyle.Fill;
            khuyenMaiDataGridView.Location = new Point(0, 170);
            khuyenMaiDataGridView.Margin = new Padding(0);
            khuyenMaiDataGridView.Name = "khuyenMaiDataGridView";
            khuyenMaiDataGridView.RowHeadersVisible = false;
            khuyenMaiDataGridView.RowHeadersWidth = 62;
            khuyenMaiDataGridView.Size = new Size(1144, 490);
            khuyenMaiDataGridView.TabIndex = 7;
            khuyenMaiDataGridView.CellContentClick += KhuyenMaiDataGridView_CellContentClick;
            // 
            // panel1
            // 
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
            label3.Location = new Point(262, 30);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
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
            themButton.Location = new Point(854, 106);
            themButton.Name = "themButton";
            themButton.Size = new Size(112, 34);
            themButton.TabIndex = 11;
            themButton.Text = "Thêm";
            themButton.UseVisualStyleBackColor = true;
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
            label1.Location = new Point(69, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
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
            xuatExcel.Location = new Point(963, 106);
            xuatExcel.Margin = new Padding(0);
            xuatExcel.Name = "xuatExcel";
            xuatExcel.Size = new Size(112, 34);
            xuatExcel.TabIndex = 3;
            xuatExcel.Text = "Xuất Excel";
            xuatExcel.UseVisualStyleBackColor = true;
            xuatExcel.Click += XuatExcel_Click;
            // 
            // lamMoiButton
            // 
            lamMoiButton.Location = new Point(739, 106);
            lamMoiButton.Margin = new Padding(0);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(112, 34);
            lamMoiButton.TabIndex = 2;
            lamMoiButton.Text = "Làm mới";
            lamMoiButton.UseVisualStyleBackColor = true;
            lamMoiButton.Click += LamMoiButton_Click;
            // 
            // timKiemButton
            // 
            timKiemButton.Location = new Point(627, 106);
            timKiemButton.Margin = new Padding(0);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(112, 34);
            timKiemButton.TabIndex = 1;
            timKiemButton.Text = "Tìm kiếm";
            timKiemButton.UseVisualStyleBackColor = true;
            timKiemButton.Click += TimKiemButton_Click;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.Location = new Point(69, 106);
            timKiemTextBox.Margin = new Padding(0);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(558, 31);
            timKiemTextBox.TabIndex = 0;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 76;
            // 
            // maKhuyenMaiColumn
            // 
            maKhuyenMaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maKhuyenMaiColumn.HeaderText = "Mã khuyến mãi";
            maKhuyenMaiColumn.MinimumWidth = 8;
            maKhuyenMaiColumn.Name = "maKhuyenMaiColumn";
            maKhuyenMaiColumn.Width = 169;
            // 
            // tenKhuyenMaiColumn
            // 
            tenKhuyenMaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenKhuyenMaiColumn.HeaderText = "Tên khuyến mãi";
            tenKhuyenMaiColumn.MinimumWidth = 8;
            tenKhuyenMaiColumn.Name = "tenKhuyenMaiColumn";
            // 
            // loaiGiaTriColumn
            // 
            loaiGiaTriColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            loaiGiaTriColumn.HeaderText = "Loại giá trị";
            loaiGiaTriColumn.MinimumWidth = 8;
            loaiGiaTriColumn.Name = "loaiGiaTriColumn";
            loaiGiaTriColumn.Width = 130;
            // 
            // giaTriColumn
            // 
            giaTriColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            giaTriColumn.HeaderText = "Giá trị";
            giaTriColumn.MinimumWidth = 8;
            giaTriColumn.Name = "giaTriColumn";
            giaTriColumn.Width = 94;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 8;
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.Resizable = DataGridViewTriState.True;
            trangThaiColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            trangThaiColumn.Width = 95;
            // 
            // chiTietButtonColumn
            // 
            chiTietButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chiTietButtonColumn.FillWeight = 30F;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
            chiTietButtonColumn.Resizable = DataGridViewTriState.True;
            chiTietButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            chiTietButtonColumn.Text = "Chi tiết";
            chiTietButtonColumn.UseColumnTextForButtonValue = true;
            chiTietButtonColumn.Width = 103;
            // 
            // suaButtonColumn
            // 
            suaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            suaButtonColumn.FillWeight = 30F;
            suaButtonColumn.HeaderText = "Sửa";
            suaButtonColumn.MinimumWidth = 8;
            suaButtonColumn.Name = "suaButtonColumn";
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
            xoaButtonColumn.Resizable = DataGridViewTriState.True;
            xoaButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            xoaButtonColumn.Text = "Xóa";
            xoaButtonColumn.UseColumnTextForButtonValue = true;
            xoaButtonColumn.Width = 79;
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