using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9ActionDelegatePrintString
{
    internal class Program
    {
       
            static void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            static void Main(string[] args)
            {
                // Define the Action delegate
                Action<string> print = PrintMessage;

                // Use the delegate to print a welcome message
                print("Welcome All");
            }
        
    }

}

