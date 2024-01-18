namespace Quan_Ly_Quan_Coffee.ViewModels
{
    public class ProductOrder
    {
        public int idProduct { get; set; }
        public String product { get; set; }
        public string nameProduct { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal total { get { return quantity * price; } }

        public string nameCategory { get; set; }
    }
}