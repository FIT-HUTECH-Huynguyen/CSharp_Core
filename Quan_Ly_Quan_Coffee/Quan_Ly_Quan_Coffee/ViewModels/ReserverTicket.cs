using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Quan_Coffee.ViewModels
{
    public class ReserverTicket
    {
        public int idTable { get; set; }
        public List<ProductOrder> productOrders { get; set; }
        public float total { get; set; }
        public float discount { get; set; }

        public ReserverTicket()
        {
            this.productOrders = new List<ProductOrder>();
        }

        public void order(ProductOrder productOrder)
        {
            ProductOrder proOrder = this.productOrders.Find(p => p.idProduct == productOrder.idProduct);
            if (proOrder != null)
            {
                proOrder.quantity += productOrder.quantity;
            }
            else
            {
                productOrders.Add(productOrder);
                total += (float)productOrder.total;
            }
        }

        public float getdiscount()
        {
            return (total * discount) / 100;
        }

        public void remove(ProductOrder productOrder)
        {
            ProductOrder proOrder = this.productOrders.Find(p => p.idProduct == productOrder.idProduct);
            if (proOrder != null)
            {
                this.productOrders.Remove(proOrder);
                total -= (float)proOrder.total;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm này trong hóa đơn");
            }
        }


    }
}
