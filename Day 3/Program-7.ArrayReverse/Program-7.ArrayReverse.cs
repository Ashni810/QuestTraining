using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program_7.ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] reverse = new int[numbers.Length];
            int count = 0;
            bool isEven = numbers.Length % 2 == 0;
            if (!isEven) 
            {
                int centerIndex = (numbers.Length / 2);
                reverse[centerIndex] = numbers[centerIndex];
                for (int i = 0; i < centerIndex; i++) 
                {
                    reverse[i] = numbers[centerIndex-1-i];
                }
                for (int i = centerIndex + 1; i < numbers.Length; i++) 
                {
                    reverse[i] = numbers[numbers.Length - 1 - count];
                    count++;
                }
                Console.WriteLine(string.Join(" ",reverse));

            }
        }
    }
}
