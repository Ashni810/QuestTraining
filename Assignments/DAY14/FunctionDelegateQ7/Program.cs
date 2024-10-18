using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDelegateQ7
{
    internal class Program
    {   
        static int Sum(int a, int b)  => (a + b);
        static void Main(string[] args)
        {
            Func<int, int ,int> sum = Sum;
             int result = sum(4,5);
            Console.WriteLine(result);
          
        }
    }
}
