using BookManagementSystem.Entities;
using BookManagementSystem.Entities.Types;
using BookManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    internal class BookManager
    {
        private readonly IStorageService _storageService;
        public BookManager(IStorageService storageService)
        {
            _storageService = storageService;
        }

        

        public void Add()
        {
            var book = new Book();
            Console.WriteLine("Enter the Book Id :");

            book.Id = Console.ReadLine();

            book.Id =Guid.NewGuid().ToString();

            Console.Write(" Enter the Book Name: ");
            book.BookName = Console.ReadLine();

            Console.Write("Enter the Author Name: ");
            book.AuthorName = Console.ReadLine();

            Console.WriteLine("Enter the Price: ");
            book.Price = decimal.Parse (Console.ReadLine());

            Console.Write("Book Type: 1. Novel 2. ShortStory 3.Poems : ");
            var bookType = Console.ReadLine();
            book.BookType = bookType == "1" ? BookType.Novel : bookType == "2" ? BookType.ShortStory : BookType.Poem;
            Console.WriteLine("Bood Detailes Added Sucessfully");


            _storageService.Save(book);
        }

        public void Remove()
        {
            Console.Write("Enter the Book id: ");
            var id = Console.ReadLine();
           _storageService.Delete(id);
        }

        public void Search()
        {
            Console.Write("Enter the name of the Book: ");
            var name = Console.ReadLine();

            var book = _storageService.Search(name);
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            Console.WriteLine(book);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Delete Book");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Search();
                        break;
                    case "3":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}


