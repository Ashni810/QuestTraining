using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public int Name{ get; set; }
        public int Email{ get; set; }
        public int Phone{ get; set; }

        private int age;
        public int Age { 
            get => age;
            set
            { 
                if (value > 0 && value < 50) 
                {  
                    age = value;
                }

                 
            }
                
        }
    }
}
