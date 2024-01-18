namespace Management_Student_AVG
{
    partial class Frm_QuanLySinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDanhSanh = new System.Windows.Forms.DataGridView();
            this.colMssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.errCanhBao = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_Quanlykhoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_TimKiem = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNắngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_QuanLyKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_TimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHuy = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCanhBao)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(361, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMssv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(556, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Điểm TB :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(36, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "MSSV :";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(171, 172);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(324, 24);
            this.cbKhoa.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Khoa :";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(171, 231);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(324, 22);
            this.txtDiem.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 4;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(169, 106);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(324, 22);
            this.txtHoten.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thông tin sinh viên";
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(169, 41);
            this.txtMssv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(324, 22);
            this.txtMssv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên : ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(256, 455);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 41);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm/Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(403, 455);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 41);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvDanhSanh
            // 
            this.dgvDanhSanh.AllowUserToAddRows = false;
            this.dgvDanhSanh.AllowUserToDeleteRows = false;
            this.dgvDanhSanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMssv,
            this.colHoTen,
            this.colKhoa,
            this.colDiem});
            this.dgvDanhSanh.Location = new System.Drawing.Point(580, 134);
            this.dgvDanhSanh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvDanhSanh.Name = "dgvDanhSanh";
            this.dgvDanhSanh.ReadOnly = true;
            this.dgvDanhSanh.RowHeadersWidth = 51;
            this.dgvDanhSanh.RowTemplate.Height = 29;
            this.dgvDanhSanh.Size = new System.Drawing.Size(695, 316);
            this.dgvDanhSanh.TabIndex = 4;
            this.dgvDanhSanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSanh_CellClick);
            // 
            // colMssv
            // 
            this.colMssv.HeaderText = "MSSV";
            this.colMssv.MinimumWidth = 6;
            this.colMssv.Name = "colMssv";
            this.colMssv.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.ReadOnly = true;
            // 
            // colDiem
            // 
            this.colDiem.HeaderText = "Điểm TB";
            this.colDiem.MinimumWidth = 6;
            this.colDiem.Name = "colDiem";
            this.colDiem.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 9;
            // 
            // errCanhBao
            // 
            this.errCanhBao.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_Quanlykhoa,
            this.toolStripBtn_TimKiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1275, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtn_Quanlykhoa
            // 
            this.toolStripBtn_Quanlykhoa.Image = global::Management_Student_AVG.Properties.Resources.project_management;
            this.toolStripBtn_Quanlykhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Quanlykhoa.Name = "toolStripBtn_Quanlykhoa";
            this.toolStripBtn_Quanlykhoa.Size = new System.Drawing.Size(119, 24);
            this.toolStripBtn_Quanlykhoa.Text = "Quản lý khoa";
            this.toolStripBtn_Quanlykhoa.Click += new System.EventHandler(this.toolStripBtn_Quanlykhoa_Click);
            // 
            // toolStripBtn_TimKiem
            // 
            this.toolStripBtn_TimKiem.Image = global::Management_Student_AVG.Properties.Resources.searching_magnifying_glass;
            this.toolStripBtn_TimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_TimKiem.Name = "toolStripBtn_TimKiem";
            this.toolStripBtn_TimKiem.Size = new System.Drawing.Size(94, 24);
            this.toolStripBtn_TimKiem.Text = "Tìm kiếm";
            this.toolStripBtn_TimKiem.Click += new System.EventHandler(this.toolStripBtn_TimKiem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNắngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNắngToolStripMenuItem
            // 
            this.chứcNắngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_QuanLyKhoa,
            this.menuItem_TimKiem,
            this.toolStripSeparator1,
            this.menuItem_Thoat});
            this.chứcNắngToolStripMenuItem.Name = "chứcNắngToolStripMenuItem";
            this.chứcNắngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNắngToolStripMenuItem.Text = "Chức năng";
            // 
            // menuItem_QuanLyKhoa
            // 
            this.menuItem_QuanLyKhoa.Name = "menuItem_QuanLyKhoa";
            this.menuItem_QuanLyKhoa.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuItem_QuanLyKhoa.Size = new System.Drawing.Size(224, 26);
            this.menuItem_QuanLyKhoa.Text = "Quản lý khoa";
            this.menuItem_QuanLyKhoa.Click += new System.EventHandler(this.toolStripBtn_Quanlykhoa_Click);
            // 
            // menuItem_TimKiem
            // 
            this.menuItem_TimKiem.Name = "menuItem_TimKiem";
            this.menuItem_TimKiem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuItem_TimKiem.Size = new System.Drawing.Size(224, 26);
            this.menuItem_TimKiem.Text = "Tìm Kiếm";
            this.menuItem_TimKiem.Click += new System.EventHandler(this.toolStripBtn_TimKiem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuItem_Thoat
            // 
            this.menuItem_Thoat.Name = "menuItem_Thoat";
            this.menuItem_Thoat.Size = new System.Drawing.Size(224, 26);
            this.menuItem_Thoat.Text = "Thoát";
            this.menuItem_Thoat.Click += new System.EventHandler(this.menuItem_Thoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1142, 491);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 42);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Management_Student_AVG.Models.Student);
            // 
            // Frm_QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1275, 545);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDanhSanh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Frm_QuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCanhBao)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbKhoa;
        private Label label6;
        private TextBox txtDiem;
        private Label label4;
        private TextBox txtHoten;
        private Label label3;
        private TextBox txtMssv;
        private Label label2;
        private Button btnThem;
        private Button btnXoa;
        private DataGridView dgvDanhSanh;
        private Label label7;
        private Label label9;
        private Label label10;
        private ErrorProvider errCanhBao;
        private DataGridViewTextBoxColumn colMssv;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colKhoa;
        private DataGridViewTextBoxColumn colDiem;
        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNắngToolStripMenuItem;
        private ToolStripMenuItem menuItem_QuanLyKhoa;
        private ToolStripMenuItem menuItem_TimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuItem_Thoat;
        private ToolStripButton toolStripBtn_Quanlykhoa;
        private ToolStripButton toolStripBtn_TimKiem;
        private BindingSource studentBindingSource;
        private Button btnHuy;
    }
}