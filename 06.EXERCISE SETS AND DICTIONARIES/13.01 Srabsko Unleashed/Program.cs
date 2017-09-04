using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class SrabskoUnleashed
{
    public static void Main() // 70/100
    {
        var concerts = new Dictionary<string, Dictionary<string, decimal>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End") break;

            Match match = Regex.Match(input, @"(.+) @(.+) (\d+) (\d+)");
            if (match != null || match.Groups.Count == 5)
            {
                string singer = match.Groups[1].Value;
                string venue = match.Groups[2].Value;
                int ticketPrice = int.Parse(match.Groups[3].Value);
                int ticketsCount = int.Parse(match.Groups[4].Value);

                if (!concerts.ContainsKey(venue))
                {
                    concerts[venue] = new Dictionary<string, decimal>();
                }
                if (!concerts[venue].ContainsKey(singer))
                {
                    concerts[venue][singer] = 0;
                }
                concerts[venue][singer] += ticketPrice * ticketsCount;
            }
        }
        foreach (KeyValuePair<string, Dictionary<string, decimal>> kvp in concerts)
        {
            Console.WriteLine(kvp.Key); // venues
            IOrderedEnumerable<KeyValuePair<string, decimal>> singersRevenuesDesc = concerts[kvp.Key].OrderByDescending(x => x.Value);
            foreach (KeyValuePair<string, decimal> singer in singersRevenuesDesc)
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value}"); // singer, revenues
            }
        }
    }
}
