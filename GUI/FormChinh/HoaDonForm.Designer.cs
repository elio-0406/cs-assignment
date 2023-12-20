namespace GUI.FormChinh
{
    partial class HoaDonForm
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
            hoaDonDataGridView = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            maHoaDonColumn = new DataGridViewTextBoxColumn();
            maNguoiTaoColumn = new DataGridViewTextBoxColumn();
            thoiGianTaoColumn = new DataGridViewTextBoxColumn();
            thanhTienColumn = new DataGridViewTextBoxColumn();
            giamGiaColumn = new DataGridViewTextBoxColumn();
            tongTienColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            thoiGianTaoDateTimePicker = new DateTimePicker();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)hoaDonDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(72, 34);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 10;
            label2.Text = "Tìm theo thời gian tạo";
            // 
            // tuyChonThoiGianComboBox
            // 
            tuyChonThoiGianComboBox.FormattingEnabled = true;
            tuyChonThoiGianComboBox.Items.AddRange(new object[] { "Ngày", "Tháng", "Năm" });
            tuyChonThoiGianComboBox.Location = new Point(72, 62);
            tuyChonThoiGianComboBox.Name = "tuyChonThoiGianComboBox";
            tuyChonThoiGianComboBox.Size = new Size(182, 33);
            tuyChonThoiGianComboBox.TabIndex = 9;
            tuyChonThoiGianComboBox.SelectionChangeCommitted += TuyChonThoiGianComboBox_SelectionChangeCommitted;
            // 
            // hoaDonDataGridView
            // 
            hoaDonDataGridView.AllowUserToAddRows = false;
            hoaDonDataGridView.AllowUserToDeleteRows = false;
            hoaDonDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            hoaDonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hoaDonDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maHoaDonColumn, maNguoiTaoColumn, thoiGianTaoColumn, thanhTienColumn, giamGiaColumn, tongTienColumn, chiTietButtonColumn });
            hoaDonDataGridView.Dock = DockStyle.Fill;
            hoaDonDataGridView.Location = new Point(0, 170);
            hoaDonDataGridView.Margin = new Padding(0);
            hoaDonDataGridView.Name = "hoaDonDataGridView";
            hoaDonDataGridView.RowHeadersVisible = false;
            hoaDonDataGridView.RowHeadersWidth = 62;
            hoaDonDataGridView.Size = new Size(1144, 490);
            hoaDonDataGridView.TabIndex = 7;
            hoaDonDataGridView.CellContentClick += HoaDonDataGridView_CellContentClick;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 76;
            // 
            // maHoaDonColumn
            // 
            maHoaDonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maHoaDonColumn.HeaderText = "Mã hóa đơn";
            maHoaDonColumn.MinimumWidth = 8;
            maHoaDonColumn.Name = "maHoaDonColumn";
            maHoaDonColumn.Width = 145;
            // 
            // maNguoiTaoColumn
            // 
            maNguoiTaoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maNguoiTaoColumn.HeaderText = "Người tạo";
            maNguoiTaoColumn.MinimumWidth = 8;
            maNguoiTaoColumn.Name = "maNguoiTaoColumn";
            maNguoiTaoColumn.Width = 129;
            // 
            // thoiGianTaoColumn
            // 
            thoiGianTaoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            thoiGianTaoColumn.HeaderText = "Thời gian tạo";
            thoiGianTaoColumn.MinimumWidth = 8;
            thoiGianTaoColumn.Name = "thoiGianTaoColumn";
            thoiGianTaoColumn.Width = 152;
            // 
            // thanhTienColumn
            // 
            thanhTienColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            thanhTienColumn.HeaderText = "Thành tiền";
            thanhTienColumn.MinimumWidth = 8;
            thanhTienColumn.Name = "thanhTienColumn";
            // 
            // giamGiaColumn
            // 
            giamGiaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            giamGiaColumn.HeaderText = "Giảm giá";
            giamGiaColumn.MinimumWidth = 8;
            giamGiaColumn.Name = "giamGiaColumn";
            // 
            // tongTienColumn
            // 
            tongTienColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tongTienColumn.HeaderText = "Tổng tiền";
            tongTienColumn.MinimumWidth = 8;
            tongTienColumn.Name = "tongTienColumn";
            // 
            // chiTietButtonColumn
            // 
            chiTietButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chiTietButtonColumn.FillWeight = 30F;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
            chiTietButtonColumn.Text = "Chi tiết";
            chiTietButtonColumn.UseColumnTextForButtonValue = true;
            chiTietButtonColumn.Width = 73;
            // 
            // thoiGianTaoDateTimePicker
            // 
            thoiGianTaoDateTimePicker.Checked = false;
            thoiGianTaoDateTimePicker.Location = new Point(257, 62);
            thoiGianTaoDateTimePicker.Name = "thoiGianTaoDateTimePicker";
            thoiGianTaoDateTimePicker.ShowCheckBox = true;
            thoiGianTaoDateTimePicker.Size = new Size(324, 31);
            thoiGianTaoDateTimePicker.TabIndex = 8;
            thoiGianTaoDateTimePicker.ValueChanged += ThoiGianTaoDateTimePicker_ValueChanged;
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
            lamMoiButton.Location = new Point(713, 107);
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
            timKiemButton.Location = new Point(590, 107);
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
            timKiemTextBox.Location = new Point(72, 109);
            timKiemTextBox.Margin = new Padding(0);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(509, 31);
            timKiemTextBox.TabIndex = 0;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tuyChonThoiGianComboBox);
            panel1.Controls.Add(thoiGianTaoDateTimePicker);
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
            // HoaDonForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(hoaDonDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HoaDonForm";
            Text = "HoaDonForm";
            Load += HoaDonForm_Load;
            ((System.ComponentModel.ISupportInitialize)hoaDonDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private ComboBox tuyChonThoiGianComboBox;
        private DataGridView hoaDonDataGridView;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maHoaDonColumn;
        private DataGridViewTextBoxColumn maNguoiTaoColumn;
        private DataGridViewTextBoxColumn thoiGianTaoColumn;
        private DataGridViewTextBoxColumn thanhTienColumn;
        private DataGridViewTextBoxColumn giamGiaColumn;
        private DataGridViewTextBoxColumn tongTienColumn;
        private DataGridViewButtonColumn chiTietButtonColumn;
        private DateTimePicker thoiGianTaoDateTimePicker;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
        private Panel panel1;
    }
}