namespace GUI
{
    partial class SanPhamBanUserControl
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
            chonButton = new Button();
            tenSanPhamLabel = new Label();
            sanPhamPictureBox = new PictureBox();
            giaBanLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)sanPhamPictureBox).BeginInit();
            SuspendLayout();
            // 
            // chonButton
            // 
            chonButton.Location = new Point(5, 142);
            chonButton.Margin = new Padding(0);
            chonButton.Name = "chonButton";
            chonButton.Size = new Size(174, 34);
            chonButton.TabIndex = 6;
            chonButton.Text = "Chọn";
            chonButton.UseVisualStyleBackColor = true;
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenSanPhamLabel.Location = new Point(111, 11);
            tenSanPhamLabel.Margin = new Padding(0);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new Size(68, 100);
            tenSanPhamLabel.TabIndex = 5;
            tenSanPhamLabel.Text = "Tên sản phẩm";
            // 
            // sanPhamPictureBox
            // 
            sanPhamPictureBox.BorderStyle = BorderStyle.FixedSingle;
            sanPhamPictureBox.Location = new Point(5, 11);
            sanPhamPictureBox.Margin = new Padding(0);
            sanPhamPictureBox.Name = "sanPhamPictureBox";
            sanPhamPictureBox.Size = new Size(100, 100);
            sanPhamPictureBox.TabIndex = 4;
            sanPhamPictureBox.TabStop = false;
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            giaBanLabel.Location = new Point(5, 117);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new Size(38, 25);
            giaBanLabel.TabIndex = 7;
            giaBanLabel.Text = "0 đ";
            // 
            // SanPhamBanUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(giaBanLabel);
            Controls.Add(chonButton);
            Controls.Add(tenSanPhamLabel);
            Controls.Add(sanPhamPictureBox);
            Name = "SanPhamBanUserControl";
            Size = new Size(185, 186);
            ((System.ComponentModel.ISupportInitialize)sanPhamPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chonButton;
        private Label tenSanPhamLabel;
        private PictureBox sanPhamPictureBox;
        private Label giaBanLabel;
    }
}
