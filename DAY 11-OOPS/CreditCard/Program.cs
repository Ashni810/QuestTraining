using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Enter credit card details:");
                Console.Write("Card Number: ");
                int cardNumber =int.Parse(Console.ReadLine());
                Console.Write("Card Holder Name: ");
                string cardHolderName = Console.ReadLine();
                Console.Write("Expiration Date (MM/yy): ");
                string expirationDate = Console.ReadLine();
                Console.Write("CVV: ");
                int cvv = int.Parse(Console.ReadLine());

                CreditCard creditCard = new CreditCard();
                creditCard.cardNumber = cardNumber;
                creditCard.cardHolderName = cardHolderName;
                creditCard.expirationDate = expirationDate;
                creditCard.cvv = cvv;

                Console.WriteLine("Credit Card Details:");
                Console.WriteLine($"Card Number: {creditCard.cardNumber}, Card Holder Name: {creditCard.cardHolderName}, Expiration Date: {creditCard.expirationDate}, CVV: {creditCard.cvv}");
            
        }

    }
}
