using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementSystem
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            // Check if the same student exists.
            if (GetStudentByRegNumber(student.RegNumber) != null)
            {
                Console.WriteLine("Student already exists");
                return;
            }

            students.Add(student);
            Console.WriteLine("Added successfully");
        }

        /// <summary>
        /// This method searches for a student based on the register number.
        /// </summary>
        /// <param name="RegNumber">The register number.</param>
        public void Search(string RegNumber)
        {
            var student = GetStudentByRegNumber(RegNumber);
            Console.WriteLine(student);
        }

        public void Update(string RegNumber, string Name, int Class)
        {
            var student = GetStudentByRegNumber(RegNumber);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            student.RegNumber = RegNumber;
            student.StudentName = Name;
            student.Class = Class;

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
            // Check if the same student exists.
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

