using E_CommerceCartManagment.Models;
using E_CommerceCartManagment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCartManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a  cart
            Cart cart = new Cart();

            // Add items
            cart.AddItem(new CartItem("Apple", 2, 25.00m)); 
            cart.AddItem(new CartItem("Banana", 3, 10.00m));
            cart.AddItem(new CartItem("Grapes", 4, 15.00m));

            // Update an item
            cart.UpdateItem("Apple", 5); // Change quantity of apples to 5
            cart.UpdateItem("Banana", 4);  // Change quantity of apples to 5
            cart.UpdateItem("Berry", 4);
            
            // Apply a flat discount
            cart.Discounts.Add(new Discount(15.00m)); // 15.00 flat discount

            // Calculate total
            BillingService billingService = new BillingService();
            decimal total = billingService.CalculateTotal(cart);
            Console.WriteLine($"Total after discounts: Rs {total}");
        }
    }
}
