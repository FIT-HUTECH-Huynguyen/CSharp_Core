namespace Quan_Ly_Quan_Coffee.Views
{
    partial class FrmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlListTable = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPay = new System.Windows.Forms.Button();
            this.cmbChangeTable = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1480, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.mónToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý ";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản ";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu ";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // mónToolStripMenuItem
            // 
            this.mónToolStripMenuItem.Name = "mónToolStripMenuItem";
            this.mónToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.mónToolStripMenuItem.Text = "Món ";
            this.mónToolStripMenuItem.Click += new System.EventHandler(this.mónToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem1
            // 
            this.tàiKhoảnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem1.Name = "tàiKhoảnToolStripMenuItem1";
            this.tàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.tàiKhoảnToolStripMenuItem1.Text = "Tài Khoản";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập ";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            // 
            // pnlListTable
            // 
            this.pnlListTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlListTable.Location = new System.Drawing.Point(23, 36);
            this.pnlListTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlListTable.Name = "pnlListTable";
            this.pnlListTable.Size = new System.Drawing.Size(717, 562);
            this.pnlListTable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPay);
            this.panel1.Controls.Add(this.cmbChangeTable);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numDiscount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvInvoiceDetail);
            this.panel1.Controls.Add(this.btnAddPro);
            this.panel1.Controls.Add(this.numCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbProducts);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCategories);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(747, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 532);
            this.panel1.TabIndex = 2;
            // 
            // buttonPay
            // 
            this.buttonPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPay.Image")));
            this.buttonPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPay.Location = new System.Drawing.Point(485, 425);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(189, 87);
            this.buttonPay.TabIndex = 14;
            this.buttonPay.Text = "Thanh Toán ";
            this.buttonPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // cmbChangeTable
            // 
            this.cmbChangeTable.FormattingEnabled = true;
            this.cmbChangeTable.Location = new System.Drawing.Point(181, 455);
            this.cmbChangeTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChangeTable.Name = "cmbChangeTable";
            this.cmbChangeTable.Size = new System.Drawing.Size(151, 24);
            this.cmbChangeTable.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(24, 434);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 63);
            this.button2.TabIndex = 12;
            this.button2.Text = "Đổi Bàn ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(541, 380);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(175, 22);
            this.txtAmount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(425, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thành Tiền : ";
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(103, 380);
            this.numDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(149, 22);
            this.numDiscount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giảm Giá :";
            // 
            // dgvInvoiceDetail
            // 
            this.dgvInvoiceDetail.AllowUserToAddRows = false;
            this.dgvInvoiceDetail.AllowUserToDeleteRows = false;
            this.dgvInvoiceDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNameProduct,
            this.colCount,
            this.colPrice,
            this.colAmount,
            this.colId});
            this.dgvInvoiceDetail.Location = new System.Drawing.Point(24, 91);
            this.dgvInvoiceDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInvoiceDetail.Name = "dgvInvoiceDetail";
            this.dgvInvoiceDetail.ReadOnly = true;
            this.dgvInvoiceDetail.RowHeadersWidth = 51;
            this.dgvInvoiceDetail.RowTemplate.Height = 29;
            this.dgvInvoiceDetail.Size = new System.Drawing.Size(693, 263);
            this.dgvInvoiceDetail.TabIndex = 7;
            this.dgvInvoiceDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceDetail_CellDoubleClick);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPro.Image")));
            this.btnAddPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPro.Location = new System.Drawing.Point(573, 14);
            this.btnAddPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(133, 62);
            this.btnAddPro.TabIndex = 6;
            this.btnAddPro.Text = "Thêm Món ";
            this.btnAddPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(456, 32);
            this.numCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(83, 22);
            this.numCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(363, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng : ";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(136, 55);
            this.cmbProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(209, 24);
            this.cmbProducts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Món :";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(136, 14);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(209, 24);
            this.cmbCategories.TabIndex = 1;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục :";
            // 
            // colNameProduct
            // 
            this.colNameProduct.HeaderText = "Tên Món ";
            this.colNameProduct.MinimumWidth = 6;
            this.colNameProduct.Name = "colNameProduct";
            this.colNameProduct.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "Số Lượng";
            this.colCount.MinimumWidth = 6;
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Đơn Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Thành Tiền";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "Mã Món";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1480, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlListTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Ban Coffee ";
            this.Load += new System.EventHandler(this.FrmSale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem mónToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem1;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private Panel pnlListTable;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private ComboBox cmbProducts;
        private Label label2;
        private ComboBox cmbCategories;
        private Button btnAddPro;
        private NumericUpDown numCount;
        private NumericUpDown numDiscount;
        private Label label4;
        private DataGridView dgvInvoiceDetail;
        private TextBox txtAmount;
        private Label label5;
        private Button buttonPay;
        private ComboBox cmbChangeTable;
        private Button button2;
        private DataGridViewTextBoxColumn colNameProduct;
        private DataGridViewTextBoxColumn colCount;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colId;
    }
}