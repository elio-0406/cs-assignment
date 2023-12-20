namespace GUI.FormChon
{
    partial class ChonKhachHangForm
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
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            khachHangDataGridView = new DataGridView();
            maKhachHangColumn = new DataGridViewTextBoxColumn();
            soDienThoaiColumn = new DataGridViewTextBoxColumn();
            chonButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)khachHangDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lamMoiButton
            // 
            lamMoiButton.Location = new Point(451, 8);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(112, 34);
            lamMoiButton.TabIndex = 11;
            lamMoiButton.Text = "Làm mới";
            lamMoiButton.UseVisualStyleBackColor = true;
            lamMoiButton.Click += LamMoiButton_Click;
            // 
            // timKiemButton
            // 
            timKiemButton.Location = new Point(333, 8);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(112, 34);
            timKiemButton.TabIndex = 10;
            timKiemButton.Text = "Tìm kiếm";
            timKiemButton.UseVisualStyleBackColor = true;
            timKiemButton.Click += TimKiemButton_Click;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.Location = new Point(12, 8);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(315, 31);
            timKiemTextBox.TabIndex = 9;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // khachHangDataGridView
            // 
            khachHangDataGridView.AllowUserToAddRows = false;
            khachHangDataGridView.AllowUserToDeleteRows = false;
            khachHangDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            khachHangDataGridView.Columns.AddRange(new DataGridViewColumn[] { maKhachHangColumn, soDienThoaiColumn, chonButtonColumn });
            khachHangDataGridView.Dock = DockStyle.Bottom;
            khachHangDataGridView.Location = new Point(0, 59);
            khachHangDataGridView.Name = "khachHangDataGridView";
            khachHangDataGridView.RowHeadersVisible = false;
            khachHangDataGridView.RowHeadersWidth = 62;
            khachHangDataGridView.Size = new Size(576, 225);
            khachHangDataGridView.TabIndex = 8;
            khachHangDataGridView.CellContentClick += KhachHangDataGridView_CellContentClick;
            // 
            // maKhachHangColumn
            // 
            maKhachHangColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maKhachHangColumn.HeaderText = "Mã khách hàng";
            maKhachHangColumn.MinimumWidth = 8;
            maKhachHangColumn.Name = "maKhachHangColumn";
            maKhachHangColumn.Width = 169;
            // 
            // soDienThoaiColumn
            // 
            soDienThoaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            soDienThoaiColumn.HeaderText = "Số điện thoại";
            soDienThoaiColumn.MinimumWidth = 8;
            soDienThoaiColumn.Name = "soDienThoaiColumn";
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
            // ChonKhachHangForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 284);
            Controls.Add(lamMoiButton);
            Controls.Add(timKiemButton);
            Controls.Add(timKiemTextBox);
            Controls.Add(khachHangDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChonKhachHangForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chọn khách hàng";
            Load += ChonKhachHangForm_Load;
            ((System.ComponentModel.ISupportInitialize)khachHangDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
        private DataGridView khachHangDataGridView;
        private DataGridViewTextBoxColumn maKhachHangColumn;
        private DataGridViewTextBoxColumn soDienThoaiColumn;
        private DataGridViewButtonColumn chonButtonColumn;
    }
}