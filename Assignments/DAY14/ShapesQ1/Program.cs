using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ShapesQ1
{
    internal class Program
    {
        public abstract class Shape
        {
            public abstract double Area();
        }

        public class Circle : Shape
        {
        public double Radius;

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Rectangle : Shape
        {
             public double Length;
             public double Width;
            

            public Rectangle(double width, double length)
            {
                Width = width;
                Length = length;
            }

            public override double Area()
            {
                return Length * Width;
            }
        }

     
            static void Main(string[] args)
            {
                Circle circle = new Circle(5);
                Rectangle rectangle = new Rectangle(4, 6);

                Console.WriteLine($"Circle Area: {circle.Area()}");
                Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
            }
        }
    }
