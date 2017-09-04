using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int rows = input[0];
        int colums = input[1];
        int[][] matrix = new int[rows][];
        
        for (int i = 0; i < rows; i++)
        {
            int[] current = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            matrix[i] = current;

        }

        int sum = int.MinValue;
        int maxSumSquareRowIndex = 0;
        int maxSumSquareColIndex = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < colums - 2; col++)
            {
                int currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] + matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                if (currentSum > sum)
                {
                    sum = currentSum;
                    maxSumSquareRowIndex = row;
                    maxSumSquareColIndex = col;

                }
            }
        }
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine($"{matrix[maxSumSquareRowIndex][maxSumSquareColIndex]} {matrix[maxSumSquareRowIndex][maxSumSquareColIndex + 1]} {matrix[maxSumSquareRowIndex][maxSumSquareColIndex + 2]}");
        Console.WriteLine($"{matrix[maxSumSquareRowIndex + 1][maxSumSquareColIndex]} {matrix[maxSumSquareRowIndex + 1][maxSumSquareColIndex + 1]} {matrix[maxSumSquareRowIndex + 1][maxSumSquareColIndex + 2]}");
        Console.WriteLine($"{matrix[maxSumSquareRowIndex + 2][maxSumSquareColIndex]} {matrix[maxSumSquareRowIndex + 2][maxSumSquareColIndex + 1]} {matrix[maxSumSquareRowIndex + 2][maxSumSquareColIndex + 2]}");
    }
}