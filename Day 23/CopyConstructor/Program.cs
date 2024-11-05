using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Car
    {
        public string Color { get; set; }
        public string Name { get; set; }

        public Car()
        {
            this.Color = Color;
            this.Name = Name;

        }
        public Car(Car car)
        {
            this.Name = car.Name;
            this.Color = car.Color;
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine($"Car is {Name},in {Color}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Car defaultCar = new Car { Name = "BMW", Color = "Red" };
                defaultCar.DisplayCarDetails();
                Car copyCar = new Car(defaultCar);
                copyCar.DisplayCarDetails();
            }
        }
    }
}
