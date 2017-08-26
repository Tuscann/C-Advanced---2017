using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        string[] input = Console.ReadLine().Split(' ');
        Queue<string> quee = new Queue<string>(input);
        int number = int.Parse(Console.ReadLine());
        int counter = 1;

        while (quee.Count > 1)
        {
            for (int i = 1; i < number; i++)
            {
                string remaider = quee.Dequeue();
                quee.Enqueue(remaider);

            }
            if (IsPrime(counter))
            {
                Console.WriteLine("Prime {0}", quee.Peek());
            }
            else
            {
                Console.WriteLine("Removed {0}", quee.Dequeue());
            }
            counter++;
        }
        Console.WriteLine("Last is {0}", quee.Dequeue());
    }

    private static bool IsPrime(int n) 
    {
        bool primeCheck = true;
        if (n == 0 || n == 1)
        {
            primeCheck = false;
            return primeCheck;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                primeCheck = false;
            }
        }
        return primeCheck;
    }
}
