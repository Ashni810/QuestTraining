using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyLINQ
{  public class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int  Balence { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new List<Account>
            {
                new Account { ID =1, Name ="ashni",Balence = 20000},
                new Account { ID =2, Name ="niha",Balence = 200 }
            };
            if (account.Any(a=>a.Balence==0)) 
            {
                Console.WriteLine("Theres is an account with balence 0");
            }
            else 
            {
                Console.WriteLine("n ot found");
            }

            if (account.All(a => a.Balence == 0))
            {
                Console.WriteLine(" there is ");
            }
        }
    }

   
}
