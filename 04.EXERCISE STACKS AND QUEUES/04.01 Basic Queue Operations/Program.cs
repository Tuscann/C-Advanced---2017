using System;
using System.Collections.Generic;
using System.Linq;
public static class BasicQueueOperations
{
    static void Main() // 100/100
    {
        int[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < input[0]; i++)
        {
            queue.Enqueue(numbers[i]);
        }
        for (int i = 0; i < input[1]; i++)
        {
            queue.Dequeue();
        }
        if (queue.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (queue.Contains(input[2]))
        {
            Console.WriteLine("true");
        }
        else if (!queue.Contains(input[2]))
        {
            Console.WriteLine(queue.Min());
        }
        
    }
}