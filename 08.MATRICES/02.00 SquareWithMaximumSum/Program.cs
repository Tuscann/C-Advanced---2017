using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] size = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int rows = size[0];
        int colums = size[1];
        int[,] matrix = new int[rows, colums];
        int sum = int.MinValue;
        int[,] resultMatrix = new int[2, 2];

        for (int r = 0; r < rows; r++)
        {
            int[] curentRow = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int c = 0; c < colums; c++)
            {
                matrix[r, c] = curentRow[c];
            }
        }
        for (int r = 0; r < matrix.GetLength(0) - 1; r++)
        {
            for (int c = 0; c < matrix.GetLength(1) - 1; c++)
            {
                int squareSum = matrix[r, c] + matrix[r, c + 1] + matrix[r + 1, c] + matrix[r + 1, c + 1];

                if (squareSum > sum)
                {
                    sum = squareSum;
                    resultMatrix[0, 0] = matrix[r, c];
                    resultMatrix[0, 1] = matrix[r, c + 1];
                    resultMatrix[1, 0] = matrix[r + 1, c];
                    resultMatrix[1, 1] = matrix[r + 1, c + 1];
                }
            }
        }

        for (int r = 0; r < resultMatrix.GetLength(0); r++)
        {
            for (int c = 0; c < resultMatrix.GetLength(1); c++)
            {
                Console.Write(resultMatrix[r, c] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(sum);
    }
}