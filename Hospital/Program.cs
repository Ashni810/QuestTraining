using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
  internal class Program
    {
        
     private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashni\OneDrive\Documents\QuestDb.mdf;Integrated Security=True";

            static void Main(string[] args)
            {
                PatientManager patientManager = new PatientManager(connectionString);
                DoctorManager doctorManager = new DoctorManager(connectionString);

                while (true)
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Patient Operations");
                    Console.WriteLine("2. Doctor Operations");
                    Console.WriteLine("3. Exit");

                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        PatientOperations(patientManager);
                    }
                    else if (choice == "2")
                    {
                        DoctorOperations(doctorManager);
                    }
                    else if (choice == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
            }

            static void PatientOperations(PatientManager patientManager)
            {
                Console.WriteLine("Select Patient Operation:");
                Console.WriteLine("1. Create Patient");
                Console.WriteLine("2. Read Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        patientManager.Create();
                        break;
                    case "2":
                        patientManager.Read();
                        break;
                    case "3":
                        patientManager.Update();
                        break;
                    case "4":
                        patientManager.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            static void DoctorOperations(DoctorManager doctorManager)
            {
                Console.WriteLine("Select Doctor Operation:");
                Console.WriteLine("1. Create Doctor");
                Console.WriteLine("2. Read Doctors");
                Console.WriteLine("3. Update Doctor");
                Console.WriteLine("4. Delete Doctor");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        doctorManager.Create();
                        break;
                    case "2":
                        doctorManager.Read();
                        break;
                    case "3":
                        doctorManager.Update();
                        break;
                    case "4":
                        doctorManager.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
    

