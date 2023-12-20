namespace GUI.FormChinh
{
    partial class DangNhapForm
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
            tenDangNhapTextBox = new TextBox();
            matKhauTextBox = new TextBox();
            dangNhapButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tenDangNhapTextBox
            // 
            tenDangNhapTextBox.Location = new Point(193, 46);
            tenDangNhapTextBox.Name = "tenDangNhapTextBox";
            tenDangNhapTextBox.Size = new Size(182, 31);
            tenDangNhapTextBox.TabIndex = 0;
            tenDangNhapTextBox.KeyPress += TenDangNhapTextBox_KeyPress;
            // 
            // matKhauTextBox
            // 
            matKhauTextBox.Location = new Point(193, 84);
            matKhauTextBox.Name = "matKhauTextBox";
            matKhauTextBox.Size = new Size(182, 31);
            matKhauTextBox.TabIndex = 1;
            matKhauTextBox.UseSystemPasswordChar = true;
            matKhauTextBox.KeyPress += MatKhauTextBox_KeyPress;
            matKhauTextBox.MouseLeave += MatKhauTextBox_MouseLeave;
            matKhauTextBox.MouseMove += MatKhauTextBox_MouseMove;
            // 
            // dangNhapButton
            // 
            dangNhapButton.BackColor = Color.FromArgb(0, 71, 107);
            dangNhapButton.FlatAppearance.BorderSize = 0;
            dangNhapButton.FlatStyle = FlatStyle.Flat;
            dangNhapButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dangNhapButton.ForeColor = Color.White;
            dangNhapButton.Location = new Point(39, 148);
            dangNhapButton.Name = "dangNhapButton";
            dangNhapButton.Size = new Size(336, 43);
            dangNhapButton.TabIndex = 2;
            dangNhapButton.Text = "Đăng nhập";
            dangNhapButton.UseVisualStyleBackColor = false;
            dangNhapButton.Click += DangNhapButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 87);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // DangNhapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(415, 220);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dangNhapButton);
            Controls.Add(matKhauTextBox);
            Controls.Add(tenDangNhapTextBox);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "DangNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            KeyDown += DangNhapForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button dangNhapButton;
        private Label label1;
        private Label label2;
        internal TextBox tenDangNhapTextBox;
        internal TextBox matKhauTextBox;
    }
}