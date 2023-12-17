﻿namespace GUI.FormChiTiet
{
    partial class ChiTietLoaiSanPhamForm
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
            tieuDeFormLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            trangThaiComboBox = new ComboBox();
            label4 = new Label();
            maLoaiSanPhamTextBox = new TextBox();
            tenLoaiSanPhamTextBox = new TextBox();
            huyBoButton = new Button();
            luuButton = new Button();
            SuspendLayout();
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tieuDeFormLabel.Location = new Point(17, 14);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(293, 38);
            tieuDeFormLabel.TabIndex = 0;
            tieuDeFormLabel.Text = "Chi tiết loại sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã loại sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 127);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên loại sản phẩm";
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang sử dụng", "Đã xóa" });
            trangThaiComboBox.Location = new Point(219, 165);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.Size = new Size(182, 33);
            trangThaiComboBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 165);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 4;
            label4.Text = "Trạng thái";
            // 
            // maLoaiSanPhamTextBox
            // 
            maLoaiSanPhamTextBox.Location = new Point(219, 83);
            maLoaiSanPhamTextBox.Name = "maLoaiSanPhamTextBox";
            maLoaiSanPhamTextBox.Size = new Size(150, 31);
            maLoaiSanPhamTextBox.TabIndex = 5;
            // 
            // tenLoaiSanPhamTextBox
            // 
            tenLoaiSanPhamTextBox.Location = new Point(219, 124);
            tenLoaiSanPhamTextBox.Name = "tenLoaiSanPhamTextBox";
            tenLoaiSanPhamTextBox.Size = new Size(150, 31);
            tenLoaiSanPhamTextBox.TabIndex = 6;
            // 
            // huyBoButton
            // 
            huyBoButton.Location = new Point(171, 217);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.Size = new Size(112, 34);
            huyBoButton.TabIndex = 7;
            huyBoButton.Text = "Hủy bỏ";
            huyBoButton.UseVisualStyleBackColor = true;
            // 
            // luuButton
            // 
            luuButton.Location = new Point(289, 217);
            luuButton.Name = "luuButton";
            luuButton.Size = new Size(112, 34);
            luuButton.TabIndex = 8;
            luuButton.Text = "Lưu";
            luuButton.UseVisualStyleBackColor = true;
            // 
            // ChiTietLoaiSanPhamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 264);
            Controls.Add(luuButton);
            Controls.Add(huyBoButton);
            Controls.Add(tenLoaiSanPhamTextBox);
            Controls.Add(maLoaiSanPhamTextBox);
            Controls.Add(label4);
            Controls.Add(trangThaiComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tieuDeFormLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietLoaiSanPhamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết loại sản phẩm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tieuDeFormLabel;
        private Label label2;
        private Label label3;
        private ComboBox trangThaiComboBox;
        private Label label4;
        private TextBox maLoaiSanPhamTextBox;
        private TextBox tenLoaiSanPhamTextBox;
        private Button huyBoButton;
        private Button luuButton;
    }
}