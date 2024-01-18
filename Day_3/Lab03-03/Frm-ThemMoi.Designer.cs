namespace Lab03_03
{
    partial class Frm_ThemMoi
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtMSSV = new TextBox();
            txtTenSV = new TextBox();
            label2 = new Label();
            txtDiemTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbKhoa = new ComboBox();
            btnThemMoi = new Button();
            btnThoat = new Button();
            errNotify = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errNotify).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 51);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(211, 49);
            txtMSSV.Margin = new Padding(3, 2, 3, 2);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(297, 22);
            txtMSSV.TabIndex = 1;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(211, 106);
            txtTenSV.Margin = new Padding(3, 2, 3, 2);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(297, 22);
            txtTenSV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 108);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 2;
            label2.Text = "Tên Sinh Viên";
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(211, 209);
            txtDiemTB.Margin = new Padding(3, 2, 3, 2);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(169, 22);
            txtDiemTB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 212);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 4;
            label3.Text = "Điểm TB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 158);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 6;
            label4.Text = "Khoa";
            // 
            // cmbKhoa
            // 
            cmbKhoa.FormattingEnabled = true;
            cmbKhoa.Location = new Point(211, 158);
            cmbKhoa.Margin = new Padding(3, 2, 3, 2);
            cmbKhoa.Name = "cmbKhoa";
            cmbKhoa.Size = new Size(294, 24);
            cmbKhoa.TabIndex = 7;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(334, 290);
            btnThemMoi.Margin = new Padding(3, 2, 3, 2);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(133, 34);
            btnThemMoi.TabIndex = 8;
            btnThemMoi.Text = "Thêm Mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(509, 290);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(133, 34);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // errNotify
            // 
            errNotify.ContainerControl = this;
            // 
            // Frm_ThemMoi
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(674, 348);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(cmbKhoa);
            Controls.Add(label4);
            Controls.Add(txtDiemTB);
            Controls.Add(label3);
            Controls.Add(txtTenSV);
            Controls.Add(label2);
            Controls.Add(txtMSSV);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_ThemMoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_ThemMoi";
            Load += Frm_ThemMoi_Load;
            ((System.ComponentModel.ISupportInitialize)errNotify).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMSSV;
        private TextBox txtTenSV;
        private Label label2;
        private TextBox txtDiemTB;
        private Label label3;
        private Label label4;
        private ComboBox cmbKhoa;
        private Button btnThemMoi;
        private Button btnThoat;
        private ErrorProvider errNotify;
    }
}