using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Local date and Time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            //UTC Time
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);

            Console.WriteLine($"Day: {dt.Day}");
            Console.WriteLine($"Month: {dt.Month}");
            Console.WriteLine($"Year: {dt.Year}");

            Console.WriteLine($"Hour: {dt.Hour}");
            Console.WriteLine($"Minute: {dt.Minute}");
            Console.WriteLine($"Second: {dt.Second}");
            Console.WriteLine($"Millisecond: {dt.Millisecond}");

            // Formatting the output

            Console.WriteLine("____________");
            Console.WriteLine($"Standard Output : {dt}");
            Console.WriteLine($"Standard Output : {dt}");
            Console.WriteLine(dt.ToString("dd-MM-yyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyy "));

            // Constructing Date Time

           
        }

    }
}
