using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_8.Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String : ");
            string text = Console.ReadLine();
            var reverse = string.Concat(text.Reverse());
            if (text == reverse)
            {
              Console.WriteLine("Yes it is Palindrome ");
            }
            else
            {

              Console.WriteLine("Not Palindrome ");

            }
        }
    }
}
