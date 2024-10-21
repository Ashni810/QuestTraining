using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "Apple", "Book", "Cat", "Bat", "Berry" };


            string startswithB = words.FirstOrDefault(x => x.StartsWith("B"));


            if (startswithB != null)
            {
                Console.WriteLine("First string starting with 'B': " + startswithB);
            }
            else
            {
                Console.WriteLine("No string starting with 'B' found.");
            }
        }
    }
}
