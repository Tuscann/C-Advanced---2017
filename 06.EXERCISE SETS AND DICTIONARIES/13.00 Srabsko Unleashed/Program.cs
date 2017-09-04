using System;
using System.Collections.Generic;
using System.Linq;
public static class Srabsko
{
    static void Main() // 70/100
    {
        string input = Console.ReadLine();
        Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();
        while (input != "End")
        {
            string[] stats = input.Split(' ').ToArray();
            string singer = string.Empty;

            string venue = string.Empty;
            long tickets = 0;
            long pricePerTicket = 0;
            if (stats.Length >= 4)
            {
                for (int i = 0; i < stats.Length; i++)
                {
                    if (stats[i].StartsWith("@"))
                    {
                        break;
                    }
                    singer += stats[i] + " ";
                }
                string[] singerName = singer.Split(' ').Select(x => x.Trim()).ToArray();

                for (int i = singerName.Length - 1; i < stats.Length; i++)
                {
                    long num;
                    if (long.TryParse(stats[i], out num))
                    {
                        break;
                    }
                    venue += stats[i] + ' ';
                }
                tickets = long.Parse(stats[stats.Length - 1]);
                pricePerTicket = long.Parse(stats[stats.Length - 2]);

                Dictionary<string, long> innerDict = new Dictionary<string, long>();

                if (!dict.ContainsKey(venue.Substring(1, venue.Length - 1)))
                {
                    innerDict[singer] = tickets * pricePerTicket;
                    dict[venue.Substring(1, venue.Length - 1)] = innerDict;
                }
                else
                {
                    if (!dict[venue.Substring(1, venue.Length - 1)].ContainsKey(singer))
                    {
                        dict[venue.Substring(1, venue.Length - 1)].Add(singer, tickets * pricePerTicket);
                    }
                    else
                    {
                        dict[venue.Substring(1, venue.Length - 1)][singer] += tickets * pricePerTicket;
                    }
                }
            }
            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, Dictionary<string, long>> concert in dict)
        {
            Console.WriteLine(concert.Key);
            Dictionary<string, long> sorted = concert.Value.OrderByDescending(v => v.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, long> singer in sorted)
            {
                Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
            }
        }
    }
}