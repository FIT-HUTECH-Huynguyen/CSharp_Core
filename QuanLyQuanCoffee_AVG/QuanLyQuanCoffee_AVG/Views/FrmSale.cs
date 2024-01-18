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
    public partial class FrmSale : Form
    {
        private List<Table> tables;
        private List<Categories> categories;
        private List<Product> products;
        Button btnTableChoosing;



        public FrmSale()
        {
            InitializeComponent();
            setControl();
            tables = new List<Table>();

            for (int i = 1; i <= 25; i++)
            {
                tables.Add(new Table()
                {
                    Id = i,
                    Name = "Bàn " + i,
                    Status = false,
                    LinkImage = ""
                });
            }

            categories = new List<Categories>()
            {
                new Categories()
                {
                    Id = 1, Name = "Coffee"
                },
                new Categories()
                {
                    Id = 2, Name = " Nước ép"
                }

            };

            products = new List<Product>()
            {
                new Product() { Id = 1 , Name = "Coffee Sữa", IdCategory = 1 , Price = 25000},
                new Product() { Id = 2 , Name = "Coffee Đen", IdCategory = 1 , Price = 25000},
                new Product() { Id = 3 , Name = "Nước Ép Cam", IdCategory = 2 , Price = 25000},
                new Product() { Id = 4 , Name = "Nước Ép Thơm", IdCategory = 2 , Price = 25000},

            };
            btnTableChoosing = null;
        }

        private void setControl()
        {
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "ID";
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "ID";
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbChangeTable.DisplayMember = "Name";
            cmbChangeTable.ValueMember = "ID";
            cmbChangeTable.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void initListTable()
        {
            int x = 15, y = 12, i = 1;
            foreach (Table table in tables)
            {
                drawTable(x, y, table);
                if (i++ % 5 == 0)
                {
                    y += 130;
                    x = 15;
                    continue;
                }
                x += 140;
            }
        }

        private void drawTable(int x, int y, Table table)
        {

            Button button = new Button();
            button.Text = table.Name;
            button.Tag = table.Id;
            button.Size = new Size(120, 100);
            button.BackColor = Color.White;
            button.TextAlign = ContentAlignment.BottomCenter;
            button.Location = new Point(x, y);
            button.Click += Button_Click;
            pnlListTable.Controls.Add(button);
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (btnTableChoosing == null)
            {
                btnTableChoosing = button;
                btnTableChoosing.Image = Image.FromFile("P:\\Dev\\Source\\C#\\Exercise\\OnClass\\Quan_Ly_Quan_Coffee\\Quan_Ly_Quan_Coffee\\Images\\armchair.png");
                btnTableChoosing.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else if (btnTableChoosing != button)
            {
                btnTableChoosing.Image = null;
                btnTableChoosing = button;
                btnTableChoosing.Image = Image.FromFile("P:\\Dev\\Source\\C#\\Exercise\\OnClass\\Quan_Ly_Quan_Coffee\\Quan_Ly_Quan_Coffee\\Images\\armchair.png");
                btnTableChoosing.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                btnTableChoosing.Image = null;
                btnTableChoosing = null;
            }

        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            initListTable();

            cmbCategories.DataSource = categories;


        }



        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategory = int.Parse(cmbCategories.SelectedValue.ToString());

            cmbProducts.DataSource = products.Where(x => x.IdCategory == idCategory).ToList();
        }

        private void cmbChangeTable_DropDown(object sender, EventArgs e)
        {
            bool currentStatus;
            /*cmbProducts.DataSource = tables.Where(x => x.Status == status).toList();*/
        }
    }
}
