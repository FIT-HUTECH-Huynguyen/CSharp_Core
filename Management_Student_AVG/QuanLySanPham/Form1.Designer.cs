namespace QuanLySanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_All = new System.Windows.Forms.CheckBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_DeliveryDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_OrderDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkbox_All);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(710, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // dtp_DeliveryDate
            // 
            this.dtp_DeliveryDate.Location = new System.Drawing.Point(343, 54);
            this.dtp_DeliveryDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_DeliveryDate.Name = "dtp_DeliveryDate";
            this.dtp_DeliveryDate.Size = new System.Drawing.Size(151, 20);
            this.dtp_DeliveryDate.TabIndex = 4;
            this.dtp_DeliveryDate.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // dtp_OrderDate
            // 
            this.dtp_OrderDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_OrderDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_OrderDate.Location = new System.Drawing.Point(155, 55);
            this.dtp_OrderDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_OrderDate.Name = "dtp_OrderDate";
            this.dtp_OrderDate.Size = new System.Drawing.Size(151, 20);
            this.dtp_OrderDate.TabIndex = 2;
            this.dtp_OrderDate.Value = new System.DateTime(2023, 10, 2, 10, 27, 49, 0);
            this.dtp_OrderDate.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời Gian Giao Hàng";
            // 
            // checkbox_All
            // 
            this.checkbox_All.AutoSize = true;
            this.checkbox_All.Location = new System.Drawing.Point(41, 25);
            this.checkbox_All.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_All.Name = "checkbox_All";
            this.checkbox_All.Size = new System.Drawing.Size(107, 17);
            this.checkbox_All.TabIndex = 0;
            this.checkbox_All.Text = "Xem tất cả tháng";
            this.checkbox_All.UseVisualStyleBackColor = true;
            this.checkbox_All.CheckedChanged += new System.EventHandler(this.checkbox_All_CheckedChanged);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colSoHD,
            this.colNgayDat,
            this.colNgayGiao,
            this.colThanhTien});
            this.dgvDanhSach.Location = new System.Drawing.Point(9, 122);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(710, 231);
            this.dgvDanhSach.TabIndex = 1;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 50F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colSoHD
            // 
            this.colSoHD.FillWeight = 91.57755F;
            this.colSoHD.HeaderText = "Số HĐ";
            this.colSoHD.MinimumWidth = 6;
            this.colSoHD.Name = "colSoHD";
            this.colSoHD.ReadOnly = true;
            // 
            // colNgayDat
            // 
            this.colNgayDat.FillWeight = 91.57755F;
            this.colNgayDat.HeaderText = "Ngày Đặt Hàng";
            this.colNgayDat.MinimumWidth = 6;
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.ReadOnly = true;
            // 
            // colNgayGiao
            // 
            this.colNgayGiao.FillWeight = 91.57755F;
            this.colNgayGiao.HeaderText = "Ngày Giao Hàng ";
            this.colNgayGiao.MinimumWidth = 6;
            this.colNgayGiao.Name = "colNgayGiao";
            this.colNgayGiao.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.FillWeight = 91.57755F;
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 365);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Cộng ";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotal.Location = new System.Drawing.Point(609, 362);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(111, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 390);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkbox_All;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_OrderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_DeliveryDate;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}

