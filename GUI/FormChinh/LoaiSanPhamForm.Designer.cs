namespace GUI.FormChinh
{
    partial class LoaiSanPhamForm
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
            loaiSanPhamDataGridView = new DataGridView();
            panel1 = new Panel();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            themButton = new Button();
            stt = new DataGridViewTextBoxColumn();
            maPhanQuyenColumn = new DataGridViewTextBoxColumn();
            tenPhanQuyenColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            xoaButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loaiSanPhamDataGridView
            // 
            loaiSanPhamDataGridView.AllowUserToAddRows = false;
            loaiSanPhamDataGridView.AllowUserToDeleteRows = false;
            loaiSanPhamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loaiSanPhamDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maPhanQuyenColumn, tenPhanQuyenColumn, trangThaiColumn, suaButtonColumn, xoaButtonColumn });
            loaiSanPhamDataGridView.Dock = DockStyle.Fill;
            loaiSanPhamDataGridView.Location = new Point(0, 87);
            loaiSanPhamDataGridView.Margin = new Padding(0);
            loaiSanPhamDataGridView.Name = "loaiSanPhamDataGridView";
            loaiSanPhamDataGridView.RowHeadersVisible = false;
            loaiSanPhamDataGridView.RowHeadersWidth = 62;
            loaiSanPhamDataGridView.Size = new Size(1144, 573);
            loaiSanPhamDataGridView.TabIndex = 3;
            loaiSanPhamDataGridView.CellContentClick += LoaiSanPhamDataGridView_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(themButton);
            panel1.Controls.Add(xuatExcel);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(timKiemButton);
            panel1.Controls.Add(timKiemTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 87);
            panel1.TabIndex = 2;
            // 
            // xuatExcel
            // 
            xuatExcel.Location = new Point(738, 29);
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
            lamMoiButton.Location = new Point(479, 29);
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
            timKiemButton.Location = new Point(340, 29);
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
            timKiemTextBox.Location = new Point(54, 29);
            timKiemTextBox.Margin = new Padding(0);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(280, 31);
            timKiemTextBox.TabIndex = 0;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // themButton
            // 
            themButton.Location = new Point(614, 29);
            themButton.Name = "themButton";
            themButton.Size = new Size(112, 34);
            themButton.TabIndex = 4;
            themButton.Text = "Thêm";
            themButton.UseVisualStyleBackColor = true;
            themButton.Click += ThemButton_Click;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 76;
            // 
            // maPhanQuyenColumn
            // 
            maPhanQuyenColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maPhanQuyenColumn.HeaderText = "Mã phân quyền";
            maPhanQuyenColumn.MinimumWidth = 8;
            maPhanQuyenColumn.Name = "maPhanQuyenColumn";
            // 
            // tenPhanQuyenColumn
            // 
            tenPhanQuyenColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenPhanQuyenColumn.HeaderText = "Tên phân quyền";
            tenPhanQuyenColumn.MinimumWidth = 8;
            tenPhanQuyenColumn.Name = "tenPhanQuyenColumn";
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 8;
            trangThaiColumn.Name = "trangThaiColumn";
            // 
            // suaButtonColumn
            // 
            suaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            xoaButtonColumn.HeaderText = "Xóa";
            xoaButtonColumn.MinimumWidth = 8;
            xoaButtonColumn.Name = "xoaButtonColumn";
            xoaButtonColumn.Resizable = DataGridViewTriState.True;
            xoaButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            xoaButtonColumn.Text = "Xóa";
            xoaButtonColumn.UseColumnTextForButtonValue = true;
            xoaButtonColumn.Width = 79;
            // 
            // LoaiSanPhamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(loaiSanPhamDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoaiSanPhamForm";
            Text = "LoaiSanPhamForm";
            Load += LoaiSanPhamForm_Load;
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView loaiSanPhamDataGridView;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maPhanQuyenColumn;
        private DataGridViewTextBoxColumn tenPhanQuyenColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewButtonColumn suaButtonColumn;
        private DataGridViewButtonColumn xoaButtonColumn;
        private Panel panel1;
        private Button themButton;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
    }
}