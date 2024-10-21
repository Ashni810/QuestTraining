using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int>(){ 1, 4, 7, 8, 5, 2, 3, 6, 9 };
            var max = data.Max();
            var min = data.Min();
           // var count = data.Count();
            var count = data.Count(x => x<5);
            var firstFiveTake = data.Take(5);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(count);
            Console.WriteLine(firstFiveTake);

        }
    }
}
