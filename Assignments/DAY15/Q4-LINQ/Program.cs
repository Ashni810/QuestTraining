using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_LINQ
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5 };

                var squares = numbers.Select(n => n * n).ToList();

                Console.WriteLine("Squares of the  numbers are: " + string.Join(", ", squares));
            }
        }
    

}
