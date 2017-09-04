using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, SortedDictionary<string, long>> result = new Dictionary<string, SortedDictionary<string, long>>();

        while (input != "report")
        {
            SortedDictionary<string, long> cities = new SortedDictionary<string, long>();
            string[] splitedInput = input.Split('|').Select(x => x.Trim()).ToArray();
            string city = splitedInput[0];
            string country = splitedInput[1];
            string population = splitedInput[2];
            if (!result.ContainsKey(country))
            {
                cities[city] = long.Parse(population);
                result[country] = cities;
            }
            else
            {
                if (result[country].ContainsKey(city))
                {
                    result[country][city] += long.Parse(population);
                }
                else
                {
                    result[country].Add(city, long.Parse(population));
                }
            }
            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, SortedDictionary<string, long>> country in result.OrderByDescending(city => city.Value.Values.Sum()))
        {
            long[] people = country.Value.Values.ToArray();
            Console.WriteLine($"{country.Key} (total population: {people.Sum()})");
            foreach (KeyValuePair<string, long> city in country.Value.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}