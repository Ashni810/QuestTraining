using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int,int) data = (2,3) ;
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
        }
    }
}
