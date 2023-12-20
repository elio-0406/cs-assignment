namespace GUI
{
    partial class ChiTietBanUserControl
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
            xoaButton = new Button();
            tenSanPhamLabel = new Label();
            soLuongNumericUpDown = new NumericUpDown();
            thanhTienLabel = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // xoaButton
            // 
            xoaButton.Location = new Point(510, 0);
            xoaButton.Margin = new Padding(0);
            xoaButton.Name = "xoaButton";
            xoaButton.Size = new Size(50, 85);
            xoaButton.TabIndex = 0;
            xoaButton.Text = "X";
            xoaButton.UseVisualStyleBackColor = true;
            xoaButton.Click += XoaButton_Click;
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenSanPhamLabel.Location = new Point(0, 0);
            tenSanPhamLabel.Margin = new Padding(0);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new Size(155, 85);
            tenSanPhamLabel.TabIndex = 1;
            tenSanPhamLabel.Text = "Tên sản phẩm";
            tenSanPhamLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // soLuongNumericUpDown
            // 
            soLuongNumericUpDown.Location = new Point(180, 6);
            soLuongNumericUpDown.Margin = new Padding(0);
            soLuongNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            soLuongNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            soLuongNumericUpDown.Name = "soLuongNumericUpDown";
            soLuongNumericUpDown.Size = new Size(100, 31);
            soLuongNumericUpDown.TabIndex = 2;
            soLuongNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            soLuongNumericUpDown.ValueChanged += SoLuongNumericUpDown_ValueChanged;
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.AutoSize = true;
            thanhTienLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thanhTienLabel.Location = new Point(277, 43);
            thanhTienLabel.Margin = new Padding(0);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new Size(50, 32);
            thanhTienLabel.TabIndex = 3;
            thanhTienLabel.Text = "0 đ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 49);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 4;
            label2.Text = "Thành tiền";
            // 
            // ChiTietBanUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(thanhTienLabel);
            Controls.Add(soLuongNumericUpDown);
            Controls.Add(tenSanPhamLabel);
            Controls.Add(xoaButton);
            Name = "ChiTietBanUserControl";
            Padding = new Padding(5);
            Size = new Size(560, 85);
            Load += ChiTietBanUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button xoaButton;
        private Label tenSanPhamLabel;
        private Label label2;
        internal NumericUpDown soLuongNumericUpDown;
        internal Label thanhTienLabel;
    }
}
