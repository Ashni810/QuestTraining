using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem.Manager
{
    public interface IAppointmentManager
    {
        bool BookAppointment(Patient patient, Doctor doctor, DateTime startTime, DateTime endTime);
        List<Appointment> GetAppointments();
        bool IsTimeSlotAvailable(DateTime startTime, DateTime endTime);
    }
}
