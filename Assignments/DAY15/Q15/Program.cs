using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 5, 6 };
            
            var result = numbers.Distinct().ToList();

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
