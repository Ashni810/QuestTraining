using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5
{
    internal class Program
    {
        // To print 1
        //          1 2
        //          1 2 3
        
        static void Main(string[] args)
        {

            Console.Write("Enter the number of rows: ");
            int numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
