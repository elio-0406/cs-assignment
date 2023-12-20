namespace GUI.FormChinh
{
    partial class NhaCungCapForm
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
            nhaCungCapDataGridView = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            maNhaCungCapColumn = new DataGridViewTextBoxColumn();
            tenNhaCungCapColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            xoaButtonColumn = new DataGridViewButtonColumn();
            panel1 = new Panel();
            label1 = new Label();
            trangThaiComboBox = new ComboBox();
            themButton = new Button();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nhaCungCapDataGridView
            // 
            nhaCungCapDataGridView.AllowUserToAddRows = false;
            nhaCungCapDataGridView.AllowUserToDeleteRows = false;
            nhaCungCapDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            nhaCungCapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nhaCungCapDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maNhaCungCapColumn, tenNhaCungCapColumn, trangThaiColumn, chiTietButtonColumn, suaButtonColumn, xoaButtonColumn });
            nhaCungCapDataGridView.Dock = DockStyle.Fill;
            nhaCungCapDataGridView.Location = new Point(0, 87);
            nhaCungCapDataGridView.Margin = new Padding(0);
            nhaCungCapDataGridView.Name = "nhaCungCapDataGridView";
            nhaCungCapDataGridView.RowHeadersVisible = false;
            nhaCungCapDataGridView.RowHeadersWidth = 62;
            nhaCungCapDataGridView.Size = new Size(1144, 573);
            nhaCungCapDataGridView.TabIndex = 5;
            nhaCungCapDataGridView.CellContentClick += NhaCungCapDataGridView_CellContentClick;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 76;
            // 
            // maNhaCungCapColumn
            // 
            maNhaCungCapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maNhaCungCapColumn.HeaderText = "Mã nhà cung cấp";
            maNhaCungCapColumn.MinimumWidth = 8;
            maNhaCungCapColumn.Name = "maNhaCungCapColumn";
            maNhaCungCapColumn.Width = 144;
            // 
            // tenNhaCungCapColumn
            // 
            tenNhaCungCapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenNhaCungCapColumn.HeaderText = "Tên nhà cung cấp";
            tenNhaCungCapColumn.MinimumWidth = 8;
            tenNhaCungCapColumn.Name = "tenNhaCungCapColumn";
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
            chiTietButtonColumn.FillWeight = 30F;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trangThaiComboBox);
            panel1.Controls.Add(themButton);
            panel1.Controls.Add(xuatExcel);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(timKiemButton);
            panel1.Controls.Add(timKiemTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 87);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 13);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 9;
            label1.Text = "Trạng thái";
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hợp tác", "Ngừng hợp tác" });
            trangThaiComboBox.Location = new Point(54, 41);
            trangThaiComboBox.Margin = new Padding(0);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.Size = new Size(182, 33);
            trangThaiComboBox.TabIndex = 8;
            trangThaiComboBox.SelectionChangeCommitted += TrangThaiComboBox_SelectionChangeCommitted;
            // 
            // themButton
            // 
            themButton.BackColor = Color.Teal;
            themButton.FlatAppearance.BorderSize = 0;
            themButton.FlatStyle = FlatStyle.Flat;
            themButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            themButton.ForeColor = Color.White;
            themButton.Location = new Point(854, 39);
            themButton.Name = "themButton";
            themButton.Size = new Size(112, 34);
            themButton.TabIndex = 4;
            themButton.Text = "Thêm";
            themButton.UseVisualStyleBackColor = false;
            themButton.Click += ThemButton_Click;
            // 
            // xuatExcel
            // 
            xuatExcel.BackColor = Color.ForestGreen;
            xuatExcel.FlatAppearance.BorderSize = 0;
            xuatExcel.FlatStyle = FlatStyle.Flat;
            xuatExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            xuatExcel.ForeColor = Color.White;
            xuatExcel.Location = new Point(979, 39);
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
            lamMoiButton.Location = new Point(662, 39);
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
            timKiemButton.Location = new Point(541, 39);
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
            timKiemTextBox.Location = new Point(252, 43);
            timKiemTextBox.Margin = new Padding(0);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(280, 31);
            timKiemTextBox.TabIndex = 0;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // NhaCungCapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(nhaCungCapDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhaCungCapForm";
            Text = "NhaCungCapForm";
            Load += NhaCungCapForm_Load;
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView nhaCungCapDataGridView;
        private Panel panel1;
        private Button themButton;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
        private Label label1;
        private ComboBox trangThaiComboBox;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maNhaCungCapColumn;
        private DataGridViewTextBoxColumn tenNhaCungCapColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewButtonColumn suaButtonColumn;
        private DataGridViewButtonColumn xoaButtonColumn;
        private DataGridViewButtonColumn chiTietButtonColumn;
    }
}