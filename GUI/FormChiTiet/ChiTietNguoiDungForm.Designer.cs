namespace GUI.FormChiTiet
{
    partial class ChiTietNguoiDungForm
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
            label7 = new Label();
            phanQuyenComboBox = new ComboBox();
            diaChiTextBox = new TextBox();
            label6 = new Label();
            emailTextBox = new TextBox();
            label5 = new Label();
            soDienThoaiTextBox = new TextBox();
            label1 = new Label();
            luuButton = new Button();
            huyBoButton = new Button();
            tenNguoiDungTextBox = new TextBox();
            maNguoiDungTextBox = new TextBox();
            label4 = new Label();
            trangThaiComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tieuDeFormLabel = new Label();
            matKhauTextBox = new TextBox();
            label8 = new Label();
            tenDangNhapTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            namRadioButton = new RadioButton();
            nuRadioButton = new RadioButton();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 148);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 46;
            label7.Text = "Phân quyền";
            // 
            // phanQuyenComboBox
            // 
            phanQuyenComboBox.FormattingEnabled = true;
            phanQuyenComboBox.Location = new Point(223, 148);
            phanQuyenComboBox.Name = "phanQuyenComboBox";
            phanQuyenComboBox.Size = new Size(182, 33);
            phanQuyenComboBox.TabIndex = 45;
            // 
            // diaChiTextBox
            // 
            diaChiTextBox.Location = new Point(648, 264);
            diaChiTextBox.Name = "diaChiTextBox";
            diaChiTextBox.Size = new Size(150, 31);
            diaChiTextBox.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 267);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 43;
            label6.Text = "Địa chỉ";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(648, 227);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(150, 31);
            emailTextBox.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 230);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 41;
            label5.Text = "Email";
            // 
            // soDienThoaiTextBox
            // 
            soDienThoaiTextBox.Location = new Point(648, 190);
            soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            soDienThoaiTextBox.Size = new Size(150, 31);
            soDienThoaiTextBox.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(446, 193);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 39;
            label1.Text = "Số điện Thoại";
            // 
            // luuButton
            // 
            luuButton.Location = new Point(683, 316);
            luuButton.Name = "luuButton";
            luuButton.Size = new Size(112, 34);
            luuButton.TabIndex = 36;
            luuButton.Text = "Lưu";
            luuButton.UseVisualStyleBackColor = true;
            // 
            // huyBoButton
            // 
            huyBoButton.Location = new Point(555, 316);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.Size = new Size(112, 34);
            huyBoButton.TabIndex = 35;
            huyBoButton.Text = "Hủy bỏ";
            huyBoButton.UseVisualStyleBackColor = true;
            // 
            // tenNguoiDungTextBox
            // 
            tenNguoiDungTextBox.Location = new Point(223, 111);
            tenNguoiDungTextBox.Name = "tenNguoiDungTextBox";
            tenNguoiDungTextBox.Size = new Size(150, 31);
            tenNguoiDungTextBox.TabIndex = 34;
            // 
            // maNguoiDungTextBox
            // 
            maNguoiDungTextBox.Location = new Point(223, 74);
            maNguoiDungTextBox.Name = "maNguoiDungTextBox";
            maNguoiDungTextBox.Size = new Size(150, 31);
            maNguoiDungTextBox.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 265);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 32;
            label4.Text = "Trạng thái";
            label4.Click += this.label4_Click;
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hoạt động", "Tạm đình chỉ", "Ngừng hoạt động" });
            trangThaiComboBox.Location = new Point(223, 265);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.Size = new Size(182, 33);
            trangThaiComboBox.TabIndex = 31;
            trangThaiComboBox.SelectedIndexChanged += trangThaiComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 114);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 30;
            label3.Text = "Tên người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 29;
            label2.Text = "Mã người dùng";
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tieuDeFormLabel.Location = new Point(21, 15);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(263, 38);
            tieuDeFormLabel.TabIndex = 28;
            tieuDeFormLabel.Text = "Chi tiết người dùng";
            // 
            // matKhauTextBox
            // 
            matKhauTextBox.Location = new Point(223, 224);
            matKhauTextBox.Name = "matKhauTextBox";
            matKhauTextBox.Size = new Size(150, 31);
            matKhauTextBox.TabIndex = 50;
            matKhauTextBox.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 227);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 49;
            label8.Text = "Mật khẩu";
            // 
            // tenDangNhapTextBox
            // 
            tenDangNhapTextBox.Location = new Point(223, 187);
            tenDangNhapTextBox.Name = "tenDangNhapTextBox";
            tenDangNhapTextBox.Size = new Size(150, 31);
            tenDangNhapTextBox.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 190);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 47;
            label9.Text = "Tên đăng nhập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(446, 80);
            label10.Name = "label10";
            label10.Size = new Size(78, 25);
            label10.TabIndex = 51;
            label10.Text = "Giới tính";
            // 
            // namRadioButton
            // 
            namRadioButton.AutoSize = true;
            namRadioButton.Location = new Point(449, 114);
            namRadioButton.Name = "namRadioButton";
            namRadioButton.Size = new Size(75, 29);
            namRadioButton.TabIndex = 52;
            namRadioButton.TabStop = true;
            namRadioButton.Text = "Nam";
            namRadioButton.UseVisualStyleBackColor = true;
            // 
            // nuRadioButton
            // 
            nuRadioButton.AutoSize = true;
            nuRadioButton.Location = new Point(596, 114);
            nuRadioButton.Name = "nuRadioButton";
            nuRadioButton.Size = new Size(61, 29);
            nuRadioButton.TabIndex = 53;
            nuRadioButton.TabStop = true;
            nuRadioButton.Text = "Nữ";
            nuRadioButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(446, 155);
            label11.Name = "label11";
            label11.Size = new Size(91, 25);
            label11.TabIndex = 54;
            label11.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(648, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Size = new Size(150, 31);
            dateTimePicker1.TabIndex = 55;
            // 
            // ChiTietNguoiDungForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 364);
            Controls.Add(dateTimePicker1);
            Controls.Add(label11);
            Controls.Add(nuRadioButton);
            Controls.Add(namRadioButton);
            Controls.Add(label10);
            Controls.Add(matKhauTextBox);
            Controls.Add(label8);
            Controls.Add(tenDangNhapTextBox);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(phanQuyenComboBox);
            Controls.Add(diaChiTextBox);
            Controls.Add(label6);
            Controls.Add(emailTextBox);
            Controls.Add(label5);
            Controls.Add(soDienThoaiTextBox);
            Controls.Add(label1);
            Controls.Add(luuButton);
            Controls.Add(huyBoButton);
            Controls.Add(tenNguoiDungTextBox);
            Controls.Add(maNguoiDungTextBox);
            Controls.Add(label4);
            Controls.Add(trangThaiComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tieuDeFormLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietNguoiDungForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết người dùng";
            Load += this.ChiTietNguoiDungForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private ComboBox phanQuyenComboBox;
        private TextBox diaChiTextBox;
        private Label label6;
        private TextBox emailTextBox;
        private Label label5;
        private TextBox soDienThoaiTextBox;
        private Label label1;
        private Button luuButton;
        private Button huyBoButton;
        private TextBox tenNguoiDungTextBox;
        private TextBox maNguoiDungTextBox;
        private Label label4;
        private ComboBox trangThaiComboBox;
        private Label label3;
        private Label label2;
        private Label tieuDeFormLabel;
        private TextBox matKhauTextBox;
        private Label label8;
        private TextBox tenDangNhapTextBox;
        private Label label9;
        private Label label10;
        private RadioButton namRadioButton;
        private RadioButton nuRadioButton;
        private Label label11;
        private DateTimePicker dateTimePicker1;
    }
}