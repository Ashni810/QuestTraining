﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardSystem
{
    public class CreditCard
    {
        public string CardHolderName;
        public int CardNumber;
        public byte ExpiryMonth;
        public byte ExpiryYear;
        public int Cvc;

        public override string ToString()
        {
            return $"Card Holder Name: {CardHolderName}\n Number: {CardNumber}\n Expiry: {ExpiryMonth}/{ExpiryYear}\n CVC: {Cvc}";
        }
    }
}