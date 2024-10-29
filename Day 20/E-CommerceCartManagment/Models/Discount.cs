using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCartManagment.Models
{
    public class Discount
    {
        public decimal Amount { get; set; }

        public Discount(decimal amount)
        {
            Amount = amount;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return Math.Min(Amount, total); // Ensure we don't go below zero
        }
    }
}
