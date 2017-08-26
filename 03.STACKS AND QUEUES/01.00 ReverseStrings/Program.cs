using System;
using System.Collections.Generic;
class Program
{
    static void Main() // 100/100
    {
        Stack<char> stack = new Stack<char>();

        char[] input = Console.ReadLine().ToCharArray();

        for (int i = 0; i < input.Length; i++)
        {
            stack.Push(input[i]);
        }

        for (int i = stack.Count - 1; i >= 0; i--)
        {
            Console.Write(stack.Pop());
        }
    }
}