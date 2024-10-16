using System;

namespace Student
{
    public class CollegeStudent : Student
    {
        public string CollegeName { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}, College: {CollegeName}";
        }
    }
}
