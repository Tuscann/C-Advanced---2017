using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        long currentElement = long.Parse(Console.ReadLine());

        Queue<long> sequenceElements = new Queue<long>();
        Queue<long> sequence = new Queue<long>();
        sequence.Enqueue(currentElement);

        while (sequence.Count < 50)
        {
            sequence.Enqueue(currentElement + 1);
            sequenceElements.Enqueue(currentElement + 1);

            if (sequence.Count < 50)
            {
                sequence.Enqueue(2 * currentElement + 1);
                sequenceElements.Enqueue(2 * currentElement + 1);
                sequence.Enqueue(currentElement + 2);
                sequenceElements.Enqueue(currentElement + 2);
                currentElement = sequenceElements.Dequeue();
            }
        }
        Console.WriteLine(string.Join(" ", sequence));
    }
}
