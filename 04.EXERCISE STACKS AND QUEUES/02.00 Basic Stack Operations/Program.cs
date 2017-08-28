using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int lenght = input[0];
        int removedNumbers = input[1];
        int searchedNumber = input[2];

        Stack<int> stack = new Stack<int>(array);
        
        for (int i = 0; i < removedNumbers; i++)
        {
            stack.Pop();
        }
        if (stack.Count == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (stack.Contains(searchedNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNUmber = stack.ToArray().Min();
                Console.WriteLine(minNUmber);
            }
        }
    }
}