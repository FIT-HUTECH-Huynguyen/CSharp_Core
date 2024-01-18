namespace Day_2
{
    partial class Exercise_1
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            label2 = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMulti = new Button();
            btnDivide = new Button();
            txtAnswer = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            error = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 57);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(302, 54);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(305, 27);
            txtNumber1.TabIndex = 1;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(302, 111);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(305, 27);
            txtNumber2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 114);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Number 2";
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(206, 205);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(103, 35);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += button2_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(504, 205);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(103, 35);
            btnMinus.TabIndex = 5;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += button2_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMulti.Location = new Point(206, 281);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(103, 35);
            btnMulti.TabIndex = 6;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += button2_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(504, 281);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(103, 35);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += button2_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = SystemColors.GradientActiveCaption;
            txtAnswer.Enabled = false;
            txtAnswer.Location = new Point(302, 349);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(305, 27);
            txtAnswer.TabIndex = 9;
            txtAnswer.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 352);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Answer";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(204, 121);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(8, 4);
            listBox1.TabIndex = 10;
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // Exercise_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(txtAnswer);
            Controls.Add(label3);
            Controls.Add(btnDivide);
            Controls.Add(btnMulti);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtNumber2);
            Controls.Add(label2);
            Controls.Add(txtNumber1);
            Controls.Add(label1);
            Name = "Exercise_1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label label2;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMulti;
        private Button btnDivide;
        private TextBox txtAnswer;
        private Label label3;
        private ListBox listBox1;
        private ErrorProvider error;
    }
}