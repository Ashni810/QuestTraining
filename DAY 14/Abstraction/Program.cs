﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class CalculatorBase
    {
        public void Add(int a, int b) => Console.WriteLine(a + b);
        public void sub(int a, int b) => Console.WriteLine(a - b);
        public void Multiply(int a, int b) => Console.WriteLine(a * b);
        public virtual void Divide(int a, int b) => Console.WriteLine(a / b);

        public abstract void power(int a, int b);
    }
          class Calculator : CalculatorBase 
          {
             public override void Divide(int a, int b)
             {
                 if( b == 0)
                 {
                   Console.WriteLine("Divide by Zero is not possible");
                   return;
                 }
                 base.Divide(a, b);
             }
             public override void power(int a, int b) => Console.WriteLine(Math.Pow(a, b));
       
          }
        internal class Program
        {
          static void Main(string[] args)
          {
            Calculator c = new Calculator();
            c.Divide(8, 2);
          }
        }
}
