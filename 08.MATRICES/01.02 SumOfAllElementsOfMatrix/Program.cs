using System;
class Program
{
    static void Main() // 100/100
    {
        string[] matrixSizes = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(matrixSizes[0]);
        int cols = int.Parse(matrixSizes[1]);
        int sum = 0;

        for (int i = 0; i < rows; i++)
        {
            string[] input = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < cols; j++)
            {
                sum += int.Parse(input[j]);
            }
        }
        Console.WriteLine(rows);
        Console.WriteLine(cols);
        Console.WriteLine(sum);
    }
}