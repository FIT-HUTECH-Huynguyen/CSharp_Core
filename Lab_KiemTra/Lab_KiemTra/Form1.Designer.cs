namespace Lab_KiemTra
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxInfor = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxXetNghiem = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbDuongTinh = new System.Windows.Forms.RadioButton();
            this.rdbAmTinh = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.cmbCty = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gbxInfor.SuspendLayout();
            this.gbxXetNghiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhânToolStripMenuItem,
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem,
            this.toolStripSeparator1,
            this.xuấtBáoCáoToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // danhSáchNhânToolStripMenuItem
            // 
            this.danhSáchNhânToolStripMenuItem.Name = "danhSáchNhânToolStripMenuItem";
            this.danhSáchNhânToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.danhSáchNhânToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.danhSáchNhânToolStripMenuItem.Text = "Danh sách NV dương tính";
            this.danhSáchNhânToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânToolStripMenuItem_Click);
            // 
            // danhSáchCtyĐãTestTheoYCToolStripMenuItem
            // 
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Name = "danhSáchCtyĐãTestTheoYCToolStripMenuItem";
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Text = "Danh sách Cty đã test theo Y/C";
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Click += new System.EventHandler(this.danhSáchCtyĐãTestTheoYCToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(316, 6);
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
            // 
            // gbxInfor
            // 
            this.gbxInfor.Controls.Add(this.btnSearch);
            this.gbxInfor.Controls.Add(this.txtCCCD);
            this.gbxInfor.Controls.Add(this.label1);
            this.gbxInfor.Location = new System.Drawing.Point(11, 57);
            this.gbxInfor.Name = "gbxInfor";
            this.gbxInfor.Size = new System.Drawing.Size(417, 109);
            this.gbxInfor.TabIndex = 1;
            this.gbxInfor.TabStop = false;
            this.gbxInfor.Text = "Thông Tin Nhân Viên";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(304, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(112, 39);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(252, 22);
            this.txtCCCD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCCD/CMND";
            // 
            // gbxXetNghiem
            // 
            this.gbxXetNghiem.Controls.Add(this.btnUpdate);
            this.gbxXetNghiem.Controls.Add(this.cmbCty);
            this.gbxXetNghiem.Controls.Add(this.label5);
            this.gbxXetNghiem.Controls.Add(this.rdbDuongTinh);
            this.gbxXetNghiem.Controls.Add(this.rdbAmTinh);
            this.gbxXetNghiem.Controls.Add(this.label4);
            this.gbxXetNghiem.Controls.Add(this.txtAmount);
            this.gbxXetNghiem.Controls.Add(this.label3);
            this.gbxXetNghiem.Controls.Add(this.txtName);
            this.gbxXetNghiem.Controls.Add(this.label2);
            this.gbxXetNghiem.Location = new System.Drawing.Point(11, 172);
            this.gbxXetNghiem.Name = "gbxXetNghiem";
            this.gbxXetNghiem.Size = new System.Drawing.Size(417, 376);
            this.gbxXetNghiem.TabIndex = 2;
            this.gbxXetNghiem.TabStop = false;
            this.gbxXetNghiem.Text = "Thông Tin Xét Nghiệm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Công ty";
            // 
            // rdbDuongTinh
            // 
            this.rdbDuongTinh.AutoSize = true;
            this.rdbDuongTinh.Location = new System.Drawing.Point(112, 170);
            this.rdbDuongTinh.Name = "rdbDuongTinh";
            this.rdbDuongTinh.Size = new System.Drawing.Size(91, 20);
            this.rdbDuongTinh.TabIndex = 6;
            this.rdbDuongTinh.TabStop = true;
            this.rdbDuongTinh.Text = "Dương tính";
            this.rdbDuongTinh.UseVisualStyleBackColor = true;
            // 
            // rdbAmTinh
            // 
            this.rdbAmTinh.AutoSize = true;
            this.rdbAmTinh.Location = new System.Drawing.Point(112, 128);
            this.rdbAmTinh.Name = "rdbAmTinh";
            this.rdbAmTinh.Size = new System.Drawing.Size(71, 20);
            this.rdbAmTinh.TabIndex = 5;
            this.rdbAmTinh.TabStop = true;
            this.rdbAmTinh.Text = "Âm tính";
            this.rdbAmTinh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết quả";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Silver;
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(112, 83);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(116, 22);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SLXN";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // cmbCty
            // 
            this.cmbCty.FormattingEnabled = true;
            this.cmbCty.Location = new System.Drawing.Point(112, 226);
            this.cmbCty.Name = "cmbCty";
            this.cmbCty.Size = new System.Drawing.Size(252, 24);
            this.cmbCty.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(149, 301);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colAmount,
            this.colResult});
            this.dgvDanhSach.Location = new System.Drawing.Point(449, 66);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(582, 482);
            this.dgvDanhSach.TabIndex = 3;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "CCCD/CMND";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Họ tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Số lần XN";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colResult
            // 
            this.colResult.HeaderText = "Kết quả";
            this.colResult.MinimumWidth = 6;
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 559);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.gbxXetNghiem);
            this.Controls.Add(this.gbxInfor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxInfor.ResumeLayout(false);
            this.gbxInfor.PerformLayout();
            this.gbxXetNghiem.ResumeLayout(false);
            this.gbxXetNghiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchCtyĐãTestTheoYCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxInfor;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxXetNghiem;
        private System.Windows.Forms.Button btnSearch;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbDuongTinh;
        private System.Windows.Forms.RadioButton rdbAmTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbCty;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
    }
}

