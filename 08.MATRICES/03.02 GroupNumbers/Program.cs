using System;
using System.Linq;
class GroupNumbers
{
    private static void Main() // 100/100
    {
        int[] numbers = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int[][] matrix = new int[3][];
        
        matrix[0] = numbers.Where(n => Math.Abs(n) % 3 == 0).ToArray();
        matrix[1] = numbers.Where(n => Math.Abs(n) % 3 == 1).ToArray();
        matrix[2] = numbers.Where(n => Math.Abs(n) % 3 == 2).ToArray();

        Console.WriteLine(string.Join(" ", matrix[0]));
        Console.WriteLine(string.Join(" ", matrix[1]));
        Console.WriteLine(string.Join(" ", matrix[2]));
    }
}
