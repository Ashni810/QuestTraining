using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital
{
    public class Doctor : Person
    {
        public Specialization Specialization { get; set; }
        public int? PatientId { get; set; } 
    }
}
