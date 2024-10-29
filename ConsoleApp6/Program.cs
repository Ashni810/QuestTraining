using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

            public class Fruit
            {
           
            public int weight { get; set; }
            }
            public class Apple : Fruit
            {
                public string variant { get; set; }

                public static void Display(string variant)
                {
                    Console.WriteLine("the variant is ");
                }
            }

    internal class program 
    {
        static void Main(string[] args)
        {
          Fruit f = new Apple{ variant = "xy"};
            f.weight = 10;
            Console.WriteLine(f.weight);
            Console.WriteLine(Apple.variant);


        }    
        }
}
