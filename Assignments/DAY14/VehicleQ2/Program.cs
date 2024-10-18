using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleQ2
{
    internal class Program
    {
        public abstract class Vehicle
        {
            public double Speed{ get; set; }
            public abstract void Drive();
        }
        public class Car : Vehicle 
        {
            public override void Drive()
            {
                Console.WriteLine($" The car is going at a speed of {Speed} km/hr");
            }
        }
        public class Bicycle : Vehicle
        {
            public override void Drive()
            {
                Console.WriteLine($"The Bicycle is moving at a speed of {Speed} km/hr");
            }
        }
        static void Main(string[] args)
        {
            Vehicle car = new Car{Speed = 5.5};
            Vehicle bicycle = new Bicycle{ Speed = 2.5};
            car.Drive();
            bicycle.Drive();
        }
    }
}
