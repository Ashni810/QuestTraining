using System;
namespace TwoDimensionArray
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            // Create a 2D array to represent the matrix
            int[,] matrix = new int[rows, columns];


            Console.WriteLine("Enter the elements of the matrix row by row:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i}, {j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Display the matrix
            Console.WriteLine("\nThe matrix is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}