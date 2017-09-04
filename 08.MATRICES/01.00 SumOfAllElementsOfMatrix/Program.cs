using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] size = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        long sum = 0;

        int rows = size[0];
        int colums = size[1];

        for (int i = 0; i < rows; i++)
        {
            int[] curentRow = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (int number in curentRow)
            {
                sum += number;
            }
        }
        Console.WriteLine(rows);
        Console.WriteLine(colums);
        Console.WriteLine(sum);
    }
}