using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementSystem
{
    class Student
        {

            public string StudentName;
            public string RegNumber;
            public int Class;
            public int Mark1;
            public int Mark2;
            public int Mark3;
            public string Sub1;
            public string Sub2;
            public string Sub3;
            public int MaxMark1;
            public int MaxMark2;
            public int MaxMark3;


            public override string ToString()
            {
                return $"  The  RegNumber {RegNumber} is {StudentName} from Class {Class} \n The mark details of {StudentName} are \n {Sub1} : {Mark1} out of {MaxMark1} \n {Sub2} : {Mark2} out of {MaxMark2}\n {Sub3} : {Mark3} out of {MaxMark3} ";
            }
        
    }
}

