using Quan_Ly_Quan_Coffee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Quan_Coffee.Views
{
    public partial class FrmManageCategory : Form
    {
        private int idCategorySelecting;
        public FrmManageCategory()
        {
            InitializeComponent();
        }

        private void FrmManageCategory_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            dgvCategories.Rows.Clear();
            using (var dbContext = new Model1())
            {
                foreach (Category category in dbContext.Categories)
                {
                    int index = dgvCategories.Rows.Add();
                    dgvCategories.Rows[index].Cells[0].Value = category.Id;
                    dgvCategories.Rows[index].Cells[1].Value = category.Name;
                    dgvCategories.Rows[index].Cells[2].Value = dbContext.Products.Count(c => c.IdCategory == category.Id);
                }
            }
        }

        private bool checkInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private bool checkExistCategory(string nameCategory)
        {
            using (var dbContext = new Model1())
            {
                return dbContext.Categories.Any(c => c.Name == nameCategory);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInput())
                {
                    if (checkExistCategory(txtName.Text))
                    {
                        MessageBox.Show("Danh mục đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    using (var dbContext = new Model1())
                    {
                        Category category = new Category()
                        {
                            Name = txtName.Text
                        };
                        dbContext.Categories.Add(category);
                        dbContext.SaveChanges();
                        MessageBox.Show("Thêm danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategory();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInput())
                {

                    using (var dbContext = new Model1())
                    {
                        Category category = dbContext.Categories.FirstOrDefault(c => c.Id == idCategorySelecting);
                        if(category != null)
                        {
                            category.Name = txtName.Text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != 1)
            {
                idCategorySelecting = int.Parse(dgvCategories.Rows[index].Cells[0].Value.ToString());
                txtName.Text = dgvCategories.Rows[index].Cells[1].Value.ToString();
            }

        }
    }
}
