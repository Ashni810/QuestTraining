using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8FunctionDelegateStringLength
{
    internal class Program
    {
     
            static void Main(string[] args)
            {
                
                Func<string, int> getStringLength = str => str.Length;
                string message = "Hello, world!";
                int length = getStringLength(message);

                Console.WriteLine($"The length of '{message}' is: {length}");
            }
        
    }


}






