using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   Q16
{
    internal class Program
    {
        class Employee
        {
            public virtual double CalculateBonus() => 120.00;
        }
        class Manager : Employee
        {
            public override double CalculateBonus() => 2000;
        }
        static void Main(string[] args)
        {
            var emp = new Employee();
            var mng = new Manager();
            Console.WriteLine($"Employee Bonus:{emp.CalculateBonus()}");
            Console.WriteLine($"Manager Bonus :{mng.CalculateBonus()}");
        }
    }
}