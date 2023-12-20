namespace GUI.FormChon
{
    partial class ChonNhaCungCapForm
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
            maNhaCungCapColumn = new DataGridViewTextBoxColumn();
            tenNhaCungCapColumn = new DataGridViewTextBoxColumn();
            chonButtonColumn = new DataGridViewButtonColumn();
            timKiemTextBox = new TextBox();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nhaCungCapDataGridView
            // 
            nhaCungCapDataGridView.AllowUserToAddRows = false;
            nhaCungCapDataGridView.AllowUserToDeleteRows = false;
            nhaCungCapDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            nhaCungCapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nhaCungCapDataGridView.Columns.AddRange(new DataGridViewColumn[] { maNhaCungCapColumn, tenNhaCungCapColumn, chonButtonColumn });
            nhaCungCapDataGridView.Dock = DockStyle.Bottom;
            nhaCungCapDataGridView.Location = new Point(0, 52);
            nhaCungCapDataGridView.Name = "nhaCungCapDataGridView";
            nhaCungCapDataGridView.RowHeadersVisible = false;
            nhaCungCapDataGridView.RowHeadersWidth = 62;
            nhaCungCapDataGridView.Size = new Size(549, 225);
            nhaCungCapDataGridView.TabIndex = 0;
            nhaCungCapDataGridView.CellContentClick += NhaCungCapDataGridView_CellContentClick;
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
            // timKiemTextBox
            // 
            timKiemTextBox.Location = new Point(12, 12);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(289, 31);
            timKiemTextBox.TabIndex = 1;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // lamMoiButton
            // 
            lamMoiButton.BackColor = Color.SkyBlue;
            lamMoiButton.FlatAppearance.BorderSize = 0;
            lamMoiButton.FlatStyle = FlatStyle.Flat;
            lamMoiButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lamMoiButton.Location = new Point(425, 12);
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
            timKiemButton.Location = new Point(307, 12);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(112, 34);
            timKiemButton.TabIndex = 3;
            timKiemButton.Text = "Tìm kiếm";
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += TimKiemButton_Click;
            // 
            // ChonNhaCungCapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(549, 277);
            Controls.Add(timKiemButton);
            Controls.Add(lamMoiButton);
            Controls.Add(timKiemTextBox);
            Controls.Add(nhaCungCapDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChonNhaCungCapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chọn nhà cung cấp";
            Load += ChonNhaCungCapForm_Load;
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView nhaCungCapDataGridView;
        private DataGridViewTextBoxColumn maNhaCungCapColumn;
        private DataGridViewTextBoxColumn tenNhaCungCapColumn;
        private DataGridViewButtonColumn chonButtonColumn;
        private TextBox timKiemTextBox;
        private Button lamMoiButton;
        private Button timKiemButton;
    }
}