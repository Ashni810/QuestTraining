using System;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 7;

            // Using the extension methods IsEven and IsOdd
            bool isEven = number.IsEven();
            bool isOdd = number.IsOdd();

            // Display the result
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Is Even: {isEven}");
            Console.WriteLine($"Is Odd: {isOdd}");
        }
    }
}
