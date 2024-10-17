using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        public enum ConvertTo
        { 
          Upper,
          Lower,
          SwapCase

        }
    public static void ConvertCasting(string input, ConvertTo targetType)
    {
        switch (targetType)
        {
            case ConvertTo.Upper:
                Console.WriteLine(input.ToUpper());
                break;
            case ConvertTo.Lower:
                Console.WriteLine(input.ToLower());
                break;

        }
    }
    
        static void Main(string[] args)
        {
            ConvertCasting("Hello", ConvertTo.SwapCase);
        }
    }
}
