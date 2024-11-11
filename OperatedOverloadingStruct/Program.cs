using System;

namespace StructExample
{
    // Defining a struct named Point
    struct Point
    {
        // Public fields
        public int X;
        public int Y;

        // Constructor to initialize the struct
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method to display the coordinates
        public void Display()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Point struct
            Point p1 = new Point(10, 20);
            p1.Display();

            // Creating another instance using object initializer
            Point p2;
            p2.X = 30;
            p2.Y = 40;
            p2.Display();
        }
    }
}
