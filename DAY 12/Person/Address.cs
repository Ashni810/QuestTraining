using System;

namespace Person
{
    public class Address
    {
        public string Type { get; set; } 
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Pin { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}, AddressLine1: {AddressLine1}, AdressLine2: {AddressLine2}, Pin: {Pin}";
        }
    }
}
