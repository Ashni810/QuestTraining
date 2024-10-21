using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 12, 8, 20, 30, 50, 90,100 };

            var result = numbers.Where(x => x > 50).ToList();

            Console.WriteLine("Greater than 50: " + string.Join(", ", result));
        }
    }
    
}
