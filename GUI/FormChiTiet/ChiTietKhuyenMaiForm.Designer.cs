namespace GUI.FormChiTiet
{
    partial class ChiTietKhuyenMaiForm
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
            giaTriTextBox = new TextBox();
            label1 = new Label();
            luuButton = new Button();
            huyBoButton = new Button();
            tenKhuyenMaiTextBox = new TextBox();
            maKhuyenMaiTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tieuDeFormLabel = new Label();
            label4 = new Label();
            phanTramRadioButton = new RadioButton();
            cuTheRadioButton = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            ngayBatDauDateTimePicker = new DateTimePicker();
            gioBatDauDateTimePicker = new DateTimePicker();
            ngayKetThucDateTimePicker = new DateTimePicker();
            gioKetThucDateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // giaTriTextBox
            // 
            giaTriTextBox.Location = new Point(222, 218);
            giaTriTextBox.Name = "giaTriTextBox";
            giaTriTextBox.Size = new Size(150, 31);
            giaTriTextBox.TabIndex = 85;
            giaTriTextBox.Text = "0";
            giaTriTextBox.KeyPress += GiaTriTextBox_KeyPress;
            giaTriTextBox.MouseLeave += GiaTriTextBox_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(20, 221);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 84;
            label1.Text = "Giá trị";
            // 
            // luuButton
            // 
            luuButton.BackColor = Color.FromArgb(0, 192, 0);
            luuButton.FlatAppearance.BorderSize = 0;
            luuButton.FlatStyle = FlatStyle.Flat;
            luuButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            luuButton.Location = new Point(342, 418);
            luuButton.Name = "luuButton";
            luuButton.Size = new Size(112, 34);
            luuButton.TabIndex = 83;
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
            huyBoButton.Location = new Point(214, 418);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.Size = new Size(112, 34);
            huyBoButton.TabIndex = 82;
            huyBoButton.Text = "Hủy bỏ";
            huyBoButton.UseVisualStyleBackColor = false;
            huyBoButton.Click += HuyBoButton_Click;
            // 
            // tenKhuyenMaiTextBox
            // 
            tenKhuyenMaiTextBox.Location = new Point(222, 115);
            tenKhuyenMaiTextBox.Name = "tenKhuyenMaiTextBox";
            tenKhuyenMaiTextBox.Size = new Size(232, 31);
            tenKhuyenMaiTextBox.TabIndex = 81;
            // 
            // maKhuyenMaiTextBox
            // 
            maKhuyenMaiTextBox.Location = new Point(222, 78);
            maKhuyenMaiTextBox.Name = "maKhuyenMaiTextBox";
            maKhuyenMaiTextBox.Size = new Size(150, 31);
            maKhuyenMaiTextBox.TabIndex = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(20, 118);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 77;
            label3.Text = "Tên khuyến mãi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(20, 81);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 76;
            label2.Text = "Mã khuyến mãi";
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tieuDeFormLabel.Location = new Point(20, 19);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(262, 38);
            tieuDeFormLabel.TabIndex = 75;
            tieuDeFormLabel.Text = "Chi tiết khuyến mãi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(20, 152);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 86;
            label4.Text = "Loại giá trị";
            // 
            // phanTramRadioButton
            // 
            phanTramRadioButton.AutoSize = true;
            phanTramRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            phanTramRadioButton.Location = new Point(20, 182);
            phanTramRadioButton.Name = "phanTramRadioButton";
            phanTramRadioButton.Size = new Size(122, 29);
            phanTramRadioButton.TabIndex = 87;
            phanTramRadioButton.TabStop = true;
            phanTramRadioButton.Text = "Phần trăm";
            phanTramRadioButton.UseVisualStyleBackColor = true;
            // 
            // cuTheRadioButton
            // 
            cuTheRadioButton.AutoSize = true;
            cuTheRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cuTheRadioButton.Location = new Point(164, 183);
            cuTheRadioButton.Name = "cuTheRadioButton";
            cuTheRadioButton.Size = new Size(91, 29);
            cuTheRadioButton.TabIndex = 88;
            cuTheRadioButton.TabStop = true;
            cuTheRadioButton.Text = "Cụ thể";
            cuTheRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 269);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 89;
            label5.Text = "Thời gian bắt đầu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 340);
            label6.Name = "label6";
            label6.Size = new Size(153, 25);
            label6.TabIndex = 90;
            label6.Text = "Thời gian kết thúc";
            // 
            // ngayBatDauDateTimePicker
            // 
            ngayBatDauDateTimePicker.Location = new Point(12, 300);
            ngayBatDauDateTimePicker.Name = "ngayBatDauDateTimePicker";
            ngayBatDauDateTimePicker.Size = new Size(300, 31);
            ngayBatDauDateTimePicker.TabIndex = 91;
            // 
            // gioBatDauDateTimePicker
            // 
            gioBatDauDateTimePicker.Format = DateTimePickerFormat.Time;
            gioBatDauDateTimePicker.Location = new Point(315, 300);
            gioBatDauDateTimePicker.Name = "gioBatDauDateTimePicker";
            gioBatDauDateTimePicker.ShowUpDown = true;
            gioBatDauDateTimePicker.Size = new Size(139, 31);
            gioBatDauDateTimePicker.TabIndex = 92;
            // 
            // ngayKetThucDateTimePicker
            // 
            ngayKetThucDateTimePicker.Location = new Point(12, 368);
            ngayKetThucDateTimePicker.Name = "ngayKetThucDateTimePicker";
            ngayKetThucDateTimePicker.Size = new Size(300, 31);
            ngayKetThucDateTimePicker.TabIndex = 93;
            // 
            // gioKetThucDateTimePicker
            // 
            gioKetThucDateTimePicker.Format = DateTimePickerFormat.Time;
            gioKetThucDateTimePicker.Location = new Point(315, 368);
            gioKetThucDateTimePicker.Name = "gioKetThucDateTimePicker";
            gioKetThucDateTimePicker.ShowUpDown = true;
            gioKetThucDateTimePicker.Size = new Size(139, 31);
            gioKetThucDateTimePicker.TabIndex = 94;
            // 
            // ChiTietKhuyenMaiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(470, 464);
            Controls.Add(gioKetThucDateTimePicker);
            Controls.Add(ngayKetThucDateTimePicker);
            Controls.Add(gioBatDauDateTimePicker);
            Controls.Add(ngayBatDauDateTimePicker);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cuTheRadioButton);
            Controls.Add(phanTramRadioButton);
            Controls.Add(label4);
            Controls.Add(giaTriTextBox);
            Controls.Add(label1);
            Controls.Add(luuButton);
            Controls.Add(huyBoButton);
            Controls.Add(tenKhuyenMaiTextBox);
            Controls.Add(maKhuyenMaiTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tieuDeFormLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietKhuyenMaiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết khuyến mãi";
            Load += ChiTietKhuyenMaiForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox giaTriTextBox;
        private Label label1;
        private Button luuButton;
        private Button huyBoButton;
        private TextBox tenKhuyenMaiTextBox;
        private TextBox maKhuyenMaiTextBox;
        private Label label3;
        private Label label2;
        private Label tieuDeFormLabel;
        private Label label4;
        private RadioButton phanTramRadioButton;
        private RadioButton cuTheRadioButton;
        private Label label5;
        private Label label6;
        private DateTimePicker ngayBatDauDateTimePicker;
        private DateTimePicker gioBatDauDateTimePicker;
        private DateTimePicker ngayKetThucDateTimePicker;
        private DateTimePicker gioKetThucDateTimePicker;
    }
}