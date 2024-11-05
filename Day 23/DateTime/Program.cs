using System;
namespace DateTimeDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a DateTime object for the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + now);

            // Create a Random DateTime object
            DateTime randomDate = new DateTime(2023, 10, 8, 14, 30, 0); // October 8, 2023, 2:30 PM
            Console.WriteLine("Random Date and Time: " + randomDate);

            // Add 10 days to the current date
            DateTime futureDate = now.AddDays(10);
            Console.WriteLine("Date after adding 10 days: " + futureDate);

            // Subtract 5 days from the current date
            DateTime pastDate = now.AddDays(-5);
            Console.WriteLine("Date after subtracting 5 days: " + pastDate);

            // Calculate the difference between two dates
            TimeSpan difference = randomDate - now;
            Console.WriteLine("Difference between random date and now: " + difference);

            // Get the UTC time
            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine("Current UTC Date and Time: " + utcNow);

            // Convert local time to UTC
            DateTime utcFromLocal = now.ToUniversalTime();
            Console.WriteLine("Local time converted to UTC: " + utcFromLocal);
        }
    }
}
