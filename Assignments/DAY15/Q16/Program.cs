using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 5, 12, 8, 20, 15, 3, 7, 25,50,40 };

            int count = numbers.Count(n => n > 10);

            Console.WriteLine(count);
        }
    }
}
