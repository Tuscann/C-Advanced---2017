using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main() //100/100
    {
        Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

        string command = Console.ReadLine();
        while (command != "report")
        {
            TreatRawData(countries, command);
            command = Console.ReadLine();
        }
        PrintReport(countries);
    }

    private static void PrintReport(Dictionary<string, Dictionary<string, long>> countries)
    {
        foreach (var c in countries.OrderByDescending(x => x.Value.Values.Sum()))
        {
            Console.WriteLine($"{c.Key} (total population: {c.Value.Values.Sum()})");
            foreach (var city in c.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }

    private static void TreatRawData(Dictionary<string, Dictionary<string, long>> countries, string command)
    {
        List<string> lineInput = command.Split('|').ToList();
        string city = lineInput[0];
        string country = lineInput[1];
        long population = long.Parse(lineInput[2]);

        if (countries.ContainsKey(country))
        {
            if (countries[country].ContainsKey(city))
            {
                countries[country][city] += population;
            }
            else
            {
                countries[country].Add(city, population);
            }
        }
        else
        {
            countries.Add(country, new Dictionary<string, long> { { city, population } });
        }
    }
}