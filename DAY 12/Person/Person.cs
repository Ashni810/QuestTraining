using System;
using System.Collections.Generic;

namespace Person
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

       

        public override string ToString()
        {
            string addressDetails = string.Join("; ", Addresses);
            return $"Name: {Name}\n Email: {Email}\n Addresses: {addressDetails}\n";
        }
    }
}
