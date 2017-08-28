using System;
using System.Collections.Generic;
using System.Linq;
class SoftUniParty
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();

        SortedSet<string> guests = new SortedSet<string>();

        while (input != "PARTY")
        {
            guests.Add(input);
            input = Console.ReadLine();
        }

        while (input != "END")
        {
            guests.Remove(input);
            input = Console.ReadLine();
        }

        Console.WriteLine(guests.Count);
        Console.WriteLine(string.Join("\n", guests));
    }
}