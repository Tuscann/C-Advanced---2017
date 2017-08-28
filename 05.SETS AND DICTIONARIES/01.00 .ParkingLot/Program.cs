using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        SortedSet<string> hashSet = new SortedSet<string>();

        while (true)
        {
            string[] current = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (current[0] == "END")
            {
                break;
            }
            if (current[0] == "IN")
            {
                hashSet.Add(current[1]);
            }
            else if (current[0] == "OUT")
            {
                hashSet.Remove(current[1]);
            }
        }
        if (hashSet.Count == 0)
        {
            Console.WriteLine("Parking Lot is Empty");
        }
        else
        {
            foreach (string car in hashSet)
            {
                Console.WriteLine(car);
            }
        }
    }
}