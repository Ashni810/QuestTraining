using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Delegates_as_Parameters
{
    using System;

    namespace Using_Delegates_as_Parameters
    {
        // Delegate declaration
        public delegate int Operation(int x, int y);

        class Program
        {
            // Method to calculate using the delegate
            public static int Calculate(int a, int b, Operation operation)
            {
                return operation(a, b);
            }

            static void Main()
            {
                Console.Write("Enter the first number: "); 
                int a = int.Parse(Console.ReadLine());
                
                Console.Write("Enter the second number: "); 
                int b = int.Parse(Console.ReadLine());

                int sum = Calculate(a, b, (x, y) => x + y);
                Console.WriteLine("Addition: " + sum);

                int product = Calculate(a, b, (x, y) => x * y);
                Console.WriteLine("Multiplication: " + product);
            }
        }
    }
}