namespace Lab02_04
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnDelete = new Button();
            btnAddUpdate = new Button();
            txtAccountBalance = new TextBox();
            label5 = new Label();
            txtCustomerAddress = new TextBox();
            label4 = new Label();
            txtCustomerName = new TextBox();
            label3 = new Label();
            txtAccountNumber = new TextBox();
            label2 = new Label();
            dgvAccounts = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colAccountNumber = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colAccountBalance = new DataGridViewTextBoxColumn();
            errNotify = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNotify).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(217, 22);
            label1.Name = "label1";
            label1.Size = new Size(693, 54);
            label1.TabIndex = 0;
            label1.Text = "MANAGE ACCOUNT INFORMATION";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAddUpdate);
            groupBox1.Controls.Add(txtAccountBalance);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCustomerAddress);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAccountNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(81, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(941, 308);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information Account";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(737, 246);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 41);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(558, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 41);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddUpdate
            // 
            btnAddUpdate.Location = new Point(376, 246);
            btnAddUpdate.Name = "btnAddUpdate";
            btnAddUpdate.Size = new Size(139, 41);
            btnAddUpdate.TabIndex = 5;
            btnAddUpdate.Text = "Add";
            btnAddUpdate.UseVisualStyleBackColor = true;
            btnAddUpdate.Click += buttonAdd_Click;
            // 
            // txtAccountBalance
            // 
            txtAccountBalance.Location = new Point(289, 190);
            txtAccountBalance.Name = "txtAccountBalance";
            txtAccountBalance.Size = new Size(408, 27);
            txtAccountBalance.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 193);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 6;
            label5.Text = "Account Balance ";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(289, 138);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(408, 27);
            txtCustomerAddress.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 141);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 4;
            label4.Text = "Customer Address";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(289, 86);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(408, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 89);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Name";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(289, 35);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(408, 27);
            txtAccountNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 38);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 0;
            label2.Text = "Account Number";
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.AllowUserToDeleteRows = false;
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Columns.AddRange(new DataGridViewColumn[] { colSTT, colAccountNumber, colCustomerName, colAddress, colAccountBalance });
            dgvAccounts.Location = new Point(30, 419);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersWidth = 51;
            dgvAccounts.RowTemplate.Height = 29;
            dgvAccounts.Size = new Size(1041, 353);
            dgvAccounts.TabIndex = 8;
            dgvAccounts.CellClick += dgvAccounts_CellClick;
            // 
            // colSTT
            // 
            colSTT.FillWeight = 26.7379646F;
            colSTT.HeaderText = "STT";
            colSTT.MaxInputLength = 32734;
            colSTT.MinimumWidth = 6;
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            // 
            // colAccountNumber
            // 
            colAccountNumber.FillWeight = 118.315514F;
            colAccountNumber.HeaderText = "Account Number";
            colAccountNumber.MinimumWidth = 6;
            colAccountNumber.Name = "colAccountNumber";
            colAccountNumber.ReadOnly = true;
            // 
            // colCustomerName
            // 
            colCustomerName.FillWeight = 118.315514F;
            colCustomerName.HeaderText = "Customer Name";
            colCustomerName.MinimumWidth = 6;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.FillWeight = 118.315514F;
            colAddress.HeaderText = "Address";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // colAccountBalance
            // 
            colAccountBalance.FillWeight = 118.315514F;
            colAccountBalance.HeaderText = "Account Balance";
            colAccountBalance.MinimumWidth = 6;
            colAccountBalance.Name = "colAccountBalance";
            colAccountBalance.ReadOnly = true;
            // 
            // errNotify
            // 
            errNotify.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 784);
            Controls.Add(dgvAccounts);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNotify).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtAccountBalance;
        private Label label5;
        private TextBox txtCustomerAddress;
        private Label label4;
        private TextBox txtCustomerName;
        private Label label3;
        private TextBox txtAccountNumber;
        private Label label2;
        private Button btnClose;
        private Button btnDelete;
        private Button btnAddUpdate;
        private DataGridView dgvAccounts;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colAccountNumber;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colAccountBalance;
        private ErrorProvider errNotify;
    }
}