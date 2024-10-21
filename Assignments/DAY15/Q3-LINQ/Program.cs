using System;
using System.Collections.Generic;
using System.Linq;

namespace Q5_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int>() { 1, 2, 3, 7, 5, 9, 4, 6, 10, 8 };
            
            var result = data.OrderByDescending(x => x).ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
