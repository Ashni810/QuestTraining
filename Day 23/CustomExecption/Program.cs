using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class Program
    {
        class MyCustomExcetion : Exception
        {
            public string Message { get; set; }
            public MyCustomExcetion(string message)
            {
                Message = message;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a positive number : ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new MyCustomExcetion("Number can not be negative");
                }
                Console.WriteLine($"You enterted : {number}");
            }
            catch (MyCustomExcetion ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}