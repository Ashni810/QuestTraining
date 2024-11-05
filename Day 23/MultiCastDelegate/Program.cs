using System;
using System.Diagnostics;

namespace MultiCastDelegate
{
    class Calculator
    {
       delegate void Calculate(int x, int y);

        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition: {x + y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"Subtraction: {x - y}");
        }

        static void Main(string[] args)
        {
            Calculator c = new Calculator(); 

            Calculate calc = c.Add;
            calc += c.Subtract;
            calc(3, 4);
        }
    }
}
