using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3
{
    internal class Program
    {
         // to print   *
         //            * *
         //            * * * 
        static void Main(string[] args)
        {

            Console.Write("Enter the number of rows: ");
            int numRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
