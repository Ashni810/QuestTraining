using System;

namespace Student
{
    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Pin { get; set; }

        public override string ToString()
        {
            return $"{Line1}, {Line2}, {Pin}";
        }
    }
}
