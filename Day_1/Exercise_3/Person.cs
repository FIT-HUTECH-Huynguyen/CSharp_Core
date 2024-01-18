using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Person
    {
        private string id;
        private string name;
       


        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
       

        public Person(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Person()
        {
            this.id = "";
            this.name = "";
        }

        public void input()
        {
            Console.Write("Enter id : ");
            this.id = Console.ReadLine();
            Console.Write("Enter name : ");
            this.name = Console.ReadLine();
           
        }

        public void output()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("ID : {0} ", this.id);
            Console.WriteLine("Name : {0} ", this.name);

        }
    }
}
