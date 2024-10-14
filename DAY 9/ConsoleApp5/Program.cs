using System;
using System.Collections.Generic;

class HospitalManagementSystem
{
    static List<string> departments = new List<string>();
    static List<string> doctors = new List<string>();
    static List<string> patients = new List<string>();
    static Dictionary<string, List<string>> departmentDoctors = new Dictionary<string, List<string>>();
    static Dictionary<string, List<string>> doctorPatients = new Dictionary<string, List<string>>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add Department");
            Console.WriteLine("2. Add Doctor");
            Console.WriteLine("3. Admit Patient");
            Console.WriteLine("4. List Doctors");
            Console.WriteLine("5. List Patients");
            Console.WriteLine("6. Discharge Patient");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddDepartment();
                    break;
                case 2:
                    AddDoctor();
                    break;
                case 3:
                    AdmitPatient();
                    break;
                case 4:
                    ListDoctors();
                    break;
                case 5:
                    ListPatients();
                    break;
                case 6:
                    DischargePatient();
                    break;
                case 7:
                    Console.WriteLine("Exiting");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void AddDepartment()
    {
        Console.Write("Enter department name: ");
        string departmentName = Console.ReadLine();
        departments.Add(departmentName);
        departmentDoctors[departmentName] = new List<string>();
        Console.WriteLine("Department is added successfully....");
    }

    static void AddDoctor()
    {
        Console.Write("Enter department name: ");
        string departmentName = Console.ReadLine();
        Console.Write("Enter doctor name: ");
        string doctorName = Console.ReadLine();

        if (departmentDoctors.ContainsKey(departmentName))
        {
            departmentDoctors[departmentName].Add(doctorName);
            doctors.Add(doctorName);
            doctorPatients[doctorName] = new List<string>();
            Console.WriteLine("Doctor added successfully....");
        }
        else
        {
            Console.WriteLine("Department not found.");
        }
    }

    static void AdmitPatient()
    {
        Console.Write("Enter doctor name: ");
        string doctorName = Console.ReadLine();
        Console.Write("Enter patient name: ");
        string patientName = Console.ReadLine();

        if (doctorPatients.ContainsKey(doctorName))
        {
            doctorPatients[doctorName].Add(patientName);
            patients.Add(patientName);
            Console.WriteLine("Patient admitted successfully.");
        }
        else
        {
            Console.WriteLine("Doctor not found.");
        }
    }

    static void ListDoctors()
    {
        Console.Write("Enter department name: ");
        string departmentName = Console.ReadLine();

        if (departmentDoctors.ContainsKey(departmentName))
        {
            Console.WriteLine($"Doctors in{departmentName} :");
            foreach (string doctor in departmentDoctors[departmentName])
            {
                Console.WriteLine(doctor);
            }
        }
        else
        {
            Console.WriteLine("Department not found.");
        }
    }

    static void ListPatients()
    {
        Console.Write("Enter doctor name: ");
        string doctorName = Console.ReadLine();

        if (doctorPatients.ContainsKey(doctorName))
        {
            Console.WriteLine($"Patients addmitted  to {doctorName} :");
            foreach (string patient in doctorPatients[doctorName])
            {
                Console.WriteLine(patient);
            }
        }
        else
        {
            Console.WriteLine("Doctor not found.");
        }
    }

    static void DischargePatient()
    {
        Console.Write("Enter doctor name: ");
        string doctorName = Console.ReadLine();
        Console.Write("Enter patient name: ");
        string patientName = Console.ReadLine();

        if (doctorPatients.ContainsKey(doctorName))
        {
            foreach (string patient in doctorPatients[doctorName])
            {
                if (patient == patientName)
                {
                    doctorPatients[doctorName].Remove(patientName);
                    patients.Remove(patientName);
                    Console.WriteLine("Patient discharged successfully.");
                    return;
                }
            }
            Console.WriteLine("Patient not found.");
        }
        else
        {
            Console.WriteLine("Doctor not found.");
        }
    }
}