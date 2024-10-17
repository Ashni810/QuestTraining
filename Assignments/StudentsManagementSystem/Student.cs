using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentsManagementSystem
{
    public class Student
    {
        public string RegNumber { get; set; }
        public string StudentName { get; set; }
        public int Class { get; set; }
        public List<MarkDetail> Marks { get; set; } = new List<MarkDetail>();

        public override string ToString()
        {
            string marksString = string.Join("\n", Marks);
            return $"The RegNumber {RegNumber} is {StudentName} from Class {Class}\nThe mark details of {StudentName} are:\n{marksString}";
        }
    }
}

