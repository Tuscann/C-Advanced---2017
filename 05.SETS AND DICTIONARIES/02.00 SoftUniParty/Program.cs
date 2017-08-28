using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        SortedSet<string> regular = new SortedSet<string>();
        SortedSet<string> vip = new SortedSet<string>();

        bool isParty = false;

        while (true)
        {
            string curentGuest = Console.ReadLine();
            if (curentGuest == "END")
            {
                break;
            }
            if (curentGuest == "PARTY")
            {
                isParty = true;
            }

            if (isParty)
            {

                if (Char.IsDigit(curentGuest[0]))
                {
                    vip.Remove(curentGuest);
                }
                else
                {
                    regular.Remove(curentGuest);
                }
            }
            else
            {
                if (Char.IsDigit(curentGuest[0]) && curentGuest.Length == 8)
                {
                    vip.Add(curentGuest);
                }
                if (!Char.IsDigit(curentGuest[0]) && curentGuest.Length == 8)
                {
                    regular.Add(curentGuest);
                }
            }
        }

        Console.WriteLine(vip.Count + regular.Count);

        foreach (string person in vip)
        {
            Console.WriteLine(person);
        }
        foreach (string person in regular)
        {
            Console.WriteLine(person);
        }
    }
}