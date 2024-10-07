using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loop //

            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter the Number to add or 'q' to exit: ");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                int data = int.Parse(input);
                sum += data;
                Console.WriteLine("Current sum: " + sum);
            }
        }
        
    }
}
