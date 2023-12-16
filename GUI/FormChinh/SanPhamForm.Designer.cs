namespace GUI.FormChinh
{
    partial class SanPhamForm
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
            themButton = new Button();
            label2 = new Label();
            label1 = new Label();
            loaiSanPhamComboBox = new ComboBox();
            trangThaiComboBox = new ComboBox();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            sanPhamDataGridView = new DataGridView();
            panel1 = new Panel();
            stt = new DataGridViewTextBoxColumn();
            maSanPhamColumn = new DataGridViewTextBoxColumn();
            loaiSanPhamColumn = new DataGridViewTextBoxColumn();
            tenSanPhamColumn = new DataGridViewTextBoxColumn();
            giaBanColumn = new DataGridViewTextBoxColumn();
            soLuongColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            xoaButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)sanPhamDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 30);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 8;
            label2.Text = "Loại sản phẩm";
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
            // loaiSanPhamComboBox
            // 
            loaiSanPhamComboBox.FormattingEnabled = true;
            loaiSanPhamComboBox.Location = new Point(257, 58);
            loaiSanPhamComboBox.Margin = new Padding(0);
            loaiSanPhamComboBox.Name = "loaiSanPhamComboBox";
            loaiSanPhamComboBox.Size = new Size(182, 33);
            loaiSanPhamComboBox.TabIndex = 5;
            loaiSanPhamComboBox.SelectionChangeCommitted += LoaiSanPhamComboBox_SelectionChangeCommitted;
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang bán", "Chờ xử lý", "Hết hàng", "Ngừng kinh doanh" });
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
            // sanPhamDataGridView
            // 
            sanPhamDataGridView.AllowUserToAddRows = false;
            sanPhamDataGridView.AllowUserToDeleteRows = false;
            sanPhamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sanPhamDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maSanPhamColumn, loaiSanPhamColumn, tenSanPhamColumn, giaBanColumn, soLuongColumn, trangThaiColumn, chiTietButtonColumn, suaButtonColumn, xoaButtonColumn });
            sanPhamDataGridView.Dock = DockStyle.Fill;
            sanPhamDataGridView.Location = new Point(0, 170);
            sanPhamDataGridView.Margin = new Padding(0);
            sanPhamDataGridView.Name = "sanPhamDataGridView";
            sanPhamDataGridView.RowHeadersVisible = false;
            sanPhamDataGridView.RowHeadersWidth = 62;
            sanPhamDataGridView.Size = new Size(1144, 490);
            sanPhamDataGridView.TabIndex = 5;
            sanPhamDataGridView.CellContentClick += SanPhamDataGridView_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(themButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loaiSanPhamComboBox);
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
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 76;
            // 
            // maSanPhamColumn
            // 
            maSanPhamColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maSanPhamColumn.HeaderText = "Mã sản phẩm";
            maSanPhamColumn.MinimumWidth = 8;
            maSanPhamColumn.Name = "maSanPhamColumn";
            maSanPhamColumn.Width = 156;
            // 
            // loaiSanPhamColumn
            // 
            loaiSanPhamColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            loaiSanPhamColumn.HeaderText = "Loại sản phẩm";
            loaiSanPhamColumn.MinimumWidth = 8;
            loaiSanPhamColumn.Name = "loaiSanPhamColumn";
            // 
            // tenSanPhamColumn
            // 
            tenSanPhamColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenSanPhamColumn.HeaderText = "Tên sản phẩm";
            tenSanPhamColumn.MinimumWidth = 8;
            tenSanPhamColumn.Name = "tenSanPhamColumn";
            // 
            // giaBanColumn
            // 
            giaBanColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            giaBanColumn.HeaderText = "Giá bán";
            giaBanColumn.MinimumWidth = 8;
            giaBanColumn.Name = "giaBanColumn";
            giaBanColumn.Width = 108;
            // 
            // soLuongColumn
            // 
            soLuongColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            soLuongColumn.HeaderText = "Số lượng";
            soLuongColumn.MinimumWidth = 8;
            soLuongColumn.Name = "soLuongColumn";
            soLuongColumn.Width = 121;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 8;
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.Width = 125;
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
            // SanPhamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(sanPhamDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SanPhamForm";
            Text = "SanPhamForm";
            Load += SanPhamForm_Load;
            ((System.ComponentModel.ISupportInitialize)sanPhamDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button themButton;
        private Label label2;
        private Label label1;
        private ComboBox loaiSanPhamComboBox;
        private ComboBox trangThaiComboBox;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
        private DataGridView sanPhamDataGridView;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maSanPhamColumn;
        private DataGridViewTextBoxColumn loaiSanPhamColumn;
        private DataGridViewTextBoxColumn tenSanPhamColumn;
        private DataGridViewTextBoxColumn giaBanColumn;
        private DataGridViewTextBoxColumn soLuongColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewButtonColumn chiTietButtonColumn;
        private DataGridViewButtonColumn suaButtonColumn;
        private DataGridViewButtonColumn xoaButtonColumn;
        private Panel panel1;
    }
}