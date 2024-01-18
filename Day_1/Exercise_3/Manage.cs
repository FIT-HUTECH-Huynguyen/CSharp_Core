using Exercise_3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericse_3
{
    internal class Manage
    {
        List<Student> students;
        List<Teacher> teachers;

        public Manage()
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
        }

        // add 
        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void addTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        // print 
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


        public void printListTeachers()
        {
            foreach (Teacher attemptTeacher in teachers)
            {
                attemptTeacher.output();
            }
        }

        public void printListTeachers(IEnumerable<Teacher> teachers)
        {
            foreach (Teacher attemptTeacher in teachers)
            {
                attemptTeacher.output();
            }
        }

        public void NumbersElement()
        {
            var student = students.Count();
            Console.WriteLine("Numbers of student : {0} ", student);
            var teacher = teachers.Count();
            Console.WriteLine("Number of teacher : {0} ", teacher);
        }

        public void getStudentsBelongFIT(string faculty)
        {
            int count = 0;
            var fitStudents = students.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase));
            foreach (var fitStudent in fitStudents)
            {
                count++;
            }
            if(count == 0)
            {
                Console.WriteLine(" Empty !!");
            }
            else
            {
                printListStudents(fitStudents);
            }
            
        }

        public void getStudentsBelongAddress(string addresss)
        {
            int count = 0;
            var teacher = teachers.Where(s => s.Address.Equals(addresss, StringComparison.OrdinalIgnoreCase));
            foreach (var attempt in teacher)
            {
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine(" Empty!! " , addresss);
            }
            else
            {
                printListTeachers(teacher);
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
                Console.WriteLine(" Empty !!");
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
