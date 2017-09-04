using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        var set = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            var name = Console.ReadLine();
            if (!set.Contains(name))
            {
                set.Add(name);
                Console.WriteLine(name);
            }
        }
    }
}