using System;
using System.Collections.Generic;
using System.Linq;

namespace Q18
{
    public class Product
    {
        public string Name { get; set; }
        public int  Price { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 500 },
                new Product { Name = "watch", Price = 89 },
                new Product { Name = "phone", Price = 300 },
                new Product { Name = "Tablet", Price = 199 },
                new Product { Name = "Headphones", Price = 49}
            };

            var result = products.Where(p => p.Price > 100)
                                                 .OrderBy(p => p.Price)
                                                 .ToList();

            Console.WriteLine("Products priced above $100 are : ");
            foreach (var product in result)
            {
                Console.WriteLine($"{product.Name}: {product.Price}");
            }
        }
    }
}
