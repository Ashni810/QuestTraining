using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Create a dictionary to store the marks
                var studentMarks = new Dictionary<int, List<int>>();

                // Read the number of students
                Console.Write("Enter the number of students: ");
                int numStudents = int.Parse(Console.ReadLine());

                // Read the marks for each student
                for (int i = 0; i < numStudents; i++)
                {
                    Console.Write($"Enter student ID for student {i + 1}: ");
                    int studentId = int.Parse(Console.ReadLine());

                    // Check if the ID already exists
                    if (studentMarks.ContainsKey(studentId))
                    {
                        Console.WriteLine("Student ID already exists. Do you want to:");
                        Console.WriteLine("1. Add marks to existing student");
                        Console.WriteLine("2. Create a new student ID");
                        Console.Write("Enter your choice (1 or 2): ");
                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                // Add marks to existing student
                                Console.Write("Enter mark 1: ");
                                studentMarks[studentId].Add(int.Parse(Console.ReadLine()));

                                Console.Write("Enter mark 2: ");
                                studentMarks[studentId].Add(int.Parse(Console.ReadLine()));

                                Console.Write("Enter mark 3: ");
                                studentMarks[studentId].Add(int.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                // Create a new student with the same ID
                                Console.Write("Enter new student ID: ");
                                int newStudentId = int.Parse(Console.ReadLine());

                                // Create a list to store the marks for this student
                                var marks = new List<int>();

                                Console.Write("Enter mark 1: ");
                                marks.Add(int.Parse(Console.ReadLine()));

                                Console.Write("Enter mark 2: ");
                                marks.Add(int.Parse(Console.ReadLine()));

                                Console.Write("Enter mark 3: ");
                                marks.Add(int.Parse(Console.ReadLine()));

                                // Add the marks to the studentMarks dictionary
                                studentMarks.Add(newStudentId, marks);
                                break;
                            default:
                                Console.WriteLine("Invalid choice....");
                                i--;
                                break;
                        }
                    }
                    else
                    {
                        // Create a list to store the marks for this student
                        var marks = new List<int>();

                        Console.Write("Enter mark 1: ");
                        marks.Add(int.Parse(Console.ReadLine()));

                        Console.Write("Enter mark 2: ");
                        marks.Add(int.Parse(Console.ReadLine()));

                        Console.Write("Enter mark 3: ");
                        marks.Add(int.Parse(Console.ReadLine()));

                        // Add the marks to the studentMarks dictionary
                        studentMarks.Add(studentId, marks);
                    }
                }

                // Print the marks
                foreach (var student in studentMarks)
                {
                    Console.WriteLine($"{student.Key}: [{string.Join(", ", student.Value)}]");
                }
            }
        

    }
}

    

    

