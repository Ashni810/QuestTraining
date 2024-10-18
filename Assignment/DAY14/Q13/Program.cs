using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
        public abstract class Appliance
        {
            public abstract void TurnOn();
        }

        public class Fan : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine("The fan is  on.");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
            Appliance fan = new Fan();
            fan.TurnOn();
            }
        
       
        }
   
}



