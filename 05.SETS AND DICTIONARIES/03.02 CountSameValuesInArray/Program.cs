using System;
using System.Collections.Generic;
using System.Linq;
public static class Program
{
    static void Main() // 100/100
    {
        double[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        var dict = new SortedDictionary<double, int>();
        foreach (var key in input)
        {
            if (!dict.ContainsKey(key))
                dict[key] = 1;
            else
                dict[key]++;
        }
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} - {item.Value} times");
        }
    }
}