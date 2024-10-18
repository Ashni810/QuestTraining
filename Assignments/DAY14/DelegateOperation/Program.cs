using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOperation
{
    internal class Program
    {
        delegate void MathDelegate(int x, int y);
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Main(string[] args)
        {
            MathDelegate del = Add;
            del += Multiply;
            del(3, 2);
        }
    }
}
