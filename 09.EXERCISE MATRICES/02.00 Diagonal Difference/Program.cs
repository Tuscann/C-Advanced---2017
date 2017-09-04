using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        long[][] matrix = new long[size][];
        
        for (int i = 0; i < size; i++)
        {
            matrix[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
        }
        long primaryDiagonal = 0;
        long secondaryDiagonal = 0;

        for (int i = 0; i < size; i++)
        {
            primaryDiagonal += matrix[i][i];
            secondaryDiagonal += matrix[size - 1 - i][i];
        }
        long difference = Math.Abs(primaryDiagonal - secondaryDiagonal);

        Console.WriteLine(difference);
    }
}