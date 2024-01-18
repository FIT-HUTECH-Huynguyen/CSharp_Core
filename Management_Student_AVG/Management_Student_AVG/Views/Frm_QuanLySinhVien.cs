using Management_Student_AVG.Models;
using Management_Student_AVG.Views;
using System.Data.Entity.Migrations;

namespace Management_Student_AVG
{
    public partial class Frm_QuanLySinhVien : Form
    {
        private List<Student> students;
        private List<Faculty> faculties;
        public Frm_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void fillFacultyCombox(List<Faculty> faculties)
        {
            cbKhoa.DisplayMember = "FacultyName";
            cbKhoa.ValueMember = "FacultyID";
            cbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoa.DataSource = faculties;

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new StudentDBContext())
                {
                    students = dbContext.Students.ToList();
                    faculties = dbContext.Faculties.ToList();

                }
                fillFacultyCombox(faculties);
                bindGridView(students);
                cbKhoa.SelectedIndex = 0;
                btnThem.Text = "Thêm";
                btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addorUpdateStudent()
        {
            using (var dbContext = new StudentDBContext())
            {

                Student student = dbContext.Students.FirstOrDefault(p => p.StudentID == txtMssv.Text);
                if (student == null)
                {
                    student = new Student()
                    {
                        StudentID = txtMssv.Text,
                        FullName = txtHoten.Text,
                        FacultyID = int.Parse(cbKhoa.SelectedValue.ToString()),
                        AverageScore = (decimal)float.Parse(txtDiem.Text)
                    };
                }
                else
                {
                    student.StudentID = txtMssv.Text;
                    student.FullName = txtHoten.Text;
                    student.FacultyID = int.Parse(cbKhoa.SelectedValue.ToString());
                    student.AverageScore = (decimal)float.Parse(txtDiem.Text);
                }
                dbContext.Students.AddOrUpdate(student);
                dbContext.SaveChanges();

            }

        }
        private void bindGridView(List<Student> students)
        {
            dgvDanhSanh.Rows.Clear();
            foreach (Student student in students)
            {
                int index = dgvDanhSanh.Rows.Add();
                dgvDanhSanh.Rows[index].Cells[0].Value = student.StudentID;
                dgvDanhSanh.Rows[index].Cells[1].Value = student.FullName;
                dgvDanhSanh.Rows[index].Cells[2].Value = student.Faculty.FacultyName;
                dgvDanhSanh.Rows[index].Cells[3].Value = student.AverageScore.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkInfoInput())
            {
                Button button = (Button)sender;
                switch (button.Text)
                {
                    case "Thêm":
                        {
                            if (checkExistId(txtMssv.Text) == false)
                            {
                                addorUpdateStudent();
                                using (var dbContext = new StudentDBContext())
                                {
                                    students = dbContext.Students.ToList();
                                    faculties = dbContext.Faculties.ToList();
                                }
                                bindGridView(students);
                            }
                            else
                            {
                                MessageBox.Show("Student Id have already existed !!");
                            }

                            break;
                        }
                    case "Sửa":
                        {
                            addorUpdateStudent();
                            using (var dbContext = new StudentDBContext())
                            {
                                students = dbContext.Students.ToList();
                                faculties = dbContext.Faculties.ToList();
                            }
                            bindGridView(students);
                            btnThem.Text = "Them";
                            txtMssv.Enabled = true;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                setDefault();

            }
        }
        private void setDefault()
        {
            txtMssv.Text = string.Empty;
            txtHoten.Text = string.Empty;
            txtDiem.Text = string.Empty;

            cbKhoa.SelectedIndex = -1;
        }

        private bool checkInfoInput()
        {
            errCanhBao.Clear();
            long mssv;
            if (long.TryParse(txtMssv.Text, out mssv) == false || string.IsNullOrEmpty(txtMssv.Text))
            {
                errCanhBao.SetError(txtMssv, "*");
                return false;
            }
            if (txtMssv.Text.Length != 10)
            {
                errCanhBao.SetError(txtMssv, "*");
                MessageBox.Show("Hãy nhập đủ 10 kí tự !!");
                return false;
            }
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                errCanhBao.SetError(txtHoten, "*");
                return false;
            }
            float diem;
            if (float.TryParse(txtDiem.Text, out diem) == false || string.IsNullOrEmpty(txtDiem.Text)
                || diem < 0 || diem > 10)
            {
                errCanhBao.SetError(txtDiem, "*");
                return false;
            }
            if (cbKhoa.SelectedIndex == -1)
            {
                errCanhBao.SetError(cbKhoa, "*");
                return false;
            }
            return true;
        }

        private void dgvDanhSanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;
                txtMssv.Text = dgvDanhSanh.Rows[index].Cells[0].Value.ToString();
                txtHoten.Text = dgvDanhSanh.Rows[index].Cells[1].Value.ToString();
                cbKhoa.Text = dgvDanhSanh.Rows[index].Cells[2].Value.ToString();
                txtDiem.Text = dgvDanhSanh.Rows[index].Cells[3].Value.ToString();

                btnThem.Text = "Sửa";
                btnXoa.Enabled = true;
                txtMssv.Enabled = false;
            }
        }

        public bool checkExistId(string id)
        {
            if (dgvDanhSanh.Rows.Count > 0)
            {
                using (var dbContext = new StudentDBContext())
                {
                    if (dbContext.Students.FirstOrDefault(x => x.StudentID == id) != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (var dbContext = new StudentDBContext())
            {


                Student removeStudent = (dbContext.Students.FirstOrDefault(r => r.StudentID == txtMssv.Text));
                if (removeStudent != null)
                {
                    dbContext.Students.Remove(removeStudent);
                    dbContext.SaveChanges();
                }
                students = dbContext.Students.ToList();
                faculties = dbContext.Faculties.ToList();
            }
            bindGridView(students);
            setDefault();
            txtMssv.Enabled = true;
        }

        private void toolStripBtn_Quanlykhoa_Click(object sender, EventArgs e)
        {
            Frm_QuanLyKhoa frm_QuanLyKhoa = new Frm_QuanLyKhoa(this);
            frm_QuanLyKhoa.Show();
        }

        private void toolStripBtn_TimKiem_Click(object sender, EventArgs e)
        {
            Frm_TimKiem frm_TimKiem = new Frm_TimKiem(this);
            frm_TimKiem.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMssv.Enabled = true;
            btnThem.Text = "Thêm";
            setDefault();
        }

        private void menuItem_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}