using System;

namespace StudentsManagementSystem
{
    public class MarkDetail
    {
        public string Subject { get; set; }
        public int MarkObtained { get; set; }
        public int MaxMark { get; set; }

        public override string ToString()
        {
            return $"{Subject}: {MarkObtained} out of {MaxMark}";
        }
    }
}
