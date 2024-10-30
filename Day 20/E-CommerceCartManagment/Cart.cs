using E_CommerceCartManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCartManagment
{
    public class Cart
    {
        public List<CartItem> Items  = new List<CartItem>();
        public List<Discount> Discounts  = new List<Discount>();

        public void AddItem(CartItem item)
        {
            Items.Add(item);
        }

        public void UpdateItem(string name, int quantity)
        {
            var item = Items.FirstOrDefault(i => i.Name == name);
            if (item != null)
            {
                item.Quantity += quantity;
            }
            else
            {
                Console.WriteLine($"Item '{name}' not found in the cart.");
            }
        }

        public void RemoveItem(string name)
        {
            Items.RemoveAll(i => i.Name == name);
        }
    }
}
