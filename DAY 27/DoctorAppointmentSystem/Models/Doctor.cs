using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem.Models
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public bool IsAvailable { get; set; }

        public Doctor(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
            IsAvailable = true; // Default to available
        }

        public void SetAvailability(bool availability)
        {
            IsAvailable = availability;
        }
    }
}