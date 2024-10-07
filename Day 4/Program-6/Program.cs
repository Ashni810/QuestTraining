using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6
{
    internal class Program
    {
        // To check vowels Present or Not..
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string vowels = "aciouAEIOU";
            string result = "";
            foreach (char c in input)
            {

                if (vowels.Contains(c))

                    result += c;

            }
            Console.WriteLine("Vowels in the string: result");
        }
    }
}
