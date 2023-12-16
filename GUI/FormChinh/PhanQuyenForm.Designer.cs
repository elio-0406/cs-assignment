﻿namespace GUI.FormChinh
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            maPhanQuyenColumn = new DataGridViewTextBoxColumn();
            tenPhanQuyenColumn = new DataGridViewTextBoxColumn();
            timKiemTextBox = new TextBox();
            timKiemButton = new Button();
            lamMoiButton = new Button();
            xuatExcel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(xuatExcel);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(timKiemButton);
            panel1.Controls.Add(timKiemTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 87);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stt, maPhanQuyenColumn, tenPhanQuyenColumn });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 87);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1122, 517);
            dataGridView1.TabIndex = 1;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            // xuatExcel
            // 
            xuatExcel.Location = new Point(663, 29);
            xuatExcel.Margin = new Padding(0);
            xuatExcel.Name = "xuatExcel";
            xuatExcel.Size = new Size(112, 34);
            xuatExcel.TabIndex = 3;
            xuatExcel.Text = "Xuất Excel";
            xuatExcel.UseVisualStyleBackColor = true;
            xuatExcel.Click += XuatExcel_Click;
            // 
            // PhanQuyenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 604);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhanQuyenForm";
            Text = "PhanQuyenForm";
            Load += PhanQuyenForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maPhanQuyenColumn;
        private DataGridViewTextBoxColumn tenPhanQuyenColumn;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
    }
}