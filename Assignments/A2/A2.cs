using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = "10_202_34_12";
            int sum = 0;
            int num = 0;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == '_')
                {
                    sum += num;
                    num = 0;
                }
                else
                {
                    num = num * 10 + (pattern[i] - '0');
                }
            }

            sum += num;
            Console.WriteLine(sum); // Output: 258
        }
    }
}
