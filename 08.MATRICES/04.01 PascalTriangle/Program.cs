using System;
public class PascalTriangle
{
    public static void Main() // 100/100
    {
        int size = int.Parse(Console.ReadLine());
        long[][] matrix = new long[size][];

        for (int row = 0; row < size; row++)
        {
            matrix[row] = new long[row + 1];
            matrix[row][0] = 1;
            matrix[row][row] = 1;

            if (row >= 2)
            {
                for (int col = 1; col < row; col++)
                {
                    matrix[row][col] = matrix[row - 1][col - 1] + matrix[row - 1][col];
                }
            }
        }
        foreach (long[] row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}