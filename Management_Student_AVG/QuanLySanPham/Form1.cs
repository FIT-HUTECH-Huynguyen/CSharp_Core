using QuanLySanPham.Models;
using QuanLySanPham.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        private List<Invoice> invoices;
        private List<Order> orders;
        private List<Product> products;
        private int _number = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkbox_All_CheckedChanged(object sender, EventArgs e)
        {
            using (var dbContext = new QuanLyDonHangDBContext())
            {
                invoices = dbContext.Invoices.ToList();
                orders = dbContext.Orders.ToList();
                products = dbContext.Products.ToList();
            }
            if (checkbox_All.Checked)
            {
                bindGridView(orders);
            }
            else
            {
                dgvDanhSach.Rows.Clear();
            }

        }

        private void bindGridView(List<Order> orders)
        {
            dgvDanhSach.Rows.Clear();

            var list = from order in orders
                       join invoice in invoices on order.InvoiceNo equals invoice.InvoiceNo
                       group new { order.InvoiceNo, invoice.OrderDate, invoice.DeliveryDate, order.Price, order.Quantity } by new { order.InvoiceNo, invoice.OrderDate, invoice.DeliveryDate } into grouped
                       select new DeliverySlip { InvoiceNo = grouped.Key.InvoiceNo, OrderDate = grouped.Key.OrderDate, DeliveryDate = grouped.Key.DeliveryDate, TotalPrice = grouped.Sum(p => (p.Price * p.Quantity)) };
            _number = 1;
            foreach (var item in list)
            {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[0].Value = _number++;
                dgvDanhSach.Rows[index].Cells[1].Value = item.InvoiceNo;
                dgvDanhSach.Rows[index].Cells[2].Value = item.OrderDate.ToString("dd/MM/yyyy");
                dgvDanhSach.Rows[index].Cells[3].Value = item.DeliveryDate.ToString("dd/MM/yyyy");
                dgvDanhSach.Rows[index].Cells[4].Value = item.TotalPrice;
            }
            txtTotal.Text = dgvDanhSach.Rows.Count.ToString();
        }

        private void bindGridView(string invoiceNo)
        {
            dgvDanhSach.Rows.Clear();

            var list = from order in orders
                       where order.InvoiceNo == invoiceNo
                       join invoice in invoices on order.InvoiceNo equals invoice.InvoiceNo
                       group new { order.InvoiceNo, invoice.OrderDate, invoice.DeliveryDate, order.Price, order.Quantity } by new { order.InvoiceNo, invoice.OrderDate, invoice.DeliveryDate } into grouped
                       select new DeliverySlip { InvoiceNo = grouped.Key.InvoiceNo, OrderDate = grouped.Key.OrderDate, DeliveryDate = grouped.Key.DeliveryDate, TotalPrice = grouped.Sum(p => (p.Price * p.Quantity)) };
            _number = 1;
            foreach (var item in list)
            {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[0].Value = _number++;
                dgvDanhSach.Rows[index].Cells[1].Value = item.InvoiceNo;
                dgvDanhSach.Rows[index].Cells[2].Value = item.OrderDate.ToString("dd/MM/yyyy");
                dgvDanhSach.Rows[index].Cells[3].Value = item.DeliveryDate.ToString("dd/MM/yyyy");
                dgvDanhSach.Rows[index].Cells[4].Value = item.TotalPrice;
            }
            txtTotal.Text = dgvDanhSach.Rows.Count.ToString();

        }

        private float getPrice(Order order)
        {
            float price = 0;
            using (var dbContext = new QuanLyDonHangDBContext())
            {
                price = (float)dbContext.Orders.Where(x => x.InvoiceNo == order.InvoiceNo).Sum(x => x.Price);
            }
            return price;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtp_OrderDate.Format = DateTimePickerFormat.Custom;
            dtp_OrderDate.CustomFormat = "dd/MM/yyyy";

            dtp_DeliveryDate.Format = DateTimePickerFormat.Custom;
            dtp_DeliveryDate.CustomFormat = "dd/MM/yyyy";

        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime orderDate = dtp_OrderDate.Value;

            string orderDateTxt = orderDate.ToString("dd/MM/yyyy");

            DateTime deliveryDate = dtp_DeliveryDate.Value;
            string deliveryDateTxt = deliveryDate.ToString("dd/MM/yyyy");

            if (orderDate > deliveryDate)
            {
                MessageBox.Show("Ngày giao hàng phải sau ngày đặt hàng \n " +
                    "Không hợp lệ !!");
            }

            using (var dbContext = new QuanLyDonHangDBContext())
            {
                invoices = dbContext.Invoices.ToList();
                orders = dbContext.Orders.ToList();
                products = dbContext.Products.ToList();

                foreach (Invoice invoice in invoices)
                {
                    if (orderDateTxt.Equals(invoice.OrderDate.ToString("dd/MM/yyyy")) && deliveryDateTxt.Equals(invoice.DeliveryDate.ToString("dd/MM/yyyy")))
                    {
                        string invoiceNo = invoice.InvoiceNo;
                        bindGridView(invoiceNo);
                    }
                }

            }

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string invoiceNo = dgvDanhSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            using (var dbContext = new QuanLyDonHangDBContext())
            {
                invoices = dbContext.Invoices.ToList();
                orders = dbContext.Orders.ToList();
                products = dbContext.Products.ToList();

                foreach (Invoice invoice in invoices)
                {
                    if (invoiceNo.Equals(invoice.InvoiceNo))
                    {
                        String Note = invoice.Note;
                        MessageBox.Show(Note, "Note");
                    }
                }

            }
        }
    }
}
