using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    class Animal
    {
        public virtual void MakeSound() => Console.WriteLine("Sound");
    }
    class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Bark");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal = new Dog();
            animal.MakeSound();
        }
    }
}