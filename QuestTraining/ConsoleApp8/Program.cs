using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Count
    {
        public void DisplayString(string text)
        {
            Console.WriteLine($"The string is {text}");
        }
        static int DisplaySpaceCount(string text)
        {
            int count = 0;
            foreach (char c in text)
            { 
                if (c == ' ')
                { 
                    count++;
                }
            }
            return count;

        }
        static void Main(string[] args)
        {
            Count c = new Count();
            c.DisplayString("This is in an apple");
        }   
        

    }
}