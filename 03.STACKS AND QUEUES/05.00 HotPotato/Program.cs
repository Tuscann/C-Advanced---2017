using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        string[] input = Console.ReadLine().Split(' ');
        Queue<string> quee = new Queue<string>(input);
        int number = int.Parse(Console.ReadLine());

        while (quee.Count > 1)
        {
            for (int i = 0; i < number - 1; i++)
            {
                string remaider = quee.Dequeue();
                quee.Enqueue(remaider);
            }
            Console.WriteLine("Removed {0}", quee.Dequeue());
        }
        Console.WriteLine("Last is {0}", quee.Dequeue());
    }
}
