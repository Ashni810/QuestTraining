using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student 
            { 
                Name = "Student1",
                Age = 15,
                Mark1 = 80, 
                Mark2 = 70, 
                Mark3 = 90
            };
            var s2 = new Student 
            {
                Name = "Student2", 
                Age = 15,
                Mark1 = 90,
                Mark2 = 85,
                Mark3 = 95
            };
            var s3 = new Student 
            {
                Name = "Student3",
                Age = 15,
                Mark1 = 75,
                Mark2 = 80,
                Mark3 = 85 
            };
            var s4 = new Student
            { 
                Name = "Student4", 
                Age = 15,
                Mark1 = 85, 
                Mark2 = 90,
                Mark3 = 95 
            };
            var s5 = new Student
            {
                Name = "Student5",
                Age = 15, 
                Mark1 = 90,
                Mark2 = 95, 
                Mark3 = 98 
            };

            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            students[3] = s4;
            students[4] = s5;

            Console.WriteLine("Student Details:");
            foreach (Student student in students)
            {
                Console.WriteLine($" {student.Name}, Total Mark: {student.TotalMark}");
            }
        }
    }
}
