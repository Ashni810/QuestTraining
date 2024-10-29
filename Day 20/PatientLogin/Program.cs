using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.IO;

namespace PatientLogin
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            ConfigureLogging();
            
            try
            {
                Console.WriteLine("Enter Patient Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Patient Age:");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Patient Diagnosis:");
                string diagnosis = Console.ReadLine();

                // Create a new patient object
                Patient patient = new Patient(name, age, diagnosis);

                // Log patient information
                log.Info(patient.ToString());

                Console.WriteLine("Patient information logged successfully.");
            }
            catch (Exception e)
            {
                log.Error("An error occurred while logging patient information.", e);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();

            var consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = Level.Info
            };

            var errorFileLogger = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "patientlog.txt"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Info,
            };

            BasicConfigurator.Configure(repository, consoleAppender, errorFileLogger);
        }
    }

}