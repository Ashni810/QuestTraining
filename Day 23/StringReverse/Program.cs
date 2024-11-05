using System;

class Program
{
    static void Main()
    {
        string original = "Hello";
        string reversed = ReverseString(original);

        Console.WriteLine("Original: " + original);
        Console.WriteLine("Reversed: " + reversed);
    }

    static string ReverseString(string str)
    {
        char[] reversedArray = new char[str.Length];
        int j = 0;

        // Fill the reversed array with characters from the end to the start
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedArray[j] = str[i];
            j++;
        }

        // Create a new string from the reversed character array
        return new string(reversedArray);

    }
}
