using System;
using System.Collections.Generic;
using System.Linq;
public class LogsAggregator
{
    public static void Main()    // 100/100
    {
        var logs = new SortedDictionary<string, SortedDictionary<string, int>>();
        int logsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < logsCount; i++)
        {
            string[] args = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string ip = args[0];
            string user = args[1];
            int duration = int.Parse(args[2]);

            if (!logs.ContainsKey(user))
            {
                logs[user] = new SortedDictionary<string, int>();
            }
            if (!logs[user].ContainsKey(ip))
            {
                logs[user][ip] = 0;
            }
            logs[user][ip] += duration;
        }
        foreach (KeyValuePair<string, SortedDictionary<string, int>> kvp in logs)
        {
            Console.WriteLine("{0}: {1} [{2}]", kvp.Key, kvp.Value.Values.Sum(), string.Join(", ", kvp.Value.Keys));
        }
    }
}