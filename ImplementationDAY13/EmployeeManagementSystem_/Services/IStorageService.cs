using EmployeeManagementSystem_.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem_.Services
{
    internal interface IStorageService
    {
        void Save(Employee employee);

        Employee GetById(string id);

        void Delete(string id);
    }
}
