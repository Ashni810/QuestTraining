using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public void TotalMarks()
        {
            Console.WriteLine($" {FirstName} {LastName} Total Mark is : {Mark1 + Mark2+ Mark3}");
        }
        public void AvgMarks()
        {
            Console.WriteLine($" {FirstName} {LastName} Average Mark is : {(Mark1 + Mark2 + Mark3)/2}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "Ashni";
            s1.LastName = "PP";
            s1.Mark1 = 45;
            s1.Mark2 = 50;
            s1.Mark3 = 35;
            s1.TotalMarks();
            s1.AvgMarks();

            Student s2 = new Student();
            s2.FirstName = "Malu";
            s2.LastName = "PP";
            s2.Mark1 = 35;
            s2.Mark2 = 40;
            s2.Mark3 = 35;
            s2.TotalMarks();
            s2.AvgMarks();
        }
    }
}
