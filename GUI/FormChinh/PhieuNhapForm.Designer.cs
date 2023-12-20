namespace GUI.FormChinh
{
    partial class PhieuNhapForm
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
            label1 = new Label();
            trangThaiComboBox = new ComboBox();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            phieuNhapDataGridView = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            tuyChonThoiGianComboBox = new ComboBox();
            thoiGianDateTimePicker = new DateTimePicker();
            stt = new DataGridViewTextBoxColumn();
            maPhieuNhapColumn = new DataGridViewTextBoxColumn();
            maNhaCungCapColumn = new DataGridViewTextBoxColumn();
            maNguoiTaoColumn = new DataGridViewTextBoxColumn();
            thoiGianTaoColumn = new DataGridViewTextBoxColumn();
            tongTienColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)phieuNhapDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            trangThaiComboBox.Items.AddRange(new object[] { "Chờ duyệt", "Đã duyệt", "Không duyệt", "Đã nhập hàng" });
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
            lamMoiButton.Location = new Point(749, 106);
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
            timKiemButton.Location = new Point(627, 106);
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
            timKiemTextBox.Size = new Size(545, 31);
            timKiemTextBox.TabIndex = 0;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // phieuNhapDataGridView
            // 
            phieuNhapDataGridView.AllowUserToAddRows = false;
            phieuNhapDataGridView.AllowUserToDeleteRows = false;
            phieuNhapDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            phieuNhapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phieuNhapDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maPhieuNhapColumn, maNhaCungCapColumn, maNguoiTaoColumn, thoiGianTaoColumn, tongTienColumn, trangThaiColumn, chiTietButtonColumn });
            phieuNhapDataGridView.Dock = DockStyle.Fill;
            phieuNhapDataGridView.Location = new Point(0, 170);
            phieuNhapDataGridView.Margin = new Padding(0);
            phieuNhapDataGridView.Name = "phieuNhapDataGridView";
            phieuNhapDataGridView.ReadOnly = true;
            phieuNhapDataGridView.RowHeadersVisible = false;
            phieuNhapDataGridView.RowHeadersWidth = 62;
            phieuNhapDataGridView.Size = new Size(1144, 490);
            phieuNhapDataGridView.TabIndex = 5;
            phieuNhapDataGridView.CellContentClick += PhieuNhapDataGridView_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
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
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(254, 30);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 10;
            label2.Text = "Tìm theo thời gian tạo";
            // 
            // tuyChonThoiGianComboBox
            // 
            tuyChonThoiGianComboBox.FormattingEnabled = true;
            tuyChonThoiGianComboBox.Items.AddRange(new object[] { "Ngày", "Tháng", "Năm" });
            tuyChonThoiGianComboBox.Location = new Point(254, 58);
            tuyChonThoiGianComboBox.Name = "tuyChonThoiGianComboBox";
            tuyChonThoiGianComboBox.Size = new Size(182, 33);
            tuyChonThoiGianComboBox.TabIndex = 9;
            tuyChonThoiGianComboBox.SelectionChangeCommitted += TuyChonThoiGianComboBox_SelectionChangeCommitted;
            // 
            // thoiGianDateTimePicker
            // 
            thoiGianDateTimePicker.Checked = false;
            thoiGianDateTimePicker.Location = new Point(439, 58);
            thoiGianDateTimePicker.Name = "thoiGianDateTimePicker";
            thoiGianDateTimePicker.ShowCheckBox = true;
            thoiGianDateTimePicker.Size = new Size(324, 31);
            thoiGianDateTimePicker.TabIndex = 8;
            thoiGianDateTimePicker.ValueChanged += ThoiGianDateTimePicker_ValueChanged;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Width = 76;
            // 
            // maPhieuNhapColumn
            // 
            maPhieuNhapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maPhieuNhapColumn.HeaderText = "Mã phiếu nhập";
            maPhieuNhapColumn.MinimumWidth = 8;
            maPhieuNhapColumn.Name = "maPhieuNhapColumn";
            maPhieuNhapColumn.ReadOnly = true;
            // 
            // maNhaCungCapColumn
            // 
            maNhaCungCapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNhaCungCapColumn.HeaderText = "Mã nhà cung cấp";
            maNhaCungCapColumn.MinimumWidth = 8;
            maNhaCungCapColumn.Name = "maNhaCungCapColumn";
            maNhaCungCapColumn.ReadOnly = true;
            // 
            // maNguoiTaoColumn
            // 
            maNguoiTaoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNguoiTaoColumn.HeaderText = "Người tạo";
            maNguoiTaoColumn.MinimumWidth = 8;
            maNguoiTaoColumn.Name = "maNguoiTaoColumn";
            maNguoiTaoColumn.ReadOnly = true;
            // 
            // thoiGianTaoColumn
            // 
            thoiGianTaoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            thoiGianTaoColumn.HeaderText = "Thời gian tạo";
            thoiGianTaoColumn.MinimumWidth = 8;
            thoiGianTaoColumn.Name = "thoiGianTaoColumn";
            thoiGianTaoColumn.ReadOnly = true;
            // 
            // tongTienColumn
            // 
            tongTienColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tongTienColumn.HeaderText = "Tổng tiền";
            tongTienColumn.MinimumWidth = 8;
            tongTienColumn.Name = "tongTienColumn";
            tongTienColumn.ReadOnly = true;
            tongTienColumn.Width = 123;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 8;
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.ReadOnly = true;
            trangThaiColumn.Width = 125;
            // 
            // chiTietButtonColumn
            // 
            chiTietButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
            chiTietButtonColumn.ReadOnly = true;
            chiTietButtonColumn.Text = "Chi tiết";
            chiTietButtonColumn.UseColumnTextForButtonValue = true;
            chiTietButtonColumn.Width = 73;
            // 
            // PhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(phieuNhapDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhieuNhapForm";
            Text = "PhieuNhapForm";
            Load += PhieuNhapForm_Load;
            ((System.ComponentModel.ISupportInitialize)phieuNhapDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ComboBox trangThaiComboBox;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
        private DataGridView phieuNhapDataGridView;
        private Panel panel1;
        private Label label2;
        private ComboBox tuyChonThoiGianComboBox;
        private DateTimePicker thoiGianDateTimePicker;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maPhieuNhapColumn;
        private DataGridViewTextBoxColumn maNhaCungCapColumn;
        private DataGridViewTextBoxColumn maNguoiTaoColumn;
        private DataGridViewTextBoxColumn thoiGianTaoColumn;
        private DataGridViewTextBoxColumn tongTienColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewButtonColumn chiTietButtonColumn;
    }
}