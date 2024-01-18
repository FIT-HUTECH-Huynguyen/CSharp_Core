using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericse_2
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
            students.Add(new Student("9", "lien", "quan tri", 8.0));


            foreach (Student attempt in students)
            {
                manage.addStudent(attempt);
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
                            Console.WriteLine("-- List Student --");
                            manage.printListStudents();
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("-- List Student belongs FIT --");
                            Console.Write("Enter faculty : ");
                            string faculty = Console.ReadLine();
                            manage.getStudentsBelongFIT(faculty);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("-- List Student have scored over 5 --");
                            Console.Write("Enter score : ");
                            double score = double.Parse(Console.ReadLine());
                            manage.getStudentHaveScoredOver5(score);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("-- List Student increasing by score ");
                            manage.getStudentIncreasingByScored();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("-- List FIT Student have scored over 5 --");
                            Console.Write("Enter faculty : ");
                            string faculty = Console.ReadLine();
                            Console.Write("Enter score : ");
                            double score = double.Parse(Console.ReadLine());
                            manage.geFITStudentHaveScoredOver5(faculty,score);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("-- List FIT Student have highest scored --");
                            Console.Write("Enter faculty : ");
                            string faculty = Console.ReadLine();
                            manage.getFITStudentHaveHighestScored(faculty);
                            break;
                        }
                    case 8:
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
            Console.WriteLine("1 . Add ");
            Console.WriteLine("2 . Print ");
            Console.WriteLine("3 . Print FIT student ");
            Console.WriteLine("4 . Print student have scored over 5 ");
            Console.WriteLine("5 . Print student increasing by avg ");
            Console.WriteLine("6 . Print FIT student have scored over 5 ");
            Console.WriteLine("7 . Print FIT student have highest scored ");
            Console.WriteLine("8 . Numbers student by level");
            Console.WriteLine("10 . Quit ");
        }
    }
}
