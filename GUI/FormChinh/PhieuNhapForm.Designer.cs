﻿namespace GUI.FormChinh
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
            stt = new DataGridViewTextBoxColumn();
            maPhieuNhapColumn = new DataGridViewTextBoxColumn();
            maNguoiTaoColumn = new DataGridViewTextBoxColumn();
            nguoiDuyetColumn = new DataGridViewTextBoxColumn();
            nguoiNhapColumn = new DataGridViewTextBoxColumn();
            tongTienColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            panel1 = new Panel();
            label2 = new Label();
            tuyChonThoiGianComboBox = new ComboBox();
            thoiGianDateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)phieuNhapDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // phieuNhapDataGridView
            // 
            phieuNhapDataGridView.AllowUserToAddRows = false;
            phieuNhapDataGridView.AllowUserToDeleteRows = false;
            phieuNhapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phieuNhapDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maPhieuNhapColumn, maNguoiTaoColumn, nguoiDuyetColumn, nguoiNhapColumn, tongTienColumn, trangThaiColumn, chiTietButtonColumn });
            phieuNhapDataGridView.Dock = DockStyle.Fill;
            phieuNhapDataGridView.Location = new Point(0, 170);
            phieuNhapDataGridView.Margin = new Padding(0);
            phieuNhapDataGridView.Name = "phieuNhapDataGridView";
            phieuNhapDataGridView.RowHeadersVisible = false;
            phieuNhapDataGridView.RowHeadersWidth = 62;
            phieuNhapDataGridView.Size = new Size(1144, 490);
            phieuNhapDataGridView.TabIndex = 5;
            phieuNhapDataGridView.CellContentClick += PhieuNhapDataGridView_CellContentClick;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 76;
            // 
            // maPhieuNhapColumn
            // 
            maPhieuNhapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maPhieuNhapColumn.HeaderText = "Mã phiếu nhập";
            maPhieuNhapColumn.MinimumWidth = 8;
            maPhieuNhapColumn.Name = "maPhieuNhapColumn";
            // 
            // maNguoiTaoColumn
            // 
            maNguoiTaoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNguoiTaoColumn.HeaderText = "Người tạo";
            maNguoiTaoColumn.MinimumWidth = 8;
            maNguoiTaoColumn.Name = "maNguoiTaoColumn";
            // 
            // nguoiDuyetColumn
            // 
            nguoiDuyetColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nguoiDuyetColumn.HeaderText = "Người duyệt";
            nguoiDuyetColumn.MinimumWidth = 8;
            nguoiDuyetColumn.Name = "nguoiDuyetColumn";
            // 
            // nguoiNhapColumn
            // 
            nguoiNhapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nguoiNhapColumn.HeaderText = "Người nhập";
            nguoiNhapColumn.MinimumWidth = 8;
            nguoiNhapColumn.Name = "nguoiNhapColumn";
            // 
            // tongTienColumn
            // 
            tongTienColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tongTienColumn.HeaderText = "Tổng tiền";
            tongTienColumn.MinimumWidth = 8;
            tongTienColumn.Name = "tongTienColumn";
            tongTienColumn.Width = 114;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 8;
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.Width = 116;
            // 
            // chiTietButtonColumn
            // 
            chiTietButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
            chiTietButtonColumn.Text = "Chi tiết";
            chiTietButtonColumn.UseColumnTextForButtonValue = true;
            chiTietButtonColumn.Width = 43;
            // 
            // panel1
            // 
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
            label2.Location = new Point(254, 30);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
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
        private DataGridViewTextBoxColumn maNguoiTaoColumn;
        private DataGridViewTextBoxColumn nguoiDuyetColumn;
        private DataGridViewTextBoxColumn nguoiNhapColumn;
        private DataGridViewTextBoxColumn tongTienColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewButtonColumn chiTietButtonColumn;
    }
}