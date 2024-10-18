using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalQ3
{
    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("The Dog Barks Loudly");
        }
    }

    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("The Cat says MeWow...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            dog.Speak();
            IAnimal cat = new Cat();
            cat.Speak();
        }
    }
}
