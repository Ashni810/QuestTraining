using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    internal class Program
    {
        static void Main(string[] args)
        {
                var numbers = new List<int> { 1, 2, 3, 4, 5 };

                int sum = numbers.Sum();

                Console.WriteLine($"The sum of all elements is: {sum}");
            
        }
    }

}
    

