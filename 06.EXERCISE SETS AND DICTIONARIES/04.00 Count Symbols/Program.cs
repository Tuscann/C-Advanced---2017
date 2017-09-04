using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        SortedDictionary<char, int> dic = new SortedDictionary<char, int>();

        char[] input = Console.ReadLine().ToCharArray();

        foreach (char charrr in input)
        {
            if (!dic.ContainsKey(charrr))
            {
                dic.Add(charrr, 0);
            }
            dic[charrr]++;
        }
        foreach (KeyValuePair<char, int> charr in dic)
        {
            Console.WriteLine("{0}: {1} time/s", charr.Key, charr.Value);
        }
    }
}