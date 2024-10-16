using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagmentSystem
{
    internal class Program
    {
        static void Main()
        {
            var sManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Search");
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
                        Console.Write("Enter the Student Registration number to search: ");
                        var RegNumber = Console.ReadLine();
                        sManager.Search(RegNumber);
                        break;
                    case "3":
                        var studentToUpdate = GetStudentData();
                        sManager.Update(studentToUpdate.RegNumber,
                        studentToUpdate.StudentName,
                        studentToUpdate.ClassName);
                        break;

                    case "4":
                        Console.Write("Enter the registration number to delete: ");
                        var regNumberToDelete = Console.ReadLine();
                        sManager.Delete(regNumberToDelete);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
            }
        }

        private static Student GetStudentData()
        {
            Student student= new Student();
            
            Console.Write("Enter the student Registration number: ");
            student.RegNumber = Console.ReadLine();

            Console.Write("Enter the Student name: ");
            student.StudentName = Console.ReadLine();

            Console.Write("Enter the Class Name: ");
          student.ClassName = int.Parse(Console.ReadLine());
            return student;
        }
    }
}


