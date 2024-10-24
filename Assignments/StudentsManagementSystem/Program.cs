﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sManager = new StudentManager();
            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        var student = GetStudentData();
                        sManager.Add(student);
                        break;
                    case "2":
                        Console.Write("Enter the register number to search: ");
                        var RegNumber = Console.ReadLine();
                        sManager.Search(RegNumber);
                        break;
                    case "3":
                        var studentToUpdate = GetStudentData();
                        sManager.Update(studentToUpdate.RegNumber, studentToUpdate.StudentName, studentToUpdate.Class, studentToUpdate.Marks);
                        break;
                    case "4":
                        Console.Write("Enter the register number to delete: ");
                        var RegNumberToDelete = Console.ReadLine();
                        sManager.Delete(RegNumberToDelete);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        private static Student GetStudentData()
        {
            var student = new Student();

            Console.Write("Enter the register number: ");
            student.RegNumber = Console.ReadLine();
            Console.Write("Enter the student name: ");
            student.StudentName = Console.ReadLine();
            Console.Write("Enter the class: ");
            student.Class = int.Parse(Console.ReadLine());

            student.Marks = new List<MarkDetail>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter Subject {i}: ");
                var subject = Console.ReadLine();
                Console.WriteLine("Enter Obtained Mark: ");
                var obtainedMark = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Maximum Mark: ");
                var maxMark = int.Parse(Console.ReadLine());

                student.Marks.Add(new MarkDetail
                {
                    Subject = subject,
                    MarkObtained = obtainedMark,
                    MaxMark = maxMark
                });
            }

            return student;
        }
    }
}

