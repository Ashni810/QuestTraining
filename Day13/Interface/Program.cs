using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<IStudent>
            { 
              new SchoolStudent {Name = "John"},
              new SchoolStudent {Name = "Miya"},
              new CollegeStudent {Name = "Riya"}
            
            
            
            };
        }
    }
}
