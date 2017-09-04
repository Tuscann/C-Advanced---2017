using System;
using System.Collections.Generic;
using System.Linq;
public class DragonArmy
{
    private const int defaultDamage = 45;
    private const int defaultHealth = 250;
    private const int defaultArmor = 10;

    public static void Main() // 100/100
    {
        PrintDragonStats(GetDragons());
    }

    private static void PrintDragonStats(Dictionary<string, SortedDictionary<string, int[]>> dragons)
    {
        foreach (KeyValuePair<string, SortedDictionary<string, int[]>> dragonType in dragons)
        {
            // dragon type average stats  
            Console.WriteLine($"{dragonType.Key}::" +
                $"({dragonType.Value.Select(x => x.Value[0]).Average():f2}" +
                $"/{dragonType.Value.Select(x => x.Value[1]).Average():f2}" +
                $"/{dragonType.Value.Select(x => x.Value[2]).Average():f2})");
            // dragon stats
            foreach (KeyValuePair<string, int[]> dragon in dragonType.Value)
            {
                Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
            }
        }
    }

    private static Dictionary<string, SortedDictionary<string, int[]>> GetDragons()
    {
        var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();
        int dragonsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < dragonsCount; i++)
        {
            string[] args = Console.ReadLine()
                      .Trim()
                      .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string type = args[0];
            string name = args[1];
            int damage = args[2] == "null" ? defaultDamage : int.Parse(args[2]);
            int health = args[3] == "null" ? defaultHealth : int.Parse(args[3]);
            int armor = args[4] == "null" ? defaultArmor : int.Parse(args[4]);

            if (!dragons.ContainsKey(type))
            {
                dragons[type] = new SortedDictionary<string, int[]>();
            }
            dragons[type][name] = new[] { damage, health, armor }; // add or update
        }
        return dragons;
    }
}