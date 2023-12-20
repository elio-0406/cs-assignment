namespace GUI.FormChon
{
    partial class ChonKhuyenMaiForm
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
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            khuyenMaiDataGridView = new DataGridView();
            maKhuyenMaiColumn = new DataGridViewTextBoxColumn();
            tenKhuyenMaiColumn = new DataGridViewTextBoxColumn();
            loaiGiaTriColumn = new DataGridViewTextBoxColumn();
            giaTriColumn = new DataGridViewTextBoxColumn();
            chonButtonColumn = new DataGridViewButtonColumn();
            lamMoiButton = new Button();
            ((System.ComponentModel.ISupportInitialize)khuyenMaiDataGridView).BeginInit();
            SuspendLayout();
            // 
            // timKiemButton
            // 
            timKiemButton.Location = new Point(558, 15);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(112, 34);
            timKiemButton.TabIndex = 6;
            timKiemButton.Text = "Tìm kiếm";
            timKiemButton.UseVisualStyleBackColor = true;
            timKiemButton.Click += TimKiemButton_Click;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.Location = new Point(12, 15);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(540, 31);
            timKiemTextBox.TabIndex = 5;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // khuyenMaiDataGridView
            // 
            khuyenMaiDataGridView.AllowUserToAddRows = false;
            khuyenMaiDataGridView.AllowUserToDeleteRows = false;
            khuyenMaiDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            khuyenMaiDataGridView.Columns.AddRange(new DataGridViewColumn[] { maKhuyenMaiColumn, tenKhuyenMaiColumn, loaiGiaTriColumn, giaTriColumn, chonButtonColumn });
            khuyenMaiDataGridView.Dock = DockStyle.Bottom;
            khuyenMaiDataGridView.Location = new Point(0, 66);
            khuyenMaiDataGridView.Name = "khuyenMaiDataGridView";
            khuyenMaiDataGridView.RowHeadersVisible = false;
            khuyenMaiDataGridView.RowHeadersWidth = 62;
            khuyenMaiDataGridView.Size = new Size(800, 225);
            khuyenMaiDataGridView.TabIndex = 4;
            khuyenMaiDataGridView.CellContentClick += KhuyenMaiDataGridView_CellContentClick;
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
            // chonButtonColumn
            // 
            chonButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chonButtonColumn.HeaderText = "Chọn";
            chonButtonColumn.MinimumWidth = 8;
            chonButtonColumn.Name = "chonButtonColumn";
            chonButtonColumn.Text = "Chọn";
            chonButtonColumn.UseColumnTextForButtonValue = true;
            chonButtonColumn.Width = 60;
            // 
            // lamMoiButton
            // 
            lamMoiButton.Location = new Point(676, 15);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(112, 34);
            lamMoiButton.TabIndex = 7;
            lamMoiButton.Text = "Làm mới";
            lamMoiButton.UseVisualStyleBackColor = true;
            lamMoiButton.Click += LamMoiButton_Click;
            // 
            // ChonKhuyenMaiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 291);
            Controls.Add(lamMoiButton);
            Controls.Add(timKiemButton);
            Controls.Add(timKiemTextBox);
            Controls.Add(khuyenMaiDataGridView);
            MaximizeBox = false;
            Name = "ChonKhuyenMaiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chọn khuyến mãi";
            FormClosed += ChonKhuyenMaiForm_FormClosed;
            Load += ChonKhuyenMaiForm_Load;
            ((System.ComponentModel.ISupportInitialize)khuyenMaiDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button timKiemButton;
        private TextBox timKiemTextBox;
        private DataGridView khuyenMaiDataGridView;
        private DataGridViewTextBoxColumn maKhuyenMaiColumn;
        private DataGridViewTextBoxColumn tenKhuyenMaiColumn;
        private DataGridViewTextBoxColumn loaiGiaTriColumn;
        private DataGridViewTextBoxColumn giaTriColumn;
        private DataGridViewButtonColumn chonButtonColumn;
        private Button lamMoiButton;
    }
}