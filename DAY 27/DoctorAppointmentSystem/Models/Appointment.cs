using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointmentSystem.Status;
namespace DoctorAppointmentSystem.Models
{
    public class Appointment
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Patient Patient { get; set; } 
        public AppointmentStatus Status { get; set; } 
        public Doctor Doctor { get; set; } 

        public Appointment(Patient patient, Doctor doctor, DateTime startTime, DateTime endTime)
        {
            Patient = patient;
            Doctor = doctor;
            StartTime = startTime;
            EndTime = endTime;
            Status = AppointmentStatus.Booked; // Default status
        }
    }
}
