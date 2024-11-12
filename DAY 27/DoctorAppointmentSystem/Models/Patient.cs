using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public Patient(string name, string contactNumber, string email)
        {
            Name = name;
            ContactNumber = contactNumber;
            Email = email;
        }
    }
}
