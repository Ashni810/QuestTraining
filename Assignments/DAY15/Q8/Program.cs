using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
            static void Main(string[] args)
            {
                var words = new List<string> { "apple", "banana", "cherry", "blueberry", "orange", "grape" };

                var groupedWords = words.GroupBy(w => w.Length)
                                        .OrderBy(g => g.Key)
                                        .ToDictionary(g => g.Key, g => g.ToList());

                foreach (var group in groupedWords)
                {
                    Console.WriteLine($"Length {group.Key}: {string.Join(", ", group.Value)}");
                }
            }
    }
}
