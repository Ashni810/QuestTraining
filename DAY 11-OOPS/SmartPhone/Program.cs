using System;
using System.Collections.Generic;

namespace SmartPhone
{
    class SmartPhone
    {
        public string BrandName;
        public string ModelName;
        public List<int> Storage;

        public void DisplayPhone()
        {
            Console.WriteLine($"The phone is a {BrandName} of {ModelName} with storage options: {string.Join(", ", Storage)} GB");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone sm1 = new SmartPhone();
            sm1.BrandName = "VIVO";
            sm1.ModelName = "VIVO T2X 5G";
            sm1.Storage = new List<int>() { 32, 64, 128, 256, 512 };
            sm1.DisplayPhone();

            Console.ReadKey();
        }
    }
}
