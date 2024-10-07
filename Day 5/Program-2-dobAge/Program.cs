using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2_dobAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date of birth (yyyy-mm-dd)");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - dob.Year;
            Console.WriteLine("age = " + age);
        }
        }
    }
