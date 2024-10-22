using LibraryManagement.Data;
using LibraryManagement.Entities;
using LibraryManagment;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Repositories
{
    public class BookRepository
    {
        public GenericResponse<List<Book>> GetAllBooks()
        {
            var books = DataStore.Books;
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books
            };
        }

        public GenericResponse<Book> GetBookById(int id)
        {
            var book = DataStore.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found"
                };
            }
            return new GenericResponse<Book>
            {
                Success = true,
                Data = book
            };
        }

        public GenericResponse<List<Book>> SearchBooksByName(string name)
        {
            var books = DataStore.Books
                .Where(b => b.Name.IndexOf(name, System.StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books
            };
        }
    }
}
