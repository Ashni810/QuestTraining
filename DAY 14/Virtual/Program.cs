﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
     
    internal class Program
    {
        class StudentBase
        {
            public String Name { get; set; }
            public virtual void Display() => Console.WriteLine(Name);
        }

        class Student : StudentBase 
        {
            public string Grade {  get; set; }
            public override void Display() => Console.WriteLine(Name + " "+Grade);
        }
        static void Main(string[] args)
        {
            var s = new Student() { Name = "Ashni", Grade = "A" };
            s.Display();

        }
    }
}
