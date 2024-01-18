using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab03_03
{
    public partial class Frm_ThemMoi : Form
    {
        private Form1 form1;
        private DataGridView dgv;
        int _numbers = 1;
        int index = -1;
        public Frm_ThemMoi(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            dgv = form1.dgvDanhSach;
            configControl();
        }
        public Sinhvien addStudent()
        {
           
             string mssv = txtMSSV.Text;
             string tenSinhVien = txtTenSV.Text;
             string khoa =cmbKhoa.SelectedItem.ToString();
             float diemTb = float.Parse(txtDiemTB.Text);
             Sinhvien sinhvien = new Sinhvien(mssv, tenSinhVien, khoa, diemTb);

            return sinhvien;
        }

        public void addOrUpdateContentInTable(Sinhvien sv, int index)
        {
            dgv.Rows[index].Cells[0].Value = _numbers++;
            dgv.Rows[index].Cells[1].Value = sv.mssv;
            dgv.Rows[index].Cells[2].Value = sv.hoten;
            dgv.Rows[index].Cells[3].Value = sv.khoa;
            dgv.Rows[index].Cells[4].Value = sv.diemTB;
        }

        public void btnThemMoi_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            
            if (checkInfoInput())
            {
                Sinhvien sv = addStudent();
                if (button.Text.Equals("Thêm Mới"))
                {
                    if (checkExist(sv) == false){
                        DialogResult result = MessageBox.Show("Luu thanh cong", "Thong bao", messageBoxButtons);
                        if (result == DialogResult.OK)
                        {
                            addOrUpdateContentInTable(sv, dgv.Rows.Add());
                            clearForm();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("MSSV đã tồn tại , Không thể thêm được", "Cảnh báo", messageBoxButtons);
                        if(result == DialogResult.OK)
                        {
                            clearForm();
                        }
                    }
                }
                if(button.Text.Equals("Sửa"))
                {
                    DialogResult result = MessageBox.Show("Sửa thành công", "Thông báo", messageBoxButtons);
                    if (result == DialogResult.OK)
                    {
                        addOrUpdateContentInTable(sv, index);
                        clearForm();
                        btnThemMoi.Text = "Thêm Mới";
                        this.Close();
                    }
                }
            }
        }

        private void Frm_ThemMoi_Load(object sender, EventArgs e)
        {
            cmbKhoa.Items.Add("Công nghệ thông tin");
            cmbKhoa.Items.Add("Kinh doanh quốc tế");
            cmbKhoa.Items.Add("Quản trị kinh doanh");
            cmbKhoa.Items.Add("Logistic");
            cmbKhoa.Items.Add("Ngôn ngữ anh");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showContent(int index)
        {
            this.Show();
            txtMSSV.Text = dgv.Rows[index].Cells[1].Value.ToString();
            txtTenSV.Text = dgv.Rows[index].Cells[2].Value.ToString();
            cmbKhoa.Text = dgv.Rows[index].Cells[3].Value.ToString();
            txtDiemTB.Text = dgv.Rows[index].Cells[4].Value.ToString();
            this.index = index;
            btnThemMoi.Text = "Sửa";
        }

        private bool checkExist(Sinhvien sinhvien)
        {
            if (dgv.RowCount > 0)
            {
                foreach (DataGridViewRow rows in dgv.Rows)
                {
                    if (rows.Cells["colMSSV"].Value.Equals(sinhvien.mssv))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void configControl()
        {
            cmbKhoa.DisplayMember = "Name";
            cmbKhoa.ValueMember = "Id";
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void clearForm()
        {
            txtMSSV.Text = string.Empty;
            txtTenSV.Text = string.Empty;
            txtDiemTB.Text = string.Empty;
            cmbKhoa.SelectedIndex = 0;
        }
        private bool checkInfoInput()
        {
            errNotify.Clear();
            int mssv;
            if (int.TryParse(txtMSSV.Text, out mssv) == false || string.IsNullOrEmpty(txtMSSV.Text))
            {
                errNotify.SetError(txtMSSV, "*");
                return false;
            }
            if (string.IsNullOrEmpty(txtTenSV.Text))
            {
                errNotify.SetError(txtTenSV, "*");
                return false;
            }
            if (cmbKhoa.SelectedIndex == -1)
            {
                errNotify.SetError(cmbKhoa, "*");
                return false;
            }
            float diemTB;
            if (float.TryParse(txtDiemTB.Text, out diemTB) == false
                || string.IsNullOrEmpty(txtDiemTB.Text) || diemTB < 0 || diemTB > 10)
            {
                errNotify.SetError(txtDiemTB, "*");
                return false;
            }
            return true;
        }

        
    }

}
