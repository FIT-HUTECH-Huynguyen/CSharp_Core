using Management_Student_AVG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Student_AVG.Views
{
    public partial class Frm_TimKiem : Form
    {
        private Frm_QuanLySinhVien frm_QuanLySinhVien;
        private List<Student> students;
        private List<Faculty> faculties;
        public Frm_TimKiem(Frm_QuanLySinhVien frm_QuanLySinhVien)
        {
            InitializeComponent();
            this.frm_QuanLySinhVien = frm_QuanLySinhVien;
        }
        private void fillFacultyComboBox(List<Faculty> faculties)
        {
            cmbKhoa.DisplayMember = "FacultyName";
            cmbKhoa.ValueMember = "FacultyID";
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKhoa.DataSource = faculties;
        }
        private void bindGridView(List<Student> students)
        {
            dgvDanhSachTimKiem.Rows.Clear();
            foreach (Student student in students)
            {
                int index = dgvDanhSachTimKiem.Rows.Add();
                dgvDanhSachTimKiem.Rows[index].Cells[0].Value = student.StudentID;
                dgvDanhSachTimKiem.Rows[index].Cells[1].Value = student.FullName;
                dgvDanhSachTimKiem.Rows[index].Cells[2].Value = student.Faculty.FacultyName;
                dgvDanhSachTimKiem.Rows[index].Cells[3].Value = student.AverageScore.ToString();
            }
        }

        private void bindFindData(Student student)
        {
            dgvDanhSachTimKiem.Rows.Clear();
            int index = dgvDanhSachTimKiem.Rows.Add();
            dgvDanhSachTimKiem.Rows[index].Cells[0].Value = student.StudentID;
            dgvDanhSachTimKiem.Rows[index].Cells[1].Value = student.FullName;
            dgvDanhSachTimKiem.Rows[index].Cells[2].Value = student.Faculty.FacultyName;
            dgvDanhSachTimKiem.Rows[index].Cells[3].Value = student.AverageScore.ToString();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var dbContext = new StudentDBContext())
            {
                int facultyId = int.Parse(cmbKhoa.SelectedValue.ToString());
                Student student = dbContext.Students.FirstOrDefault(x => x.StudentID.Equals(txtMSSV.Text)
                && x.FullName.Equals(txtHoTen.Text)
                && x.FacultyID == facultyId);
                if (student == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setDefault();
                }
                else
                {
                    bindFindData(student);
                }

            }
            int count = 0;
            foreach (DataGridViewRow row in dgvDanhSachTimKiem.Rows)
            {
                count++;
            }
            txtSoluong.Text = count.ToString();
            btnXoa.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (var dbContext = new StudentDBContext())
            {
                students = dbContext.Students.ToList();
                faculties = dbContext.Faculties.ToList();
            }
            bindGridView(students);
            setDefault();
        }



        private void btnTrove_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Ban chắc chắn muốn đóng cửa sổ này ?", "Cảnh báo", messageBoxButtons);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void Frm_TimKiem_Load(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new StudentDBContext())
                {
                    students = dbContext.Students.ToList();
                    faculties = dbContext.Faculties.ToList();

                }
                fillFacultyComboBox(faculties);
                bindGridView(students);
                cmbKhoa.SelectedIndex = 0;
                btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setDefault()
        {
            txtMSSV.Text = txtHoTen.Text = string.Empty;
            cmbKhoa.SelectedIndex = -1;
        }

    }
}
