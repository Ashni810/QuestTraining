using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceCartManagment.Services
{
   public class BillingService
    {
        public decimal CalculateTotal(Cart cart)
        {
            decimal total = cart.Items.Sum(item => item.TotalPrice());

            // Apply all discounts
            foreach (var discount in cart.Discounts)
            {
                total -= discount.ApplyDiscount(total);
            }

            return total;
        }
    }
}

