using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 80/100
    {
        int n = int.Parse(Console.ReadLine());
        var periodicTable = new SortedSet<string>();

        for (int i = 0; i < n; i++)
        {
            var current = Console.ReadLine().Split().ToArray();

            foreach (string t in current)
            {
                periodicTable.Add(t);
            }
        }
        Console.WriteLine("{0}", string.Join(" ", periodicTable));
    }
}