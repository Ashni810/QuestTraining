using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<object>
            {
                new Circle(3),
                new Rectangle(4, 5)
            };

            foreach (var shape in shapes)
            {
                if (shape is Circle circle)
                {
                    Console.WriteLine($"Circle Area = {circle.GetArea()}, Perimeter = {circle.GetPerimeter()}");
                }
                else if (shape is Rectangle rectangle)
                {
                    Console.WriteLine($"Rectangle Area = {rectangle.GetArea()}, Perimeter = {rectangle.GetPerimeter()}");
                }
            }
        }
    }
}

