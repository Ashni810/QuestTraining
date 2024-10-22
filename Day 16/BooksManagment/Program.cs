using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BookInserter
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Book One", Author = "Author A", Year = 2001, Genre = "Fiction" },
                new Book { Id = 2, Title = "Book Two", Author = "Author B", Year = 2002, Genre = "Non-Fiction" },
                new Book { Id = 3, Title = "Book Three", Author = "Author C", Year = 2003, Genre = "Science Fiction" },
                new Book { Id = 4, Title = "Book Four", Author = "Author D", Year = 2004, Genre = "Fantasy" },
                new Book { Id = 5, Title = "Book Five", Author = "Author E", Year = 2005, Genre = "Mystery" }
            };

            InsertBooksIntoDatabase(books);
        }

        public static void InsertBooksIntoDatabase(List<Book> books)
        {
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashni\OneDrive\Documents\QuestDb.mdf;Integrated Security=True";

            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();

                foreach (var book in books)
                {
                    var query = "INSERT INTO Books (Id, Title, Author, Year, Genre) VALUES (@Id, @Title, @Author, @Year, @Genre)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", book.Id);
                        command.Parameters.AddWithValue("@Title", book.Title);
                        command.Parameters.AddWithValue("@Author", book.Author);
                        command.Parameters.AddWithValue("@Year", book.Year);
                        command.Parameters.AddWithValue("@Genre", book.Genre);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
    }
}

