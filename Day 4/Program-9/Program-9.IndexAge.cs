using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_9
{
    internal class Program
    {
        // Question : -  input = name1,name2... // output  = name 1 is o year old
                                                 //          name 2 is 1 year old  (based on the each index)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of names:"); 
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter name " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
            }

            StringBuilder sb = new StringBuilder();
            int index = 0;
            foreach (string name in names)
            {
                sb.AppendLine(name + " is " + index + " year old"); 
                index++;
            }

            Console.WriteLine(sb.ToString());
            
            
        }
    }
}
