using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IStudent
    {
        public string Name { get; set; }
        public const string CollegeName = "CETKR";

        public void Display() 
        {
            Console.WriteLine($"Student {Name} | collegeName {CollegeName}");
        }
    }
}
