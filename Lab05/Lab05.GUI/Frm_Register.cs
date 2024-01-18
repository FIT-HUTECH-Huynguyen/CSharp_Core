using Lab05.BUS;
using Lab05.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05.GUI
{
    public partial class Frm_Register : Form
    {
        private readonly FacultyServices facultyServices = new FacultyServices();
        private readonly StudentServices StudentServices = new StudentServices();
        private readonly MajorServices majorServices = new MajorServices();

        private Frm_QuanLySinhVien frm_QuanLySinhVien;
        public Frm_Register(Frm_QuanLySinhVien frm_QuanLySinhVien)
        {
            InitializeComponent();
            this.frm_QuanLySinhVien = frm_QuanLySinhVien;

        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            try
            {
                var listFaculties = facultyServices.getAll();
                fillFacutyComboBox(listFaculties);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void fillFacutyComboBox(List<Faculty> listFaculties)
        {
            this.cmbFaculty.DataSource = listFaculties;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = (Faculty)cmbFaculty.SelectedItem;
            if (selectedFaculty != null)
            {
                var listMajor = majorServices.getAllByFaculty(selectedFaculty.FacultyID);
                fillMajorComboBox(listMajor);
                var listStudent = StudentServices.getAllHasNoMajor(selectedFaculty.FacultyID);
                bindGrid(listStudent);
            }
        }

        private void bindGrid(List<Student> listStudent)
        {
            dgvDanhSach.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[1].Value = item.StudentID;
                dgvDanhSach.Rows[index].Cells[2].Value = item.FullName;
                if (item.FacultyID != null)
                {
                    dgvDanhSach.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
                }
                dgvDanhSach.Rows[index].Cells[4].Value = item.AverageScore;
                if (item.MajorID != null)
                {
                    dgvDanhSach.Rows[index].Cells[5].Value = item.Major.Name;
                }
            }
        }

        private void fillMajorComboBox(List<Major> listMajor)
        {
            this.cmbMajor.DataSource = listMajor;
            this.cmbMajor.DisplayMember = "Name";
            this.cmbMajor.ValueMember = "MajorID";
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDanhSach.Rows[e.RowIndex].Cells[0].Value = !Convert.ToBoolean(dgvDanhSach.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvDanhSach.Rows)
            {

                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng ký chuyên ngành cho sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        StudentServices studentServices = new StudentServices();
                        Student student = studentServices.findById(row.Cells[1].Value.ToString());
                        student.MajorID = Convert.ToInt32(cmbMajor.SelectedValue);
                        studentServices.insertUpdate(student);
                        this.Close();
                        frm_QuanLySinhVien.Frm_QuanLySinhVien_Load(sender, e);

                    }

                }
            }

        }


    }
}
