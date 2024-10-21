using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double> { 1.2, 3.4, 5.6, 7.8, 9.0 };

            // Use LINQ to calculate the average
            double result = numbers.Average();

            // Display the average
            Console.WriteLine($"The average of the numbers is: {result}");
        }
    }
}

        //without using .Average//

       // var numbers = new List<float> { 1.2f, 3.4f, 5.6f, 7.8f, 9.0f };

        //calculate the sum and average
       // float sum = 0;
         //   foreach (var number in numbers)
         //   {
         //       sum += number;
          //  }

    //float result = sum / numbers.Count;

    // Display the result
   // Console.WriteLine($"The average of the numbers is: {result}");
    
