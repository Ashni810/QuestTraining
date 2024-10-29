using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace loglibrary
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            // Set up a simple configuration that logs on the console.
            //BasicConfigurator.Configure();
            //log.Info("Entering application.");
            //Console.WriteLine("Hello World");
            ConfigureLogging();
            try
            {
                Console.WriteLine("enter num1");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("enter num2");
                int j = int.Parse(Console.ReadLine());
                int sum = i + j;
                Console.WriteLine(sum);

            }
            catch (Exception ex)
            {
                //log.Error(ex.Message);
                log.Error(ex.StackTrace);
            }
        }
        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger %messagr%newline"
            };
            layout.ActivateOptions();
            var consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = Level.Info
            };
            var errorFileLogger = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "error.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Error,
            };
            BasicConfigurator.Configure(repository, consoleAppender, errorFileLogger);
        }


    }
}
