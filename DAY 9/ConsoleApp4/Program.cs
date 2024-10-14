using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {//copy to an array and resizing//
        static void Main(string[] args)
        {
                string[] animals = { "Cat", "Rat", "Rabbit", "Tiger" };
                Console.WriteLine("Original Array:");
                foreach (string i in animals)
                {
                    Console.WriteLine(i);
                }

                int newSize = animals.Length + 3;
                string[] newArray = new string[newSize];
                for (int i = 0; i < animals.Length; i++)
                {
                    newArray[i] = animals[i];
                }
            Console.WriteLine("New Array:");
            foreach (string j in newArray)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
  

