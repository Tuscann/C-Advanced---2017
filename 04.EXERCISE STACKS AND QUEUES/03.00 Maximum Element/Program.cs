using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 75/100
    { 
        int n = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (input.Length == 2)
            {
                stack.Push(input[1]);
            }
            if (input.Length == 1)
            {
                if (input[0] == 2)
                {
                    stack.Pop();
                }
                if (input[0] == 3)
                {
                    int maxNumber = stack.ToArray().Max();

                    Console.WriteLine(maxNumber);
                }

            }
        }
    }
}