using System;
public class Program
{
    private static long[] finnumbers;

    static void Main() // 100/100
    {
        int nthNumber = int.Parse(Console.ReadLine());
        finnumbers = new long[nthNumber];
        long result = GetFibonacci(nthNumber);
        Console.WriteLine(result);
    }

    private static long GetFibonacci(int nthNumber)
    {
        if (nthNumber <= 2)
        {
            return 1;
        }
        if (finnumbers[nthNumber - 1] != 0)
        {
            return finnumbers[nthNumber - 1];
        }
        return finnumbers[nthNumber - 1] = GetFibonacci(nthNumber - 1) + GetFibonacci(nthNumber - 2);
    }
}