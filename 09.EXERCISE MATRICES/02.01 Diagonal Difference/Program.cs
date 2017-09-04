using System;
using System.Linq;
public class DiagonalDifference
{
    public static void Main() // 100/100
    {
        int[][] matrix = GetMatrix();
        PrintDiagonalsDiff(CalcDiagonalsDifference(matrix));
    }
    public static int[][] GetMatrix()
    {
        int size = int.Parse(Console.ReadLine());
        int[][] matrix = new int[size][];

        for (int row = 0; row < size; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        return matrix;
    }
    public static long CalcDiagonalsDifference(int[][] matrix)
    {
        long sumPrimaryDiagonal = 0;
        long sumSecondaryDiagonal = 0;

        for (int row = 0; row < matrix.Length; row++)
        {
            sumPrimaryDiagonal += matrix[row][row];
            sumSecondaryDiagonal += matrix[row][matrix.Length - 1 - row];
        }

        return Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
    }

    public static void PrintDiagonalsDiff(long difference)
    {
        Console.WriteLine(difference);
    }
}