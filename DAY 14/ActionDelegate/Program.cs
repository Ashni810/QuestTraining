﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    internal class Program
    {
        static void Greet() => Console.WriteLine("Hello");
        static void GreetByMessage(string message) => Console.WriteLine(message);
        static void Add(int a , int b) => Console.WriteLine(a + b);
  static void Main(string[] args)
        {
            Action g = Greet;
            Action<string> gm = GreetByMessage;
            Action<int ,int> a = Add;
            g();
            gm("Quys");
            a(1,2);
                

        }
    }
}
