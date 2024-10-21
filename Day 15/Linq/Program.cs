using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
        internal class Program
        {
            static void Main(string[] args)
            {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var result = numbers.Skip(3).Take(5).Where(x => x % 2 == 0).Sum();
            Console.WriteLine(result);

            }
        }
   }


