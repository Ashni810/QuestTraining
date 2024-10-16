using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagmentSystem
{
    class Student
    {
        public string RegNumber;
        public string StudentName;
        public int ClassName;
        public List<Mark> Marks;
        public Student()
        {
            Marks = new List<Mark>();
        }

        public override string ToString()
        {
            string marksDetails = string.Join(", ", Marks); 
            return $"RegNumber: {RegNumber} is {StudentName} from {ClassName} Marks details are {marksDetails}";
        }
    }
}




