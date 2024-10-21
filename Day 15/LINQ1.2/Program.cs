using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1._2
{
    public class Person
    {

        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>()
            {
                new Person{Name = "Ash",Country = "US", Age =20},
                new Person{Name = "AshOK",Country = "US", Age =40},
                new Person{Name = "Amal",Country = "IN", Age =30},
                new Person{Name = "Sheena",Country = "US", Age =50}
            };
            int minAge = data.Where(p=>p.Country == "US").Min(p=>-p.Age);
            var person = data.Where(p => p.Country == "us" && p.Age == minAge).FirstOrDefault(); 
            
        }
    }
}
