using System;
using System.Collections.Generic;
public class MinersTask
{
    public static void Main() // 100/100
    {
        Dictionary<string, long> resources = GetResources();
        PrintResources(resources);
    }

    private static void PrintResources(Dictionary<string, long> resources)
    {
        foreach (KeyValuePair<string, long> kvp in resources)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }

    private static Dictionary<string, long> GetResources()
    {
        Dictionary<string, long> resources = new Dictionary<string, long>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "stop") break;

            if (!resources.ContainsKey(input))
            {
                resources[input] = 0;
            }
            resources[input] += int.Parse(Console.ReadLine());
        }
        return resources;
    }
}