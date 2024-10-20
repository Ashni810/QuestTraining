using System;
using Newtonsoft.Json;
using BookManagementSystem.Entities;
using BookManagementSystem.Entities.Types;
using BookManagementSystem.Services;
namespace BookManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStorageService storageService = new JsonFileStorage();
            BookManager bookManager = new BookManager(storageService);
            bookManager.Run();
        }
    }
}
