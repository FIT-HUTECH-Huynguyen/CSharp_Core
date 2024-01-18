using Lab05.BUS;
using Lab05.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05.GUI
{
    public partial class Frm_QuanLySinhVien : Form
    {
        private readonly FacultyServices facultyServices = new FacultyServices();
        private readonly StudentServices StudentServices = new StudentServices();
        private string filePath = string.Empty;
        public Frm_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInfoInput())
            {
                Button button = (Button)sender;
                switch (button.Text)
                {
                    case "Thêm":
                        {
                            if (checkExistId(txtMSSV.Text) == false)
                            {
                                string studentID = txtMSSV.Text;
                                string StudentName = txtName.Text;
                                int facultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                                decimal averageScore = decimal.Parse(txtAVG.Text);
                                int? majorID = null;
                                string avatar = filePath;

                                Student student = new Student
                                {
                                    StudentID = studentID,
                                    FullName = StudentName,
                                    AverageScore = averageScore,
                                    FacultyID = facultyID,
                                    MajorID = majorID,
                                    Avatar = avatar
                                };

                                StudentServices.insertUpdate(student); ;
                            }
                            else
                            {
                                MessageBox.Show("Student Id have already existed !!");
                            }

                            break;
                        }
                    case "Sửa":
                        {
                            string studentID = txtMSSV.Text;
                            string StudentName = txtName.Text;
                            int facultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                            decimal averageScore = decimal.Parse(txtAVG.Text);
                            int? majorID = null;
                            string avatar = filePath;


                            Student student = new Student
                            {
                                StudentID = studentID,
                                FullName = StudentName,
                                AverageScore = averageScore,
                                FacultyID = facultyID,
                                MajorID = majorID,
                                Avatar = avatar
                            };

                            StudentServices.insertUpdate(student);
                            btnDelete.Enabled = false;
                            btnAdd.Text = "Thêm";
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                setDefault();
                bindGrid(StudentServices.getAll());

            }

        }

        private void setDefault()
        {
            txtMSSV.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAVG.Text = string.Empty;

            cmbFaculty.SelectedIndex = -1;
            pictureBox.Image = null;
        }

        private bool checkInfoInput()
        {
            errCanhBao.Clear();
            long mssv;
            if (long.TryParse(txtMSSV.Text, out mssv) == false || string.IsNullOrEmpty(txtMSSV.Text))
            {
                errCanhBao.SetError(txtMSSV, "*");
                return false;
            }
            if (txtMSSV.Text.Length != 10)
            {
                errCanhBao.SetError(txtMSSV, "*");
                MessageBox.Show("Hãy nhập đủ 10 kí tự !!");
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errCanhBao.SetError(txtName, "*");
                return false;
            }
            float diem;
            if (float.TryParse(txtAVG.Text, out diem) == false || string.IsNullOrEmpty(txtAVG.Text)
                || diem < 0 || diem > 10)
            {
                errCanhBao.SetError(txtAVG, "*");
                return false;
            }
            if (cmbFaculty.SelectedIndex == -1)
            {
                errCanhBao.SetError(cmbFaculty, "*");
                return false;
            }
            return true;
        }

        private bool checkExistId(string text)
        {
            if (dgvDanhSach.Rows.Count > 0)
            {
                StudentServices.findById(text.ToString());
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var dbContext = new StudentModel())
            {
                if (dbContext.Students.FirstOrDefault(s => s.StudentID == txtMSSV.Text) != null)
                {
                    dbContext.Students.Remove(dbContext.Students.FirstOrDefault(s => s.StudentID == txtMSSV.Text));
                    dbContext.SaveChanges();
                    bindGrid(StudentServices.getAll());
                }
                else
                {
                    MessageBox.Show("Student Id is not existed !!");
                }
            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFile.FileName);
                filePath = openFile.FileName;

            }
        }

        private void fillFacultyComboBox(List<Faculty> faculty)
        {
            cmbFaculty.DataSource = faculty;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";
        }

        public void Frm_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                var faculties = facultyServices.getAll();
                var students = StudentServices.getAll();
                fillFacultyComboBox(faculties);
                bindGrid(students);
                pictureBox.Image = null;


                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void bindGrid(List<Student> students)
        {
            dgvDanhSach.Rows.Clear();
            foreach (var item in students)
            {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[0].Value = item.StudentID;
                dgvDanhSach.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvDanhSach.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvDanhSach.Rows[index].Cells[3].Value = item.AverageScore;
                if (item.MajorID != null)
                    dgvDanhSach.Rows[index].Cells[4].Value = item.Major.Name.ToString();
                showAvatar(item.Avatar);
            }
        }

        private void showAvatar(string avatar)
        {
            if (string.IsNullOrEmpty(avatar))
            {
                pictureBox.Image = null;
            }
            else
            {
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string path = Path.Combine(parentDirectory, "Images", avatar);
                pictureBox.Image = Image.FromFile(path);
                pictureBox.Refresh();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[index];
                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAVG.Text = row.Cells[3].Value.ToString();
                cmbFaculty.Text = row.Cells[2].Value.ToString();
                using (var dbContext = new StudentModel())
                {
                    showAvatar(dbContext.Students.FirstOrDefault(s => s.StudentID == txtMSSV.Text).Avatar);
                }
                btnAdd.Text = "Sửa";
                btnDelete.Enabled = true;
            }
        }

        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.chkUnregisterMajor.Checked)
            {
                listStudents = StudentServices.getAllHasNoMajor();
            }
            else
            {
                listStudents = StudentServices.getAll();
            }
            bindGrid(listStudents);
        }

        private void đăngKýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Register frm_Register = new Frm_Register(this);
            frm_Register.ShowDialog();
        }
    }
}
