using System;

namespace Student 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a college student
            var collegeStudent = new CollegeStudent
            {
                CollegeName = "TKR College",
                Name = "Malu",
                Email = "245@yahoo.com",
                Address = new Address { Line1 = "Ezhimala ", Line2 = "Apt 4B", Pin = "670308" }
            };

            // Create a school student
            var schoolStudent = new SchoolStudent
            {
                SchoolName = "Empire High",
                Name = "Ashni",
                Email = "123@gmail.com",
                Address = new Address { Line1 = "Kunnaru", Line2 = "HouseNo 48", Pin = "670305" }
            };

            // Display the students
            Console.WriteLine(collegeStudent);
            Console.WriteLine(schoolStudent);
        }
    }
}
