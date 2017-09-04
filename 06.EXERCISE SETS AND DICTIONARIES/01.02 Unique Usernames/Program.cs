using System;
using System.Collections.Generic;
public class UniqueUsernames
{
    public static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        var uniqueUsernames = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            uniqueUsernames.Add(Console.ReadLine().Trim());
        }
        Console.WriteLine(string.Join("\n", uniqueUsernames));
    }
}
