using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCartManagment.Models
{
    public class CartItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; }

        public CartItem(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public decimal TotalPrice()
        {
            return Quantity * Price;
        }
    }
}