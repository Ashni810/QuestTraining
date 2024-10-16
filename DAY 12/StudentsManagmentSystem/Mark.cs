using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagmentSystem
{
    class Mark
    {
        public string SubjectName;
        public int MarkObtained;
        public int MaxMark;
        public override string ToString()
        {
            return $"In Subject: {SubjectName}, Mark Obtained: {MarkObtained}, Max Mark: {MaxMark}";
        }
    }
}

