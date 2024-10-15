using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {      
            public string Name;
            public int Age;
            public int Mark1;
            public int Mark2;
            public int Mark3;

            public int TotalMark
            {
                get { return Mark1 + Mark2 + Mark3; }
            }
        
    }
}
