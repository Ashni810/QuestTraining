using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string text = "Good AfterNoon !";
        string result = RemoveDuplicates(text);

        Console.WriteLine("Original: " + text);
        Console.WriteLine("Result: " + result);
    }

    static string RemoveDuplicates(string input)
    {
      var distinctChars = input.Distinct(); 
      StringBuilder sb = new StringBuilder(); 
      foreach (char c in distinctChars)
        {
            sb.Append(c);
        }
      return sb.ToString();
    }
}
