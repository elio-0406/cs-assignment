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
            stt = new DataGridViewTextBoxColumn();
            maKhachHangColumn = new DataGridViewTextBoxColumn();
            hoTenColumn = new DataGridViewTextBoxColumn();
            soDienThoaiColumn = new DataGridViewTextBoxColumn();
            hangThanhVienColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            xoaButtonColumn = new DataGridViewButtonColumn();
            themButton = new Button();
            label2 = new Label();
            label1 = new Label();
            hangThanhVienComboBox = new ComboBox();
            trangThaiComboBox = new ComboBox();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)khachHangDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // khachHangDataGridView
            // 
            khachHangDataGridView.AllowUserToAddRows = false;
            khachHangDataGridView.AllowUserToDeleteRows = false;
            khachHangDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            khachHangDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            khachHangDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maKhachHangColumn, hoTenColumn, soDienThoaiColumn, hangThanhVienColumn, trangThaiColumn, chiTietButtonColumn, suaButtonColumn, xoaButtonColumn });
            khachHangDataGridView.Dock = DockStyle.Fill;
            khachHangDataGridView.Location = new Point(0, 170);
            khachHangDataGridView.Margin = new Padding(0);
            khachHangDataGridView.Name = "khachHangDataGridView";
            khachHangDataGridView.ReadOnly = true;
            khachHangDataGridView.RowHeadersVisible = false;
            khachHangDataGridView.RowHeadersWidth = 62;
            khachHangDataGridView.Size = new Size(1144, 490);
            khachHangDataGridView.TabIndex = 5;
            khachHangDataGridView.CellContentClick += KhachHangDataGridView_CellContentClick;
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
            // maKhachHangColumn
            // 
            maKhachHangColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maKhachHangColumn.HeaderText = "Mã khách hàng";
            maKhachHangColumn.MinimumWidth = 8;
            maKhachHangColumn.Name = "maKhachHangColumn";
            maKhachHangColumn.ReadOnly = true;
            maKhachHangColumn.Width = 155;
            // 
            // hoTenColumn
            // 
            hoTenColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hoTenColumn.HeaderText = "Họ tên";
            hoTenColumn.MinimumWidth = 8;
            hoTenColumn.Name = "hoTenColumn";
            hoTenColumn.ReadOnly = true;
            // 
            // soDienThoaiColumn
            // 
            soDienThoaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            soDienThoaiColumn.HeaderText = "Số điện thoại";
            soDienThoaiColumn.MinimumWidth = 8;
            soDienThoaiColumn.Name = "soDienThoaiColumn";
            soDienThoaiColumn.ReadOnly = true;
            soDienThoaiColumn.Width = 141;
            // 
            // hangThanhVienColumn
            // 
            hangThanhVienColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hangThanhVienColumn.HeaderText = "Hạng thành viên";
            hangThanhVienColumn.MinimumWidth = 8;
            hangThanhVienColumn.Name = "hangThanhVienColumn";
            hangThanhVienColumn.ReadOnly = true;
            hangThanhVienColumn.Width = 135;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 8;
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.ReadOnly = true;
            trangThaiColumn.Width = 116;
            // 
            // chiTietButtonColumn
            // 
            chiTietButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chiTietButtonColumn.FillWeight = 30F;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
            chiTietButtonColumn.ReadOnly = true;
            chiTietButtonColumn.Text = "Chi tiết";
            chiTietButtonColumn.UseColumnTextForButtonValue = true;
            chiTietButtonColumn.Width = 43;
            // 
            // suaButtonColumn
            // 
            suaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            suaButtonColumn.FillWeight = 30F;
            suaButtonColumn.HeaderText = "Sửa";
            suaButtonColumn.MinimumWidth = 8;
            suaButtonColumn.Name = "suaButtonColumn";
            suaButtonColumn.ReadOnly = true;
            suaButtonColumn.Text = "Sửa";
            suaButtonColumn.UseColumnTextForButtonValue = true;
            suaButtonColumn.Width = 48;
            // 
            // xoaButtonColumn
            // 
            xoaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            xoaButtonColumn.FillWeight = 30F;
            xoaButtonColumn.HeaderText = "Xóa";
            xoaButtonColumn.MinimumWidth = 8;
            xoaButtonColumn.Name = "xoaButtonColumn";
            xoaButtonColumn.ReadOnly = true;
            xoaButtonColumn.Text = "Xóa";
            xoaButtonColumn.UseColumnTextForButtonValue = true;
            xoaButtonColumn.Width = 49;
            // 
            // themButton
            // 
            themButton.BackColor = Color.Teal;
            themButton.FlatAppearance.BorderSize = 0;
            themButton.FlatStyle = FlatStyle.Flat;
            themButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            themButton.ForeColor = Color.White;
            themButton.Location = new Point(841, 106);
            themButton.Margin = new Padding(0);
            themButton.Name = "themButton";
            themButton.Size = new Size(112, 34);
            themButton.TabIndex = 10;
            themButton.Text = "Thêm";
            themButton.UseVisualStyleBackColor = false;
            themButton.Click += ThemButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(257, 30);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 8;
            label2.Text = "Hạng thành viên";
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
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hoạt động", "Ngừng hoạt động" });
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
            lamMoiButton.Location = new Point(660, 106);
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
            timKiemButton.Location = new Point(537, 106);
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
            timKiemTextBox.Size = new Size(458, 31);
            timKiemTextBox.TabIndex = 0;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(themButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
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
        private Label label2;
        private Label label1;
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
        private DataGridViewTextBoxColumn hangThanhVienColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewButtonColumn chiTietButtonColumn;
        private DataGridViewButtonColumn suaButtonColumn;
        private DataGridViewButtonColumn xoaButtonColumn;
    }
}