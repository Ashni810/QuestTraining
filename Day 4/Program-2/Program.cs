using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    internal class Program
    {
        static void Main(string[] args)

        {   // input - "HeLlO WoRld"  output - "hElLo wOrLd" //
            
            string inputString = "HeLlO WoRld";
            StringBuilder outputStringBuilder = new StringBuilder();
            foreach (char c in inputString)
            {
            if (char.IsUpper(c))
             outputStringBuilder.Append(char.ToLower(c));
            else
                   outputStringBuilder.Append(char.ToUpper(c));
            }
            string outputString = outputStringBuilder.ToString();
            Console.WriteLine(outputString);
        }
    }
}
