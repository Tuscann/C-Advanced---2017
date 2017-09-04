using System;
using System.Linq;
class MaximalSum
{
    static void Main() // 100/100
    {
        int[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

        int rows = dimentions[0];
        int cols = dimentions[1];
        int[][] source = new int[rows][];
        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            source[row] =Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
        }

        matrix = To2D(source);
        
        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int tmpSum = CalcSum(row, col, matrix);
                
                if (tmpSum > maxSum)
                {
                    maxRow = row;
                    maxCol = col;
                    maxSum = tmpSum;
                }
            }
        }
        
        Console.WriteLine("Sum = {0}", maxSum);
        PrintMatrix(matrix, maxRow, maxCol);
    }

    private static void PrintMatrix(int[,] matrix, int maxRow, int maxCol)
    {
        for (int rows = maxRow; rows <= maxRow + 2; rows++)
        {
            for (int cols = maxCol; cols <= maxCol + 2; cols++)
            {
                Console.Write("{0} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    // takes a starting point and calculates the sum in starting cell + 2 cells to the right, starting cell plus 2 cells down
    static int CalcSum(int startRow, int startCol, int[,] matrix)
    {
        int sum = 0;
        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                sum = sum + matrix[row, col];
            }
        }

        return sum;
    }

    static T[,] To2D<T>(T[][] source)
    {
        int firstDim = source.Length;
        int secondDim = source.GroupBy(row => row.Length).Single().Key;

        var result = new T[firstDim, secondDim];
        for (int i = 0; i < firstDim; ++i)
        {
            for (int j = 0; j < secondDim; ++j)
            {
                result[i, j] = source[i][j];
            }
        }
        return result;
    }
}