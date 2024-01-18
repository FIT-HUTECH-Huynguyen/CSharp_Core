using Quan_Ly_Quan_Coffee.Models;
using Quan_Ly_Quan_Coffee.ViewModels;
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

namespace Quan_Ly_Quan_Coffee.Views
{
    public partial class FrmManageProduct : Form
    {

        private int idProdSelecting = -1;
        public FrmManageProduct()
        {
            InitializeComponent();
            configControl();

            updateControl();
        }

        private void configControl()
        {
            cmbNameCategory.DisplayMember = "Name";
            cmbNameCategory.ValueMember = "Id";
            cmbNameCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmManageProduct_Load(object sender, EventArgs e)
        {
            using (var dbContext = new Model1())
            {
                cmbNameCategory.DataSource = dbContext.Categories.Select(c => new { c.Name, c.Id }).ToList();
            }
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.Rows.Clear();
            using (var dbContext = new Model1())
            {
                var products = dbContext.Products.Select(c => new ProductOrder { idProduct = c.Id, nameProduct = c.Name, price = (decimal)c.Price, nameCategory = c.Category.Name }).ToList();
                foreach (var product in products)
                {
                    int index = dgvProducts.Rows.Add();
                    dgvProducts.Rows[index].Cells[0].Value = product.idProduct;
                    dgvProducts.Rows[index].Cells[1].Value = product.nameProduct;
                    dgvProducts.Rows[index].Cells[2].Value = product.price;
                    dgvProducts.Rows[index].Cells[3].Value = product.nameCategory;
                }
            }

        }

        private void update()
        {

            using (var dbContext = new Model1())
            {
                Product product = dbContext.Products.FirstOrDefault(c => c.Id == idProdSelecting);
                if (product == null)
                {
                    product = new Product()
                    {
                        Name = txtNamePro.Text,
                        Price = decimal.Parse(txtPricePro.Text),
                        IdCategory = int.Parse(cmbNameCategory.SelectedValue.ToString())
                    };
                }
                else
                {
                    product.Name = txtNamePro.Text;
                    product.Price = decimal.Parse(txtPricePro.Text);
                    product.IdCategory = int.Parse(cmbNameCategory.SelectedValue.ToString());
                }
                dbContext.Products.AddOrUpdate(product);
                dbContext.SaveChanges();
            }


        }

        private void remove()
        {
            using (var dbContext = new Model1())
            {
                Product product = dbContext.Products.FirstOrDefault(c => c.Id == idProdSelecting);
                if (product == null)
                {
                    MessageBox.Show("Khong tim thay san pham can xoa!");
                    return;
                }
                else
                {
                    dbContext.Products.Remove(product);
                    dbContext.SaveChanges();
                }
            }
        }

        private bool checkInput()
        {
            if (string.IsNullOrEmpty(txtNamePro.Text))
            {
                errNotify.SetError(txtNamePro, "*");
                return false;
            }
            int price;
            if (string.IsNullOrEmpty(txtPricePro.Text) && int.TryParse(txtPricePro.Text, out price))
            {
                errNotify.SetError(txtPricePro, "*");
                return false;
            }
            if (string.IsNullOrEmpty(cmbNameCategory.Text))
            {
                errNotify.SetError(cmbNameCategory, "*");
                return false;
            }
            return true;

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                idProdSelecting = int.Parse(dgvProducts.Rows[index].Cells[0].Value.ToString());
                txtNamePro.Text = dgvProducts.Rows[index].Cells[1].Value.ToString();
                txtPricePro.Text = dgvProducts.Rows[index].Cells[2].Value.ToString();
                cmbNameCategory.Text = dgvProducts.Rows[index].Cells[3].Value.ToString();
            }
            updateControl();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                try
                {
                    update();
                    LoadProducts();
                    setDefault();

                    updateControl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Thong tin khong hop le!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                try
                {
                    update();
                    idProdSelecting = -1;
                    LoadProducts();
                    setDefault();

                    updateControl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Thong tin khong hop le!");
            }
        }
        private void setDefault()
        {
            txtNamePro.Text = txtPricePro.Text = string.Empty;
            cmbNameCategory.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                remove();
                LoadProducts();
                setDefault();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateControl()
        {
            btnAdd.Enabled = (idProdSelecting == -1);
            btnDelete.Enabled = btnUpdate.Enabled = !btnAdd.Enabled;
        }
    }
}
