using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int>() { 24,40, 4, 5, 10, 20, 15, 8, 7 };
            var result = data.Min();
            Console.WriteLine(result);
        }
    }
}
