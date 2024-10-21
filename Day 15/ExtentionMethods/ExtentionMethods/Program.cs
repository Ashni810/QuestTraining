using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "this is a sample sentence.";

            // Using the extension method ToTitleCase
            string titleCased = example.ToTitleCase();

            // Display the result
            Console.WriteLine("Original: " + example);
            Console.WriteLine("Title Cased: " + titleCased);
        }
    }
}
