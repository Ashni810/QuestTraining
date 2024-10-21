using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 12, 8, 20, 30, 50, 90, -3 };

            var result = numbers.Select(x => x > 0).ToList();
            
            Console.WriteLine($"Numbers Greater than 0:  " + string.Join(", ", result));
        }
    }
}
