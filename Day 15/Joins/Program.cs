using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joins
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAndTime { get; set; }

      
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<Account>
            {
                new Account { Id = 101, Name = "Account1", Balance = 1000 },
                new Account { Id = 102, Name = "Account2", Balance = 2000 },
                new Account { Id = 103, Name = "Account3", Balance = 3000 },
                new Account { Id = 104, Name = "Account4", Balance = 4000 }
            };

            var transactions = new List<Transaction>
            {
                new Transaction { Id = 1, FromAccountId = 101, ToAccountId = 102, Amount = 500, DateAndTime = DateTime.Now },
                new Transaction { Id = 2, FromAccountId = 102, ToAccountId = 101, Amount = 300, DateAndTime = DateTime.Now.AddDays(-2) },
                new Transaction { Id = 3, FromAccountId = 103, ToAccountId = 104, Amount = 700, DateAndTime = DateTime.Now.AddDays(-3) },
                new Transaction { Id = 4, FromAccountId = 101, ToAccountId = 102, Amount = 200, DateAndTime = DateTime.Now.AddDays(-4) }
            };
            var transcationDetails = Transaction
                .join(
                  accounts,
                  t => t.From
                )
                
           
        }
    }
}
