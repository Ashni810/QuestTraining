using DoctorAppointmentSystem.Manager;
using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IAppointmentManager appointmentManager = new AppointmentManager();

            // Create some doctors
            Doctor doctor1 = new Doctor("Dr. Smith", "Cardiology");
            Doctor doctor2 = new Doctor("Dr. Miya", "Dermatology");

            // Create some patients
            Patient patient1 = new Patient("Ryan", "823-456-7890", "ryankk@gmail.com");
            Patient patient2 = new Patient("Ashni Ashok", "987-654-3210", "ash345@gmail.com");
            Patient patient3 = new Patient("Nyra", "755-456-3515", "nyra123@gmail.com");

            // bookings
            Console.WriteLine("Booking appointment for John Doe with Dr. Smith.");
            bool booked1 = appointmentManager.BookAppointment(patient1, doctor1,
                new DateTime(2023, 10, 1, 10, 0, 0),
                new DateTime(2023, 10, 1, 11, 0, 0));
            Console.WriteLine(booked1 ? "Appointment booked successfully." : "Failed to book appointment.");

            Console.WriteLine("Booking appointment for Jane Smith with Dr. Miya.");
            bool booked2 = appointmentManager.BookAppointment(patient2, doctor2,
                new DateTime(2023, 10, 1, 11, 0, 0),
                new DateTime(2023, 10, 1, 12, 0, 0));
            Console.WriteLine(booked2 ? "Appointment booked successfully." : "Failed to book appointment.");

            // Overlapping appointment
            Console.WriteLine("Attempting to book overlapping appointment for Nyra with Dr. Smith.");
            bool booked3 = appointmentManager.BookAppointment(patient3, doctor1,
                new DateTime(2023, 10, 1, 10, 30, 0),
                new DateTime(2023, 10, 1, 11, 30, 0));
            Console.WriteLine(booked3 ? "Appointment booked successfully." : "Failed to book appointment.");

            // Display all appointments
            Console.WriteLine("\nAll Appointments:");
            List<Appointment> appointments = appointmentManager.GetAppointments();
            foreach (var appointment in appointments)
            {
                Console.WriteLine($"Patient: { appointment.Patient.Name}, Doctor: {appointment.Doctor.Name} , Start: {appointment.StartTime} ,End:{appointment.EndTime},Status: {appointment.Status}");

            }
        }
    }
}
