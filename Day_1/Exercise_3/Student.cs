using Exercise_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericse_3
{
    internal class Student : Person
    {
        // Fields

        private string faculty;
        private double avg;


        // properties 
        public string Faculty { get => faculty; set => faculty = value; }
        public double Avg { get => avg; set => avg = value; }

        // constructor 
        public Student(string id, string name, string faculty, double avg) : base(id,name)
        {
            this.faculty = faculty;
            this.avg = avg;
        }
        public Student() 
        {
            this.faculty = "";
            this.avg = 0.0;
        }

        // input 
        public void input()
        {
            base.input();
            Console.Write("Enter faculty : ");
            this.faculty = Console.ReadLine();
            Console.Write("Enter avg score : ");
            this.avg = double.Parse(Console.ReadLine());
        }

        // output
        public void output()
        {
            base.output();
            Console.WriteLine("Faculty : {0} ", this.faculty);
            Console.WriteLine("Avg : {0} ", this.avg);
            Console.WriteLine("----------------------------------------");
        }
    }
}
