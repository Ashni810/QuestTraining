using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leastMost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
    //    static void Main()
    //    {
    //        string input = "Hello, World!";

    //        // Print the original string
    //        Console.WriteLine($"Original String: {input}");

    //        // Get the character occurances
    //        var charOccurances= GetCharacterOccurances(input);

    //        // Find the most and least occurring characters
    //        var mostOccurringChar = charOccurances.OrderByDescending(x => x.Value).First().Key;
    //        var leastOccurringChar = charOccurances.OrderBy(x => x.Value).First().Key;

    //        // Print the most and least occurring characters
    //        Console.WriteLine($"Most Occurring Character: {mostOccurringChar}");
    //        Console.WriteLine($"Least Occurring Character: {leastOccurringChar}");
    //    }

    //    static Dictionary<char, int> GetCharacterOccurances(string input)
    //    {
    //        var occurances = new Dictionary<char, int>();

    //        foreach (var c in input)
    //        {
    //            if (char.IsLetterOrDigit(c))
    //            {
    //                if (occurances.ContainsKey(c))
    //                {
    //                    occurances[c]++;
    //                }
    //                else
    //                {
    //                    occurances[c] = 1;
    //                }
    //            }
    //        }

    //        return occurances;
    //    }

        // using linq
    
        static void Main()
        {
            // Input string
            string input = "Hello Guys,Hi GoodAfternoon";

            // Count occurrences and find most and least occurring characters
            var characterCounts = input
                .GroupBy(c => c)  // Group by character
                .Select(g => new { Character = g.Key, Count = g.Count() }) // Create anonymous type
                .ToList();   // Convert to list

            // Most occurring character
            var mostOccurring = characterCounts
                .OrderByDescending(x => x.Count)
                .FirstOrDefault();

            // Least occurring character
            var leastOccurring = characterCounts
                .OrderBy(x => x.Count)
                .FirstOrDefault();

            // Output 
            Console.WriteLine($"Most Occurring Character: '{mostOccurring.Character}' with {mostOccurring.Count} occurrences");
            Console.WriteLine($"Least Occurring Character: '{leastOccurring.Character}' with {leastOccurring.Count} occurrences");
        }
    }
}
