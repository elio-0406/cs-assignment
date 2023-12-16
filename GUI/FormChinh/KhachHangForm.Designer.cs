namespace GUI.FormChinh
{
    partial class KhachHangForm
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
            khachHangDataGridView = new DataGridView();
            themButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gioiTinhComboBox = new ComboBox();
            hangThanhVienComboBox = new ComboBox();
            trangThaiComboBox = new ComboBox();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            panel1 = new Panel();
            stt = new DataGridViewTextBoxColumn();
            maKhachHangColumn = new DataGridViewTextBoxColumn();
            hoTenColumn = new DataGridViewTextBoxColumn();
            soDienThoaiColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            hangThanhVienColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            xoaButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)khachHangDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // khachHangDataGridView
            // 
            khachHangDataGridView.AllowUserToAddRows = false;
            khachHangDataGridView.AllowUserToDeleteRows = false;
            khachHangDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            khachHangDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maKhachHangColumn, hoTenColumn, soDienThoaiColumn, trangThaiColumn, hangThanhVienColumn, chiTietButtonColumn, suaButtonColumn, xoaButtonColumn });
            khachHangDataGridView.Dock = DockStyle.Fill;
            khachHangDataGridView.Location = new Point(0, 170);
            khachHangDataGridView.Margin = new Padding(0);
            khachHangDataGridView.Name = "khachHangDataGridView";
            khachHangDataGridView.RowHeadersVisible = false;
            khachHangDataGridView.RowHeadersWidth = 62;
            khachHangDataGridView.Size = new Size(1144, 490);
            khachHangDataGridView.TabIndex = 5;
            khachHangDataGridView.CellContentClick += KhachHangDataGridView_CellContentClick;
            // 
            // themButton
            // 
            themButton.Location = new Point(851, 106);
            themButton.Margin = new Padding(0);
            themButton.Name = "themButton";
            themButton.Size = new Size(112, 34);
            themButton.TabIndex = 10;
            themButton.Text = "Thêm";
            themButton.UseVisualStyleBackColor = true;
            themButton.Click += ThemButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 30);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 9;
            label3.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 30);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 8;
            label2.Text = "Hạng thành viên";
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
            // gioiTinhComboBox
            // 
            gioiTinhComboBox.FormattingEnabled = true;
            gioiTinhComboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioiTinhComboBox.Location = new Point(445, 58);
            gioiTinhComboBox.Margin = new Padding(0);
            gioiTinhComboBox.Name = "gioiTinhComboBox";
            gioiTinhComboBox.Size = new Size(182, 33);
            gioiTinhComboBox.TabIndex = 6;
            gioiTinhComboBox.SelectionChangeCommitted += GioiTinhComboBox_SelectionChangeCommitted;
            // 
            // hangThanhVienComboBox
            // 
            hangThanhVienComboBox.FormattingEnabled = true;
            hangThanhVienComboBox.Items.AddRange(new object[] { "Đồng", "Bạc", "Vàng" });
            hangThanhVienComboBox.Location = new Point(257, 58);
            hangThanhVienComboBox.Margin = new Padding(0);
            hangThanhVienComboBox.Name = "hangThanhVienComboBox";
            hangThanhVienComboBox.Size = new Size(182, 33);
            hangThanhVienComboBox.TabIndex = 5;
            hangThanhVienComboBox.SelectionChangeCommitted += HangThanhVienComboBox_SelectionChangeCommitted;
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hoạt động", "Tạm đình chỉ", "Đã xóa" });
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
            // panel1
            // 
            panel1.Controls.Add(themButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(gioiTinhComboBox);
            panel1.Controls.Add(hangThanhVienComboBox);
            panel1.Controls.Add(trangThaiComboBox);
            panel1.Controls.Add(xuatExcel);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(timKiemButton);
            panel1.Controls.Add(timKiemTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 170);
            panel1.TabIndex = 4;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 76;
            // 
            // maKhachHangColumn
            // 
            maKhachHangColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maKhachHangColumn.HeaderText = "Mã khách hàng";
            maKhachHangColumn.MinimumWidth = 8;
            maKhachHangColumn.Name = "maKhachHangColumn";
            maKhachHangColumn.Width = 169;
            // 
            // hoTenColumn
            // 
            hoTenColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hoTenColumn.HeaderText = "Họ tên";
            hoTenColumn.MinimumWidth = 8;
            hoTenColumn.Name = "hoTenColumn";
            // 
            // soDienThoaiColumn
            // 
            soDienThoaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            soDienThoaiColumn.HeaderText = "Số điện thoại";
            soDienThoaiColumn.MinimumWidth = 8;
            soDienThoaiColumn.Name = "soDienThoaiColumn";
            soDienThoaiColumn.Width = 153;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 8;
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.Width = 125;
            // 
            // hangThanhVienColumn
            // 
            hangThanhVienColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hangThanhVienColumn.HeaderText = "Hạng thành viên";
            hangThanhVienColumn.MinimumWidth = 8;
            hangThanhVienColumn.Name = "hangThanhVienColumn";
            hangThanhVienColumn.Width = 178;
            // 
            // chiTietButtonColumn
            // 
            chiTietButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
            chiTietButtonColumn.Text = "Chi tiết";
            chiTietButtonColumn.UseColumnTextForButtonValue = true;
            chiTietButtonColumn.Width = 73;
            // 
            // suaButtonColumn
            // 
            suaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            suaButtonColumn.HeaderText = "Sửa";
            suaButtonColumn.MinimumWidth = 8;
            suaButtonColumn.Name = "suaButtonColumn";
            suaButtonColumn.Text = "Sửa";
            suaButtonColumn.UseColumnTextForButtonValue = true;
            suaButtonColumn.Width = 48;
            // 
            // xoaButtonColumn
            // 
            xoaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            xoaButtonColumn.HeaderText = "Xóa";
            xoaButtonColumn.MinimumWidth = 8;
            xoaButtonColumn.Name = "xoaButtonColumn";
            xoaButtonColumn.Text = "Xóa";
            xoaButtonColumn.UseColumnTextForButtonValue = true;
            xoaButtonColumn.Width = 49;
            // 
            // KhachHangForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(khachHangDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhachHangForm";
            Text = "KhachHangForm";
            Load += KhachHangForm_Load;
            ((System.ComponentModel.ISupportInitialize)khachHangDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView khachHangDataGridView;
        private Button themButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox gioiTinhComboBox;
        private ComboBox hangThanhVienComboBox;
        private ComboBox trangThaiComboBox;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
        private Panel panel1;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maKhachHangColumn;
        private DataGridViewTextBoxColumn hoTenColumn;
        private DataGridViewTextBoxColumn soDienThoaiColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewTextBoxColumn hangThanhVienColumn;
        private DataGridViewButtonColumn chiTietButtonColumn;
        private DataGridViewButtonColumn suaButtonColumn;
        private DataGridViewButtonColumn xoaButtonColumn;
    }
}