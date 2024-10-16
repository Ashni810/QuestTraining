using System;
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
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
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
                        var StudentToUpdate = GetStudentData();
                        sManager.Update(StudentToUpdate.RegNumber,
                            StudentToUpdate.StudentName,
                            StudentToUpdate.Class);
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
            Student student = new Student();

            Console.Write("Enter the register number: ");
            student.RegNumber = Console.ReadLine();

            Console.Write("Enter the student name: ");
            student.StudentName = Console.ReadLine();

            Console.Write("Enter the class: ");
            student.Class = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject 1: ");
            student.Sub1 = Console.ReadLine();

            Console.WriteLine("Enter Obtained Mark: ");
            student.Mark1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maximum Mark: ");
            student.MaxMark1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject2: ");
            student.Sub2 = Console.ReadLine();

            Console.WriteLine("Enter Obtained Mark: ");
            student.Mark2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maximum Mark: ");
            student.MaxMark2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject3: ");
            student.Sub3 = Console.ReadLine();

            Console.WriteLine("Enter Obtained Mark: ");
            student.Mark3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maximum Mark: ");
            student.MaxMark3 = int.Parse(Console.ReadLine());

            return student;

        }
    }
}
