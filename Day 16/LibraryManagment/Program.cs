using LibraryManagement.Repositories;
using System;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookRepository = new BookRepository();
            var memberRepository = new MemberRepository();

            // List all books
            var allBooksResponse = bookRepository.GetAllBooks();
            Console.WriteLine("All Books:");
            if (allBooksResponse.Success)
            {
                foreach (var book in allBooksResponse.Data)
                {
                    Console.WriteLine($"Book ID: {book.Id}, Name: {book.Name}, Author: {book.Author}");
                }
            }

            // Search books by name
            var searchBookName = "Book";
            var searchBooksResponse = bookRepository.SearchBooksByName(searchBookName);
            Console.WriteLine($"\nBooks containing '{searchBookName}':");
            if (searchBooksResponse.Success)
            {
                foreach (var book in searchBooksResponse.Data)
                {
                    Console.WriteLine($"Book ID: {book.Id}, Name: {book.Name}, Author: {book.Author}");
                }
            }

            // List all members
            var allMembersResponse = memberRepository.GetAllMembers();
            Console.WriteLine("\nAll Members:");
            if (allMembersResponse.Success)
            {
                foreach (var member in allMembersResponse.Data)
                {
                    Console.WriteLine($"Member ID: {member.Id}, Name: {member.Name}, Email: {member.Email}");
                }
            }

            // Search members by name
            var searchMemberName = "John";
            var searchMembersByNameResponse = memberRepository.SearchMembersByName(searchMemberName);
            Console.WriteLine($"\nMembers containing '{searchMemberName}':");
            if (searchMembersByNameResponse.Success)
            {
                foreach (var member in searchMembersByNameResponse.Data)
                {
                    Console.WriteLine($"Member ID: {member.Id}, Name: {member.Name}, Email: {member.Email}");
                }
            }

            // Search members by email
            var searchMemberEmail = "gmail";
            var searchMembersByEmailResponse = memberRepository.SearchMembersByEmail(searchMemberEmail);
            Console.WriteLine($"\nMembers containing '{searchMemberEmail}':");
            if (searchMembersByEmailResponse.Success)
            {
                foreach (var member in searchMembersByEmailResponse.Data)
                {
                    Console.WriteLine($"Member ID: {member.Id}, Name: {member.Name}, Email: {member.Email}");
                }
            }
        }
    }
}
