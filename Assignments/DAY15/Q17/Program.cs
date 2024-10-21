using System;
using System.Collections.Generic;
using System.Linq;

namespace Q17
{
    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int DId { get; set; }
        public string DName { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { EId = 1, EName = "Employee1", DepartmentId = 1 },
                new Employee { EId = 2, EName = "Employee2", DepartmentId = 2 },
                new Employee { EId = 3, EName = "Employee3", DepartmentId = 1 },
                new Employee { EId = 4, EName = "Employee4", DepartmentId = 3 }
            };

            var departments = new List<Department>
            {
                new Department { DId = 1, DName = "HR" },
                new Department { DId = 2, DName = "Marketing" },
                new Department { DId = 3, DName = "Engineering" }
            };

            var employeeDepartments = from emp in employees
                                      join dept in departments on emp.DepartmentId equals dept.DId
                                      select new
                                      {
                                          emp.EName,
                                          DepartmentName = dept.DName
                                      };

            
            foreach (var empDept in employeeDepartments)
            {
                Console.WriteLine($"{empDept.EName}:{empDept.DepartmentName}");
            }
        }
    }
}

