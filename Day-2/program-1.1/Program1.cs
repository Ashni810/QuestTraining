using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ashni";
              string lastName = "Ashok";
              int age = 22;
              string fName = $"{firstName}{lastName} is {age} years old ";
              Console.WriteLine(fName);
        }
    }
}
