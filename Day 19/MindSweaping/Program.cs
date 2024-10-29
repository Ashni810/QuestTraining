using System;

public class Minesweeper
{
    private CellState[,] grid;
    private int rows;
    private int cols;

    public Minesweeper(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        grid = new CellState[rows, cols];
        InitGrid();
    }

    private void InitGrid()
    {
        var random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                var state = (CellState)random.Next(0, 3);
                grid[i, j] = state;
            }
        }
    }

    public void DisplayGrid()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public enum CellState
    {
        Empty,
        Mine,
        Number
    }
}

class Program
{
    static void Main(string[] args)
    {
        var game = new Minesweeper(3, 3);
        game.DisplayGrid();
    }
}

