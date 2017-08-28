using System;
using System.Collections.Generic;
internal class QueueSequence
{
    private static void Main() // 100/100
    {
        long n = long.Parse(Console.ReadLine());
        
        Queue<long> numQueue = new Queue<long>();
        numQueue.Enqueue(n);

        int count = 0;
        while (count < 50)
        {
            long element = numQueue.Dequeue();
            Console.Write($"{element} ");
            numQueue.Enqueue(element + 1);
            numQueue.Enqueue(2 * element + 1);
            numQueue.Enqueue(element + 2);
            count++;
        }
    }
}
