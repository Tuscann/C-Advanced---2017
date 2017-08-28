using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        decimal[] input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
        var dictionary = new SortedDictionary<decimal, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!dictionary.ContainsKey(input[i]))
            {
                dictionary.Add(input[i], 0);
            }
            dictionary[input[i]]++;
        }
        foreach (var number in dictionary)
        {
            Console.WriteLine("{0} - {1} times", number.Key, number.Value);
        }
    }
}