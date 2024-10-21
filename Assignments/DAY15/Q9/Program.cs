using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int>() {1,2, 3, 4, 5,10,20,15,8,7};
            var result = data.Max();
            Console.WriteLine(result);
        }
    }
}
