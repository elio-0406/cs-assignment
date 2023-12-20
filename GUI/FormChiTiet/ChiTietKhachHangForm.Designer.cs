namespace GUI.FormChiTiet
{
    partial class ChiTietKhachHangForm
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
            diemThanhVienTextBox = new TextBox();
            label9 = new Label();
            label7 = new Label();
            soDienThoaiTextBox = new TextBox();
            label1 = new Label();
            luuButton = new Button();
            huyBoButton = new Button();
            hoTenTextBox = new TextBox();
            maKhachHangTextBox = new TextBox();
            label4 = new Label();
            trangThaiComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tieuDeFormLabel = new Label();
            hangThanhVienTextBox = new TextBox();
            SuspendLayout();
            // 
            // diemThanhVienTextBox
            // 
            diemThanhVienTextBox.Location = new Point(224, 230);
            diemThanhVienTextBox.Name = "diemThanhVienTextBox";
            diemThanhVienTextBox.Size = new Size(150, 31);
            diemThanhVienTextBox.TabIndex = 74;
            diemThanhVienTextBox.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(22, 233);
            label9.Name = "label9";
            label9.Size = new Size(148, 25);
            label9.TabIndex = 73;
            label9.Text = "Điểm thành viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(22, 191);
            label7.Name = "label7";
            label7.Size = new Size(148, 25);
            label7.TabIndex = 72;
            label7.Text = "Hạng thành viên";
            // 
            // soDienThoaiTextBox
            // 
            soDienThoaiTextBox.Location = new Point(224, 154);
            soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            soDienThoaiTextBox.Size = new Size(150, 31);
            soDienThoaiTextBox.TabIndex = 66;
            soDienThoaiTextBox.KeyPress += SoDienThoaiTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(22, 157);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 65;
            label1.Text = "Số điện Thoại";
            // 
            // luuButton
            // 
            luuButton.BackColor = Color.FromArgb(0, 192, 0);
            luuButton.FlatAppearance.BorderSize = 0;
            luuButton.FlatStyle = FlatStyle.Flat;
            luuButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            luuButton.ForeColor = Color.White;
            luuButton.Location = new Point(294, 310);
            luuButton.Name = "luuButton";
            luuButton.Size = new Size(112, 34);
            luuButton.TabIndex = 64;
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
            huyBoButton.Location = new Point(166, 310);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.Size = new Size(112, 34);
            huyBoButton.TabIndex = 63;
            huyBoButton.Text = "Hủy bỏ";
            huyBoButton.UseVisualStyleBackColor = false;
            huyBoButton.Click += HuyBoButton_Click;
            // 
            // hoTenTextBox
            // 
            hoTenTextBox.Location = new Point(224, 117);
            hoTenTextBox.Name = "hoTenTextBox";
            hoTenTextBox.Size = new Size(182, 31);
            hoTenTextBox.TabIndex = 62;
            // 
            // maKhachHangTextBox
            // 
            maKhachHangTextBox.Location = new Point(224, 80);
            maKhachHangTextBox.Name = "maKhachHangTextBox";
            maKhachHangTextBox.Size = new Size(150, 31);
            maKhachHangTextBox.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(22, 271);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 60;
            label4.Text = "Trạng thái";
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hoạt động", "Ngừng hoạt động" });
            trangThaiComboBox.Location = new Point(224, 271);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.Size = new Size(182, 33);
            trangThaiComboBox.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(22, 120);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 58;
            label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 57;
            label2.Text = "Mã khách hàng";
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tieuDeFormLabel.Location = new Point(22, 21);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(262, 38);
            tieuDeFormLabel.TabIndex = 56;
            tieuDeFormLabel.Text = "Chi tiết khách hàng";
            // 
            // hangThanhVienTextBox
            // 
            hangThanhVienTextBox.Location = new Point(224, 191);
            hangThanhVienTextBox.Name = "hangThanhVienTextBox";
            hangThanhVienTextBox.Size = new Size(150, 31);
            hangThanhVienTextBox.TabIndex = 75;
            hangThanhVienTextBox.Text = "Đồng";
            // 
            // ChiTietKhachHangForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(428, 364);
            Controls.Add(hangThanhVienTextBox);
            Controls.Add(diemThanhVienTextBox);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(soDienThoaiTextBox);
            Controls.Add(label1);
            Controls.Add(luuButton);
            Controls.Add(huyBoButton);
            Controls.Add(hoTenTextBox);
            Controls.Add(maKhachHangTextBox);
            Controls.Add(label4);
            Controls.Add(trangThaiComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tieuDeFormLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietKhachHangForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết khách hàng";
            Load += ChiTietKhachHangForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox diemThanhVienTextBox;
        private Label label9;
        private Label label7;
        private TextBox soDienThoaiTextBox;
        private Label label1;
        private Button luuButton;
        private Button huyBoButton;
        private TextBox hoTenTextBox;
        private TextBox maKhachHangTextBox;
        private Label label4;
        private ComboBox trangThaiComboBox;
        private Label label3;
        private Label label2;
        private Label tieuDeFormLabel;
        private TextBox hangThanhVienTextBox;
    }
}