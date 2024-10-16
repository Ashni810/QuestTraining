using System;

namespace Student
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Address: {Address}";
        }
    }
}
