using System;
class SudokuSolver
{
    private static bool IsCellValid(int[,] board, int row, int col, int num)
    {
        for (int i = 0; i < 9; i++)
        {
            if (board[row, i] == num || board[i, col] == num)
            {
                return false;
            }
        }
        int rowStart = row - (row % 3);
        int colStart = col - (col % 3);
        for (int i = rowStart; i < rowStart + 3; i++)
        {
            for (int j = colStart; j < colStart + 3; j++)
            {
                if (board[i, j] == num)
                {
                    return false;
                }
            }
        }
        return true;
    }
    private static bool SolveSudoku(int[,] board)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row, col] == 0)
                {
                    for (int num = 1; num <= 9; num++)
                    {
                        if (IsCellValid(board, row, col, num))
                        {
                            board[row, col] = num;
                            if (SolveSudoku(board))
                            {
                                return true;
                            }
                            board[row, col] = 0;
                        }
                    }

                    return false;
                }
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        int[,] board = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            Console.Write("Enter row {0}: ", i + 1);
            string input = Console.ReadLine();
            for (int j = 0; j < 9; j++)
            {
                if (input[j] == ' ') // Empty cell
                {
                    board[i, j] = 0;
                }
                else
                {
                    board[i, j] = Convert.ToInt32(input[j].ToString());
                }
            }
        }
        if (SolveSudoku(board))
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No solution found!");
        }
        Console.ReadKey();
    }
}
