using LibraryManagement.Entities;
using System.Collections.Generic;

namespace LibraryManagement.Data
{
    internal static class DataStore
    {
        public static List<Book> Books;
        public static List<Member> Members;

        static DataStore()
        {
            Books = new List<Book>
            {
                new Book { Id = 1, Name = "Book One", Author = "Author A" },
                new Book { Id = 2, Name = "Book Two", Author = "Author B" },
                new Book { Id = 3, Name = "Book Three", Author = "Author C" }
            };

            Members = new List<Member>
            {
                new Member { Id = 1, Name = "John", Email = "john@gmail.com" },
                new Member { Id = 2, Name = "Jane", Email = "jane@gmail.com" },
                new Member { Id = 3, Name = "Miya", Email = "miya@gmail.com" }
            };
        }
    }
}
