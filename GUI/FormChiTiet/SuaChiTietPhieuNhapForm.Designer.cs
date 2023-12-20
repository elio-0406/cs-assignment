namespace GUI.FormChiTiet
{
    partial class SuaChiTietPhieuNhapForm
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
            luuButton = new Button();
            huyBoButton = new Button();
            donGiaTextBox = new TextBox();
            maSanPhamTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            thanhTienLabel = new Label();
            soLuongNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // luuButton
            // 
            luuButton.BackColor = Color.FromArgb(0, 192, 0);
            luuButton.FlatAppearance.BorderSize = 0;
            luuButton.FlatStyle = FlatStyle.Flat;
            luuButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            luuButton.ForeColor = Color.White;
            luuButton.Location = new Point(268, 186);
            luuButton.Name = "luuButton";
            luuButton.Size = new Size(112, 34);
            luuButton.TabIndex = 17;
            luuButton.Text = "Lưu";
            luuButton.UseVisualStyleBackColor = false;
            luuButton.Click += LuuButton_Click;
            // 
            // huyBoButton
            // 
            huyBoButton.BackColor = Color.Red;
            huyBoButton.FlatAppearance.BorderSize = 0;
            huyBoButton.FlatStyle = FlatStyle.Flat;
            huyBoButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            huyBoButton.ForeColor = Color.White;
            huyBoButton.Location = new Point(150, 186);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.Size = new Size(112, 34);
            huyBoButton.TabIndex = 16;
            huyBoButton.Text = "Hủy bỏ";
            huyBoButton.UseVisualStyleBackColor = false;
            huyBoButton.Click += HuyBoButton_Click;
            // 
            // donGiaTextBox
            // 
            donGiaTextBox.Location = new Point(230, 66);
            donGiaTextBox.Name = "donGiaTextBox";
            donGiaTextBox.Size = new Size(150, 31);
            donGiaTextBox.TabIndex = 15;
            donGiaTextBox.Text = "0";
            donGiaTextBox.TextChanged += DonGiaTextBox_TextChanged;
            donGiaTextBox.KeyPress += DonGiaTextBox_KeyPress;
            donGiaTextBox.MouseLeave += DonGiaTextBox_MouseLeave;
            // 
            // maSanPhamTextBox
            // 
            maSanPhamTextBox.Location = new Point(230, 25);
            maSanPhamTextBox.Name = "maSanPhamTextBox";
            maSanPhamTextBox.Size = new Size(150, 31);
            maSanPhamTextBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(28, 69);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 11;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 28);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 10;
            label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(28, 106);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 18;
            label1.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(28, 143);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 20;
            label4.Text = "Thành tiền";
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thanhTienLabel.Location = new Point(230, 143);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new Size(150, 38);
            thanhTienLabel.TabIndex = 21;
            thanhTienLabel.Text = "0 đ";
            // 
            // soLuongNumericUpDown
            // 
            soLuongNumericUpDown.Location = new Point(230, 109);
            soLuongNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            soLuongNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            soLuongNumericUpDown.Name = "soLuongNumericUpDown";
            soLuongNumericUpDown.Size = new Size(150, 31);
            soLuongNumericUpDown.TabIndex = 22;
            soLuongNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            soLuongNumericUpDown.ValueChanged += SoLuongNumericUpDown_ValueChanged;
            // 
            // SuaChiTietPhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(408, 244);
            Controls.Add(soLuongNumericUpDown);
            Controls.Add(thanhTienLabel);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(luuButton);
            Controls.Add(huyBoButton);
            Controls.Add(donGiaTextBox);
            Controls.Add(maSanPhamTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SuaChiTietPhieuNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa chi tiết phiếu nhập";
            Load += SuaChiTietPhieuNhapForm_Load;
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button luuButton;
        private Button huyBoButton;
        private TextBox donGiaTextBox;
        private TextBox maSanPhamTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label thanhTienLabel;
        private NumericUpDown soLuongNumericUpDown;
    }
}