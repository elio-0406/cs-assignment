namespace GUI.FormChinh
{
    partial class TaoPhieuNhapForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            hoanTatButton = new Button();
            label1 = new Label();
            tongTienLabel = new Label();
            timKiemSanPhamTextBox = new TextBox();
            timKiemSanPhamButton = new Button();
            lamMoiSanPhamButton = new Button();
            loaiSanPhamComboBox = new ComboBox();
            label3 = new Label();
            chonNhaCungCapButton = new Button();
            label4 = new Label();
            label5 = new Label();
            lamMoiNhaCungCapButton = new Button();
            maNhaCungCapLabel = new Label();
            tenNhaCungCapLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 660);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(572, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 660);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(loaiSanPhamComboBox);
            panel3.Controls.Add(lamMoiSanPhamButton);
            panel3.Controls.Add(timKiemSanPhamButton);
            panel3.Controls.Add(timKiemSanPhamTextBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(572, 120);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(tenNhaCungCapLabel);
            panel4.Controls.Add(maNhaCungCapLabel);
            panel4.Controls.Add(lamMoiNhaCungCapButton);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(chonNhaCungCapButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(572, 120);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(tongTienLabel);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(hoanTatButton);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 560);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(572, 100);
            panel5.TabIndex = 1;
            // 
            // hoanTatButton
            // 
            hoanTatButton.AutoSize = true;
            hoanTatButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoanTatButton.Location = new Point(391, 26);
            hoanTatButton.Margin = new Padding(0);
            hoanTatButton.Name = "hoanTatButton";
            hoanTatButton.Size = new Size(139, 48);
            hoanTatButton.TabIndex = 0;
            hoanTatButton.Text = "Hoàn tất";
            hoanTatButton.UseVisualStyleBackColor = true;
            hoanTatButton.Click += HoanTatButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 15);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 1;
            label1.Text = "Tổng tiền";
            // 
            // tongTienLabel
            // 
            tongTienLabel.AutoSize = true;
            tongTienLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tongTienLabel.Location = new Point(42, 47);
            tongTienLabel.Margin = new Padding(0);
            tongTienLabel.Name = "tongTienLabel";
            tongTienLabel.Size = new Size(58, 38);
            tongTienLabel.TabIndex = 2;
            tongTienLabel.Text = "0 đ";
            // 
            // timKiemSanPhamTextBox
            // 
            timKiemSanPhamTextBox.Location = new Point(30, 64);
            timKiemSanPhamTextBox.Margin = new Padding(0);
            timKiemSanPhamTextBox.Name = "timKiemSanPhamTextBox";
            timKiemSanPhamTextBox.PlaceholderText = "Tìm kiếm";
            timKiemSanPhamTextBox.Size = new Size(289, 31);
            timKiemSanPhamTextBox.TabIndex = 0;
            timKiemSanPhamTextBox.TextChanged += TimKiemSanPhamTextBox_TextChanged;
            // 
            // timKiemSanPhamButton
            // 
            timKiemSanPhamButton.Location = new Point(319, 62);
            timKiemSanPhamButton.Margin = new Padding(0);
            timKiemSanPhamButton.Name = "timKiemSanPhamButton";
            timKiemSanPhamButton.Size = new Size(112, 34);
            timKiemSanPhamButton.TabIndex = 1;
            timKiemSanPhamButton.Text = "Tìm kiếm";
            timKiemSanPhamButton.UseVisualStyleBackColor = true;
            timKiemSanPhamButton.Click += TimKiemSanPhamButton_Click;
            // 
            // lamMoiSanPhamButton
            // 
            lamMoiSanPhamButton.Location = new Point(431, 62);
            lamMoiSanPhamButton.Margin = new Padding(0);
            lamMoiSanPhamButton.Name = "lamMoiSanPhamButton";
            lamMoiSanPhamButton.Size = new Size(112, 34);
            lamMoiSanPhamButton.TabIndex = 2;
            lamMoiSanPhamButton.Text = "Làm mới";
            lamMoiSanPhamButton.UseVisualStyleBackColor = true;
            lamMoiSanPhamButton.Click += LamMoiSanPhamButton_Click;
            // 
            // loaiSanPhamComboBox
            // 
            loaiSanPhamComboBox.FormattingEnabled = true;
            loaiSanPhamComboBox.Location = new Point(157, 25);
            loaiSanPhamComboBox.Margin = new Padding(0);
            loaiSanPhamComboBox.Name = "loaiSanPhamComboBox";
            loaiSanPhamComboBox.Size = new Size(274, 33);
            loaiSanPhamComboBox.TabIndex = 3;
            loaiSanPhamComboBox.SelectionChangeCommitted += LoaiSanPhamComboBox_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 28);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 4;
            label3.Text = "Loại sản phẩm";
            // 
            // chonNhaCungCapButton
            // 
            chonNhaCungCapButton.AutoSize = true;
            chonNhaCungCapButton.Location = new Point(16, 23);
            chonNhaCungCapButton.Margin = new Padding(0);
            chonNhaCungCapButton.Name = "chonNhaCungCapButton";
            chonNhaCungCapButton.Size = new Size(175, 35);
            chonNhaCungCapButton.TabIndex = 0;
            chonNhaCungCapButton.Text = "Chọn nhà cung cấp";
            chonNhaCungCapButton.UseVisualStyleBackColor = true;
            chonNhaCungCapButton.Click += ChonNhaCungCapButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 6);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(37, 25);
            label4.TabIndex = 1;
            label4.Text = "Mã";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 45);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(38, 25);
            label5.TabIndex = 2;
            label5.Text = "Tên";
            // 
            // lamMoiNhaCungCapButton
            // 
            lamMoiNhaCungCapButton.Location = new Point(16, 66);
            lamMoiNhaCungCapButton.Margin = new Padding(0);
            lamMoiNhaCungCapButton.Name = "lamMoiNhaCungCapButton";
            lamMoiNhaCungCapButton.Size = new Size(112, 34);
            lamMoiNhaCungCapButton.TabIndex = 4;
            lamMoiNhaCungCapButton.Text = "Làm mới";
            lamMoiNhaCungCapButton.UseVisualStyleBackColor = true;
            lamMoiNhaCungCapButton.Click += LamMoiNhaCungCapButton_Click;
            // 
            // maNhaCungCapLabel
            // 
            maNhaCungCapLabel.AutoSize = true;
            maNhaCungCapLabel.BorderStyle = BorderStyle.FixedSingle;
            maNhaCungCapLabel.Location = new Point(269, 6);
            maNhaCungCapLabel.Margin = new Padding(0);
            maNhaCungCapLabel.Name = "maNhaCungCapLabel";
            maNhaCungCapLabel.Size = new Size(210, 27);
            maNhaCungCapLabel.TabIndex = 5;
            maNhaCungCapLabel.Text = "Chưa chọn nhà cung cấp";
            // 
            // tenNhaCungCapLabel
            // 
            tenNhaCungCapLabel.BorderStyle = BorderStyle.FixedSingle;
            tenNhaCungCapLabel.Location = new Point(269, 45);
            tenNhaCungCapLabel.Margin = new Padding(0);
            tenNhaCungCapLabel.Name = "tenNhaCungCapLabel";
            tenNhaCungCapLabel.Size = new Size(260, 68);
            tenNhaCungCapLabel.TabIndex = 6;
            tenNhaCungCapLabel.Text = "Chưa chọn nhà cung cấp";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 120);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(572, 440);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 120);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(572, 540);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // TaoPhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaoPhieuNhapForm";
            Text = "TaoPhieuNhapForm";
            Load += TaoPhieuNhapForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private ComboBox loaiSanPhamComboBox;
        private Button lamMoiSanPhamButton;
        private Button timKiemSanPhamButton;
        private TextBox timKiemSanPhamTextBox;
        private Panel panel2;
        private Panel panel5;
        private Label tongTienLabel;
        private Label label1;
        private Button hoanTatButton;
        private Panel panel4;
        private Label label4;
        private Button chonNhaCungCapButton;
        private Label label5;
        private Label tenNhaCungCapLabel;
        private Label maNhaCungCapLabel;
        private Button lamMoiNhaCungCapButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}