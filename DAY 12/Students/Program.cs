using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student();
            var marks = new List<Student>();
            {
                new Mark { Subject = "English", MarkObtained = 45 },
                new Mark { Subject = "Physics", MarkObtained = 45 },
           };

            s1.Marks = marks;
          
        }
    }
}
