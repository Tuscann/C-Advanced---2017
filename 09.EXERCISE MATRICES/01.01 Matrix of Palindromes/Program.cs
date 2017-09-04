using System;
using System.Linq;
using System.Text;
public class MatrixOfPalindromes
{
    public static void Main() // 100/100
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rows = size[0];
        int cols = size[1];
        string[][] matrix = new string[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new string[cols];

            for (int col = 0; col < cols; col++)
            {
                char firstLetter = (char)('a' + row);
                char secondLetter = (char)(firstLetter + col);

                StringBuilder palindrome = new StringBuilder();

                palindrome
                    .Append(firstLetter)
                    .Append(secondLetter)
                    .Append(firstLetter);
                matrix[row][col] = palindrome.ToString();
            }
        }
        foreach (string[] row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}