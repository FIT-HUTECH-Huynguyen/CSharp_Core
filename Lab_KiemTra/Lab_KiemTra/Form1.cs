using Lab_KiemTra.Models;
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

namespace Lab_KiemTra
{
    public partial class Form1 : Form
    {
        private List<NHANVIEN> NHANVIENs = new List<NHANVIEN>();
        private List<CONGTY> CONGTYS = new List<CONGTY>();
        public Form1()
        {
            InitializeComponent();

            txtAmount.Text = "1";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkInputCCCD())
            {
                if (checkExistCCCD())
                {
                    MessageBox.Show("Tìm thấy nhân viên!", "Thông báo");
                    btnUpdate.Text = "Cập nhật";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo");
                    gbxXetNghiem.Enabled = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ManageModel())
            {
                NHANVIEN nhanvien = new NHANVIEN
                {
                    ID = txtCCCD.Text,
                    HoTen = txtName.Text,
                    SoLanXN = int.Parse(txtAmount.Text),
                    AmTinh = rdbAmTinh.Checked ? true : false,
                    MaCty = cmbCty.SelectedValue.ToString()
                };
                dbContext.NHANVIENs.AddOrUpdate(nhanvien);
                if (btnUpdate.Text.Equals("Thêm mới"))
                    MessageBox.Show("Thêm mới thành công!", "Thông báo");
                else
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                dbContext.SaveChanges();
            }
            clearForm();
            bindGrid();
            gbxXetNghiem.Enabled = false;

        }

        private void clearForm()
        {
            txtCCCD.Text = txtName.Text = string.Empty;
            txtAmount.Text = "1";
            rdbAmTinh.Checked = true;
            cmbCty.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var dbContext = new ManageModel())
            {
                NHANVIENs = dbContext.NHANVIENs.ToList();
                CONGTYS = dbContext.CONGTies.ToList();
            }
            gbxXetNghiem.Enabled = false;
            rdbAmTinh.Checked = true;
            btnUpdate.Text = "Thêm mới";
            configControl(CONGTYS);
            bindGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCCCD.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
        }

        private void configControl(List<CONGTY> CONGTYS)
        {
            cmbCty.DataSource = CONGTYS;
            cmbCty.DisplayMember = "TenCty";
            cmbCty.ValueMember = "MaCty";

        }

        private void bindGrid()
        {
            dgvDanhSach.Rows.Clear();
            using (var db = new ManageModel())
            {
                var list = db.NHANVIENs.ToList();
                foreach (var item in list)
                {
                    int index = dgvDanhSach.Rows.Add();
                    dgvDanhSach.Rows[index].Cells[0].Value = item.ID;
                    dgvDanhSach.Rows[index].Cells[1].Value = item.HoTen;
                    dgvDanhSach.Rows[index].Cells[2].Value = item.SoLanXN;
                    if (item.AmTinh == true)
                    {
                        dgvDanhSach.Rows[index].Cells[3].Value = "Âm tính";
                    }
                    else
                    {
                        dgvDanhSach.Rows[index].Cells[3].Value = "Dương tính";
                    }
                }
            }
        }

        private void bindGrid(List<NHANVIEN> nhanvien)
        {
            dgvDanhSach.Rows.Clear();

            foreach (var item in nhanvien)
            {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[0].Value = item.ID;
                dgvDanhSach.Rows[index].Cells[1].Value = item.HoTen;
                dgvDanhSach.Rows[index].Cells[2].Value = item.SoLanXN;
                if (item.AmTinh == true)
                {
                    dgvDanhSach.Rows[index].Cells[3].Value = "Âm tính";
                }
                else
                {
                    dgvDanhSach.Rows[index].Cells[3].Value = "Dương tính";
                }
            }

        }

        private bool checkInputCCCD()
        {
            long cccd;
            if (long.TryParse(txtCCCD.Text, out cccd) == false)
            {
                MessageBox.Show("CCCD/CMND không được để trống và phải là số!", "Thông báo");
                return false;
            }

            if (txtCCCD.Text.Length != 12 && txtCCCD.Text.Length != 9)
            {
                MessageBox.Show("Vui lòng nhập CCCD hoặc CMND!", "Thông báo");
                return false;
            }


            return true;
        }

        private bool checkExistCCCD()
        {
            using (var dbContext = new ManageModel())
            {
                var list = dbContext.NHANVIENs.ToList();
                foreach (var item in list)
                {
                    if (item.ID == txtCCCD.Text)
                    {
                        txtCCCD.Text = item.ID;
                        txtName.Text = item.HoTen;
                        int amount = item.SoLanXN + 1;
                        txtAmount.Text = amount.ToString();
                        if (item.AmTinh == true)
                        {
                            rdbAmTinh.Checked = true;
                        }
                        else
                        {
                            rdbDuongTinh.Checked = true;
                        }
                        cmbCty.Text = item.CONGTY.TenCty;
                        gbxXetNghiem.Enabled = true;
                        return true;

                    }
                }
            }
            return false;
        }

        private void danhSáchNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ManageModel())
            {
                List<NHANVIEN> list = dbContext.NHANVIENs.Where(x => x.AmTinh == false).ToList();
                bindGrid(list);

            }
        }

        private void danhSáchCtyĐãTestTheoYCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ManageModel())
            {
                var list = from nhanvien in NHANVIENs
                           join congty in CONGTYS on nhanvien.MaCty equals congty.MaCty
                           group nhanvien by nhanvien.MaCty into g
                           let countNhanvien = g.Count()
                           where countNhanvien >= g.First().CONGTY.SLNV
                           select new
                           {
                               MaCty = g.Key,
                               countNhanvien = countNhanvien
                           };
                string result = "";
                foreach (var item in list)
                {
                    int i = 1;
                    CONGTY cty = dbContext.CONGTies.FirstOrDefault(x => x.MaCty == item.MaCty);
                    result += cty.TenCty.ToString() + "\n";
                }
                MessageBox.Show("Danh Sach Cong Ty Da TEST Theo Y/C \n " + result, "Thông báo");

            }
        }


    }
}
