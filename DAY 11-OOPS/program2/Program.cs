using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Salary;

        public void TotalSalary()
        {
            Console.WriteLine($" {FirstName} {LastName} Total Salary is : {Salary * 12}");
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Ashni";
            employee.LastName = "PP";
            employee.Salary = 10_000;
            employee.TotalSalary();

            Employee employee1 = new Employee();
            employee1.FirstName = "Ash";
            employee1.LastName = "JK";
            employee1.Salary = 15_000;
            employee1.TotalSalary();

            Employee employee2 = new Employee();
            employee2.FirstName = "Miya";
            employee2.LastName = "JK";
            employee2.Salary = 20_000;
            employee2.TotalSalary();
        }
    }
}
