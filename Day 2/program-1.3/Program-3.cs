using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditional statement //

            Console.Write("Enter your mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark > 90)
            {
                Console.WriteLine("A grade");
            }
            else if (mark > 80)
            {
                Console.WriteLine("B grade");
            }
            else if (mark > 70)
            {
                Console.WriteLine("C grade");
            }
            else if (mark > 60)
            {
                Console.WriteLine("D grade");
            }
            else
            {
                Console.WriteLine("Failed");
            }

        }

    }
}
