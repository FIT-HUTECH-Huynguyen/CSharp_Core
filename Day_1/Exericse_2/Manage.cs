using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericse_2
{
    internal class Manage
    {
        List<Student> students;

        public Manage()
        {
            students = new List<Student>();
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }
        public void printListStudents()
        {
            foreach (Student attemptStudent in students)
            {
                attemptStudent.output();
            }
        }

        public void printListStudents(IEnumerable<Student> students)
        {
            foreach (Student attemptStudent in students)
            {
                attemptStudent.output();
            }
        }

        public void getStudentsBelongFIT(string faculty)
        {
            int count = 0;
            var fitStudents = students.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase));
            foreach (var fitStudent in fitStudents)
            {
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine(" Empty!! ");
            }
            else
            {
                printListStudents(fitStudents);
            }
        }

        public void getStudentHaveScoredOver5(double minAvg)
        {
            int count = 0;
            var studentOver5 = students.Where(s => s.Avg >= minAvg);
            foreach (var fitStudent in studentOver5)
            {
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine(" Empty!! ");
            }
            else
            {
                printListStudents(studentOver5);
            }
        }

        public void getStudentIncreasingByScored()
        {
            var studentIncreasing = students.OrderBy(s => s.Avg).ToList();
            printListStudents(studentIncreasing);
        }

        public void geFITStudentHaveScoredOver5(string faculty, double minAvg)
        {
            int count = 0;
            var fitStudentOver5 = students.Where(s => s.Avg >= minAvg && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var fitStudent in fitStudentOver5)
            {
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine(" Empty !! ");
            }
            else
            {
                printListStudents(fitStudentOver5);
            }
        }

        public void getFITStudentHaveHighestScored(string faculty)
        {
            int count = 0;
            var fitStudentHighest = students.Where(s => s.Avg == students.Max(x => x.Avg) && s.Faculty.Equals(faculty,StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var fitStudent in fitStudentHighest)
            {
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine(" Empty !! ");
            }
            else
            {
                printListStudents(fitStudentHighest);
            }
        }

        public void getNumbersStudentByLevel()
        {
            var excellent = students.Count(s => s.Avg >= 9 && s.Avg <= 10);
            Console.WriteLine("Excellent : {0} ", excellent);
            var good = students.Count(s => s.Avg >= 8 && s.Avg < 9);
            Console.WriteLine("Good : {0} ", good);
            var quite = students.Count(s => s.Avg >= 7  && s.Avg < 8);
            Console.WriteLine("Quite : {0} ", quite);
            var medium = students.Count(s => s.Avg >= 5 && s.Avg < 7);
            Console.WriteLine("Medium : {0} ", medium);
            var weak = students.Count(s => s.Avg >=4 && s.Avg < 5);
            Console.WriteLine("Weak : {0}", weak);
            var poor = students.Count(s => s.Avg < 4);
            Console.WriteLine("Poor : {0}", poor);
        }
    }
}
