using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    internal class Program
    {
        static bool IsEven(int n) => n % 2 == 0;
        static void Main(string[] args)
        {
            Predicate<int> a = IsEven;
            Console.Write("Enter a number to check if it's evenor not : ");
            int number = int.Parse(Console.ReadLine());

            var res = a(number);
            Console.WriteLine(res);
        }
    }
}
