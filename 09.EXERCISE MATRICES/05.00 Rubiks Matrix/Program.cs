using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int comandsCount = int.Parse(Console.ReadLine());

        int rows = input[0];
        int cols = input[1];
        int[][] matrix = new int[rows][];
        int number = 1;


        for (int i = 0; i < rows; i++)
        {
            matrix[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                matrix[i][j] = number;
                number++;
            }
        }


        for (int i = 0; i < comandsCount; i++)
        {
            string[] curentComand = Console.ReadLine().Split().ToArray();

            int row = int.Parse(curentComand[0]);
            string direction = curentComand[1];
            int moves = int.Parse(curentComand[2]);

            if (direction == "down" || direction == "up")
            {
                moves = moves % matrix.Length;
                MoveColumnValues(row, direction, moves, matrix);
            }
            else if (direction == "left" || direction == "right")
            {
                moves = moves % matrix[0].Length;
                MoveRowValues(row, direction, moves, matrix);
            }
            //PrintMatrix(matrix);//Testing
        }
        RearrangeMatrix(matrix);
        //PrintMatrix(matrix);//Testing
    }

    private static void RearrangeMatrix(int[][] matrix)
    {
        int correctValue = 1;
        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[0].Length; c++)
            {
                if (matrix[r][c] != correctValue)
                {
                    SwapValues(r, c, correctValue, matrix);
                    //Console.WriteLine();//Testing
                    //PrintMatrix(matrix);//Testing
                    //Console.WriteLine();//Testing
                }
                else
                {
                    Console.WriteLine("No swap required");
                }
                correctValue++;
            }
        }
    }

    private static void SwapValues(int r, int c, int correctValue, int[][] matrix)
    {
        int swapRowIndex = 0;
        int swapColIndex = 0;

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[row][col] == correctValue)
                {
                    swapRowIndex = row;
                    swapColIndex = col;
                    break;
                }
            }
        }

        int swapValue = matrix[r][c];
        matrix[r][c] = matrix[swapRowIndex][swapColIndex];
        matrix[swapRowIndex][swapColIndex] = swapValue;
        Console.WriteLine($"Swap ({r}, {c}) with ({swapRowIndex}, {swapColIndex})");
    }

    private static void PrintMatrix(int[][] matrix)
    {
        foreach (int[] arr in matrix)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }

    private static void MoveRowValues(int rowCol, string direction, int moves, int[][] matrix)
    {
        if (moves == matrix[rowCol].Length || moves == 0)
        {
            return;
        }

        if (direction == "left")
        {
            for (int i = 0; i < moves; i++)
            {
                int tempValue = matrix[rowCol][0];
                for (int j = 0; j < matrix[rowCol].Length; j++)
                {
                    if (j == matrix[rowCol].Length - 1)
                    {
                        matrix[rowCol][j] = tempValue;
                    }
                    else
                    {
                        matrix[rowCol][j] = matrix[rowCol][j + 1];
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < moves; i++)
            {
                int tempValue = matrix[rowCol][matrix[rowCol].Length - 1];
                for (int j = matrix[rowCol].Length - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        matrix[rowCol][j] = tempValue;
                    }
                    else
                    {
                        matrix[rowCol][j] = matrix[rowCol][j - 1];
                    }
                }
            }
        }
    }
    private static void MoveColumnValues(int rowCol, string direction, int moves, int[][] matrix)
    {
        if (moves == matrix.Length || moves == 0)
        {
            return;
        }

        if (direction == "up")
        {
            for (int i = 0; i < moves; i++)
            {
                int tempValue = matrix[0][rowCol];

                for (int j = 0; j < matrix.Length; j++)
                {
                    if (j == matrix.Length - 1)
                    {
                        matrix[j][rowCol] = tempValue;
                    }
                    else
                    {
                        matrix[j][rowCol] = matrix[j + 1][rowCol];
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < moves; i++)
            {
                int tempValue = matrix[matrix.Length - 1][rowCol];
                for (int j = matrix.Length - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        matrix[j][rowCol] = tempValue;
                    }
                    else
                    {
                        matrix[j][rowCol] = matrix[j - 1][rowCol];
                    }
                }
            }
        }
    }
}