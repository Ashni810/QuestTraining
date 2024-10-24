using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Types;
namespace Hospital.Models
{
    public class Patient : Person
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string MedicalCondition { get; set; }
    }
}
