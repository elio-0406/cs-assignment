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
            tenLoaiSanPhamTextBox = new TextBox();
            maLoaiSanPhamTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // luuButton
            // 
            luuButton.Location = new Point(268, 186);
            luuButton.Name = "luuButton";
            luuButton.Size = new Size(112, 34);
            luuButton.TabIndex = 17;
            luuButton.Text = "Lưu";
            luuButton.UseVisualStyleBackColor = true;
            // 
            // huyBoButton
            // 
            huyBoButton.Location = new Point(150, 186);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.Size = new Size(112, 34);
            huyBoButton.TabIndex = 16;
            huyBoButton.Text = "Hủy bỏ";
            huyBoButton.UseVisualStyleBackColor = true;
            // 
            // tenLoaiSanPhamTextBox
            // 
            tenLoaiSanPhamTextBox.Location = new Point(230, 66);
            tenLoaiSanPhamTextBox.Name = "tenLoaiSanPhamTextBox";
            tenLoaiSanPhamTextBox.Size = new Size(150, 31);
            tenLoaiSanPhamTextBox.TabIndex = 15;
            tenLoaiSanPhamTextBox.Text = "0";
            // 
            // maLoaiSanPhamTextBox
            // 
            maLoaiSanPhamTextBox.Location = new Point(230, 25);
            maLoaiSanPhamTextBox.Name = "maLoaiSanPhamTextBox";
            maLoaiSanPhamTextBox.Size = new Size(150, 31);
            maLoaiSanPhamTextBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 69);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 11;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 28);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 10;
            label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 106);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 18;
            label1.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 143);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 20;
            label4.Text = "Thành tiền";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(230, 143);
            label5.Name = "label5";
            label5.Size = new Size(150, 38);
            label5.TabIndex = 21;
            label5.Text = "0 đ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(230, 109);
            numericUpDown1.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 31);
            numericUpDown1.TabIndex = 22;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SuaChiTietPhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 244);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(luuButton);
            Controls.Add(huyBoButton);
            Controls.Add(tenLoaiSanPhamTextBox);
            Controls.Add(maLoaiSanPhamTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SuaChiTietPhieuNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa chi tiết phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button luuButton;
        private Button huyBoButton;
        private TextBox tenLoaiSanPhamTextBox;
        private TextBox maLoaiSanPhamTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}