using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new List<string>() { "Ashni", "Arya", "Navya", "Malu" };
            var studentGrades = new List<int>() { 85, 78, 90, 65 };


            var studentsAbove80 = studentNames.Where((name, grade) => studentGrades[grade] > 80).ToList();


            Console.WriteLine("Students scoring above 80: " + string.Join(", ", studentsAbove80));
        }
    }
    
}
