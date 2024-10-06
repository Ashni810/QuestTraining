using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_8.ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int min = elements.Min();
            int max = elements.Max();
            int sum = elements.Sum();
            var asc = elements.OrderBy(X=>X).ToArray();
            var desc = elements.OrderByDescending(X => X).ToArray();

        }
    }
}
