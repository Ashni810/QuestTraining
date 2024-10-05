using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Build a rectangle like this  * * * * * * * * * * *
            //   *                   *
            //       *                   *
            //    * * * * * * * * * * *
            //    


            
            int width = 10;
            Console.WriteLine("Enter the Height of the Rectangle : ");
            int height = int.Parse(Console.ReadLine());

            // For Drawing the rectangle
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
   
