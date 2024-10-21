using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareManagementSystem
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition { get; set; }
    }

    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentType { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var patients = new List<Patient>
            {
                new Patient { Id = 1, Name = "Shymala", Age = 65, Gender = "F", MedicalCondition = "Diabetes" },
                new Patient { Id = 2, Name = "Sam", Age = 70, Gender = "M", MedicalCondition = "Heart Disease" },
                new Patient { Id = 3, Name = "James", Age = 55, Gender = "M", MedicalCondition = "Asthma" },
                new Patient { Id = 4, Name = "David", Age = 45, Gender = "M", MedicalCondition = "Diabetes" }
            };

            var appointments = new List<Appointment>
            {
                new Appointment { Id = 1, PatientId = 1, DoctorName = "Dr. Smith", AppointmentDate = DateTime.Now.AddDays(5), AppointmentType = "Consultation" },
                new Appointment { Id = 2, PatientId = 2, DoctorName = "Dr. Ashni", AppointmentDate = DateTime.Now.AddDays(6), AppointmentType = "Surgery" },
                new Appointment { Id = 3, PatientId = 1, DoctorName = "Dr. Smith", AppointmentDate = DateTime.Now.AddDays(-5), AppointmentType = "Follow-up" },
                new Appointment { Id = 4, PatientId = 3, DoctorName = "Dr. Miya", AppointmentDate = DateTime.Now.AddDays(10), AppointmentType = "Consultation" },
                new Appointment { Id = 5, PatientId = 4, DoctorName = "Dr. Jacob", AppointmentDate = DateTime.Now.AddDays(-2), AppointmentType = "Follow-up" }
            };

            // 1. List all patients with upcoming appointments within the next 7 days
            var upcomingAppointments = patients.Join(appointments,
                p => p.Id,
                a => a.PatientId,
                (p, a) => new { Patient = p, Appointment = a })
                .Where(pa => pa.Appointment.AppointmentDate >= DateTime.Now &&
                             pa.Appointment.AppointmentDate <= DateTime.Now.AddDays(7))
                .Select(pa => new
                {
                    pa.Patient.Name,
                    pa.Patient.Age,
                    pa.Patient.MedicalCondition
                }).ToList();

            Console.WriteLine("Upcoming Appointments in the next 7 days:");
            foreach (var appointment in upcomingAppointments)
            {
                Console.WriteLine($"Name: {appointment.Name}, Age: {appointment.Age}, Medical Condition: {appointment.MedicalCondition}");
            }

            // 2. Group patients by their Medical Condition with upcoming appointments
            var groupedByCondition = patients.Join(appointments,
                p => p.Id,
                a => a.PatientId,
                (p, a) => new { Patient = p, Appointment = a })
                .Where(pa => pa.Appointment.AppointmentDate >= DateTime.Now &&
                             pa.Appointment.AppointmentDate <= DateTime.Now.AddDays(7))
                .GroupBy(pa => pa.Patient.MedicalCondition)
                .Select(g => new
                {
                    MedicalCondition = g.Key,
                    Count = g.Count()
                }).ToList();

            Console.WriteLine("\nPatients grouped by Medical Condition:");
            foreach (var group in groupedByCondition)
            {
                Console.WriteLine($"{group.MedicalCondition}: {group.Count}");
            }

            // 3. Find the patient(s) with the most appointments in the last 30 days
            var mostAppointments = patients.Join(appointments,
                p => p.Id,
                a => a.PatientId,
                (p, a) => new { Patient = p, Appointment = a })
                .Where(pa => pa.Appointment.AppointmentDate >= DateTime.Now.AddDays(-30))
                .GroupBy(pa => pa.Patient.Id)
                .Select(g => new
                {
                    PatientId = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(g => g.Count)
                .ToList();

            var maxCount = mostAppointments.First().Count;
            var patientsWithMostAppointments = mostAppointments.Where(pa => pa.Count == maxCount)
                .Select(pa => pa.PatientId)
                .ToList();

            var patientsDetails = patients.Where(p => patientsWithMostAppointments.Contains(p.Id)).ToList();

            Console.WriteLine("\nPatient(s) with the most appointments in the last 30 days:");
            foreach (var patient in patientsDetails)
            {
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Medical Condition: {patient.MedicalCondition}");
            }

            // 4. List patients over age 60 with their most recent appointment
            var patientsOver60 = patients.Where(p => p.Age > 60)
                .Join(appointments,
                    p => p.Id,
                    a => a.PatientId,
                    (p, a) => new { Patient = p, Appointment = a })
                .GroupBy(pa => pa.Patient.Id)
                .Select(g => g.OrderByDescending(pa => pa.Appointment.AppointmentDate).First())
                .Select(pa => new
                {
                    pa.Patient.Name,
                    pa.Appointment.DoctorName,
                    pa.Appointment.AppointmentDate,
                    pa.Appointment.AppointmentType
                }).ToList();

            Console.WriteLine("\nPatients over age 60 with their most recent appointment:");
            foreach (var pa in patientsOver60)
            {
                Console.WriteLine($"Name: {pa.Name}, Doctor: {pa.DoctorName}, Date: {pa.AppointmentDate}, Type: {pa.AppointmentType}");
            }
        }
    }
}
