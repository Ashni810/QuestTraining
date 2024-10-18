using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorQ4
{
    internal class Program
    {
        class SimpleCalculator : ICalculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Subtract(int a, int b)
            {
                return a - b;
            }
        }
        static void Main(string[] args)
        {
            ICalculator calculator = new SimpleCalculator();
            calculator.Add(1, 2);
            calculator.Subtract(1, 2);

        }
    }
}

