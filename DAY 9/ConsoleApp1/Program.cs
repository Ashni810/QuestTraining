using System;
using System.Collections.Generic;
using System.Linq;

namespace PatientDiagnosisSystem
{
    internal class Program
    {
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();

        static void AddPatient()
        {
            var patient = new Dictionary<string, string>();

            Console.WriteLine("Enter patient name: ");
            patient.Add("name", Console.ReadLine());

            Console.WriteLine("Enter the patient age: ");
            patient.Add("age", Console.ReadLine());

            Console.WriteLine("Enter the symptoms as comma separated values: ");
            patient.Add("symptoms", Console.ReadLine());

            patient.Add("id", Guid.NewGuid().ToString());

            patients.Add(patient);
            Console.WriteLine($"Patient added successfully: {patient["id"]}");
        }

        static void SearchPatient()
        {
            Console.WriteLine("Enter patient ID or name to search: ");
            string search = Console.ReadLine();

            var foundPatients = patients.Where(p => p["id"] == search || p["name"] == search).ToList();

            if (foundPatients.Any())
            {
                foreach (var patient in foundPatients)
                {
                    Console.WriteLine($"Patient ID: {patient["id"]}, Name: {patient["name"]}, Age: {patient["age"]}, Symptoms: {patient["symptoms"]}");
                }
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Search Patient");
                Console.WriteLine("3. Exit");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        SearchPatient();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}