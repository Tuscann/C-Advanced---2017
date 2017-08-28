using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int number = int.Parse(Console.ReadLine());
        Queue<long[]> pumps = new Queue<long[]>();

        for (int i = 0; i < number; i++)
        {
            long[] curent = Console.ReadLine().Split().Select(long.Parse).ToArray();
           
            pumps.Enqueue(curent);
        }

        for (int i = 0; i < number; i++)
        {
            long petrol = 0;
            long distance = 0;
            bool isCompleteTour = true;

            foreach (var pump in pumps)
            {
                petrol += pump[0];
                distance += pump[1];
                if (petrol < distance)
                {
                    isCompleteTour = false;
                    break;
                }
            }
            if (isCompleteTour)
            {
                Console.WriteLine(i);
                break;
            }
            pumps.Enqueue(pumps.Dequeue());
        }
    }
}