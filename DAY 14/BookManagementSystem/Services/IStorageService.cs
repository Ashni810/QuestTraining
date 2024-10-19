using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Services
{
    internal interface IStorageService
    {

        void Save(Book book);

       Book GetById(string id);

        void Delete(string id);

        Book Search(string name);
    }
}
