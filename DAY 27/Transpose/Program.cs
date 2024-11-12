using System;

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

        // Calculate the transpose of the matrix
        int[,] transpose = new int[columns, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        Console.WriteLine("\nThe original matrix is:");
        DisplayMatrix(matrix, rows, columns);

        Console.WriteLine("\nThe transpose of the matrix is:");
        DisplayMatrix(transpose, columns, rows);
    }

    static void DisplayMatrix(int[,] matrix, int rows, int columns)
    {
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