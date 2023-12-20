namespace GUI.FormChiTiet
{
    partial class ChiTietSanPhamForm
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
            tenSanPhamTextBox = new TextBox();
            maSanPhamTextBox = new TextBox();
            label4 = new Label();
            trangThaiComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tieuDeFormLabel = new Label();
            sanPhamPictureBox = new PictureBox();
            chonAnhButton = new Button();
            donViTinhTextBox = new TextBox();
            label1 = new Label();
            giaBanTextBox = new TextBox();
            label5 = new Label();
            soLuongTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            loaiSanPhamComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)sanPhamPictureBox).BeginInit();
            SuspendLayout();
            // 
            // luuButton
            // 
            luuButton.BackColor = Color.FromArgb(0, 192, 0);
            luuButton.FlatAppearance.BorderSize = 0;
            luuButton.FlatStyle = FlatStyle.Flat;
            luuButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            luuButton.ForeColor = Color.White;
            luuButton.Location = new Point(522, 342);
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
            huyBoButton.Location = new Point(394, 342);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.Size = new Size(112, 34);
            huyBoButton.TabIndex = 16;
            huyBoButton.Text = "Hủy bỏ";
            huyBoButton.UseVisualStyleBackColor = false;
            huyBoButton.Click += HuyBoButton_Click;
            // 
            // tenSanPhamTextBox
            // 
            tenSanPhamTextBox.Font = new Font("Segoe UI", 9F);
            tenSanPhamTextBox.Location = new Point(394, 108);
            tenSanPhamTextBox.Name = "tenSanPhamTextBox";
            tenSanPhamTextBox.Size = new Size(206, 31);
            tenSanPhamTextBox.TabIndex = 15;
            // 
            // maSanPhamTextBox
            // 
            maSanPhamTextBox.Font = new Font("Segoe UI", 9F);
            maSanPhamTextBox.Location = new Point(394, 71);
            maSanPhamTextBox.Name = "maSanPhamTextBox";
            maSanPhamTextBox.Size = new Size(206, 31);
            maSanPhamTextBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(248, 295);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 13;
            label4.Text = "Trạng thái";
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.Font = new Font("Segoe UI", 9F);
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang bán", "Chờ xử lý", "Hết hàng", "Ngừng kinh doanh" });
            trangThaiComboBox.Location = new Point(394, 295);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.Size = new Size(238, 33);
            trangThaiComboBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(248, 111);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 11;
            label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(248, 74);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 10;
            label2.Text = "Mã sản phẩm";
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tieuDeFormLabel.Location = new Point(13, 13);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(239, 38);
            tieuDeFormLabel.TabIndex = 9;
            tieuDeFormLabel.Text = "Chi tiết sản phẩm";
            // 
            // sanPhamPictureBox
            // 
            sanPhamPictureBox.BorderStyle = BorderStyle.Fixed3D;
            sanPhamPictureBox.Location = new Point(21, 71);
            sanPhamPictureBox.Name = "sanPhamPictureBox";
            sanPhamPictureBox.Size = new Size(150, 150);
            sanPhamPictureBox.TabIndex = 18;
            sanPhamPictureBox.TabStop = false;
            // 
            // chonAnhButton
            // 
            chonAnhButton.BackColor = Color.MediumPurple;
            chonAnhButton.FlatAppearance.BorderSize = 0;
            chonAnhButton.FlatStyle = FlatStyle.Flat;
            chonAnhButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chonAnhButton.Location = new Point(21, 227);
            chonAnhButton.Name = "chonAnhButton";
            chonAnhButton.Size = new Size(150, 34);
            chonAnhButton.TabIndex = 19;
            chonAnhButton.Text = "Chọn ảnh";
            chonAnhButton.UseVisualStyleBackColor = false;
            chonAnhButton.Click += ChonAnhButton_Click;
            // 
            // donViTinhTextBox
            // 
            donViTinhTextBox.Font = new Font("Segoe UI", 9F);
            donViTinhTextBox.Location = new Point(394, 184);
            donViTinhTextBox.Name = "donViTinhTextBox";
            donViTinhTextBox.Size = new Size(206, 31);
            donViTinhTextBox.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(248, 187);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 20;
            label1.Text = "Đơn vị tính";
            // 
            // giaBanTextBox
            // 
            giaBanTextBox.Font = new Font("Segoe UI", 9F);
            giaBanTextBox.Location = new Point(394, 221);
            giaBanTextBox.Name = "giaBanTextBox";
            giaBanTextBox.Size = new Size(206, 31);
            giaBanTextBox.TabIndex = 23;
            giaBanTextBox.Text = "0";
            giaBanTextBox.KeyPress += GiaBanTextBox_KeyPress;
            giaBanTextBox.MouseLeave += GiaBanTextBox_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(248, 224);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 22;
            label5.Text = "Giá bán";
            // 
            // soLuongTextBox
            // 
            soLuongTextBox.Font = new Font("Segoe UI", 9F);
            soLuongTextBox.Location = new Point(394, 258);
            soLuongTextBox.Name = "soLuongTextBox";
            soLuongTextBox.Size = new Size(206, 31);
            soLuongTextBox.TabIndex = 25;
            soLuongTextBox.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(248, 261);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 24;
            label6.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(248, 145);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 27;
            label7.Text = "Loại sản phẩm";
            // 
            // loaiSanPhamComboBox
            // 
            loaiSanPhamComboBox.Font = new Font("Segoe UI", 9F);
            loaiSanPhamComboBox.FormattingEnabled = true;
            loaiSanPhamComboBox.Location = new Point(394, 145);
            loaiSanPhamComboBox.Name = "loaiSanPhamComboBox";
            loaiSanPhamComboBox.Size = new Size(238, 33);
            loaiSanPhamComboBox.TabIndex = 26;
            // 
            // ChiTietSanPhamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(648, 389);
            Controls.Add(label7);
            Controls.Add(loaiSanPhamComboBox);
            Controls.Add(soLuongTextBox);
            Controls.Add(label6);
            Controls.Add(giaBanTextBox);
            Controls.Add(label5);
            Controls.Add(donViTinhTextBox);
            Controls.Add(label1);
            Controls.Add(chonAnhButton);
            Controls.Add(sanPhamPictureBox);
            Controls.Add(luuButton);
            Controls.Add(huyBoButton);
            Controls.Add(tenSanPhamTextBox);
            Controls.Add(maSanPhamTextBox);
            Controls.Add(label4);
            Controls.Add(trangThaiComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tieuDeFormLabel);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietSanPhamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết sản phẩm";
            Load += ChiTietSanPhamForm_Load;
            ((System.ComponentModel.ISupportInitialize)sanPhamPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button luuButton;
        private Button huyBoButton;
        private TextBox tenSanPhamTextBox;
        private TextBox maSanPhamTextBox;
        private Label label4;
        private ComboBox trangThaiComboBox;
        private Label label3;
        private Label label2;
        private Label tieuDeFormLabel;
        private PictureBox sanPhamPictureBox;
        private Button chonAnhButton;
        private TextBox donViTinhTextBox;
        private Label label1;
        private TextBox giaBanTextBox;
        private Label label5;
        private TextBox soLuongTextBox;
        private Label label6;
        private Label label7;
        private ComboBox loaiSanPhamComboBox;
    }
}