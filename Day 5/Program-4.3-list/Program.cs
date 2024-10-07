using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4._3_list
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                var data = new List<int>[2];
                for (int i = 0; i < 2; i++)
                {
                    data[i] = new List<int>();
                    for (int j = 1; j <= 3; j++)
                    {
                        Console.WriteLine($"Enter marks {j}: ");
                        int mark = int.Parse(Console.ReadLine());
                        data[i].Add(mark);
                    }
                }
                Console.WriteLine("\nMarks:");
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine($"Student {i + 1}: [{string.Join(",", data[i])}]");
                }
            
        }
    }
}

