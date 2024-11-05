using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the array to be sorted
        int[] array = { 5, 3, 8, 1, 2, 7 };

        // Print the original array
        Console.WriteLine("Original array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Sort the array in descending order using Bubble Sort
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Compare adjacent elements
                if (array[j] < array[j + 1])
                {
                    // Swap if the current element is less than the next element
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        // Print the sorted array
        Console.WriteLine("Sorted array in descending order:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}