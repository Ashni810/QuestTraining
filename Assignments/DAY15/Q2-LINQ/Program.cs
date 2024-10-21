using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "Apple", "Book", "Ashni", "Cat", "Airpot", "Ashok" , "Orange"};
           
            var stringsStartingWithA = strings.Where(s => s.StartsWith("A")).ToList();

           Console.WriteLine("Strings starting with 'A': " + string.Join(", ", stringsStartingWithA));
        }
    }
}
