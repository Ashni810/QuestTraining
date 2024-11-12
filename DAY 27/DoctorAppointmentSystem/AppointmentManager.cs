using System;
using System.Collections.Generic;
using DoctorAppointmentSystem.Manager;
using DoctorAppointmentSystem.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem
{
    public class AppointmentManager : IAppointmentManager
    {
        private List<Appointment> appointments = new List<Appointment>();
        private const int WORKING_HOUR_START = 9; // 9 AM
        private const int WORKING_HOUR_END = 17; // 5 PM

        public bool BookAppointment(Patient patient, Doctor doctor, DateTime startTime, DateTime endTime)
        {
            if (!doctor.IsAvailable)
            {
                return false; // Doctor is not available
            }

            if (!IsTimeSlotAvailable(startTime, endTime))
            {
                return false; // Time slot is not available
            }

            if (!IsWithinWorkingHours(startTime, endTime))
            {
                return false; // Time is outside working hours
            }

            var appointment = new Appointment(patient, doctor, startTime, endTime);
            appointments.Add(appointment);
            return true; // Appointment booked successfully
        }

        public List<Appointment> GetAppointments()
        {
            return appointments;
        }

        public bool IsTimeSlotAvailable(DateTime startTime, DateTime endTime)
        {
            foreach (var appointment in appointments)
            {
                if (startTime < appointment.EndTime && endTime > appointment.StartTime)
                {
                    return false; // Overlap 
                }
            }
            return true; // No overlap
        }

        private bool IsWithinWorkingHours(DateTime startTime, DateTime endTime)
        {
            var startHour = startTime.TimeOfDay.Hours;
            var endHour = endTime.TimeOfDay.Hours;

            return startHour >= WORKING_HOUR_START && endHour <= WORKING_HOUR_END && startTime < endTime;
        }
    }
}
