using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Employee
    {
        public string Name { get; set; }
        public static string CompanyName { get; set; }
        public override string ToString() => $"Name:{Name}, Company:{CompanyName}";
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.CompanyName = "OLD name";
            var e1 = new Employee();
            var e2 = new Employee();
        }
    }
}
