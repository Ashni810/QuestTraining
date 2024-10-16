using System;
using System.Collections.Generic;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            person1.Name = "Ashni";
            person1.Email = "123@gmail.com";
            var addresses1 = new List<Address>
            {
                new Address { Type = "Home",AddressLine1 = "soccer city", AddressLine2 = "Apt 48B", Pin = "12345 \n" },
                new Address { Type = "Office", AddressLine1 = "Wing complex", AddressLine2 = "Suite 300", Pin = "678905" }
            };

            var person2 = new Person();
            person2.Name = "Malu";
            person2.Email = "345@yahoo.com";
            var addresses2 = new List<Address>
            {
                new Address { Type = "Home",AddressLine1 = "345 Main St",AddressLine2 = "Apt 8B", Pin = "670305\n" },
               
            };

            person1.Addresses = addresses1;
            person2.Addresses = addresses2;

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}

