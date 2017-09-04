using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();

        SortedDictionary<string, Dictionary<string, int>> dict = new SortedDictionary<string, Dictionary<string, int>>();
        while (input != "end")
        {
            string[] splitted = input.Split(' ').ToArray();
            string lastElem = splitted[splitted.Length - 1];
            string username = lastElem.Substring(lastElem.IndexOf("=") + 1, lastElem.Length - (lastElem.IndexOf("=") + 1));
            string IPAdress = splitted[0].Substring(splitted[0].IndexOf("=") + 1, splitted[0].Length - (splitted[0].IndexOf("=") + 1));
            
            if (!dict.ContainsKey(username))
            {
                dict[username] = new Dictionary<string, int>();
            }
            if (!dict[username].ContainsKey(IPAdress))
            {
                dict[username].Add(IPAdress, 0);
            }
            dict[username][IPAdress]++;

            input = Console.ReadLine();
        }

        foreach (string item in dict.Keys)
        {
            Console.WriteLine(item + ":");
            Dictionary<string, int> result = dict[item];

            Console.WriteLine(string.Join(", ", result.Select(x => x.Key + " => " + x.Value).ToArray()) + ".");
        }
    }
}
