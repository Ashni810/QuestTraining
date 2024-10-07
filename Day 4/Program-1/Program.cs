using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var numbers = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            Console.WriteLine("Enter the input :");
            string input = Console.ReadLine();
            var inputItems = input.Replace(" ", "").Split(',');
            var sb = new StringBuilder();
            foreach (var item in numbers)
            {
              if (item.Length <= 2)
                {
               int number = int.Parse(item);
              string text = numbers[number - 1];
              sb.Append($"{text},");
            }
            else
            {
                 sb.Append($"{ item}, ");

              }    
             }
             Console.WriteLine(sb.ToString());
        }
    }
}
