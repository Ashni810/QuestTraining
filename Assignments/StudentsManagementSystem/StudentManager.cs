using System;
using System.Collections.Generic;

namespace StudentsManagementSystem
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            if (GetStudentByRegNumber(student.RegNumber) != null)
            {
                Console.WriteLine("Student already exists");
                return;
            }
            students.Add(student);
            Console.WriteLine("Added successfully");
        }

        public void Search(string RegNumber)
        {
            var student = GetStudentByRegNumber(RegNumber);
            if (student != null)
            {
                Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public void Update(string RegNumber, string Name, int Class, List<MarkDetail> marks)
        {
            var student = GetStudentByRegNumber(RegNumber);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            student.StudentName = Name;
            student.Class = Class;
            student.Marks = marks;
            Console.WriteLine("Updated successfully");
        }

        public void Delete(string RegNumber)
        {
            var student = GetStudentByRegNumber(RegNumber);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }
            students.Remove(student);
            Console.WriteLine("Deleted successfully");
        }

        private Student GetStudentByRegNumber(string RegNumber)
        {
            foreach (var student in students)
            {
                if (student.RegNumber == RegNumber)
                {
                    return student;
                }
            }
            return null;
        }
    }
}

