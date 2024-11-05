using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str1 = "listen", str2 = "silent";

            char[] arr1 = str1.ToCharArray();

            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);

            Array.Sort(arr2);

            //Console.WriteLine(Array.Equals(arr1, arr2));

            // Check if the sorted arrays are equal

            bool areAnagrams = arr1.SequenceEqual(arr2);
            Console.WriteLine($"{str1}' and '{str2} are anagram ?:{areAnagrams}");
        }
    }
    
}
