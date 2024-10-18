using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    internal class Program
    {
       
            static bool StartsWithA(string str)
            {
                return str.StartsWith("A", StringComparison.OrdinalIgnoreCase);
            }

            static void Main(string[] args)
            {
                Predicate<string> startsWithA = StartsWithA;

                Console.Write("Enter a string to check if it starts with 'A': ");
                string input = Console.ReadLine();

                bool result = startsWithA(input);
                Console.WriteLine(result);
            }
        
    }

}


