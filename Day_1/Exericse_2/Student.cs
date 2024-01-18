using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericse_2
{
    internal class Student
    {
        // Fields
        private string id;
        private string name;
        private string faculty;
        private double avg;

        // properties 
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public double Avg { get => avg; set => avg = value; }

        // constructor 
        public Student(string id, string name, string faculty, double avg)
        {
            this.id = id;
            this.name = name;
            this.faculty = faculty;
            this.avg = avg;
        }
        public Student()
        {
            id = "";
            name = "";
            faculty = "";
            avg = 0.0;
        }

        // input 
        public void input()
        {
            Console.Write("Enter id : ");
            this.id = Console.ReadLine();
            Console.Write("Enter name : ");
            this.name = Console.ReadLine();
            Console.Write("Enter faculty : ");
            this.faculty = Console.ReadLine();
            Console.Write("Enter avg score : ");
            this.avg = double.Parse(Console.ReadLine());
        }

        // output
        public void output()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("ID : {0} ", this.id);
            Console.WriteLine("Name : {0} ",this.name);
            Console.WriteLine("Faculty : {0} ", this.faculty);
            Console.WriteLine("Avg : {0} ", this.avg);
            Console.WriteLine("----------------------------------------");
        }
    }
}
