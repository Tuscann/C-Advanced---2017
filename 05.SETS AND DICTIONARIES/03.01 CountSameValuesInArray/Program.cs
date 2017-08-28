using System;
using System.Collections.Generic;
using System.Linq;
public class CountSameValuesInArray
{
    public static void Main() // 100/100
    {
        SortedDictionary<decimal, int> counts = GetNumberCounts();
        PrintCounts(counts);
    }

    private static void PrintCounts(SortedDictionary<decimal, int> counts)
    {
        foreach (KeyValuePair<decimal, int> kvp in counts)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
        }
    }

    private static SortedDictionary<decimal, int> GetNumberCounts()
    {
        decimal[] numbers = Console.ReadLine().Trim()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();

        SortedDictionary<decimal, int> counts = new SortedDictionary<decimal, int>();

        foreach (decimal number in numbers)
        {
            if (!counts.ContainsKey(number))
            {
                counts[number] = 0;
            }
            counts[number]++;
        }

        return counts;
    }
}