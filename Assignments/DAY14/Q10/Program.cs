using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        static void Sum(int a, int b) => Console.WriteLine(a + b);
        static void Main(string[] args)
        {
            Action<int, int> sum = Sum;
            sum(2,3);
        }
    }
}
