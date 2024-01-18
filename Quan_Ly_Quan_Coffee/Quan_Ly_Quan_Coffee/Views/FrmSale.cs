using Quan_Ly_Quan_Coffee.Models;
using Quan_Ly_Quan_Coffee.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Quan_Coffee.Views
{
    public partial class FrmSale : Form
    {
        List<ReserverTicket> reserverTickets = new List<ReserverTicket>();
        List<Table> tables = new List<Table>();
        Button btnTableChoosing = null;



        public FrmSale()
        {
            InitializeComponent();
            setControl();
            btnTableChoosing = null;

            numDiscount.TextChanged += NumDiscount_TextChanged;
        }

        private void NumDiscount_TextChanged(object sender, EventArgs e)
        {
            ReserverTicket reserverTicket = reserverTickets.FirstOrDefault(x => x.idTable == int.Parse(btnTableChoosing.Tag.ToString()));
            if (numDiscount.Text == string.Empty)
            {
                txtAmount.Text = reserverTicket.total.ToString();
            }
            if (reserverTicket != null)
            {
                reserverTicket.discount = (float)numDiscount.Value;
                txtAmount.Text = (reserverTicket.total - reserverTicket.getdiscount()).ToString();

            }

        }

        private void setControl()
        {
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "Id";
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbChangeTable.DisplayMember = "Name";
            cmbChangeTable.ValueMember = "Id";
            cmbChangeTable.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void initListTable()
        {
            int x = 15, y = 12, i = 1;
            using (var dbConext = new Model1())
            {
                foreach (var table in dbConext.Tables.Select(c => new { c.Name, c.Id }).ToList())
                {
                    drawTable(x, y, table.Name, table.Id);
                    if (i++ % 5 == 0)
                    {
                        y += 90;
                        x = 15;
                        continue;
                    }
                    x += 100;
                }
            }

        }

        private void drawTable(int x, int y, string name, int id)
        {

            Button button = new Button();
            button.Text = name;
            button.Tag = id;
            button.Size = new Size(90, 70);
            button.BackColor = Color.White;
            button.TextAlign = ContentAlignment.BottomCenter;
            button.Location = new Point(x, y);
            button.Click += Button_Click;
            pnlListTable.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (btnTableChoosing == null)
            {
                btnTableChoosing = button;
                btnTableChoosing.BackColor = Color.Yellow;


            }
            else if (btnTableChoosing != button)
            {
                btnTableChoosing.BackColor = Color.White;
                btnTableChoosing = button;
                btnTableChoosing.BackColor = Color.Yellow;


            }
            else
            {
                btnTableChoosing.BackColor = Color.White;
                btnTableChoosing = null;

            }
            if (btnTableChoosing != null)
            {
                loadTicket(button);
                numDiscount.Refresh();
            }


        }

        private void loadTicket(Button button)
        {
            int idTableOrder = int.Parse(button.Tag.ToString());
            ReserverTicket ticket = reserverTickets.FirstOrDefault(x => x.idTable == idTableOrder);
            if (ticket != null)
            {
                loadInformationOrder(ticket.productOrders);
                txtAmount.Text = (ticket.total - ticket.getdiscount()).ToString();
            }
            else
            {
                dgvInvoiceDetail.Rows.Clear();
                txtAmount.Text = string.Empty;
            }

        }
        private void FrmSale_Load(object sender, EventArgs e)
        {
            initListTable();
            using (var dbContext = new Model1())
            {
                cmbCategories.DataSource = dbContext.Categories.Select(c => new { c.Name, c.Id }).ToList();
                cmbChangeTable.DataSource = dbContext.Tables.Select(c => new { c.Name, c.Id }).ToList();

            }
        }



        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategory = int.Parse(cmbCategories.SelectedValue.ToString());

            using (var dbContext = new Model1())
            {
                cmbProducts.DataSource = dbContext.Products.Where(x => x.IdCategory == idCategory).ToList();
            }

        }
        private void btnAddPro_Click(object sender, EventArgs e)
        {
            if (btnTableChoosing == null)
            {
                MessageBox.Show("Vui long chon ban!");
                return;
            }
            if (numCount.Value == 0)
            {
                MessageBox.Show("Vui long nhap so luong!");
                return;
            }
            int idTableOrder = int.Parse(btnTableChoosing.Tag.ToString());
            ReserverTicket ticket = reserverTickets.FirstOrDefault(x => x.idTable == idTableOrder);
            if (ticket == null)
            {
                ticket = new ReserverTicket();
                ticket.idTable = idTableOrder;
                reserverTickets.Add(ticket);

                btnTableChoosing.Image = Image.FromFile("P:\\Dev\\Source\\C#\\Exercise\\OnClass\\Quan_Ly_Quan_Coffee\\Quan_Ly_Quan_Coffee\\Images\\armchair.png");
                btnTableChoosing.ImageAlign = ContentAlignment.MiddleCenter;
            }
            Product product = cmbProducts.SelectedItem as Product;
            ProductOrder productOrder = new ProductOrder()
            {
                idProduct = product.Id,
                product = product.Name,
                nameProduct = product.Name,
                price = decimal.Parse(product.Price.ToString()),
                quantity = int.Parse(numCount.Value.ToString()),

            };
            ticket.order(productOrder);
            loadInformationOrder(ticket.productOrders);
            txtAmount.Text = (ticket.total - ticket.getdiscount()).ToString();
        }

        private void loadInformationOrder(List<ProductOrder> productOrders)
        {
            dgvInvoiceDetail.Rows.Clear();
            foreach (var item in productOrders)
            {
                int index = dgvInvoiceDetail.Rows.Add();
                dgvInvoiceDetail.Rows[index].Cells[0].Value = item.nameProduct;
                dgvInvoiceDetail.Rows[index].Cells[1].Value = item.quantity;
                dgvInvoiceDetail.Rows[index].Cells[2].Value = item.price;
                dgvInvoiceDetail.Rows[index].Cells[3].Value = item.total;
                dgvInvoiceDetail.Rows[index].Cells[4].Value = item.idProduct;
            }
        }

        private void mónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageProduct frmManageProduct = new FrmManageProduct();
            frmManageProduct.ShowDialog();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageCategory frmManageCategory = new FrmManageCategory();
            frmManageCategory.ShowDialog();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            ReserverTicket ticket = reserverTickets.FirstOrDefault(x => x.idTable == int.Parse(btnTableChoosing.Tag.ToString()));
            DateTime date = DateTime.Now;
            using (var dbContext = new Model1())
            {
                if (ticket != null)
                {
                    DialogResult result = MessageBox.Show("Xac nhan thanh toan ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Invoice invoice = new Invoice()
                        {
                            IdTable = ticket.idTable,
                            IdStaff = "11",
                            BookingDate = date,
                            Amount = (decimal)ticket.total,
                        };
                        dbContext.Invoices.Add(invoice);

                        foreach (ProductOrder productOrder in ticket.productOrders)
                        {
                            InvoiceDetail invoiceDetail = new InvoiceDetail()
                            {
                                IdInvoice = invoice.Id,
                                IdProduct = productOrder.idProduct,
                                Count = productOrder.quantity,
                                Price = productOrder.price,

                            };
                            dbContext.InvoiceDetails.Add(invoiceDetail);
                        }
                        dbContext.SaveChanges();
                        buttonPay.Enabled = false;
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ReserverTicket ticket = reserverTickets.FirstOrDefault(x => x.idTable == int.Parse(btnTableChoosing.Tag.ToString()));

            Button newButton = new Button();

            int id = int.Parse(cmbChangeTable.SelectedValue.ToString());

            Button button = pnlListTable.Controls.OfType<Button>().FirstOrDefault(x => x.Tag.ToString() == id.ToString());

            button.Image = Image.FromFile("P:\\Dev\\Source\\C#\\Exercise\\OnClass\\Quan_Ly_Quan_Coffee\\Quan_Ly_Quan_Coffee\\Images\\armchair.png");
            button.ImageAlign = ContentAlignment.MiddleCenter;
            btnTableChoosing.Image = null;
            btnTableChoosing.BackColor = Color.White;
            button.BackColor = Color.Yellow;
            ReserverTicket newTicket = reserverTickets.FirstOrDefault(x => x.idTable == int.Parse(button.Tag.ToString()));

            if (dgvInvoiceDetail.Rows.Count == 0)
            {
                MessageBox.Show("Ban chua dat mon!");
            }
            else
            {
                if (newTicket == null)
                {
                    newTicket = new ReserverTicket();
                    newTicket.idTable = int.Parse(button.Tag.ToString());
                    reserverTickets.Add(newTicket);
                    foreach (var item in ticket.productOrders)
                    {
                        newTicket.order(item);
                    }
                }
                else
                {
                    newTicket.idTable = int.Parse(button.Tag.ToString());
                    foreach (var item in ticket.productOrders)
                    {
                        newTicket.order(item);
                    }
                    newTicket.total += ticket.total;
                }
            }
            loadInformationOrder(newTicket.productOrders);
            reserverTickets.Remove(ticket);
            numDiscount.Value = (decimal)newTicket.discount;
            txtAmount.Text = (newTicket.total - newTicket.getdiscount()).ToString();


        }

        private void dgvInvoiceDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xoá món này ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int index = e.RowIndex;
                if (index != -1)
                {
                    int id = int.Parse(dgvInvoiceDetail.Rows[index].Cells[4].Value.ToString());
                    ReserverTicket ticket = reserverTickets.FirstOrDefault(x => x.idTable == int.Parse(btnTableChoosing.Tag.ToString()));
                    ProductOrder product = ticket.productOrders.FirstOrDefault(x => x.idProduct == id);
                    ticket.remove(product);
                    loadInformationOrder(ticket.productOrders);

                    if (ticket.productOrders.Count == 0)
                    {
                        btnTableChoosing.Image = null;
                        btnTableChoosing.BackColor = Color.White;
                        reserverTickets.Remove(ticket);
                        txtAmount.Text = string.Empty;
                        numDiscount.Value = 0;
                    }
                    else
                    {
                        txtAmount.Text = (ticket.total - ticket.getdiscount()).ToString();
                    }
                }



            }
        }
    }
}
