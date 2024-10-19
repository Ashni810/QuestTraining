using BookManagementSystem.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Entities
{
    internal class Book
    {
        public string Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public decimal Price{ get; set; }
        public BookType BookType { get; set; }

        public override string ToString()
        {
            return $"{BookName} {AuthorName} {Price}";
        }

    }
}
