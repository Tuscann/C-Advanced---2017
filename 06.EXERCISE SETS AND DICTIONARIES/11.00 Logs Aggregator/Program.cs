using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        var dict = new SortedDictionary<string, SortedDictionary<string, int>>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string ip = input[0];
            string username = input[1];
            int duration = int.Parse(input[2]);

            SortedDictionary<string, int> innerDict = new SortedDictionary<string, int>();
            if (!dict.ContainsKey(username))
            {
                innerDict[ip] = duration;
                dict[username] = innerDict;
            }
            else if (dict.ContainsKey(username))
            {
                if (!dict[username].ContainsKey(ip))
                {
                    dict[username].Add(ip, 0);
                }
                dict[username][ip] += duration;
            }
        }
        foreach (string item in dict.Keys)
        {
            Console.WriteLine($"{item}: {dict[item].Values.Sum()} [{string.Join(", ", dict[item].Keys.ToArray())}]");
        }
    }
}