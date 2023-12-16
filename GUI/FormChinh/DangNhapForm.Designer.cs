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
            dangNhapButton = new Button();
            label2 = new Label();
            tenDangNhapTextBox = new TextBox();
            matKhauTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // dangNhapButton
            // 
            dangNhapButton.Anchor = AnchorStyles.None;
            dangNhapButton.AutoSize = true;
            dangNhapButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dangNhapButton.BackColor = Color.White;
            dangNhapButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dangNhapButton.Location = new Point(144, 154);
            dangNhapButton.Name = "dangNhapButton";
            dangNhapButton.Padding = new Padding(5);
            dangNhapButton.Size = new Size(177, 58);
            dangNhapButton.TabIndex = 10;
            dangNhapButton.Text = "Đăng nhập";
            dangNhapButton.UseVisualStyleBackColor = false;
            dangNhapButton.Click += dangNhapButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(86, 89);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 14;
            label2.Text = "Mật khẩu";
            // 
            // tenDangNhapTextBox
            // 
            tenDangNhapTextBox.Anchor = AnchorStyles.None;
            tenDangNhapTextBox.BackColor = Color.White;
            tenDangNhapTextBox.BorderStyle = BorderStyle.None;
            tenDangNhapTextBox.Location = new Point(261, 35);
            tenDangNhapTextBox.Name = "tenDangNhapTextBox";
            tenDangNhapTextBox.Size = new Size(150, 24);
            tenDangNhapTextBox.TabIndex = 11;
            // 
            // matKhauTextBox
            // 
            matKhauTextBox.Anchor = AnchorStyles.None;
            matKhauTextBox.BorderStyle = BorderStyle.None;
            matKhauTextBox.Location = new Point(261, 90);
            matKhauTextBox.Name = "matKhauTextBox";
            matKhauTextBox.Size = new Size(150, 24);
            matKhauTextBox.TabIndex = 12;
            matKhauTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(86, 34);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 13;
            label1.Text = "Tên đăng nhập";
            // 
            // DangNhapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 247);
            Controls.Add(dangNhapButton);
            Controls.Add(label2);
            Controls.Add(tenDangNhapTextBox);
            Controls.Add(matKhauTextBox);
            Controls.Add(label1);
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
        private Label label2;
        private TextBox tenDangNhapTextBox;
        private TextBox matKhauTextBox;
        private Label label1;
    }
}