using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem_.Entities.Types;
using static EmployeeManagementSystem_.Entities.Types.EmployementType;

namespace EmployeeManagementSystem_.Entities.Types
{
    internal class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EmploymentType EmploymentType { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Email})";
        }
    }
}
