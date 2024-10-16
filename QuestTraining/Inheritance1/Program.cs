using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Animal
    {
        public string Name { get; set; }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");

        }


        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
