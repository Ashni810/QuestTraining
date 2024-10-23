using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefType
{
    internal class Program
    {
        static void DoThis(ref int num)
        {
            num = 0;
        }
        static void Main(string[] args)
        {
            int number = 10;   // Initialize the variable
            DoThis(ref number);
            Console.WriteLine(number);
        }
    }
}
