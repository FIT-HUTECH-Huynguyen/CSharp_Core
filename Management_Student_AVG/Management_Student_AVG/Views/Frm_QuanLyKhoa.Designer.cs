namespace Management_Student_AVG.Views
{
    partial class Frm_QuanLyKhoa
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongGS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachKhoa = new System.Windows.Forms.DataGridView();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.errCanhBao = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCanhBao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongGS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(483, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khoa";
            // 
            // txtTongGS
            // 
            this.txtTongGS.Location = new System.Drawing.Point(133, 197);
            this.txtTongGS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongGS.Name = "txtTongGS";
            this.txtTongGS.Size = new System.Drawing.Size(129, 22);
            this.txtTongGS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng số GS : ";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(133, 117);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(247, 22);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khoa : ";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMaKhoa.Enabled = false;
            this.txtMaKhoa.Location = new System.Drawing.Point(133, 44);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(129, 22);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa :";
            // 
            // dgvDanhSachKhoa
            // 
            this.dgvDanhSachKhoa.AllowUserToAddRows = false;
            this.dgvDanhSachKhoa.AllowUserToDeleteRows = false;
            this.dgvDanhSachKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKhoa,
            this.colTenKhoa,
            this.colTongGS});
            this.dgvDanhSachKhoa.Location = new System.Drawing.Point(504, 39);
            this.dgvDanhSachKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachKhoa.Name = "dgvDanhSachKhoa";
            this.dgvDanhSachKhoa.ReadOnly = true;
            this.dgvDanhSachKhoa.RowHeadersWidth = 51;
            this.dgvDanhSachKhoa.Size = new System.Drawing.Size(556, 366);
            this.dgvDanhSachKhoa.TabIndex = 1;
            this.dgvDanhSachKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKhoa_CellClick);
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.HeaderText = "Mã Khoa ";
            this.colMaKhoa.MinimumWidth = 6;
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.ReadOnly = true;
            // 
            // colTenKhoa
            // 
            this.colTenKhoa.HeaderText = "Tên Khoa";
            this.colTenKhoa.MinimumWidth = 6;
            this.colTenKhoa.Name = "colTenKhoa";
            this.colTenKhoa.ReadOnly = true;
            // 
            // colTongGS
            // 
            this.colTongGS.HeaderText = "Tổng số GS";
            this.colTongGS.MinimumWidth = 6;
            this.colTongGS.Name = "colTongGS";
            this.colTongGS.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(201, 295);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 39);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(344, 295);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 39);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(947, 412);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(113, 39);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // errCanhBao
            // 
            this.errCanhBao.ContainerControl = this;
            // 
            // Frm_QuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 464);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSachKhoa);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_QuanLyKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khoa";
            this.Load += new System.EventHandler(this.Frm_QuanLyKhoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCanhBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvDanhSachKhoa;
        private TextBox txtMaKhoa;
        private Label label1;
        private TextBox txtTongGS;
        private Label label3;
        private TextBox txtTenKhoa;
        private Label label2;
        private DataGridViewTextBoxColumn colMaKhoa;
        private DataGridViewTextBoxColumn colTenKhoa;
        private DataGridViewTextBoxColumn colTongGS;
        private Button btnThem;
        private Button btnXoa;
        private Button btnDong;
        private ErrorProvider errCanhBao;
    }
}