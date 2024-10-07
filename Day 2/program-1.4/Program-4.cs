using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop //

            string data = "This is a text ";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ' ')
                {
                    break;
                }
                Console.WriteLine(data[i]);
            }
            Console.WriteLine();
        }
    }
}
