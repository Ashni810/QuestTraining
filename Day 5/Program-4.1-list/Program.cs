using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4._1_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<int>();
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Enter numbers {i+1}:");
                lst.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] % 2 == 0) 
                {
                  lst.RemoveAt(i);
                }
            }
            Console.WriteLine(string.Join(", ", lst));
        }
    }
}
