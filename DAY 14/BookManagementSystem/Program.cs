using BookManagementSystem;
using BookManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageService = new JsonFileStorage();
            var bookManager= new BookManager((IStorageService)storageService);
            bookManager.Run();
        }
    }
}
