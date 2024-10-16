using System;

namespace Student 
{ 
    public class SchoolStudent : Student
    {
        public string SchoolName { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, School: {SchoolName}";
        }
    }
}
