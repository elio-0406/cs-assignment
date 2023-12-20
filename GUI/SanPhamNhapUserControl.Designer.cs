namespace GUI
{
    partial class SanPhamNhapUserControl
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
            sanPhamPictureBox = new PictureBox();
            tenSanPhamLabel = new Label();
            chonButton = new Button();
            ((System.ComponentModel.ISupportInitialize)sanPhamPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sanPhamPictureBox
            // 
            sanPhamPictureBox.BorderStyle = BorderStyle.FixedSingle;
            sanPhamPictureBox.Location = new Point(5, 11);
            sanPhamPictureBox.Margin = new Padding(0);
            sanPhamPictureBox.Name = "sanPhamPictureBox";
            sanPhamPictureBox.Size = new Size(100, 100);
            sanPhamPictureBox.TabIndex = 0;
            sanPhamPictureBox.TabStop = false;
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenSanPhamLabel.Location = new Point(111, 11);
            tenSanPhamLabel.Margin = new Padding(0);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new Size(68, 100);
            tenSanPhamLabel.TabIndex = 2;
            tenSanPhamLabel.Text = "Tên sản phẩm";
            // 
            // chonButton
            // 
            chonButton.BackColor = Color.RoyalBlue;
            chonButton.FlatAppearance.BorderSize = 0;
            chonButton.FlatStyle = FlatStyle.Flat;
            chonButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chonButton.ForeColor = Color.White;
            chonButton.Location = new Point(5, 122);
            chonButton.Margin = new Padding(0);
            chonButton.Name = "chonButton";
            chonButton.Size = new Size(174, 34);
            chonButton.TabIndex = 3;
            chonButton.Text = "Chọn";
            chonButton.UseVisualStyleBackColor = false;
            chonButton.Click += ChonButton_Click;
            // 
            // SanPhamNhapUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            Controls.Add(chonButton);
            Controls.Add(tenSanPhamLabel);
            Controls.Add(sanPhamPictureBox);
            Margin = new Padding(0);
            Name = "SanPhamNhapUserControl";
            Size = new Size(185, 165);
            Load += SanPhamNhapUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)sanPhamPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox sanPhamPictureBox;
        private Label tenSanPhamLabel;
        private Button chonButton;
    }
}
