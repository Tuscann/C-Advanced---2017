using System;
using System.Collections.Generic;
class StackFibonaci
{
    static void Main() // 100/100
    {
        long n = long.Parse(Console.ReadLine());
        Queue<long> fibQueue = new Queue<long>();
        fibQueue.Enqueue(1);
        fibQueue.Enqueue(1);
        for (int i = 0; i < n - 1; i++)
        {
            fibQueue.Enqueue(fibQueue.Dequeue() + fibQueue.Peek());
        }
        Console.WriteLine(fibQueue.Peek());
    }
}