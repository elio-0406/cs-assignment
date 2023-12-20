namespace GUI.FormChinh
{
    partial class PhanQuyenForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            phanQuyenDataGridView = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            maPhanQuyenColumn = new DataGridViewTextBoxColumn();
            tenPhanQuyenColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phanQuyenDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(xuatExcel);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(timKiemButton);
            panel1.Controls.Add(timKiemTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 87);
            panel1.TabIndex = 0;
            // 
            // xuatExcel
            // 
            xuatExcel.BackColor = Color.ForestGreen;
            xuatExcel.FlatAppearance.BorderSize = 0;
            xuatExcel.FlatStyle = FlatStyle.Flat;
            xuatExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            xuatExcel.ForeColor = Color.White;
            xuatExcel.Location = new Point(959, 29);
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
            lamMoiButton.ForeColor = Color.Black;
            lamMoiButton.Location = new Point(803, 29);
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
            timKiemButton.Location = new Point(679, 29);
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
            timKiemTextBox.BackColor = Color.White;
            timKiemTextBox.Location = new Point(54, 29);
            timKiemTextBox.Margin = new Padding(0);
            timKiemTextBox.Multiline = true;
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(606, 34);
            timKiemTextBox.TabIndex = 0;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // phanQuyenDataGridView
            // 
            phanQuyenDataGridView.AllowUserToAddRows = false;
            phanQuyenDataGridView.AllowUserToDeleteRows = false;
            phanQuyenDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle1.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            phanQuyenDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            phanQuyenDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phanQuyenDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maPhanQuyenColumn, tenPhanQuyenColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            phanQuyenDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            phanQuyenDataGridView.Dock = DockStyle.Fill;
            phanQuyenDataGridView.Location = new Point(0, 87);
            phanQuyenDataGridView.Margin = new Padding(0);
            phanQuyenDataGridView.Name = "phanQuyenDataGridView";
            phanQuyenDataGridView.ReadOnly = true;
            phanQuyenDataGridView.RowHeadersVisible = false;
            phanQuyenDataGridView.RowHeadersWidth = 62;
            phanQuyenDataGridView.Size = new Size(1144, 573);
            phanQuyenDataGridView.TabIndex = 1;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Width = 76;
            // 
            // maPhanQuyenColumn
            // 
            maPhanQuyenColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maPhanQuyenColumn.HeaderText = "Mã phân quyền";
            maPhanQuyenColumn.MinimumWidth = 8;
            maPhanQuyenColumn.Name = "maPhanQuyenColumn";
            maPhanQuyenColumn.ReadOnly = true;
            // 
            // tenPhanQuyenColumn
            // 
            tenPhanQuyenColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenPhanQuyenColumn.HeaderText = "Tên phân quyền";
            tenPhanQuyenColumn.MinimumWidth = 8;
            tenPhanQuyenColumn.Name = "tenPhanQuyenColumn";
            tenPhanQuyenColumn.ReadOnly = true;
            // 
            // PhanQuyenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(phanQuyenDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhanQuyenForm";
            Text = "PhanQuyenForm";
            Load += PhanQuyenForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phanQuyenDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView phanQuyenDataGridView;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maPhanQuyenColumn;
        private DataGridViewTextBoxColumn tenPhanQuyenColumn;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
    }
}