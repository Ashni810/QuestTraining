using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandiling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two numbers:");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());

                Console.WriteLine(i / j);


            }
            catch(OverflowException) 
            {
                Console.WriteLine("Number too large.");
            }
            catch(DivideByZeroException) 
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch(FormatException)
            {
                Console.WriteLine("please enter a vaild number.");
            } catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                
            }
           

        }
    }
}
