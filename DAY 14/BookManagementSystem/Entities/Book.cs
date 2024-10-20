using BookManagementSystem.Entities.Types;
namespace BookManagementSystem.Entities
{
    public class Book
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
