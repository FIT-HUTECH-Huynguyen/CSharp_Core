using System.Data;

namespace Lab03_03
{
    public partial class Form1 : Form
    {
        private Frm_ThemMoi frm_ThemMoi;
        public int index = -1;
        public Form1()
        {
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm_ThemMoi = new Frm_ThemMoi(this);
            frm_ThemMoi.Show();
        }
       

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            frm_ThemMoi = new Frm_ThemMoi(this);
            frm_ThemMoi.showContent(index);
            
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string q = txtTimKiem.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dgvDanhSach.Rows)
            {
                if (String.IsNullOrEmpty(q))
                {
                    row.Visible = true;
                    continue;
                }
                if (row.Cells[2].Value.ToString().ToLower().Contains(q))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThemMoi = new Frm_ThemMoi(this);
            frm_ThemMoi.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}