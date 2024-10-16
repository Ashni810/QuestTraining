using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagmentSystem
{
        class StudentManager
        {
            private List<Student> students = new List<Student>();

            /// <summary>
            /// This method adds a student. If a student  already exists, it will not be added.
            /// </summary>
            /// <param name="student">An instance of <see cref="Student"/>>.</param>
            public void Add(Student student)
            {
                // Check if the same student exists.
                foreach (var item in students)
                {
                    if (item.RegNumber == student.RegNumber)
                    {
                        Console.WriteLine("Student already exists");
                        return;
                    }
                }

                students.Add(student);
                Console.WriteLine("Added successfully");
            }

            /// <summary>
            /// This method searches for a student based on the Registration number.
            /// </summary>
            /// <param name="regNumber">The reg number.</param>

            public void Search(string regNumber)
            {
                var student = GetRegByNumber(regNumber);
                Console.WriteLine(student);
            }

            public void Update(string regNumber, string studentName, int className)
            {
                var student = GetRegByNumber(regNumber);
                if (student == null)
                {
                    Console.WriteLine("Student not found");
                    return;
                }

              
                student.StudentName = studentName;
                student.ClassName = className;
                Console.WriteLine("Updated successfully");
            }

            public void Delete(string regNumber)
            {
                var student = GetRegByNumber(regNumber);
                if (student == null)
                {
                    Console.WriteLine("Student not found");
                    return;
                }

                students.Remove(student);
                Console.WriteLine("Deleted successfully");
            }

            private Student GetRegByNumber(string regNumber)
            {
                // Check if the same student exists.
                foreach (var student in students)
                {
                    if (student.RegNumber == regNumber)
                    {
                        return student;
                    }
                }
                return null;
            }
        }
    }








