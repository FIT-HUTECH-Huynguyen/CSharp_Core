using Management_Student_AVG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Management_Student_AVG.Views
{
    public partial class Frm_QuanLyKhoa : Form
    {
        private Frm_QuanLySinhVien Frm_QuanLySinhVien;
        private List<Faculty> faculties;
        public Frm_QuanLyKhoa(Frm_QuanLySinhVien frm_QuanLySinhVien)
        {
            InitializeComponent();
            Frm_QuanLySinhVien = frm_QuanLySinhVien;
        }

        private void Frm_QuanLyKhoa_Load(object sender, EventArgs e)
        {
            using (var dbContext = new StudentDBContext())
            {
                faculties = dbContext.Faculties.ToList();
                int maxId = dbContext.Faculties.Max(x => x.FacultyID) + 1;
                txtMaKhoa.Text = maxId.ToString();
            }
            bindGridView(faculties);
            btnXoa.Enabled = false;
        }

        private void bindGridView(List<Faculty> faculties)
        {
            dgvDanhSachKhoa.Rows.Clear();
            foreach (Faculty faculty in faculties)
            {
                int index = dgvDanhSachKhoa.Rows.Add();
                dgvDanhSachKhoa.Rows[index].Cells[0].Value = faculty.FacultyID;
                dgvDanhSachKhoa.Rows[index].Cells[1].Value = faculty.FacultyName;
                dgvDanhSachKhoa.Rows[index].Cells[2].Value = faculty.TotalProfessor;

            }
        }

        private void addorUpdateFaculty()
        {
            using (var dbContext = new StudentDBContext())
            {
                int makhoa = int.Parse(txtMaKhoa.Text);
                Faculty faculty = dbContext.Faculties.FirstOrDefault(x => x.FacultyID == makhoa);
                if (faculty == null)
                {
                    if (string.IsNullOrEmpty(txtTongGS.Text))
                    {
                        int? nullableValue = null;
                        faculty = new Faculty()
                        {
                            FacultyID = int.Parse(txtMaKhoa.Text),
                            FacultyName = txtTenKhoa.Text,
                            TotalProfessor = nullableValue
                        };
                    }
                    else
                    {
                        faculty = new Faculty()
                        {
                            FacultyID = int.Parse(txtMaKhoa.Text),
                            FacultyName = txtTenKhoa.Text,
                            TotalProfessor = int.Parse(txtTongGS.Text)
                        };
                    }
                }
                else
                {
                    faculty.FacultyName = txtTenKhoa.Text;
                    faculty.TotalProfessor = int.Parse(txtTongGS.Text);
                }
                dbContext.Faculties.AddOrUpdate(faculty);
                dbContext.SaveChanges();
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
                            addorUpdateFaculty();
                            using (var dbContext = new StudentDBContext())
                            {
                                faculties = dbContext.Faculties.ToList();

                            }
                            bindGridView(faculties);

                            break;
                        }
                    case "Sửa":
                        {
                            addorUpdateFaculty();
                            using (var dbContext = new StudentDBContext())
                            {
                                faculties = dbContext.Faculties.ToList();
                            }
                            bindGridView(faculties);
                            btnThem.Text = "Thêm";
                            break;
                        }
                }
                setDefault();
            }
        }

        private bool checkInfoInput()
        {
            errCanhBao.Clear();
            if (string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                errCanhBao.SetError(txtTenKhoa, "*");
                return false;
            }
            int soluong;
            /*if (int.TryParse(txtTongGS.Text, out soluong) == false)
            {
                errCanhBao.SetError(txtTongGS, "*");
                return false;
            }*/
            return true;
        }

        private void setDefault()
        {
            using (var dbContext = new StudentDBContext())
            {
                int maxId = dbContext.Faculties.Max(x => x.FacultyID) + 1;
                txtMaKhoa.Text = maxId.ToString();
            }

            txtTenKhoa.Text = txtTongGS.Text = string.Empty;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Ban chắc chắn muốn đóng cửa sổ này ?", "Cảnh báo", messageBoxButtons);

            if (result == DialogResult.OK)
            {
                this.Close();
                Frm_QuanLySinhVien.Form1_Load(sender, e);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (var dbContext = new StudentDBContext())
            {
                int makhoa = int.Parse(txtMaKhoa.Text);
                Faculty faculty = dbContext.Faculties.FirstOrDefault(x => x.FacultyID == makhoa);
                if (faculty != null)
                {
                    if (faculty.Students.Count > 0)
                    {
                        MessageBox.Show("Không thể xóa khoa này vì có sinh viên thuộc khoa này");
                        return;
                    }
                    else
                    {
                        dbContext.Faculties.Remove(faculty);
                        dbContext.SaveChanges();
                    }

                }
                faculties = dbContext.Faculties.ToList();
            }
            bindGridView(faculties);
            setDefault();
            btnThem.Text = "Thêm";
            btnXoa.Enabled = false;
        }

        private void dgvDanhSachKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;
                txtMaKhoa.Text = dgvDanhSachKhoa.Rows[index].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgvDanhSachKhoa.Rows[index].Cells[1].Value.ToString();
                if (dgvDanhSachKhoa.Rows[index].Cells[2].Value != null)
                {
                    txtTongGS.Text = dgvDanhSachKhoa.Rows[index].Cells[2].Value.ToString();

                }
                else
                {
                    txtTongGS.Text = null;

                }

                btnThem.Text = "Sửa";
                btnXoa.Enabled = true;
            }
        }
    }
}
