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
            panel1 = new Panel();
            themButton = new Button();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            stt = new DataGridViewTextBoxColumn();
            maNhaCungCapColumn = new DataGridViewTextBoxColumn();
            tenNhaCungCapColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewTextBoxColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            xoaButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nhaCungCapDataGridView
            // 
            nhaCungCapDataGridView.AllowUserToAddRows = false;
            nhaCungCapDataGridView.AllowUserToDeleteRows = false;
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
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
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
            maNhaCungCapColumn.Width = 184;
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
            trangThaiColumn.Width = 125;
            // 
            // chiTietButtonColumn
            // 
            chiTietButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
            chiTietButtonColumn.Width = 103;
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
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maNhaCungCapColumn;
        private DataGridViewTextBoxColumn tenNhaCungCapColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewTextBoxColumn chiTietButtonColumn;
        private DataGridViewButtonColumn suaButtonColumn;
        private DataGridViewButtonColumn xoaButtonColumn;
    }
}