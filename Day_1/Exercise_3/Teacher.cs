using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Teacher : Person
    {
        private string address;

       

        public string Address { get => address; set => address = value; } 
        
        public Teacher(string id, string name, string address) : base(id, name)
        {
            this.address = address;
        }

        public Teacher()
        {
            this.address = "";
        }

        public void input()
        {
            base.input();
            Console.Write("Enter address : ");
            this.address = Console.ReadLine();
        }

        public void output()
        {
            base.output();
            Console.WriteLine("Address : {0} " , this.address);
            Console.WriteLine("----------------------------------------");
        }
    }
}
