using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayMultiplication
{
    class Program
    {
        static void Main()
        {
            // Example matrices
            int[,] matrix1 =
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int[,] matrix2 =
            {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

            int[,] result = Multiply(matrix1, matrix2);

            if (result != null)
            {
                Console.WriteLine("The product of the matrices is:");
                DisplayMatrix(result);
            }
            else
            {
                Console.WriteLine("The matrices cannot be multiplied.");
            }
        }

        static int[,] Multiply(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            // Check if matrices can be multiplied
            if (cols1 != rows2)
            {
                return null;
            }

            // Initialize the result matrix with zeros
            int[,] result = new int[rows1, cols2];

            // Perform matrix multiplication
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        static void DisplayMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
