using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

                Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
            }
        }
    }
}
