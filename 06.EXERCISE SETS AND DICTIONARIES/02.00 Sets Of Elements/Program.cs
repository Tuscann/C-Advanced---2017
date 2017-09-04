using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        var n = new HashSet<string>();

        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < input[0]; i++)
        {
            string currentNumber = Console.ReadLine();
            n.Add(currentNumber);
        }
        for (int i = 0; i < input[1]; i++)
        {
            string currentNumber = Console.ReadLine();
            if (n.Contains(currentNumber))
            {
                Console.Write("{0} ", currentNumber);
            }
        }
    }
}