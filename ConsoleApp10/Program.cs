using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Overloading the + operator
        public static Point operator +(Point a, Point b)
        {
            return new Point()
            {
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }

        // Overloading the - operator for demonstration
        public static Point operator -(Point a, Point b)
        {
            return new Point()
            {
                X = a.X - b.X,
                Y = a.Y - b.Y
            };
        }

        // Overloading the * operator for demonstration
        public static Point operator *(Point a, Point b)
        {
            return new Point()
            {
                X = a.X * b.X,
                Y = a.Y * b.Y
            };
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 3, Y = 4 };
            Point p2 = new Point { X = 1, Y = 2 };

            // Using the overloaded + operator
            Point sum = p1 + p2;
            Console.WriteLine($"Sum: {sum}");

            // Using the overloaded - operator
            Point difference = p1 - p2;
            Console.WriteLine($"Difference: {difference}");

            // Using the overloaded * operator
            Point product = p1 * p2;
            Console.WriteLine($"Product: {product}");
        }
    }
}
