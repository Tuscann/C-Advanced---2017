using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

        int rows = input[0];
        int cows = input[1];
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cows; j++)
            {
                Console.Write("{0}{1}{0} ", alphabet[i], alphabet[i + j]);
            }
            Console.WriteLine();
        }
    }
}