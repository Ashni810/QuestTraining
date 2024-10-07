using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6.ArraySumEvenNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter Element no : {i+1} ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0) 
                {
                    sum = sum + numbers[i];
                }
                Console.WriteLine($"Sum of Even Number is : {sum} ");
            }
        }
    }
}
