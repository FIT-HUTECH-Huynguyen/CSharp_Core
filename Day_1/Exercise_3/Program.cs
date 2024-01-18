using Exercise_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericse_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Manage manage = new Manage();
            List<Student> students = new List<Student>();
            students.Add(new Student("1","huy","cntt",10.0));
            students.Add(new Student("2", "hoang", "cntt", 10.0));
            students.Add(new Student("3", "hung", "cntt", 10.0));
            students.Add(new Student("4", "hiep", "cntt", 8.0));
            students.Add(new Student("5", "hieu", "cntt", 5.0));
            students.Add(new Student("6", "huong", "cntt", 1.0));
            students.Add(new Student("7", "long", "kinh te", 4.0));
            students.Add(new Student("8", "ling", "quan tri", 3.0));
            students.Add(new Student("8", "lien", "quan tri", 8.0));

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("1", "Khanh", "Quan 9"));
            teachers.Add(new Teacher("2", "Khuong", "Quan 9"));
            teachers.Add(new Teacher("3", "Binh", "Quan 10"));
            teachers.Add(new Teacher("4", "Lan", "Quan Thu Duc"));



            foreach (Student attempt in students)
            {
                manage.addStudent(attempt);
            }

            foreach (Teacher attempt in teachers)
            {
                manage.addTeacher(attempt);
            }

            int selected = 0;
            bool exit = true;
            do
            {
                Menu();
                Console.Write("Enter select : ");
                selected = int.Parse(Console.ReadLine());

                switch (selected)
                {
                    case 1:
                        {
                            Student newStudent = new Student();
                            newStudent.input();
                            manage.addStudent(newStudent);
                            break;
                        }
                    case 2:
                        {
                            Teacher newTeacher = new Teacher();
                            newTeacher.input();
                            manage.addTeacher(newTeacher);
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("-- List Student --");
                            manage.printListStudents();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("-- List Teacher --");
                            manage.printListTeachers();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("-- Number of student and teacher ");
                            manage.NumbersElement();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("-- List FIT Student  --");
                            Console.Write("Enter faculty : ");
                            string faculty = Console.ReadLine();
                            manage.getStudentsBelongFIT(faculty);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("-- List Teacher live in Quan 9 --");
                            Console.Write("Enter address : ");
                            string address = Console.ReadLine();
                            manage.getStudentsBelongAddress(address);
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("-- List FIT Student have highest scored --");
                            Console.Write("Enter faculty : ");
                            string faculty = Console.ReadLine();
                            manage.getFITStudentHaveHighestScored(faculty);
                            break;
                            
                        }
                    case 9:
                        {
                            Console.WriteLine("-- Numbers Student By Level --");
                            manage.getNumbersStudentByLevel();
                            break;
                        }
                    case 10:
                        {
                            exit = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid!!");
                            break;
                        }
                }

            } while (exit != false);
        }

        public static void Menu()
        {
            Console.WriteLine("1 . Add Student ");
            Console.WriteLine("2 . Add Teacher ");
            Console.WriteLine("3 . Print Student ");
            Console.WriteLine("4 . Print Teacher ");
            Console.WriteLine("5 . Print Numbers of student and teacher ");
            Console.WriteLine("6 . Print student belong to FIT ");
            Console.WriteLine("7 . Print student live in Quan 9 ");
            Console.WriteLine("8 . Print FIT student have highest scored ");
            Console.WriteLine("9 . Numbers student by level");
            Console.WriteLine("10 . Quit ");
        }
    }
}
