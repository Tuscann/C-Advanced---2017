using System;
using System.Collections.Generic;
public static class SoftUniParty
{
    static void Main() // 100/100
    {
        string guest = Console.ReadLine();
        SortedSet<string> InvitedGuests = new SortedSet<string>();
        SortedSet<string> GuestsWhoCame = new SortedSet<string>();

        while (guest != "PARTY")
        {
            InvitedGuests.Add(guest);
            guest = Console.ReadLine();
        }
        guest = Console.ReadLine();
        while (guest != "END")
        {
            GuestsWhoCame.Add(guest);
            guest = Console.ReadLine();
        }

        Console.WriteLine(InvitedGuests.Count - GuestsWhoCame.Count);
        foreach (string person in InvitedGuests)
        {
            if (!GuestsWhoCame.Contains(person))
            {
                Console.WriteLine(person);
            }
        }
    }
}