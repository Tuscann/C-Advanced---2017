using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        Dictionary<string, string> obtained = new Dictionary<string, string>
        {
            { "shards", "Shadowmourne" }, { "fragments", "Valanyr" }, { "motes", "Dragonwrath" }
        };
        Dictionary<string, int> otherMaterials = new Dictionary<string, int>();
        Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "shards", 0 }, { "fragments", 0 }, { "motes", 0 }
        };
        string winner = string.Empty;

        while (winner == string.Empty)
        {
            string[] splittedInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 1; i < splittedInput.Length; i += 2)
            {
                string material = splittedInput[i].ToLower();
                int quantity = int.Parse(splittedInput[i - 1]);

                switch (material)
                {
                    case "shards":
                    case "fragments":
                    case "motes":
                        dict[material] += quantity;
                        if (dict[material] >= 250)
                        {
                            winner = material;
                            dict[material] -= 250;
                            Console.WriteLine($"{obtained[material]} obtained!");
                        }
                        break;

                    default:
                        if (!otherMaterials.ContainsKey(material)) otherMaterials[material] = quantity;
                        else otherMaterials[material] += quantity;
                        break;
                }

                if (winner != string.Empty) break;
            }
            if (winner != string.Empty) break;

            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, int> material in dict.OrderByDescending(x => x.Value).ThenBy(k => k.Key))
        {
            Console.WriteLine($"{material.Key}: {material.Value}");
        }
        foreach (KeyValuePair<string, int> material in otherMaterials.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{material.Key}: {material.Value}");
        }
    }
}