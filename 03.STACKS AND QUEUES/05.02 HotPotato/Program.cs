using System;
using System.Collections.Generic;
using System.Linq;
class HotPotatoDemo
{
    static void Main() // 100/100
    {
        Queue<string> names = new Queue<string>(Console.ReadLine().Split().ToArray());

        int n = int.Parse(Console.ReadLine());
        int count = 1;
        while (names.Count > 1)
        {
            string name = names.Dequeue();
            if (count == n)
            {
                count = 1;
                Console.WriteLine($"Removed {name}");
            }
            else
            {
                names.Enqueue(name);
                count++;
            }
        }
        string lastName = names.Dequeue();
        Console.WriteLine($"Last is {lastName}");
    }
}