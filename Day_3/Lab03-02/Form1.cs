using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        private string filePath = string.Empty;
        private string fileContent = string.Empty;
        private string fileName = string.Empty;
        private bool fileSaved = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay la {0} - Bây giờ là {1}",
                DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileSaved == true)
            {
                richTextBox.Clear();
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save an Text File";
                saveFileDialog.FileName = fileName;
                saveFileDialog.RestoreDirectory = true;




                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
                    fileSaved = true;
                    richTextBox.Clear();
                }
            }

        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                fileName = System.IO.Path.GetFileName(openFileDialog.FileName);


                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                richTextBox.Text = fileContent;
                fileSaved = false;
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save an Text File";
            saveFileDialog.FileName = fileName;
            saveFileDialog.RestoreDirectory = true;




            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.Equals(null))
                {
                    saveFileDialog.FileName = "*.txt";
                }
                File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
                fileSaved = true;
            }

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;


            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình ?", "Warning", messageBoxButtons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowHelp = true;

            System.Drawing.Font font = fontDialog.Font;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.ForeColor = fontDialog.Color;
                richTextBox.Font = fontDialog.Font;


                cmbFont.SelectedItem = font.Name;
                cmbFontSize.SelectedItem = font.Size.ToString();
                if (fontDialog.Font.Style.HasFlag(FontStyle.Bold))
                {
                    btnBold.BackColor = Color.DodgerBlue;
                }
                else
                {
                    btnBold.BackColor = Color.LightBlue;
                }
                if (fontDialog.Font.Style.HasFlag(FontStyle.Italic))
                {
                    btnItalic.BackColor = Color.DodgerBlue;
                }
                else
                {
                    btnItalic.BackColor = Color.LightBlue;
                }
                if (fontDialog.Font.Style.HasFlag(FontStyle.Underline))
                {
                    btnUndeline.BackColor = Color.DodgerBlue;
                }
                else
                {
                    btnUndeline.BackColor = Color.LightBlue;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                cmbFont.Items.Add(fontFamily.Name);
            }
            List<int> fontSizes = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int fontSize in fontSizes)
            {
                cmbFontSize.Items.Add(fontSize.ToString());
            }
            cmbFont.SelectedItem = "Tahoma";
            cmbFontSize.SelectedItem = "14";
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            changeFontStyle(FontStyle.Bold);
            changeColorBtn(btnBold);
        }
        private void btnItalic_Click(object sender, EventArgs e)
        {
            changeFontStyle(FontStyle.Italic);
            changeColorBtn(btnItalic);
        }

        private void btnUndeline_Click(object sender, EventArgs e)
        {
            changeFontStyle(FontStyle.Underline);
            changeColorBtn(btnUndeline);
        }
        private void changeColorBtn(ToolStripButton btn)
        {

            if (btn.BackColor == Color.DodgerBlue)
            {
                btn.BackColor = Color.LightBlue;
            }
            else if (btn.BackColor == Color.LightBlue)
            {
                btn.BackColor = Color.DodgerBlue;
            }
        }
        private void changeFontStyle(FontStyle fontStyle)
        {
            bool hasStyle = (richTextBox.SelectionFont != null && richTextBox.SelectionFont.Style.HasFlag(fontStyle));
            string font = cmbFont.SelectedItem.ToString();
            int size = int.Parse(cmbFontSize.SelectedItem.ToString());
            FontStyle newStyle = richTextBox.SelectionFont != null ? richTextBox.SelectionFont.Style : FontStyle.Regular;

            if (hasStyle)
            {
                newStyle &= ~fontStyle;
            }
            else
            {
                newStyle |= fontStyle;
            }

            richTextBox.SelectionFont = new Font(font, size, newStyle);
        }


        private void applyChange()
        {
            if (cmbFontSize.SelectedItem != null)
            {
                string font = cmbFont.SelectedItem.ToString();
                int size = int.Parse(cmbFontSize.SelectedItem.ToString());
                richTextBox.SelectionFont = new Font(font, size);
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyChange();
        }
    }
}