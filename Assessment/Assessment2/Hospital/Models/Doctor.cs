using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Types;
namespace Hospital.Models
{
   
        public class Doctor : Person
        {
            public Specialization Specialization { get; set; }
            public int? PatientId { get; set; }
        }
    
}
