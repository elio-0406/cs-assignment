namespace GUI
{
    partial class ChiTietNhapUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            thanhTienLabel = new Label();
            soLuongNumericUpDown = new NumericUpDown();
            tenSanPhamLabel = new Label();
            xoaButton = new Button();
            label1 = new Label();
            giaNhapTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 54);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 9;
            label2.Text = "Thành tiền";
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.AutoSize = true;
            thanhTienLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thanhTienLabel.Location = new Point(258, 48);
            thanhTienLabel.Margin = new Padding(0);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new Size(50, 32);
            thanhTienLabel.TabIndex = 8;
            thanhTienLabel.Text = "0 đ";
            // 
            // soLuongNumericUpDown
            // 
            soLuongNumericUpDown.Location = new Point(164, 5);
            soLuongNumericUpDown.Margin = new Padding(0);
            soLuongNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            soLuongNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            soLuongNumericUpDown.Name = "soLuongNumericUpDown";
            soLuongNumericUpDown.Size = new Size(100, 31);
            soLuongNumericUpDown.TabIndex = 7;
            soLuongNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            soLuongNumericUpDown.ValueChanged += SoLuongNumericUpDown_ValueChanged;
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenSanPhamLabel.Location = new Point(0, 0);
            tenSanPhamLabel.Margin = new Padding(0);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new Size(155, 85);
            tenSanPhamLabel.TabIndex = 6;
            tenSanPhamLabel.Text = "Tên sản phẩm";
            tenSanPhamLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // xoaButton
            // 
            xoaButton.Location = new Point(510, 0);
            xoaButton.Margin = new Padding(0);
            xoaButton.Name = "xoaButton";
            xoaButton.Size = new Size(50, 85);
            xoaButton.TabIndex = 5;
            xoaButton.Text = "X";
            xoaButton.UseVisualStyleBackColor = true;
            xoaButton.Click += XoaButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 7);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 10;
            label1.Text = "Giá nhập";
            // 
            // giaNhapTextBox
            // 
            giaNhapTextBox.Location = new Point(355, 4);
            giaNhapTextBox.Name = "giaNhapTextBox";
            giaNhapTextBox.Size = new Size(150, 31);
            giaNhapTextBox.TabIndex = 11;
            giaNhapTextBox.Text = "0";
            giaNhapTextBox.TextChanged += GiaNhapTextBox_TextChanged;
            giaNhapTextBox.KeyPress += GiaNhapTextBox_KeyPress;
            giaNhapTextBox.MouseLeave += GiaNhapTextBox_MouseLeave;
            // 
            // ChiTietNhapUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(giaNhapTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(thanhTienLabel);
            Controls.Add(soLuongNumericUpDown);
            Controls.Add(tenSanPhamLabel);
            Controls.Add(xoaButton);
            Name = "ChiTietNhapUserControl";
            Size = new Size(560, 85);
            Load += ChiTietNhapUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label tenSanPhamLabel;
        private Button xoaButton;
        private Label label1;
        internal NumericUpDown soLuongNumericUpDown;
        internal Label thanhTienLabel;
        internal TextBox giaNhapTextBox;
    }
}
