using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_04
{
    public class Customer
    {
        private string accountNumber;
        private string customerName;
        private string customerAddress;
        private long accountBalance;

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
        public long AccountBalance { get => accountBalance; set => accountBalance = value; }

        public Customer(string accountNumber, string customerName, string customerAddress, long accountBalance)
        {
            this.AccountNumber = accountNumber;
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.AccountBalance = accountBalance;
        }

        public Customer()
        {
            this.AccountNumber = "";
            this.CustomerName = "";
            this.CustomerAddress = "";
            this.AccountBalance = 0;
        }


    }
}
