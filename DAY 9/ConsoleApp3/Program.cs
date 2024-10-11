using System;
using System.Collections;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    class Program
    {
        static Dictionary<string, Dictionary<string, object>> inventory = new Dictionary<string, Dictionary<string, object>>();

        static void AddProduct()
        {
            Console.WriteLine("Enter product ID: ");
            string productId = Console.ReadLine();

            Console.WriteLine("Enter product name: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter product price: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter initial stock quantity: ");
            int initialStock = int.Parse(Console.ReadLine());

            if (!inventory.ContainsKey(productId))
            {
                inventory.Add(productId, new Dictionary<string, object>
                {
                    { "Name", productName },
                    { "Price", productPrice },
                    { "Stock", initialStock }
                });
                Console.WriteLine("Product is added successfully.");
            }
            else
            {
                Console.WriteLine("Product ID is already exists. ");
            }
        }

        static void UpdateStock()
        {
            Console.WriteLine("Enter product ID: ");
            string productId = Console.ReadLine();

            if (inventory.ContainsKey(productId))
            {
                Console.WriteLine("Enter new stock quantity: ");
                int newStock = int.Parse(Console.ReadLine());

                inventory[productId]["Stock"] = newStock;
                Console.WriteLine("Stock is updated successfully.");
            }
            else
            {
                Console.WriteLine("Product ID not found.");
            }
        }

        static void GetProductDetails()
        {
            Console.WriteLine("Enter the product ID: ");
            string productId = Console.ReadLine();

            if (inventory.ContainsKey(productId))
            {
                Dictionary<string, object> product = inventory[productId];
                Console.WriteLine($"Product ID: {productId}, Name: {product["Name"]}, Price: {product["Price"]}, Stock: {product["Stock"]}");
            }
            else
            {
                Console.WriteLine("Product ID not found.");
            }
        }

        static void GetLowStockProducts()
        {
            Console.WriteLine("Enter Low Stock Level : ");
            int LowStock  = int.Parse(Console.ReadLine());

            List<string> lowStockProducts = new List<string>();

            foreach (var product in inventory)
            {
                if ((int)product.Value["Stock"] < LowStock)
                {
                    lowStockProducts.Add(product.Key);
                }
            }

            if (lowStockProducts.Count > 0)
            {
                Console.WriteLine("Products with Low Stock :");
                foreach (var productId in lowStockProducts)
                {
                    Dictionary<string, object> product = inventory[productId];
                    Console.WriteLine($"Product ID: {productId}, Name: {product["Name"]}, Price: {product["Price"]}, Stock: {product["Stock"]}");
                }
            }
            else
            {
                Console.WriteLine("No products with Low Stock.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Get Product Details");
                Console.WriteLine("4. Get Low Stock Products");
                Console.WriteLine("5. Exit");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateStock();
                        break;
                    case "3":
                        GetProductDetails();
                        break;
                    case "4":
                        GetLowStockProducts();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}