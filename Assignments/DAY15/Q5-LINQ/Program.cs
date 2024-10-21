using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
                var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                var squaresOfEvenNumbers = numbers.Where(n => n % 2 == 0).Select(n => n * n).ToList();

                Console.WriteLine("Squares even numbers: " + string.Join(", ", squaresOfEvenNumbers));
        }
    }
}
