using System;

namespace SimpleCalculator
{
    // Define a Calculator class
    public class Calculator
    {
        public int Num1;
        public int Num2;

        // Method for addition
        public double Add()
        {
            return Num1 + Num2;
        }

        // Method for subtraction
        public double Subtract()
        {
            return Num1 - Num2;
        }

        // Method for multiplication
        public double Multiply()
        {
            return Num1 * Num2;
        }

        // Method for division
        public double Divide()
        {
            return Num1 / (double)Num2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.Write("Enter the first number: ");
            calc.Num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            calc.Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition: " + calc.Add());
            Console.WriteLine("Subtraction: " + calc.Subtract());
            Console.WriteLine("Multiplication: " + calc.Multiply());
            Console.WriteLine("Division: " + calc.Divide());

            
        }
    }
}