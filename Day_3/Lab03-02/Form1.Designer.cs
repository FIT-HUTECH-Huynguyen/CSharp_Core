namespace Lab03_02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tạoVănBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            mởTậpTinToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            lưuNộiDungVănBảnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            richTextBox = new RichTextBox();
            toolStrip1 = new ToolStrip();
            btnNewFile = new ToolStripButton();
            btnSaveFile = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            cmbFont = new ToolStripComboBox();
            cmbFontSize = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUndeline = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnMớiToolStripMenuItem, mởTậpTinToolStripMenuItem, toolStripSeparator1, lưuNộiDungVănBảnToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(92, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống ";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            tạoVănBảnMớiToolStripMenuItem.Image = (Image)resources.GetObject("tạoVănBảnMớiToolStripMenuItem.Image");
            tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tạoVănBảnMớiToolStripMenuItem.Size = new Size(289, 26);
            tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            tạoVănBảnMớiToolStripMenuItem.Click += tạoVănBảnMớiToolStripMenuItem_Click;
            // 
            // mởTậpTinToolStripMenuItem
            // 
            mởTậpTinToolStripMenuItem.Image = (Image)resources.GetObject("mởTậpTinToolStripMenuItem.Image");
            mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            mởTậpTinToolStripMenuItem.Size = new Size(289, 26);
            mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            mởTậpTinToolStripMenuItem.Click += mởTậpTinToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(286, 6);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            lưuNộiDungVănBảnToolStripMenuItem.Image = (Image)resources.GetObject("lưuNộiDungVănBảnToolStripMenuItem.Image");
            lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            lưuNộiDungVănBảnToolStripMenuItem.Size = new Size(289, 26);
            lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản ";
            lưuNộiDungVănBảnToolStripMenuItem.Click += lưuNộiDungVănBảnToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(289, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(94, 24);
            địnhDạngToolStripMenuItem.Text = "Định Dạng";
            địnhDạngToolStripMenuItem.Click += địnhDạngToolStripMenuItem_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(0, 59);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(800, 365);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.LightBlue;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNewFile, btnSaveFile, toolStripSeparator2, cmbFont, cmbFontSize, btnBold, btnItalic, btnUndeline, toolStripSeparator3 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNewFile
            // 
            btnNewFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNewFile.Image = (Image)resources.GetObject("btnNewFile.Image");
            btnNewFile.ImageTransparentColor = Color.Magenta;
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new Size(29, 25);
            btnNewFile.Text = "toolStripButton1";
            btnNewFile.Click += tạoVănBảnMớiToolStripMenuItem_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveFile.Image = (Image)resources.GetObject("btnSaveFile.Image");
            btnSaveFile.ImageTransparentColor = Color.Magenta;
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(29, 25);
            btnSaveFile.Text = "toolStripButton2";
            btnSaveFile.Click += lưuNộiDungVănBảnToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // cmbFont
            // 
            cmbFont.Name = "cmbFont";
            cmbFont.Size = new Size(200, 28);
            cmbFont.SelectedIndexChanged += cmbFont_SelectedIndexChanged;
            // 
            // cmbFontSize
            // 
            cmbFontSize.Name = "cmbFontSize";
            cmbFontSize.Size = new Size(80, 28);
            cmbFontSize.SelectedIndexChanged += cmbFont_SelectedIndexChanged;
            // 
            // btnBold
            // 
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBold.Image = (Image)resources.GetObject("btnBold.Image");
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(29, 25);
            btnBold.Text = "toolStripButton3";
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItalic.Image = (Image)resources.GetObject("btnItalic.Image");
            btnItalic.ImageTransparentColor = Color.Magenta;
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(29, 25);
            btnItalic.Text = "toolStripButton4";
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUndeline
            // 
            btnUndeline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUndeline.Image = (Image)resources.GetObject("btnUndeline.Image");
            btnUndeline.ImageTransparentColor = Color.Magenta;
            btnUndeline.Name = "btnUndeline";
            btnUndeline.Size = new Size(29, 25);
            btnUndeline.Text = "toolStripButton5";
            btnUndeline.Click += btnUndeline_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private RichTextBox richTextBox;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNewFile;
        private ToolStripButton btnSaveFile;
        private ToolStripComboBox cmbFont;
        private ToolStripComboBox cmbFontSize;
        private ToolStripButton btnBold;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUndeline;
        private ToolStripSeparator toolStripSeparator3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}