using Lab05.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class StudentServices
    {
        public List<Student> getAll()
        {
            StudentModel context = new StudentModel();
            return context.Students.ToList();
        }

        public List<Student> getAllHasNoMajor()
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(s => s.Major == null).ToList();
        }

        public List<Student> getAllHasNoMajor(int facultyID)
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(s => s.Major == null && s.FacultyID == facultyID).ToList();
        }

        public Student findById(string studentID)
        {
            StudentModel context = new StudentModel();
            return context.Students.FirstOrDefault(s => s.StudentID == studentID);
        }

        public void insertUpdate(Student student)
        {
            StudentModel context = new StudentModel();
            context.Students.AddOrUpdate(student);
            context.SaveChanges();
        }
    }
}
