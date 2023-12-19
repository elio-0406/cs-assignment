namespace GUI.FormChiTiet
{
    partial class ChiTietNhaCungCapForm
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
            diaChiTextBox = new TextBox();
            label6 = new Label();
            emailTextBox = new TextBox();
            label5 = new Label();
            soDienThoaiTextBox = new TextBox();
            label1 = new Label();
            luuButton = new Button();
            huyBoButton = new Button();
            tenNhaCungCapTextBox = new TextBox();
            label4 = new Label();
            trangThaiComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tieuDeFormLabel = new Label();
            maNhaCungCapTextBox = new TextBox();
            SuspendLayout();
            // 
            // diaChiTextBox
            // 
            diaChiTextBox.Location = new Point(219, 221);
            diaChiTextBox.Name = "diaChiTextBox";
            diaChiTextBox.Size = new Size(150, 31);
            diaChiTextBox.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 224);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 43;
            label6.Text = "Địa chỉ";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(219, 184);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(150, 31);
            emailTextBox.TabIndex = 42;
            emailTextBox.KeyPress += EmailTextBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 187);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 41;
            label5.Text = "Email";
            // 
            // soDienThoaiTextBox
            // 
            soDienThoaiTextBox.Location = new Point(219, 147);
            soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            soDienThoaiTextBox.Size = new Size(150, 31);
            soDienThoaiTextBox.TabIndex = 40;
            soDienThoaiTextBox.KeyPress += SoDienThoaiTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 150);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 39;
            label1.Text = "Số điện thoại";
            // 
            // luuButton
            // 
            luuButton.Location = new Point(289, 297);
            luuButton.Name = "luuButton";
            luuButton.Size = new Size(112, 34);
            luuButton.TabIndex = 36;
            luuButton.Text = "Lưu";
            luuButton.UseVisualStyleBackColor = true;
            luuButton.Click += LuuButton_Click;
            // 
            // huyBoButton
            // 
            huyBoButton.Location = new Point(161, 297);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.Size = new Size(112, 34);
            huyBoButton.TabIndex = 35;
            huyBoButton.Text = "Hủy bỏ";
            huyBoButton.UseVisualStyleBackColor = true;
            huyBoButton.Click += HuyBoButton_Click;
            // 
            // tenNhaCungCapTextBox
            // 
            tenNhaCungCapTextBox.Location = new Point(219, 110);
            tenNhaCungCapTextBox.Name = "tenNhaCungCapTextBox";
            tenNhaCungCapTextBox.Size = new Size(150, 31);
            tenNhaCungCapTextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 258);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 32;
            label4.Text = "Trạng thái";
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hợp tác", "Ngừng hợp tác" });
            trangThaiComboBox.Location = new Point(219, 258);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.Size = new Size(182, 33);
            trangThaiComboBox.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 113);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 30;
            label3.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 76);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 29;
            label2.Text = "Mã nhà cung cấp";
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tieuDeFormLabel.Location = new Point(17, 13);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(285, 38);
            tieuDeFormLabel.TabIndex = 28;
            tieuDeFormLabel.Text = "Chi tiết nhà cung cấp";
            // 
            // maNhaCungCapTextBox
            // 
            maNhaCungCapTextBox.Location = new Point(219, 73);
            maNhaCungCapTextBox.Name = "maNhaCungCapTextBox";
            maNhaCungCapTextBox.Size = new Size(150, 31);
            maNhaCungCapTextBox.TabIndex = 33;
            // 
            // ChiTietNhaCungCapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 344);
            Controls.Add(diaChiTextBox);
            Controls.Add(label6);
            Controls.Add(emailTextBox);
            Controls.Add(label5);
            Controls.Add(soDienThoaiTextBox);
            Controls.Add(label1);
            Controls.Add(luuButton);
            Controls.Add(huyBoButton);
            Controls.Add(tenNhaCungCapTextBox);
            Controls.Add(maNhaCungCapTextBox);
            Controls.Add(label4);
            Controls.Add(trangThaiComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tieuDeFormLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChiTietNhaCungCapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết nhà cung cấp";
            Load += ChiTietNhaCungCapForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox diaChiTextBox;
        private Label label6;
        private TextBox emailTextBox;
        private Label label5;
        private TextBox soDienThoaiTextBox;
        private Label label1;
        private Button luuButton;
        private Button huyBoButton;
        private TextBox tenNhaCungCapTextBox;
        private Label label4;
        private ComboBox trangThaiComboBox;
        private Label label3;
        private Label label2;
        private Label tieuDeFormLabel;
        private TextBox maNhaCungCapTextBox;
    }
}